USE CarRental

-- Disable foreign key constraints
ALTER TABLE Reservations NOCHECK CONSTRAINT ALL;
ALTER TABLE Cars NOCHECK CONSTRAINT ALL;
ALTER TABLE Employees NOCHECK CONSTRAINT ALL;
ALTER TABLE Customers NOCHECK CONSTRAINT ALL;

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

INSERT INTO CarType (Type, DailyPrice, WeeklyPrice, MonthlyPrice) VALUES ('SMALL', 30, 175, 500)
INSERT INTO CarType (Type, DailyPrice, WeeklyPrice, MonthlyPrice) VALUES ('SUV', 40, 200, 600)
INSERT INTO CarType (Type, DailyPrice, WeeklyPrice, MonthlyPrice) VALUES ('SPORT', 55, 300, 900)
INSERT INTO CarType (Type, DailyPrice, WeeklyPrice, MonthlyPrice) VALUES ('TRUCK', 50, 250, 750)
INSERT INTO CarType (Type, DailyPrice, WeeklyPrice, MonthlyPrice) VALUES ('LUXURY', 110, 500, 1500)

SET IDENTITY_INSERT Branches ON

-- Edmonton Branch
INSERT INTO Branches (Branch_ID, Name, Street, City, Postal_Code, Province, Country) VALUES  (1,'Edmonton South', 'Calgary Trail', 'Edmonton', 'T5Z ZZZ', 'AB', 'Canada')

-- Calgary Branch
INSERT INTO Branches (Branch_ID, Name, Street, City, Postal_Code, Province, Country) VALUES (2,'Calgary Main', '10 St SW', 'Calgary', 'T2R 0G3', 'AB', 'Canada');

-- Red Deer Branch
INSERT INTO Branches (Branch_ID, Name, Street, City, Postal_Code, Province, Country) VALUES (3,'Red Deer Central', '49th Ave', 'Red Deer', 'T4N 6X2', 'AB', 'Canada');

-- Lethbridge Branch
INSERT INTO Branches (Branch_ID, Name, Street, City, Postal_Code, Province, Country) VALUES (4,'Lethbridge West', '5 Ave S', 'Lethbridge', 'T1J 3Z1', 'AB', 'Canada');

-- Fort McMurray Branch
INSERT INTO Branches (Branch_ID, Name, Street, City, Postal_Code, Province, Country) VALUES (5,'Fort McMurray South', 'McLeod Ave', 'Fort McMurray', 'T9H 4K1', 'AB', 'Canada');

-- Grande Prairie Branch
INSERT INTO Branches (Branch_ID, Name, Street, City, Postal_Code, Province, Country) VALUES (6,'Grande Prairie East', '100 St', 'Grande Prairie', 'T8N 1X7', 'AB', 'Canada');

-- Sample Car Data
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('WA1DGAFP4EA042058', 'BobRox' , 'Volkswagen', 'Golf', 'Manual', 1, 'SMALL')
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('56PI8I9PLGN7Z4SPN', 'DG1YV0N', 'Subaru', 'Sonata', 'Automatic', 3, 'TRUCK');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('5E4A3G05DMUPZD89A', 'BPI52UW', 'Kia', 'Sonata', 'Automatic', 2, 'SMALL');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('38VGKOKZR0PCKXAFL', 'L2AW7GP', 'Hyundai', 'Forester', 'Manual', 5, 'SUV');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('DKA35BZT3ENC5MBVS', 'LIXWJ5J', 'Kia', 'Optima', 'Manual', 3, 'SPORT');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('QM7NQREKOUI6HRD6T', 'V2D1I68', 'Hyundai', 'Forester', 'Automatic', 2, 'SMALL');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('XS0EO3HS2TFG682FF', 'PTGSV82', 'Subaru', 'Golf', 'Manual', 5, 'SMALL');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('2SLNH3JH9YJDWLVW6', 'EOMP1B9', 'Chevrolet', 'Accord', 'Automatic', 4, 'TRUCK');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('B98YAL25SDE6UNM1E', '9XD6H7B', 'Hyundai', 'Sonata', 'Automatic', 1, 'SPORT');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('1R3HFATOMDG9E9QT5', 'FTQ70R4', 'Kia', 'Silverado', 'Automatic', 2, 'SUV');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('2L9QYF3T9C3605J0E', 'D52BZ2L', 'Ford', 'Camry', 'Manual', 2, 'LUXURY');
INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type) VALUES ('1G4A1B7C8HF000001', 'MitchelGoated', 'Buick', 'Century', 'Automatic', 1, 'LUXURY');

-- Sample Customers
INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('John', 'Doe', '123 Main St', 'Edmonton', 'T5G 2C4', 'AB', 'Canada', '(555) 555-1234');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('Jane', 'Smith', '456 Elm Ave', 'Calgary', 'T2P 0J1', 'AB', 'Canada', '(403) 555-5678');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('Buddy', 'Brown', '789 Maple Rd', 'Vancouver', 'V6T 1Z2', 'BC', 'Canada', '(604) 555-9012');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('Johnny', 'Johnson', '1000 Oak Dr', 'Winnipeg', 'R3J 3T6', 'MB', 'Canada', '(204) 555-2345');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('Sophia', 'Garcia', '2345 Birch Lane', 'Toronto', 'M4W 2R7', 'ON', 'Canada', '(416) 555-6789');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('Lucas', 'Davis', '5678 Poplar St', 'Montreal', 'H2W 1R4', 'QC', 'Canada', '(514) 555-0123');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('Mia', 'McDonald', '8901 Pine Ave', 'Halifax', 'B3J 2S8', 'NS', 'Canada', '(902) 555-3456');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('Ethan', 'Bussin', '1234 Spruce Cr', 'St. Johns', 'A1B 3C4', 'NL', 'Canada', '(709) 555-7890');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('Emily', 'Waluigi', '5678 Willow Way', 'Victoria', 'V9B 1T7', 'BC', 'Canada', '(250) 555-1212');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES ('Alexander', 'Supertramp', '9012 Ash St', 'Regina', 'S4P 3J3', 'SK', 'Canada', '(306) 555-5678');


-- Sample Employee Data
INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('John', 'Doe', '123 Main St', 'Anytown', '12345', 'ON', 'Canada', '(555) 555-1212', 1);

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('Jane', 'Smith', '456 Elm St', 'Anytown', '54321', 'BC', 'Canada', '(555) 555-1213', 2);

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('Peter', 'Johnson', '789 Oak St', 'Anytown', '98765', 'QC', 'Canada', '(555) 555-1214', 1);

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('Mary', 'Williams', '1011 Maple St', 'Anytown', '41640', 'AB', 'Canada', '(555) 555-1215', 3);

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('David', 'Miller', '1213 Birch St', 'Anytown', '10001', 'NS', 'Canada', '(555) 555-1216', 2);

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('Lisa', 'GarbanzoBean', '1415 Spruce St', 'Anytown', '90210', 'MB', 'Canada', '(555) 555-1217', 1);

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('Michael', 'BigHomie', '1617 Pine St', 'Anytown', '33445', 'SK', 'Canada', '(555) 555-1218', 2);

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('Sarah', 'Clareview', '1819 Cedar St', 'Anytown', '78901', 'PE', 'Canada', '(555) 555-1219', 3);

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('Daniel', 'Mckernan', '2021 Hickory St', 'Anytown', '12378', 'NB', 'Canada', '(555) 555-1220', 1);

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES ('Emily', 'Enterprise', '2223 Ash St', 'Anytown', '45600', 'NL', 'Canada', '(555) 555-1221', 3);