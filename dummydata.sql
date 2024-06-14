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

-- Reservations
INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-01', '2024-04-05', 150.00, 1, 1, 1, 1, 'WA1DGAFP4EA042058');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-10', '2024-04-15', 200.00, 2, 2, 2, 2, '56PI8I9PLGN7Z4SPN');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-20', '2024-04-25', 175.00, 3, 3, 3, 3, '5E4A3G05DMUPZD89A');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-01', '2024-05-07', 250.00, 4, 4, 4, 4, '38VGKOKZR0PCKXAFL');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-10', '2024-05-17', 300.00, 5, 5, 5, 5, 'DKA35BZT3ENC5MBVS');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-15', '2024-05-20', 225.00, 6, 6, 6, 6, 'QM7NQREKOUI6HRD6T');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-20', '2024-05-25', 175.00, 7, 7, 1, 2, 'XS0EO3HS2TFG682FF');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-25', '2024-06-01', 400.00, 8, 8, 2, 3, '2SLNH3JH9YJDWLVW6');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-06-01', '2024-06-07', 350.00, 9, 9, 3, 4, 'B98YAL25SDE6UNM1E');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-06-07', '2024-06-14', 450.00, 10, 10, 4, 5, '1R3HFATOMDG9E9QT5');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-02', '2024-04-04', 120.00, 1, 1, 1, 1, '56PI8I9PLGN7Z4SPN');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-05', '2024-04-09', 180.00, 2, 1, 1, 1, '5E4A3G05DMUPZD89A');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-15', '2024-04-18', 150.00, 3, 2, 2, 2, '38VGKOKZR0PCKXAFL');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-20', '2024-04-24', 210.00, 4, 2, 2, 2, 'DKA35BZT3ENC5MBVS');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-25', '2024-04-29', 240.00, 5, 3, 3, 3, 'QM7NQREKOUI6HRD6T');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-02', '2024-05-06', 260.00, 6, 4, 4, 4, 'XS0EO3HS2TFG682FF');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-07', '2024-05-12', 300.00, 7, 4, 4, 4, '2SLNH3JH9YJDWLVW6');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-13', '2024-05-17', 200.00, 8, 5, 5, 5, 'B98YAL25SDE6UNM1E');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-18', '2024-05-23', 350.00, 9, 5, 5, 5, '1R3HFATOMDG9E9QT5');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-24', '2024-05-29', 400.00, 10, 5, 5, 5, '1G4A1B7C8HF000001');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-06-01', '2024-06-05', 150.00, 1, 1, 1, 1, 'WA1DGAFP4EA042058');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-06-06', '2024-06-10', 180.00, 2, 1, 1, 1, '56PI8I9PLGN7Z4SPN');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-06-11', '2024-06-14', 210.00, 3, 1, 1, 1, '5E4A3G05DMUPZD89A');

-- More reservations for Employee_ID 1
INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-01', '2024-04-04', 120.00, 1, 1, 1, 1, '5E4A3G05DMUPZD89A');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-06', '2024-04-09', 180.00, 2, 1, 1, 1, '38VGKOKZR0PCKXAFL');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-10', '2024-04-14', 150.00, 3, 1, 1, 1, 'DKA35BZT3ENC5MBVS');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-15', '2024-04-19', 210.00, 4, 1, 1, 1, 'QM7NQREKOUI6HRD6T');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-04-20', '2024-04-24', 240.00, 5, 1, 1, 1, 'XS0EO3HS2TFG682FF');

-- More reservations for Employee_ID 2
INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-02', '2024-05-06', 260.00, 6, 2, 2, 2, '2SLNH3JH9YJDWLVW6');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-07', '2024-05-12', 300.00, 7, 2, 2, 2, 'B98YAL25SDE6UNM1E');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-13', '2024-05-17', 200.00, 8, 2, 2, 2, '1R3HFATOMDG9E9QT5');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-18', '2024-05-23', 350.00, 9, 2, 2, 2, '1G4A1B7C8HF000001');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-05-24', '2024-05-29', 400.00, 10, 2, 2, 2, 'WA1DGAFP4EA042058');

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES ('2024-06-01', '2024-06-05', 150.00, 1, 3, 3, 3, '56PI8I9PLGN7Z4SPN');