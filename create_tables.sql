IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'CarRental')
BEGIN
    CREATE DATABASE CarRental;
    PRINT 'CarRental DB created.';
END
ELSE
BEGIN
    PRINT 'CarRental DB already exists.';
END
GO
USE CarRental;
GO
CREATE TABLE Branches (
    Branch_ID   INT PRIMARY KEY IDENTITY(1, 1),
    Name        NVARCHAR(60) NOT NULL,
    Street      NVARCHAR(40) NOT NULL,
    City        NVARCHAR(50) NOT NULL,
    Postal_Code NVARCHAR(10) NOT NULL,
    Province    NVARCHAR(2)  NOT NULL,
    Country     NVARCHAR(50) NOT NULL
);

CREATE TABLE Customers (
    Customer_ID INT PRIMARY KEY IDENTITY(1, 1),
    FirstName   NVARCHAR(40) NOT NULL,
    LastName    NVARCHAR(40) NOT NULL,
    Street      NVARCHAR(40) NOT NULL,
    City        NVARCHAR(50) NOT NULL,
    Postal_Code NVARCHAR(10) NOT NULL,
    Province    NVARCHAR(2)  NOT NULL,
    Country     NVARCHAR(50) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL
);

CREATE TABLE Employees (
    Employee_ID             INT PRIMARY KEY IDENTITY(1, 1),
    FirstName               NVARCHAR(40) NOT NULL,
    LastName                NVARCHAR(40) NOT NULL,
    Street                  NVARCHAR(40) NOT NULL,
    City                    NVARCHAR(50) NOT NULL,
    Postal_Code             NVARCHAR(10) NOT NULL,
    Province                NVARCHAR(2)  NOT NULL,
    Country                 NVARCHAR(50) NOT NULL,
    PhoneNumber             NVARCHAR(20) NOT NULL,
    Branch_ID               INT NOT NULL,
    FOREIGN KEY (Branch_ID) REFERENCES Branches(Branch_ID)
);

CREATE TABLE CarType (
    Type         NVARCHAR(20) PRIMARY KEY,
    DailyPrice   SMALLMONEY NOT NULL,
    WeeklyPrice  SMALLMONEY NOT NULL,
    MonthlyPrice SMALLMONEY NOT NULL
);

CREATE TABLE Cars (
    VIN                     NVARCHAR(17) PRIMARY KEY,
    License_Plate           NVARCHAR(20) NOT NULL,
    Make                    NVARCHAR(50) NOT NULL,
    Model                   NVARCHAR(50) NOT NULL,
    Transmission            NVARCHAR(20) NOT NULL,
    Branch_ID               INT,
    Type                    NVARCHAR(20) NOT NULL,
    FOREIGN KEY (Branch_ID) REFERENCES Branches(Branch_ID),
    FOREIGN KEY (Type)      REFERENCES CarType(Type)
);

CREATE TABLE Reservations (
    Reservation_ID                  INT PRIMARY KEY IDENTITY(1, 1),
    Start_Date                      DATE NOT NULL,
    End_Date                        DATE NOT NULL,
    TotalPrice                      SMALLMONEY,
    Customer_ID                     INT NOT NULL,          -- Customer ID
    Employee_ID                     INT NOT NULL,          -- Employee ID
    Branch_Pickup_ID                INT NOT NULL,          -- Pickup ID
    Branch_Dropoff_ID               INT NOT NULL,          -- Dropoff ID
    VIN                             NVARCHAR(17) NOT NULL, -- Car ID
    FOREIGN KEY (Customer_ID)       REFERENCES Customers(Customer_ID),
    FOREIGN KEY (Employee_ID)       REFERENCES Employees(Employee_ID),
    FOREIGN KEY (Branch_Pickup_ID)  REFERENCES Branches(Branch_ID),
    FOREIGN KEY (Branch_Dropoff_ID) REFERENCES Branches(Branch_ID),
    FOREIGN KEY (VIN)               REFERENCES Cars(VIN)
);