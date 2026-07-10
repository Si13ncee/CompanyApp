USE CompanyDB;
GO

/* Insertovanie zamestnancov */ 
INSERT INTO Employees
(
    Title,
    FirstName,
    LastName,
    Phone,
    Email
)
VALUES
('Ing.', 'Peter', 'Novák', '+421900111111', 'peter.novak@techcorp.sk'),
('Mgr.', 'Jana', 'Kováčová', '+421900222222', 'jana.kovacova@techcorp.sk'),
('Ing.', 'Martin', 'Horváth', '+421900333333', 'martin.horvath@techcorp.sk'),
('Bc.', 'Lucia', 'Mrázová', '+421900444444', 'lucia.mrazova@techcorp.sk'),
('Ing.', 'Tomáš', 'Bartoš', '+421900555555', 'tomas.bartos@techcorp.sk'),
('Mgr.', 'Eva', 'Šimková', '+421900666666', 'eva.simkova@techcorp.sk'),
('Ing.', 'Andrej', 'Polák', '+421900777777', 'andrej.polak@techcorp.sk'),
('Bc.', 'Michal', 'Varga', '+421900888888', 'michal.varga@techcorp.sk');

/* Insertovanie firmy */ 
INSERT INTO OrganizationUnits
(
    Name,
    Code,
    UnitType,
    ParentId,
    ManagerId
)
VALUES
(
    'TechCorp',
    'TC',
    1,
    NULL,
    1
);

/* Insertovanie divízie */ 
INSERT INTO OrganizationUnits
(
    Name,
    Code,
    UnitType,
    ParentId,
    ManagerId
)
VALUES
(
    'IT Division',
    'IT',
    2,
    1,
    2
),
(
    'HR Division',
    'HR',
    2,
    1,
    6
);

/* Insertovanie Projektov */ 
INSERT INTO OrganizationUnits
(
    Name,
    Code,
    UnitType,
    ParentId,
    ManagerId
)
VALUES
(
    'ERP System',
    'ERP',
    3,
    2,
    3
),
(
    'CRM System',
    'CRM',
    3,
    2,
    7
),
(
    'Recruitment System',
    'REC',
    3,
    3,
    8
);

/* Insertovanie oddelení */ 
INSERT INTO OrganizationUnits
(
    Name,
    Code,
    UnitType,
    ParentId,
    ManagerId
)
VALUES
(
    'Backend Department',
    'BACK',
    4,
    4,
    4
),
(
    'Frontend Department',
    'FRONT',
    4,
    4,
    5
),
(
    'Recruitment Department',
    'RECR',
    4,
    6,
    8
);