using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CompanyApp.Models
{
    public class OrganizationUnit
    {
        [Key]
        public int UnitID { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public UnitType UnitType { get; set; }

        public int? ParentId { get; set; }

        public int? ManagerId { get; set; }
        public override string ToString() => Name;
        public string FullName => $"{Name} ({Code})";
    }
}
