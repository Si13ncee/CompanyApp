using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace CompanyApp.Validation
{
    public static class EmployeeValidator
    {
        static bool IsValidEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
