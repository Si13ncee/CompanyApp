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
                employee.Phone = NormalizePhoneNumber(employee.Phone);
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

        public OperationResult Update(Employee employee)
        {
            try
            {
                ValidateEmployeeUnit(employee);
                Validate(employee);
                
            }
            catch (Exception ex)
            {
                return OperationResult.Fail(ex.Message);
            }

            using var db = new CompanyContext();

            var existing = db.Employees.Find(employee.EmployeeId);
 
            if (existing == null)
                return OperationResult.Fail("Tento zamestnanec neexistuje v databáze.");

            
            existing.Title = employee.Title;
            existing.FirstName = employee.FirstName;
            existing.LastName = employee.LastName;
            existing.Phone = employee.Phone;
            existing.Email = employee.Email;
            existing.UnitID = employee.UnitID;

            db.SaveChanges();
            return OperationResult.Ok();
        }

        public OperationResult Delete(int id)
        {
            using var db = new CompanyContext();
            var employee = db.Employees.Find(id);
            if (employee == null)
                return OperationResult.Fail("Neexistuje zamestnanec s takýmto id.");

            bool isManager = db.OrganizationUnits.Any(x => x.ManagerId == employee.EmployeeId);

            if (isManager)
            {
                return OperationResult.Fail(
                    $"Zamestnanec {employee.FullName} je vedúcim organizačnej jednotky. Nemôžeš ho zmazať.");
            }

            db.Employees.Remove(employee);
            db.SaveChanges();
            return OperationResult.Ok();
        }

        public bool Exists(int id)
        {
            using var db = new CompanyContext();

            return db.Employees.Any(x => x.EmployeeId == id);
        }

        private void Validate(Employee emp)
        {          
            
            EmployeeValidator.Validate(emp);
        }

        private void ValidateEmployeeUnit(Employee employee)
        {
            using var db = new CompanyContext();

            var managedUnit = db.OrganizationUnits
                .FirstOrDefault(x => x.ManagerId == employee.EmployeeId);

            if (managedUnit == null)
                return; // zamestnanec nie je manažér

            if (managedUnit.UnitID != employee.UnitID)
            {
                throw new Exception(
                    "Manažér musí pracovať v organizačnej jednotke, ktorú vedie.");
            }
        }

        public static string NormalizePhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return phone;

            // odstráni medzery, pomlčky, zátvorky
            phone = phone
                .Replace(" ", "")
                .Replace("-", "")
                .Replace("(", "")
                .Replace(")", "");


            // slovenský formát 0900xxxxxx
            if (phone.StartsWith("0"))
            {
                phone = "+421" + phone.Substring(1);
            }

            return phone;
        }
    }
}
