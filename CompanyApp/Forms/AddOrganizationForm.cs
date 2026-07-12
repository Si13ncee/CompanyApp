using CompanyApp.Models;
using CompanyApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CompanyApp.Forms
{
    public partial class AddOrganizationForm : Form
    {
        private readonly OrganizationServices _organizationService;
        private readonly EmployeeServices _employeeService;
        public AddOrganizationForm(OrganizationUnit? parent)
        {
            InitializeComponent();

            _organizationService = new OrganizationServices();
            _employeeService = new EmployeeServices();

            LoadData(parent);
        }

        private void LoadData(OrganizationUnit? parent)
        {
            LoadTypes(parent);
            LoadManagers();
            LoadParents(parent);
        }

        private void LoadParents(OrganizationUnit? parent)
        {
            if (comboBoxType.SelectedItem == null)
                return;


            var selectedType = (UnitType)comboBoxType.SelectedItem;


            if (selectedType == UnitType.Company)
            {
                comboBoxParent.DataSource = null;
                return;
            }


            var parentType = (UnitType)((int)selectedType - 1);


            var units = _organizationService.GetAll().Where(x => x.UnitType == parentType).ToList();

            comboBoxParent.DisplayMember = "FullName";
            comboBoxParent.ValueMember = "UnitID";
            comboBoxParent.DataSource = units;

            if (parent is not null)
            {
                comboBoxParent.SelectedValue = parent.UnitID;
            }
        }

        private void LoadManagers()
        {
            var employees = _employeeService.GetAll();
            var units = _organizationService.GetAll();
            var managerIds = units.Where(x => x.ManagerId != null).Select(x => x.ManagerId).ToList();


            var availableManagers = employees.Where(x => !managerIds.Contains(x.EmployeeId)).ToList();


            comboBoxManager.DataSource = availableManagers;



            comboBoxManager.DisplayMember = "FullName";
            comboBoxManager.ValueMember = "EmployeeId";
        }

        private void LoadTypes(OrganizationUnit? parent)
        {            
            comboBoxType.DataSource = Enum.GetValues(typeof(UnitType));
            if (parent == null || (int)parent.UnitType == 4) 
                return;
            comboBoxType.SelectedItem = parent.UnitType + 1;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParents(null);

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

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var unit = new OrganizationUnit
            {
                Name = textBoxName.Text,
                Code = textBoxCode.Text,

                UnitType = (UnitType)comboBoxType.SelectedItem,
                ParentId = comboBoxParent.SelectedValue as int?,
                ManagerId = comboBoxManager.SelectedValue as int?
            };


            var result = _organizationService.Add(unit);


            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Upozornenie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
