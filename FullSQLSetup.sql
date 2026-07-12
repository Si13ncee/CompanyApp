IF NOT EXISTS 
(
    SELECT name 
    FROM sys.databases 
    WHERE name = 'CompanyDB'
)
BEGIN
    CREATE DATABASE CompanyDB;
END
GO

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

--------------------------------------------------
-- Employees
--------------------------------------------------

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email)
VALUES
('Ing.', 'Peter', 'Novák', '+421901111111', 'peter.novak@company.sk'),
('Mgr.', 'Ján', 'Kováč', '+421902222222', 'jan.kovac@company.sk'),
('Bc.', 'Martin', 'Horváth', '+421903333333', 'martin.horvath@company.sk'),
('Ing.', 'Lucia', 'Vargová', '+421904444444', 'lucia.vargova@company.sk'),
('Mgr.', 'Anna', 'Šimková', '+421905555555', 'anna.simkova@company.sk'),
('Ing.', 'Tomáš', 'Mráz', '+421906666666', 'tomas.mraz@company.sk'),
('Bc.', 'Marek', 'Urban', '+421907777777', 'marek.urban@company.sk'),
('Ing.', 'Eva', 'Kováčová', '+421908888888', 'eva.kovacova@company.sk'),
('Mgr.', 'Filip', 'Bartoš', '+421909999999', 'filip.bartos@company.sk'),
('Ing.', 'Dominika', 'Černá', '+421910000000', 'dominika.cerna@company.sk');

--------------------------------------------------
-- Organization Units
--------------------------------------------------

INSERT INTO OrganizationUnits (Name, Code, UnitType, ParentId)
VALUES
('Tech Solutions', 'COMP', 1, NULL),

('Software Division', 'DIV-SW', 2, 1),
('Infrastructure Division', 'DIV-INF', 2, 1),

('ERP Project', 'PRJ-ERP', 3, 2),
('Mobile App', 'PRJ-MOB', 3, 2),
('Cloud Migration', 'PRJ-CLD', 3, 3),

('Backend Department', 'DEP-BE', 4, 4),
('Frontend Department', 'DEP-FE', 4, 4),
('Android Department', 'DEP-AND', 4, 5),
('Cloud Operations', 'DEP-CLOUD', 4, 6);

--------------------------------------------------
-- Employees -> Departments
--------------------------------------------------

UPDATE Employees SET UnitID = 1 WHERE EmployeeId = 1;   -- CEO

UPDATE Employees SET UnitID = 2 WHERE EmployeeId = 2;   -- Software Director
UPDATE Employees SET UnitID = 3 WHERE EmployeeId = 3;   -- Infrastructure Director

UPDATE Employees SET UnitID = 4 WHERE EmployeeId = 4;   -- ERP Manager
UPDATE Employees SET UnitID = 5 WHERE EmployeeId = 5;   -- Mobile Manager
UPDATE Employees SET UnitID = 6 WHERE EmployeeId = 6;   -- Cloud Manager

UPDATE Employees SET UnitID = 7 WHERE EmployeeId = 7;   -- Backend Lead
UPDATE Employees SET UnitID = 8 WHERE EmployeeId = 8;   -- Frontend Lead
UPDATE Employees SET UnitID = 9 WHERE EmployeeId = 9;   -- Android Lead
UPDATE Employees SET UnitID = 10 WHERE EmployeeId = 10; -- Cloud Ops Lead

--------------------------------------------------
-- Managers
--------------------------------------------------

UPDATE OrganizationUnits SET ManagerId = 1 WHERE UnitID = 1;

UPDATE OrganizationUnits SET ManagerId = 2 WHERE UnitID = 2;
UPDATE OrganizationUnits SET ManagerId = 3 WHERE UnitID = 3;

UPDATE OrganizationUnits SET ManagerId = 4 WHERE UnitID = 4;
UPDATE OrganizationUnits SET ManagerId = 5 WHERE UnitID = 5;
UPDATE OrganizationUnits SET ManagerId = 6 WHERE UnitID = 6;

UPDATE OrganizationUnits SET ManagerId = 7 WHERE UnitID = 7;
UPDATE OrganizationUnits SET ManagerId = 8 WHERE UnitID = 8;
UPDATE OrganizationUnits SET ManagerId = 9 WHERE UnitID = 9;
UPDATE OrganizationUnits SET ManagerId = 10 WHERE UnitID = 10;

--------------------------------------------------
-- Additional Employees
--------------------------------------------------

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, UnitID)
VALUES
(NULL, 'Milan', 'Král', '+421911111111', 'milan.kral@company.sk', 7),
(NULL, 'Ivana', 'Križanová', '+421912222222', 'ivana.krizanova@company.sk', 7),
(NULL, 'Richard', 'Bielik', '+421913333333', 'richard.bielik@company.sk', 8),
(NULL, 'Monika', 'Benová', '+421914444444', 'monika.benova@company.sk', 8),
(NULL, 'Patrik', 'Hudec', '+421915555555', 'patrik.hudec@company.sk', 9),
(NULL, 'Karol', 'Farkaš', '+421916666666', 'karol.farkas@company.sk', 9),
(NULL, 'Simona', 'Brezová', '+421917777777', 'simona.brezova@company.sk', 10),
(NULL, 'Michaela', 'Švecová', '+421918888888', 'michaela.svecova@company.sk', 10);