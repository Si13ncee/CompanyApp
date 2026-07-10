using CompanyApp.Data;
using CompanyApp.Models;
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

        public void Add(Employee employee)
        {
            using var db = new CompanyContext();
            db.Employees.Add(employee);
            db.SaveChanges();
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
    }
}
