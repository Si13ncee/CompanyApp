using CompanyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Validation
{
    public static class HierarchyValidator
    {
        public static bool IsTextBoxFilled(TextBox box) {
            return string.IsNullOrWhiteSpace(box.Text);
        }

        internal static bool isMovable(int depth, int level)
        {
            return depth + level <= 4;
        }

        

    }
}
