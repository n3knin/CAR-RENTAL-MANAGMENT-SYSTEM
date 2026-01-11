CREATE DATABASE RentalDB;
USE RentalDB;


CREATE TABLE IF NOT EXISTS Users (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Firstname VARCHAR(50) NOT NULL,
    Lastname VARCHAR(50) NOT NULL,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    Role ENUM('Admin', 'Manager', 'RentalAgent') NOT NULL
);

CREATE TABLE IF NOT EXISTS VehicleCategories (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    CategoryName VARCHAR(50) NOT NULL,
    HourlyRate DECIMAL(10,2),
    DailyRate DECIMAL(10,2) NOT NULL,
    WeeklyRate DECIMAL(10,2),
    MonthlyRate DECIMAL(10,2),
    Description VARCHAR(255)
);

CREATE TABLE IF NOT EXISTS VehicleFeatures (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    FeatureName VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS Vehicles (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Make VARCHAR(50) NOT NULL,
    Model VARCHAR(50) NOT NULL,
    Year INT NOT NULL,
    Color VARCHAR(30),
    LicensePlate VARCHAR(20) UNIQUE NOT NULL,
    VIN VARCHAR(50) UNIQUE NOT NULL,
    CategoryID INT NOT NULL,
    Status ENUM('Available', 'Rented', 'Reserved', 'Maintenance', 'OutOfService', 'Retired') DEFAULT 'Available',
    Mileage INT NOT NULL,
    FuelType ENUM('Gasoline', 'Diesel', 'Electric', 'Hybrid'),
    Transmission ENUM('Automatic', 'Manual'),
    SeatingCapacity INT,
    ImageUrl VARCHAR(255),
    FOREIGN KEY (CategoryID) REFERENCES VehicleCategories(ID)
);

CREATE TABLE IF NOT EXISTS VehicleFeatureMap (
    VehicleID INT,
    FeatureID INT,
    PRIMARY KEY (VehicleID, FeatureID),
    FOREIGN KEY (VehicleID) REFERENCES Vehicles(ID),
    FOREIGN KEY (FeatureID) REFERENCES VehicleFeatures(ID)
);

CREATE TABLE IF NOT EXISTS Customers (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Phone VARCHAR(20),
    Address VARCHAR(255),
    DateOfBirth DATE NOT NULL,
    DriverLicenseNumber VARCHAR(50) UNIQUE NOT NULL,
    LicenseIssueDate DATE,
    LicenseExpiryDate DATE NOT NULL,
    LicenseState VARCHAR(50),
    EmergencyContact VARCHAR(100),
    CustomerType ENUM('Individual', 'Corporate') DEFAULT 'Individual',
    IsBlacklisted BOOLEAN DEFAULT FALSE,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS Reservations (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    CustomerID INT NOT NULL,
    VehicleID INT NOT NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    Status ENUM('Pending', 'Confirmed', 'Cancelled', 'Completed') DEFAULT 'Pending',
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CustomerID) REFERENCES Customers(ID),
    FOREIGN KEY (VehicleID) REFERENCES Vehicles(ID)
);


CREATE TABLE IF NOT EXISTS Rentals (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    ReservationID INT,
    CustomerID INT NOT NULL,
    VehicleID INT NOT NULL,
    RentalAgentID INT NOT NULL,
    ActualPickupDate DATETIME NOT NULL,
    ExpectedReturnDate DATETIME,
    ActualReturnDate DATETIME,
    StartMileage INT NOT NULL,
    EndMileage INT,
    Status ENUM('Active', 'Completed', 'Overdue') DEFAULT 'Active',
    FOREIGN KEY (ReservationID) REFERENCES Reservations(ID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(ID),
    FOREIGN KEY (VehicleID) REFERENCES Vehicles(ID),
    FOREIGN KEY (RentalAgentID) REFERENCES Users(ID)
);

CREATE TABLE IF NOT EXISTS Invoices (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    RentalID INT NOT NULL,
    IssueDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    RentalCharge DECIMAL(10,2),
    AppliedRateType ENUM('Hourly', 'Daily', 'Weekly', 'Monthly'),
    LateFee DECIMAL(10,2) DEFAULT 0,
    DamageFee DECIMAL(10,2) DEFAULT 0,
    FuelCharge DECIMAL(10,2) DEFAULT 0,
    CleaningFee DECIMAL(10,2) DEFAULT 0,
    TotalAmount DECIMAL(10,2) NOT NULL,
    IsPaid BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (RentalID) REFERENCES Rentals(ID)
);

CREATE TABLE IF NOT EXISTS Payments (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    InvoiceID INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    PaymentDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    PaymentMethod ENUM('Cash', 'CreditCard', 'DebitCard', 'Online'),
    FOREIGN KEY (InvoiceID) REFERENCES Invoices(ID)
);
CREATE TABLE IF NOT EXISTS MaintenanceRecords (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    VehicleID INT NOT NULL,
    MaintenanceType VARCHAR(100) NOT NULL,
    Cost DECIMAL(10,2),
    StartDate DATE NOT NULL,
    EndDate DATE,
    IsCompleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (VehicleID) REFERENCES Vehicles(ID)
);

CREATE TABLE IF NOT EXISTS VehicleInspections (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    RentalID INT NOT NULL,
    InspectionType ENUM('Pickup', 'Return') NOT NULL,
    InspectionDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    InspectedBy INT NOT NULL,  -- UserID of agent
    Mileage INT NOT NULL,
    FuelLevel ENUM('Empty', 'Quarter', 'Half', 'ThreeQuarter', 'Full') NOT NULL,
    ExteriorCondition ENUM('Excellent', 'Good', 'Fair', 'Poor') NOT NULL,
    InteriorCondition ENUM('Excellent', 'Good', 'Fair', 'Poor') NOT NULL,
    HasSmokingViolation BOOLEAN DEFAULT FALSE,
    AllAccessoriesReturned BOOLEAN DEFAULT TRUE,
    Notes TEXT,
    FOREIGN KEY (RentalID) REFERENCES Rentals(ID),
    FOREIGN KEY (InspectedBy) REFERENCES Users(ID)
);

CREATE TABLE IF NOT EXISTS DamageReports (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    InspectionID INT NOT NULL,
    DamageType ENUM('Scratch', 'Dent', 'Crack', 'Stain', 'Missing', 'Other') NOT NULL,
    Location VARCHAR(100) NOT NULL,  -- e.g., "Front bumper", "Driver door"
    Severity ENUM('Minor', 'Moderate', 'Major') NOT NULL,
    Description TEXT,
    EstimatedCost DECIMAL(10,2),
    PhotoUrl VARCHAR(255),
    FOREIGN KEY (InspectionID) REFERENCES VehicleInspections(ID)
);
CREATE TABLE IF NOT EXISTS Deposits (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    RentalID INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    Status ENUM('Held', 'Refunded', 'Applied') DEFAULT 'Held',
    RefundedAmount DECIMAL(10,2) DEFAULT 0,
    AppliedToInvoice BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (RentalID) REFERENCES Rentals(ID)
);