using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Models
{
    internal class OperationResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }


        public static OperationResult Ok()
        {
            return new OperationResult
            {
                Success = true
            };
        }


        public static OperationResult Fail(string message)
        {
            return new OperationResult
            {
                Success = false,
                Message = message
            };
        }
    }
}
