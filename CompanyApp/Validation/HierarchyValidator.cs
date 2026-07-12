using CompanyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Validation
{
    public static class HierarchyValidator
    {
        internal static bool isMovable(int depth, int level)
        {
            // 4 -> maximálna povolená hĺbka stromu
            return depth + level <= 4;
        }
    }
}
