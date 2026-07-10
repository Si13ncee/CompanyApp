using CompanyApp.Data;
using CompanyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public CompanyExplorer()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddChild_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CompanyExplorer_Load(object sender, EventArgs e)
        {
            LoadUnitTypes();
            LoadManagers();
            LoadEmployees();
            LoadOrganizationTree();
        }
        private void LoadManagers()
        {
            using (var db = new CompanyContext())
            {
                var employees = db.Employees.ToList();

                comboBoxManager.DataSource = employees;
                comboBoxManager.DisplayMember = "FullName";
                comboBoxManager.ValueMember = "EmployeeId";
            }
        }
        private void LoadUnitTypes()
        {
            comboBoxType.DataSource = Enum.GetValues(typeof(UnitType));
        }

        private void LoadOrganizationTree()
        {
            using (var db = new CompanyContext())
            {
                var units = db.OrganizationUnits.ToList();

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
            using (var db = new CompanyContext())
            {
                var employees = db.Employees.ToList();

                dgvEmployees.DataSource = employees;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tvOrganization_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedUnit = (OrganizationUnit)e.Node.Tag;


            textBoxName.Text = selectedUnit.Name;
            textBoxCode.Text = selectedUnit.Code;

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

            using (var db = new CompanyContext())
            {
                var unit = db.OrganizationUnits.Find(selectedUnit.UnitID);

                if (unit == null)
                    return;

                // Validácia
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    MessageBox.Show("Name is required.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxCode.Text))
                {
                    MessageBox.Show("Code is required.");
                    return;
                }

                unit.Name = textBoxName.Text;
                unit.Code = textBoxCode.Text;
                unit.UnitType = (UnitType)comboBoxType.SelectedItem;
                unit.ManagerId = (int?)comboBoxManager.SelectedValue;

                db.SaveChanges();
            }

            LoadOrganizationTree();
        }
    }
}
