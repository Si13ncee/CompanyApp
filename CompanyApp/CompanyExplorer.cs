using CompanyApp.Data;
using CompanyApp.Forms;
using CompanyApp.Models;
using CompanyApp.Services;
using CompanyApp.Validation;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace CompanyApp
{
    public partial class CompanyExplorer : Form
    {
        private OrganizationUnit? selectedUnit;
        private readonly OrganizationServices _organizationServices;
        private readonly EmployeeServices _employeeService;

        public CompanyExplorer()
        {
            InitializeComponent();
            _organizationServices = new OrganizationServices();
            _employeeService = new EmployeeServices();
        }

        private void CompanyExplorer_Load(object sender, EventArgs e)
        {

            LoadUnitTypes();     
            LoadOrganizationTree();
            loadParents();
            LoadEmployees();
        }

        private void LoadManagers(int? currentManagerId)
        {
            var employees = _employeeService.GetAll();
            var units = _organizationServices.GetAll();

            var managerIds = units.Where(x => x.ManagerId != null).Select(x => x.ManagerId).ToList();
            // iba zamestnanci z daného oddelenia a ktorí ešte nie sú manažéri
            var availableManagers = employees.Where(x => x.UnitID == selectedUnit.UnitID && !managerIds.Contains(x.EmployeeId)).ToList();

            if (currentManagerId is not null)
            {
                var currentManager = employees
                    .FirstOrDefault(x => x.EmployeeId == currentManagerId);

                if (currentManager != null &&
                    !availableManagers.Any(x => x.EmployeeId == currentManager.EmployeeId))
                {
                    availableManagers.Add(currentManager);
                }
            }


            comboBoxManager.DataSource = availableManagers;
            comboBoxManager.DisplayMember = "FullName";
            comboBoxManager.ValueMember = "EmployeeId";


            if (currentManagerId is not null)
            {
                comboBoxManager.SelectedValue = currentManagerId.Value;
            }
        }

        private void LoadUnitTypes()
        {
            comboBoxType.DataSource = Enum.GetValues(typeof(UnitType));
        }

        // metóda slúži na načítanie celého hierarchického stromu.
        private void LoadOrganizationTree()
        {
            // uloženie rozloženia predošlého stavu stromu, aby sme ho mohli ponechať rovnako roztvorený po reloade
            var expandedNodes = GetExpandedNodes();
            var units = _organizationServices.GetAll();

            tvOrganization.Nodes.Clear();

            // Vytiahneme z listu organizačnej štruktúry firmy prvky, ktoré nemajú parentID -> korene stromov.
            var rootUnits = units.Where(x => x.ParentId == null).ToList();

            // Pridruží koreňom všetky ich potomkov/branches.
            foreach (var unit in rootUnits)
            {
                TreeNode node = CreateTreeNode(unit, units);

                tvOrganization.Nodes.Add(node);
            }
            
            RestoreExpandedNodes(expandedNodes);

        }

        private TreeNode CreateTreeNode(OrganizationUnit unit, List<OrganizationUnit> allUnits)
        {
            TreeNode node = new TreeNode($"{unit.Name} ({unit.Code})");
            node.Tag = unit;
            var children = allUnits.Where(x => x.ParentId == unit.UnitID).ToList();

            // rekurzívne vytvára branche pre jednotlivé položky, až kým sa nedostane na list.
            foreach (var child in children)
            {
                node.Nodes.Add(CreateTreeNode(child, allUnits));
            }
            return node;
        }

        private void LoadEmployees()
        {

            var employees = _employeeService.GetAll();
            var units = _organizationServices.GetAll();
            foreach (var employee in employees)
            {
                employee.DepartmentName = units.FirstOrDefault(u => u.UnitID == employee.UnitID)?.Name ?? "";
                employee.Position = units.Any(x => x.ManagerId == employee.EmployeeId) ? "Vedúci" : "Zamestnanec";
            }

            dgvEmployees.DataSource = employees;

        }

        private void tvOrganization_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedUnit = (OrganizationUnit)e.Node.Tag;
            textBoxName.Text = selectedUnit.Name;
            textBoxCode.Text = selectedUnit.Code;
            comboBoxType.SelectedItem = selectedUnit.UnitType;
            loadParents();
            LoadManagers(selectedUnit.ManagerId);
            if (selectedUnit.ManagerId != null)
            {
                comboBoxManager.SelectedValue = selectedUnit.ManagerId;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (selectedUnit is null)
                return;

            var parent = comboBoxParent.SelectedItem as OrganizationUnit;
            if (parent == null && (int)comboBoxType.SelectedValue > 1)
            {
                MessageBox.Show("Vyberte nadradenú organizačnú jednotku.", "Upozornenie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            // táto validácia slúži na to, aby sme nemohli spraviť branch, ktorý začína od iného unit type ako 1 (firma)
            var result = _organizationServices.CanMove(selectedUnit, parent);
            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // napĺňame editing unit
            OrganizationUnit editingUnit = new OrganizationUnit
            {
                UnitID = selectedUnit.UnitID,
                Name = selectedUnit.Name,
                Code = selectedUnit.Code,
                UnitType = selectedUnit.UnitType,
                ParentId = selectedUnit.ParentId,
                ManagerId = selectedUnit.ManagerId
            };
            editingUnit.Name = textBoxName.Text;
            editingUnit.Code = textBoxCode.Text;
            editingUnit.UnitType = (UnitType)comboBoxType.SelectedItem;
            editingUnit.ParentId = (int?)comboBoxParent.SelectedValue;
            editingUnit.ManagerId = (int?)comboBoxManager.SelectedValue;

            result = _organizationServices.Update(editingUnit);

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Save error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show("Zmena bola uložená!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadOrganizationTree();
            LoadEmployees();
        }

        /* Metóda na načítanie všetkých možných prvkov, 
         * ktoré môžu byť ako parent pre aktuálne zvolený typ jednotky.
         */
        private void loadParents()
        {
            if (selectedUnit is null)
                return;
            var SelectedType = (UnitType)comboBoxType.SelectedItem;
            var parentType = (UnitType)((int)SelectedType - 1);

            var units = _organizationServices.GetAll().Where(x => (x.UnitType == parentType) && selectedUnit.UnitID != x.UnitID).ToList(); ;
            comboBoxParent.DataSource = units;
            comboBoxParent.DisplayMember = "FullName";
            comboBoxParent.ValueMember = "UnitID";
            if (selectedUnit.ParentId is not null)
                comboBoxParent.SelectedValue = selectedUnit.ParentId;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadParents();

            if (comboBoxType.SelectedItem is not UnitType type)
                return;

            switch (type)
            {
                case UnitType.Company:
                    labelManager.Text = "Riaditeľ:";
                    break;

                case UnitType.Division:
                    labelManager.Text = "Vedúci divízie:";
                    break;

                case UnitType.Project:
                    labelManager.Text = "Vedúci projektu:";
                    break;

                case UnitType.Department:
                    labelManager.Text = "Vedúci oddelenia:";
                    break;

                default:
                    labelManager.Text = "Manažér:";
                    break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Naozaj chcete odstrániť túto organizačnú jednotku?",
                "Potvrdenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            var deleteResult = _organizationServices.Delete(selectedUnit.UnitID);

            if (!deleteResult.Success)
            {
                MessageBox.Show(deleteResult.Message, "Upozornenie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            selectedUnit = null;

            ClearDetails();
            LoadOrganizationTree();
            LoadEmployees();
        }

        private void ClearDetails()
        {
            textBoxName.Clear();
            textBoxCode.Clear();

            comboBoxType.SelectedIndex = -1;
            comboBoxParent.DataSource = null;
            comboBoxManager.DataSource = null;
        }

        private void buttonAddChild_Click(object sender, EventArgs e)
        {
            var parent = selectedUnit;
            using (var form = new AddOrganizationForm(parent))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadOrganizationTree();
                }
            }
        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            using (var form = new AddEmployeeForm(selectedUnit))
            {
                form.ShowDialog();
            }
            LoadEmployees();
        }

        private void buttonDeleteEmp_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvEmployees.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vyberte aspoň jedného zamestnanca.",
                    "Upozornenie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            List<int> employeeIds = new();

            foreach (DataGridViewRow row in selectedRows)
            {
                int id = (int)row.Cells["EmployeeId"].Value;
                employeeIds.Add(id);
            }

            var result = MessageBox.Show(
                    $"Naozaj chcete odstrániť {employeeIds.Count} zamestnancov?",
                    "Potvrdenie mazania",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            foreach (var id in employeeIds)
            {
                var deleteResult = _employeeService.Delete(id);

                if (!deleteResult.Success)
                {
                    MessageBox.Show(deleteResult.Message, 
                        "Upozornenie",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            LoadEmployees();
        }

        private void buttonEditEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Pre úpravu vyberte presne jedného zamestnanca.", 
                    "Upozornenie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var row = dgvEmployees.SelectedRows[0];
            var employee = (Employee)dgvEmployees.SelectedRows[0].DataBoundItem;

            using (var form = new EditEmployeeForm(employee))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees();
                }
            }
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditEmp_Click(null, null);
        }

        /// <summary>
        /// Získa identifikátory všetkých aktuálne rozbalených uzlov v organizačnom strome.
        /// Používa sa na zachovanie stavu TreeView pri opätovnom načítaní dát.
        /// </summary>
        private HashSet<int> GetExpandedNodes()
        {
            var expandedNodes = new HashSet<int>();

            foreach (TreeNode node in tvOrganization.Nodes)
            {
                SaveExpandedNodes(node, expandedNodes);
            }

            return expandedNodes;
        }

        /// <summary>
        /// Rekurzívne prechádza strom a ukladá ID všetkých rozbalených organizačných jednotiek.
        /// </summary>
        private void SaveExpandedNodes(TreeNode node, HashSet<int> expandedNodes)
        {
            if (node.IsExpanded && node.Tag is OrganizationUnit unit)
            {
                expandedNodes.Add(unit.UnitID);
            }

            foreach (TreeNode child in node.Nodes)
            {
                SaveExpandedNodes(child, expandedNodes);
            }
        }

        /// <summary>
        /// Obnoví stav rozbalenia organizačného stromu podľa uložených ID uzlov.
        /// </summary>
        private void RestoreExpandedNodes(HashSet<int> expandedNodes)
        {
            foreach (TreeNode node in tvOrganization.Nodes)
            {
                RestoreNode(node, expandedNodes);
            }
        }

        /// <summary>
        /// Rekurzívne prechádza strom a rozbaľuje uzly, ktoré boli pred refreshom otvorené.
        /// </summary>
        private void RestoreNode(TreeNode node, HashSet<int> expandedNodes)
        {
            if (node.Tag is OrganizationUnit unit &&
                expandedNodes.Contains(unit.UnitID))
            {
                node.Expand();
            }

            foreach (TreeNode child in node.Nodes)
            {
                RestoreNode(child, expandedNodes);
            }
        }
    }
}
