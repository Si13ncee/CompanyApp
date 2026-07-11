using CompanyApp.Data;
using CompanyApp.Models;
using CompanyApp.Services;
using CompanyApp.Validation;
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

            LoadUnitTypes(); // loaduje enum typov pre OrganizationUnits
            LoadManagers(); // loadne všetkých zamestnancov do comboBoxu pre výber
            LoadEmployees();
            LoadOrganizationTree();
            loadParents();
        }
        private void LoadManagers()
        {

            var employees = _employeeService.GetAll();

            comboBoxManager.DataSource = employees;
            comboBoxManager.DisplayMember = "FullName";
            comboBoxManager.ValueMember = "EmployeeId";

        }

        private void LoadUnitTypes()
        {
            comboBoxType.DataSource = Enum.GetValues(typeof(UnitType));
        }

        private void LoadOrganizationTree()
        {

            var units = _organizationServices.GetAll();

            tvOrganization.Nodes.Clear();

            // Vytiahneme z listu organizačnej štruktúry firmy prvky, ktoré nemajú parentID -> korene stromov.
            var rootUnits = units
                .Where(x => x.ParentId == null)
                .ToList();

            // Pridruží koreňom všetky ich potomkov/branches.
            foreach (var unit in rootUnits)
            {
                TreeNode node = CreateTreeNode(unit, units);

                tvOrganization.Nodes.Add(node);
            }

        }

        private TreeNode CreateTreeNode(OrganizationUnit unit, List<OrganizationUnit> allUnits)
        {
            TreeNode node = new TreeNode($"{unit.Name} ({unit.Code})");

            node.Tag = unit;


            var children = allUnits
                .Where(x => x.ParentId == unit.UnitID)
                .ToList();

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
            dgvEmployees.DataSource = employees;

        }

        private void tvOrganization_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedUnit = (OrganizationUnit)e.Node.Tag;


            textBoxName.Text = selectedUnit.Name;
            textBoxCode.Text = selectedUnit.Code;
            loadParents();
            comboBoxType.SelectedItem = selectedUnit.UnitType;
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
            if (parent == null)
            {
                MessageBox.Show("Vyberte nadradenú organizačnú jednotku.");
                return;
            }
            int depth = _organizationServices.GetSubtreeDepth(selectedUnit);
            int level = _organizationServices.GetLevel(parent);
            if (!HierarchyValidator.isMovable(depth,level))
            {
                MessageBox.Show("Presun nie je možný, nakoľko presahuje maximálnu hĺbku štruktúry.");
                return;
            }

            // napĺňame selected unit
            selectedUnit.Name = textBoxName.Text;
            selectedUnit.Code = textBoxCode.Text;
            selectedUnit.UnitType = (UnitType)comboBoxType.SelectedItem;
            selectedUnit.ParentId = (int?)comboBoxParent.SelectedValue;
            selectedUnit.ManagerId = (int?)comboBoxManager.SelectedValue;

            var result = _organizationServices.Update(selectedUnit);

            if (!result.Success)
            {
                MessageBox.Show(
                    result.Message,
                    "Save error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show(
                "Organization unit saved.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadOrganizationTree();
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
        }
    }
}
