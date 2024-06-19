-- ONLY use when you want to DELETE data from already existing tables.

USE CarRental;

-- Disable foreign key constraints
ALTER TABLE Reservations NOCHECK CONSTRAINT ALL;
ALTER TABLE Cars NOCHECK CONSTRAINT ALL;
ALTER TABLE Employees NOCHECK CONSTRAINT ALL;
ALTER TABLE Customers NOCHECK CONSTRAINT ALL;

-- Delete data from tables
DELETE FROM Reservations;
DELETE FROM Employees;
DELETE FROM Cars;
DELETE FROM Branches;
DELETE FROM CarType;
DELETE FROM Customers;

-- Reset identity columns
DBCC CHECKIDENT ('Reservations', RESEED, 0);
DBCC CHECKIDENT ('Employees', RESEED, 0);
DBCC CHECKIDENT ('Branches', RESEED, 0);
DBCC CHECKIDENT ('Customers', RESEED, 0);

-- Re-enable foreign key constraints
ALTER TABLE Reservations CHECK CONSTRAINT ALL;
ALTER TABLE Cars CHECK CONSTRAINT ALL;
ALTER TABLE Employees CHECK CONSTRAINT ALL;
ALTER TABLE Customers CHECK CONSTRAINT ALL;