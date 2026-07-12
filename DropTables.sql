USE CompanyDB;
GO

ALTER TABLE Employees DROP CONSTRAINT FK_Employee_OrganizationUnit;
ALTER TABLE OrganizationUnits DROP CONSTRAINT FK_OrganizationUnit_Manager;
ALTER TABLE OrganizationUnits DROP CONSTRAINT FK_OrganizationUnit_Parent;

DROP TABLE Employees;
DROP TABLE OrganizationUnits;