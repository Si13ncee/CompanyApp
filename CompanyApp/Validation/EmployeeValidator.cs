using CompanyApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace CompanyApp.Validation
{
    public static class EmployeeValidator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidPhone(string phone) {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            return Regex.IsMatch(
                phone,
                @"^\+421\d{9}$"
            );
        }

        public static void Validate(Employee emp)
        {
            if (string.IsNullOrWhiteSpace(emp.FirstName))
                throw new Exception("Zamestnanec musí mať meno!");

            if (string.IsNullOrWhiteSpace(emp.LastName))
                throw new Exception("Zamestnanec musí mať priezvisko!");

            if (!EmployeeValidator.IsValidEmail(emp.Email))
                throw new Exception($"Invalid email: {emp.Email}");

            if (!EmployeeValidator.IsValidPhone(emp.Phone))
                throw new Exception("Telefónne číslo musí byť vo formáte +421XXXXXXXXX alebo 0XXXXXXXXX .");

            if (emp.UnitID == null)
                throw new Exception("Oddelenie je povinné.");
        }
    }
}
