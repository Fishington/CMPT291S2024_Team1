-- Use for inserting data into tables.

USE CarRental;

INSERT INTO CarType (Type, DailyPrice, WeeklyPrice, MonthlyPrice)
VALUES 
('SMALL', 30, 175, 500),
('SUV', 40, 200, 600),
('SPORT', 55, 300, 900),
('TRUCK', 50, 250, 750),
('LUXURY', 110, 500, 1500);

SET IDENTITY_INSERT Branches ON;

INSERT INTO Branches (Branch_ID, Name, Street, City, Postal_Code, Province, Country)
VALUES  
(1, 'Edmonton South', 'Calgary Trail', 'Edmonton', 'T5Z ZZZ', 'AB', 'Canada'),
(2, 'Calgary Main', '10 St SW', 'Calgary', 'T2R 0G3', 'AB', 'Canada'),
(3, 'Red Deer Central', '49th Ave', 'Red Deer', 'T4N 6X2', 'AB', 'Canada'),
(4, 'Lethbridge West', '5 Ave S', 'Lethbridge', 'T1J 3Z1', 'AB', 'Canada'),
(5, 'Fort McMurray South', 'McLeod Ave', 'Fort McMurray', 'T9H 4K1', 'AB', 'Canada'),
(6, 'Grande Prairie East', '100 St', 'Grande Prairie', 'T8N 1X7', 'AB', 'Canada');

SET IDENTITY_INSERT Branches OFF;

INSERT INTO Cars (VIN, License_Plate, Make, Model, Transmission, Branch_ID, Type)
VALUES 
('WA1DGAFP4EA042058', 'BobRox', 'Volkswagen', 'Golf', 'Manual', 1, 'SMALL'),
('56PI8I9PLGN7Z4SPN', 'DG1YV0N', 'Subaru', 'Sonata', 'Automatic', 3, 'TRUCK'),
('5E4A3G05DMUPZD89A', 'BPI52UW', 'Kia', 'Sonata', 'Automatic', 2, 'SMALL'),
('38VGKOKZR0PCKXAFL', 'L2AW7GP', 'Hyundai', 'Forester', 'Manual', 5, 'SUV'),
('DKA35BZT3ENC5MBVS', 'LIXWJ5J', 'Kia', 'Optima', 'Manual', 3, 'SPORT'),
('QM7NQREKOUI6HRD6T', 'V2D1I68', 'Hyundai', 'Forester', 'Automatic', 2, 'SMALL'),
('XS0EO3HS2TFG682FF', 'PTGSV82', 'Subaru', 'Golf', 'Manual', 5, 'SMALL'),
('2SLNH3JH9YJDWLVW6', 'EOMP1B9', 'Chevrolet', 'Accord', 'Automatic', 4, 'TRUCK'),
('B98YAL25SDE6UNM1E', '9XD6H7B', 'Hyundai', 'Sonata', 'Automatic', 1, 'SPORT'),
('1R3HFATOMDG9E9QT5', 'FTQ70R4', 'Kia', 'Silverado', 'Automatic', 2, 'SUV'),
('2L9QYF3T9C3605J0E', 'D52BZ2L', 'Ford', 'Camry', 'Manual', 2, 'LUXURY'),
('1G4A1B7C8HF000001', 'MitchelGoated', 'Buick', 'Century', 'Automatic', 1, 'LUXURY');

INSERT INTO Customers (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber)
VALUES 
('Jimbo', 'Jones', '123 Main St', 'Edmonton', 'T5G 2C4', 'AB', 'Canada', '(555) 555-1234'),
('Jane', 'Smith', '456 Elm Ave', 'Calgary', 'T2P 0J1', 'AB', 'Canada', '(403) 555-5678'),
('Buddy', 'Brown', '789 Maple Rd', 'Vancouver', 'V6T 1Z2', 'BC', 'Canada', '(604) 555-9012'),
('Johnny', 'Johnson', '1000 Oak Dr', 'Winnipeg', 'R3J 3T6', 'MB', 'Canada', '(204) 555-2345'),
('Sophia', 'Sandwich', '2345 Birch Lane', 'Toronto', 'M4W 2R7', 'ON', 'Canada', '(416) 555-6789'),
('Lucas', 'Davis', '5678 Poplar St', 'Montreal', 'H2W 1R4', 'QC', 'Canada', '(514) 555-0123'),
('Mia', 'McDonald', '8901 Pine Ave', 'Halifax', 'B3J 2S8', 'NS', 'Canada', '(902) 555-3456'),
('Ethan', 'Bussin', '1234 Spruce Cr', 'St. Johns', 'A1B 3C4', 'NL', 'Canada', '(709) 555-7890'),
('Emily', 'Waluigi', '5678 Willow Way', 'Victoria', 'V9B 1T7', 'BC', 'Canada', '(250) 555-1212'),
('Alexander', 'Supertramp', '9012 Ash St', 'Regina', 'S4P 3J3', 'SK', 'Canada', '(306) 555-5678');

INSERT INTO Employees (FirstName, LastName, Street, City, Postal_Code, Province, Country, PhoneNumber, Branch_ID)
VALUES 
('John', 'Doe', '123 Main St', 'Toronto', '12345', 'ON', 'Canada', '(555) 555-1212', 1),
('Jane', 'Smith', '456 Elm St', 'Vancouver', '54321', 'BC', 'Canada', '(555) 555-1213', 2),
('Peter', 'Juicebox', '789 Oak St', 'Montreal', '98765', 'QC', 'Canada', '(555) 555-1214', 1),
('Mary', 'WendysFrosty', '1011 Maple St', 'Edmonton', '41640', 'AB', 'Canada', '(555) 555-1215', 3),
('David', 'McDonaldsBigMac', '1213 Birch St', 'Halifax', '10001', 'NS', 'Canada', '(555) 555-1216', 2),
('Lisa', 'GarbanzoBean', '1415 Spruce St', 'Winnipeg', '90210', 'MB', 'Canada', '(555) 555-1217', 1),
('Michael', 'BigHomie', '1617 Pine St', 'Saskatoon', '33445', 'SK', 'Canada', '(555) 555-1218', 2),
('Sarah', 'Clareview', '1819 Cedar St', 'Charlottetown', '78901', 'PE', 'Canada', '(555) 555-1219', 3),
('Daniel', 'Mckernan', '2021 Hickory St', 'Fredericton', '12378', 'NB', 'Canada', '(555) 555-1220', 1),
('Emily', 'Enterprise', '2223 Ash St', 'St. Johns', '45600', 'NL', 'Canada', '(555) 555-1221', 3);

INSERT INTO Reservations (Start_Date, End_Date, TotalPrice, Customer_ID, Employee_ID, Branch_Pickup_ID, Branch_Dropoff_ID, VIN)
VALUES 
('2024-04-01', '2024-04-05', 150.00, 1, 1, 1, 1, 'WA1DGAFP4EA042058'),
('2024-04-10', '2024-04-15', 200.00, 2, 2, 2, 2, '56PI8I9PLGN7Z4SPN'),
('2024-04-20', '2024-04-25', 175.00, 3, 3, 3, 3, '5E4A3G05DMUPZD89A'),
('2024-05-01', '2024-05-07', 250.00, 4, 4, 4, 4, '38VGKOKZR0PCKXAFL'),
('2024-05-10', '2024-05-17', 300.00, 5, 5, 5, 5, 'DKA35BZT3ENC5MBVS'),
('2024-05-15', '2024-05-20', 225.00, 6, 6, 6, 6, 'QM7NQREKOUI6HRD6T'),
('2024-05-20', '2024-05-25', 175.00, 7, 7, 1, 2, 'XS0EO3HS2TFG682FF'),
('2024-05-25', '2024-06-01', 400.00, 8, 8, 2, 3, '2SLNH3JH9YJDWLVW6'),
('2024-06-01', '2024-06-07', 350.00, 9, 9, 3, 4, 'B98YAL25SDE6UNM1E'),
('2024-06-07', '2024-06-14', 450.00, 10, 10, 4, 5, '1R3HFATOMDG9E9QT5'),
('2024-04-02', '2024-04-04', 120.00, 1, 1, 1, 1, '56PI8I9PLGN7Z4SPN'),
('2024-04-05', '2024-04-09', 180.00, 2, 1, 1, 1, '5E4A3G05DMUPZD89A'),
('2024-04-15', '2024-04-18', 150.00, 3, 2, 2, 2, '38VGKOKZR0PCKXAFL'),
('2024-04-20', '2024-04-24', 210.00, 4, 2, 2, 2, 'DKA35BZT3ENC5MBVS'),
('2024-04-25', '2024-04-29', 240.00, 5, 3, 3, 3, 'QM7NQREKOUI6HRD6T'),
('2024-05-02', '2024-05-06', 260.00, 6, 4, 4, 4, 'XS0EO3HS2TFG682FF'),
('2024-05-07', '2024-05-12', 300.00, 7, 4, 4, 4, '2SLNH3JH9YJDWLVW6'),
('2024-05-13', '2024-05-17', 200.00, 8, 5, 5, 5, 'B98YAL25SDE6UNM1E'),
('2024-05-18', '2024-05-23', 350.00, 9, 5, 5, 5, '1R3HFATOMDG9E9QT5'),
('2024-05-24', '2024-05-29', 400.00, 10, 5, 5, 5, '1G4A1B7C8HF000001'),
('2024-06-01', '2024-06-05', 150.00, 1, 1, 1, 1, 'WA1DGAFP4EA042058'),
('2024-06-06', '2024-06-10', 180.00, 2, 1, 1, 1, '56PI8I9PLGN7Z4SPN'),
('2024-06-11', '2024-06-14', 210.00, 3, 1, 1, 1, '5E4A3G05DMUPZD89A'),
('2024-04-01', '2024-04-04', 120.00, 1, 1, 1, 1, '5E4A3G05DMUPZD89A'),
('2024-04-06', '2024-04-09', 180.00, 2, 1, 1, 1, '38VGKOKZR0PCKXAFL'),
('2024-04-10', '2024-04-14', 150.00, 3, 1, 1, 1, 'DKA35BZT3ENC5MBVS'),
('2024-04-15', '2024-04-19', 210.00, 4, 1, 1, 1, 'QM7NQREKOUI6HRD6T'),
('2024-04-20', '2024-04-24', 240.00, 5, 1, 1, 1, 'XS0EO3HS2TFG682FF'),
('2024-05-02', '2024-05-06', 260.00, 6, 2, 2, 2, '2SLNH3JH9YJDWLVW6'),
('2024-05-07', '2024-05-12', 300.00, 7, 2, 2, 2, 'B98YAL25SDE6UNM1E'),
('2024-05-13', '2024-05-17', 200.00, 8, 2, 2, 2, '1R3HFATOMDG9E9QT5'),
('2024-05-18', '2024-05-23', 350.00, 9, 2, 2, 2, '1G4A1B7C8HF000001'),
('2024-05-24', '2024-05-29', 400.00, 10, 2, 2, 2, 'WA1DGAFP4EA042058'),
('2024-06-01', '2024-06-05', 150.00, 1, 3, 3, 3, '56PI8I9PLGN7Z4SPN');
