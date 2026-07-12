USE CompanyDB;
GO
/* Vytvorenie tabuľky Employees */
CREATE TABLE Employees
(
    EmployeeId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(20),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(100) NOT NULL
)

/* Vytvorenie tabuľky OrganizationUnit
    UnitType:
        Company = 1,
        Division = 2,
        Project = 3,
        Department = 4
*/
CREATE TABLE OrganizationUnits
(
    UnitID INT PRIMARY KEY IDENTITY(1, 1),
    Name NVARCHAR(100) NOT NULL,
    Code NVARCHAR(20) UNIQUE NOT NULL,
    UnitType INT NOT NULL,
        CHECK (UnitType IN (1,2,3,4)),
    ParentId INT NULL,
    ManagerId INT NULL,

    CONSTRAINT FK_OrganizationUnit_Parent
        FOREIGN KEY (ParentID)
        REFERENCES OrganizationUnits(UnitId),

    CONSTRAINT FK_OrganizationUnit_Manager
        FOREIGN KEY (ManagerId)
        REFERENCES Employees(EmployeeId)
)

ALTER TABLE Employees
ADD UnitID INT NULL;

ALTER TABLE Employees
ADD CONSTRAINT FK_Employee_OrganizationUnit
FOREIGN KEY (UnitID)
REFERENCES OrganizationUnits(UnitID)
ON DELETE SET NULL;
