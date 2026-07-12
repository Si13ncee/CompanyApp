using CompanyApp.Data;
using CompanyApp.Models;
using CompanyApp.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Services
{
    /* trieda pre obsluhu formulára po stránke zamestnancov */
    internal class EmployeeServices
    {
        public List<Employee> GetAll() {
            using var db = new CompanyContext();
            return db.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            using var db = new CompanyContext();
            return db.Employees.Find(id);
        }

        public OperationResult Add(Employee employee)
        {
            try
            {
                using var db = new CompanyContext();
                Validate(employee);
                db.Employees.Add(employee);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return OperationResult.Fail(ex.Message);
            }
            return OperationResult.Ok();
            
        }

        public void Update(Employee employee)
        {
            using var db = new CompanyContext();

            var existing = db.Employees.Find(employee.EmployeeId);

            if (existing == null)
                return;


            existing.Title = employee.Title;
            existing.FirstName = employee.FirstName;
            existing.LastName = employee.LastName;
            existing.Phone = employee.Phone;
            existing.Email = employee.Email;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new CompanyContext();
            var employee = db.Employees.Find(id);
            if (employee == null)
                return;

            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public bool Exists(int id)
        {
            using var db = new CompanyContext();

            return db.Employees.Any(x => x.EmployeeId == id);
        }

        private void Validate(Employee emp)
        {
            if (string.IsNullOrWhiteSpace(emp.FirstName))
                throw new Exception("Zamestnanec musí mať meno!");

            if (string.IsNullOrWhiteSpace(emp.LastName))
                throw new Exception("Zamestnanec musí mať priezvisko!");

            if (!EmployeeValidator.IsValidEmail(emp.Email))
                throw new Exception($"Invalid email: {emp.Email}");

            if (emp.UnitID == null)
                throw new Exception("Oddelenie je povinné.");
        }
    }
}
