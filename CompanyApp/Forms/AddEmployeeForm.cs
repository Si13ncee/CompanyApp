using CompanyApp.Models;
using CompanyApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompanyApp.Forms
{
    public partial class AddEmployeeForm : Form
    {
        private readonly OrganizationServices _organizationService;
        private readonly EmployeeServices _employeeService;
        public AddEmployeeForm(OrganizationUnit? selectedUnit)
        {
            InitializeComponent();
            _organizationService = new OrganizationServices();
            _employeeService = new EmployeeServices();
            LoadDepartments(selectedUnit);
        }

        private void LoadDepartments(OrganizationUnit? selectedUnit)
        {
            var departments = _organizationService.GetAll();

            comboBoxDepartment.DataSource = departments;
            comboBoxDepartment.DisplayMember = "FullName";
            comboBoxDepartment.ValueMember = "UnitID";
            if (selectedUnit is not null)
                comboBoxDepartment.SelectedValue = selectedUnit.UnitID;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var emp = new Employee
            {
                Title = textBoxTitle.Text,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                UnitID = (int?)comboBoxDepartment.SelectedValue
            };

            var result = _employeeService.Add(emp);

            if (!result.Success)
            {
                MessageBox.Show(result.Message);
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
