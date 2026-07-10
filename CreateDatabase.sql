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