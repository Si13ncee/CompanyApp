using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Models
{
    internal class OrganizationUnit
    {
        public int UnitId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public UnitType UnitType { get; set; }

        public int? ParentId { get; set; }

        public int? ManagerId { get; set; }
    }
}
