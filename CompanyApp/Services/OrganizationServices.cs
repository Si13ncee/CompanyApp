using CompanyApp.Data;
using CompanyApp.Models;
using CompanyApp.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Services
{
    /* trieda pre obsluhu formulára po stránke organizácie */
    internal class OrganizationServices
    {
        public List<OrganizationUnit> GetAll()
        {
            using var db = new CompanyContext();
            return db.OrganizationUnits.ToList();
        }

        public OrganizationUnit? GetById(int id)
        {
            using var db = new CompanyContext();
            return db.OrganizationUnits.Find(id);
        }

        public void Add(OrganizationUnit unit)
        {
            using var db = new CompanyContext();

            db.OrganizationUnits.Add(unit);

            db.SaveChanges();
        }

        public OperationResult Update(OrganizationUnit unit)
        {
            // Validácia
            try
            {
                Validate(unit);
            }
            catch (Exception ex)
            {
                return OperationResult.Fail(ex.Message);
            }

            using var db = new CompanyContext();

            var existing = db.OrganizationUnits.FirstOrDefault(u => u.UnitID == unit.UnitID);

            if (existing == null)
                return OperationResult.Fail("Organizáciu sa nepodarilo nájsť.");

            existing.Name = unit.Name;
            existing.Code = unit.Code;
            existing.UnitType = unit.UnitType;
            existing.ParentId = unit.ParentId;
            existing.ManagerId = unit.ManagerId;

            db.SaveChanges();
            return OperationResult.Ok();
        }

        public OperationResult Delete(int id)
        {
            using var db = new CompanyContext();

            var unit = db.OrganizationUnits.FirstOrDefault(u => u.UnitID == id);

            if (unit == null)
                return OperationResult.Fail("Organizáciu sa nepodarilo nájsť.");

            var hasChildren = db.OrganizationUnits.Any(u => u.ParentId == id);

            if (hasChildren)
            {
                return OperationResult.Fail("Zmazanie sa nepodarilo nakoľko organizácia obsahuje podčlenov.");
            }

            db.OrganizationUnits.Remove(unit);

            db.SaveChanges();
            return OperationResult.Ok();
        }

        public int GetSubtreeDepth(OrganizationUnit unit)
        {
            var children = GetAll().Where(x => x.ParentId == unit.UnitID).ToList();

            if (!children.Any())
                return 1;

            return 1 + children.Max(GetSubtreeDepth);
        }

        public int GetLevel(OrganizationUnit unit)
        {
            if (unit.ParentId == null)
                return 1;

            var parent = GetAll().First(x => x.UnitID == unit.ParentId);

            return 1 + GetLevel(parent);
        }

        private void Validate(OrganizationUnit unit)
        {
            if (string.IsNullOrWhiteSpace(unit.Name))
                throw new Exception("Názov jednotky je povinný.");

            if (string.IsNullOrWhiteSpace(unit.Code))
                throw new Exception("Kód jednotky je povinný.");

            if (unit.ManagerId == null)
                throw new Exception("Jednotka musí mať vedúceho.");

        }
    }
}