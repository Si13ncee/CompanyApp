using CompanyApp.Models;
using CompanyApp.Services;
using CompanyApp.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompanyApp.Forms
{
    public partial class EditEmployeeForm : Form
    {
        private readonly OrganizationServices _organizationService;
        private readonly EmployeeServices _employeeService;
        private Employee _employee;
        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();
            _organizationService = new OrganizationServices();
            _employeeService = new EmployeeServices();
            _employee = employee;

            LoadEmployee(employee);

        }

        private void LoadEmployee(Employee employee)
        {
            if (employee is null)
            {
                MessageBox.Show($"Nepodarilo sa nájsť zamestnanca s {employee.EmployeeId} id.");
                Close();
            }
            textBoxTitle.Text = employee.Title;
            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxPhone.Text = employee.Phone;
            textBoxEmail.Text = employee.Email;
            LoadDepartments(employee.UnitID);
        }

        private void LoadDepartments(int? DepartmentId)
        {
            var departments = _organizationService.GetAll();

            comboBoxDepartment.DataSource = departments;
            comboBoxDepartment.DisplayMember = "FullName";
            comboBoxDepartment.ValueMember = "UnitID";
            if (DepartmentId is not null)
                comboBoxDepartment.SelectedValue = DepartmentId.Value;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var tempEmp = new Employee
            {
                EmployeeId = _employee.EmployeeId,
                Title = textBoxTitle.Text,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                UnitID = (int?)comboBoxDepartment.SelectedValue
            };
            var result = _employeeService.Update(tempEmp);

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
