-- ============================================
-- RENTAL MANAGEMENT SYSTEM - SAMPLE DATA
-- ============================================
-- Run this AFTER creating the database schema
-- This will populate tables with test data

USE RentalDB;

-- 1. INSERT USERS (Admin, Manager, Rental Agents)
-- Passwords are now SHA256 hashed:
-- admin123 -> 240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9
-- manager123 -> 6c7ca345f63f835cb353ff15bd6c5e052ec08e7855d9f994d7d5a0e5e8c9a5c7
-- agent123 -> b4c0c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8

INSERT INTO Users (Firstname, Lastname, Username, Password, Role, Status) VALUES
('John', 'Admin', 'admin', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Admin', 'Active'),
('Sarah', 'Manager', 'manager', '6c7ca345f63f835cb353ff15bd6c5e052ec08e7855d9f994d7d5a0e5e8c9a5c7', 'Manager', 'Active'),
('Mike', 'Smith', 'agent1', 'b4c0c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8', 'RentalAgent', 'Active'),
('Lisa', 'Johnson', 'agent2', 'b4c0c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8', 'RentalAgent', 'Active');

-- 2. INSERT VEHICLE CATEGORIES WITH RATES
INSERT INTO VehicleCategories (CategoryName, HourlyRate, DailyRate, WeeklyRate, MonthlyRate, Description) VALUES
('Sedan', 80.00, 1500.00, 9500.00, 40000.00, 'Comfortable 4-door sedans for city driving'),
('SUV', 120.00, 2000.00, 13000.00, 50000.00, 'Spacious SUVs perfect for families'),
('Hatchback', 70.00, 1300.00, 9000.00, 38000.00, 'Compact and fuel-efficient'),
('Van', 150.00, 3000.00, 18000.00, 55000.00, 'Large vans for groups or cargo'),
('Pickup', 200.00, 3500.00, 20000.00, 60000.00, 'Pickup trucks for hauling');

-- 3. INSERT VEHICLE FEATURES
INSERT INTO VehicleFeatures (FeatureName) VALUES
('GPS Navigation'),
('Bluetooth'),
('Air Conditioning'),
('Backup Camera'),
('Child Seat Available'),
('USB Charging'),
('Cruise Control'),
('Sunroof'),
('Leather Seats'),
('All-Wheel Drive');

-- 4. INSERT VEHICLES
INSERT INTO Vehicles (Make, Model, Year, Color, LicensePlate, VIN, CategoryID, Status, Mileage, FuelType, Transmission, SeatingCapacity, ImageUrl) VALUES
-- Sedans
('Toyota', 'Camry', 2022, 'Silver', 'ABC-1234', 'VIN001CAMRY2022', 1, 'Available', 15000, 'Gasoline', 'Automatic', 5, NULL),
('Honda', 'Accord', 2023, 'Black', 'DEF-5678', 'VIN002ACCORD2023', 1, 'Available', 8000, 'Hybrid', 'Automatic', 5, NULL),
('Nissan', 'Altima', 2021, 'White', 'GHI-9012', 'VIN003ALTIMA2021', 1, 'Available', 25000, 'Gasoline', 'Automatic', 5, NULL),

-- SUVs
('Ford', 'Explorer', 2023, 'Blue', 'JKL-3456', 'VIN004EXPLORER2023', 2, 'Available', 12000, 'Gasoline', 'Automatic', 7, NULL),
('Toyota', 'RAV4', 2022, 'Red', 'MNO-7890', 'VIN005RAV42022', 2, 'Rented', 18000, 'Hybrid', 'Automatic', 5, NULL),
('Chevrolet', 'Tahoe', 2023, 'Black', 'PQR-2345', 'VIN006TAHOE2023', 2, 'Available', 9000, 'Gasoline', 'Automatic', 8, NULL),

-- Hatchbacks
('Honda', 'Civic', 2022, 'Gray', 'STU-6789', 'VIN007CIVIC2022', 3, 'Available', 20000, 'Gasoline', 'Manual', 5, NULL),
('Mazda', '3', 2023, 'Blue', 'VWX-0123', 'VIN008MAZDA32023', 3, 'Available', 7000, 'Gasoline', 'Automatic', 5, NULL),

-- Vans
('Toyota', 'Sienna', 2022, 'Silver', 'YZA-4567', 'VIN009SIENNA2022', 4, 'Available', 22000, 'Hybrid', 'Automatic', 8, NULL),
('Honda', 'Odyssey', 2023, 'White', 'BCD-8901', 'VIN010ODYSSEY2023', 4, 'Maintenance', 11000, 'Gasoline', 'Automatic', 8, NULL),

-- Pickups
('Ford', 'F-150', 2023, 'Red', 'EFG-2345', 'VIN011F1502023', 5, 'Available', 14000, 'Gasoline', 'Automatic', 5, NULL),
('Chevrolet', 'Silverado', 2022, 'Black', 'HIJ-6789', 'VIN012SILVERADO2022', 5, 'Available', 19000, 'Diesel', 'Automatic', 6, NULL);

-- 5. MAP FEATURES TO VEHICLES (Many-to-Many)
-- Toyota Camry features
INSERT INTO VehicleFeatureMap (VehicleID, FeatureID) VALUES
(1, 1), (1, 2), (1, 3), (1, 4), (1, 6),
-- Honda Accord features
(2, 1), (2, 2), (2, 3), (2, 4), (2, 6), (2, 7), (2, 9),
-- Ford Explorer features
(4, 1), (4, 2), (4, 3), (4, 4), (4, 5), (4, 6), (4, 7), (4, 10),
-- Toyota RAV4 features
(5, 1), (5, 2), (5, 3), (5, 4), (5, 6), (5, 10),
-- Honda Civic features
(7, 2), (7, 3), (7, 6),
-- Ford F-150 features
(11, 1), (11, 2), (11, 3), (11, 4), (11, 6), (11, 10);

-- 6. INSERT CUSTOMERS
INSERT INTO Customers (FirstName, LastName, Email, Phone, Address, DateOfBirth, DriverLicenseNumber, LicenseIssueDate, LicenseExpiryDate, LicenseState, EmergencyContact, CustomerType, IsBlacklisted) VALUES
('Robert', 'Williams', 'robert.w@email.com', '555-0101', '123 Main St, City, State', '1985-03-15', 'DL001234567', '2020-01-15', '2028-01-15', 'CA', 'Jane Williams 555-0102', 'Individual', FALSE),
('Emily', 'Brown', 'emily.b@email.com', '555-0201', '456 Oak Ave, City, State', '1990-07-22', 'DL002345678', '2019-05-20', '2027-05-20', 'CA', 'Tom Brown 555-0202', 'Individual', FALSE),
('Michael', 'Davis', 'michael.d@email.com', '555-0301', '789 Pine Rd, City, State', '1988-11-08', 'DL003456789', '2021-03-10', '2029-03-10', 'CA', 'Sarah Davis 555-0302', 'Individual', FALSE),
('ABC Corporation', 'N/A', 'fleet@abccorp.com', '555-0401', '321 Business Blvd, City, State', '1980-01-01', 'DL004567890', '2022-06-01', '2030-06-01', 'CA', 'HR Dept 555-0402', 'Corporate', FALSE),
('Jennifer', 'Martinez', 'jennifer.m@email.com', '555-0501', '654 Elm St, City, State', '1992-05-30', 'DL005678901', '2020-09-15', '2028-09-15', 'CA', 'Carlos Martinez 555-0502', 'Individual', FALSE);

-- 7. INSERT RESERVATIONS
INSERT INTO Reservations (CustomerID, VehicleID, StartDate, EndDate, Status, CreatedAt) VALUES
(1, 1, '2025-12-10 09:00:00', '2025-12-12 09:00:00', 'Confirmed', '2025-12-05 14:30:00'),
(2, 4, '2025-12-15 10:00:00', '2025-12-20 10:00:00', 'Confirmed', '2025-12-06 11:00:00'),
(3, 7, '2025-12-08 08:00:00', '2025-12-09 08:00:00', 'Completed', '2025-12-01 16:45:00');

-- 8. INSERT ACTIVE RENTAL (Toyota RAV4 currently rented)
INSERT INTO Rentals (ReservationID, CustomerID, VehicleID, RentalAgentID, ActualPickupDate, ExpectedReturnDate, ActualReturnDate, StartMileage, EndMileage, Status) VALUES
(NULL, 2, 5, 3, '2025-12-05 10:00:00', '2025-12-07 10:00:00', NULL, 18000, NULL, 'Active');

-- 9. INSERT COMPLETED RENTAL WITH INSPECTION
INSERT INTO Rentals (ReservationID, CustomerID, VehicleID, RentalAgentID, ActualPickupDate, ExpectedReturnDate, ActualReturnDate, StartMileage, EndMileage, Status) VALUES
(3, 3, 7, 4, '2025-12-08 08:00:00', '2025-12-09 08:00:00', '2025-12-09 09:00:00', 20000, 20150, 'Completed');

-- 10. INSERT VEHICLE INSPECTIONS
-- Pickup inspection for completed rental
INSERT INTO VehicleInspections (RentalID, InspectionType, InspectionDate, InspectedBy, Mileage, FuelLevel, ExteriorCondition, InteriorCondition, HasSmokingViolation, AllAccessoriesReturned, Notes) VALUES
(2, 'Pickup', '2025-12-08 08:00:00', 4, 20000, 'Full', 'Excellent', 'Excellent', FALSE, TRUE, 'Vehicle in perfect condition at pickup'),
(2, 'Return', '2025-12-09 09:00:00', 4, 20150, 'ThreeQuarter', 'Good', 'Good', FALSE, TRUE, 'Minor dirt on exterior, interior clean');

-- 11. INSERT DEPOSIT
INSERT INTO Deposits (RentalID, Amount, Status, RefundedAmount, AppliedToInvoice) VALUES
(2, 200.00, 'Refunded', 200.00, FALSE);

-- 12. INSERT INVOICE FOR COMPLETED RENTAL
INSERT INTO Invoices (RentalID, IssueDate, RentalCharge, AppliedRateType, LateFee, DamageFee, FuelCharge, CleaningFee, TotalAmount, IsPaid) VALUES
(2, '2025-12-09 09:15:00', 40.00, 'Daily', 0.00, 0.00, 10.00, 0.00, 50.00, TRUE);

-- 13. INSERT PAYMENT
INSERT INTO Payments (InvoiceID, Amount, PaymentDate, PaymentMethod) VALUES
(1, 50.00, '2025-12-09 09:20:00', 'CreditCard');

-- 14. INSERT MAINTENANCE RECORD
INSERT INTO MaintenanceRecords (VehicleID, MaintenanceType, Cost, StartDate, EndDate, IsCompleted) VALUES
(10, 'Oil Change', 150.00, '2025-12-01', '2025-12-01', TRUE),
(10, 'Repair', 350.00, '2025-12-03', '2025-12-04', TRUE);

-- ============================================
-- VERIFICATION QUERIES
-- ============================================
-- Run these to verify data was inserted correctly

SELECT 'Users' AS TableName, COUNT(*) AS RecordCount FROM Users
UNION ALL
SELECT 'VehicleCategories', COUNT(*) FROM VehicleCategories
UNION ALL
SELECT 'VehicleFeatures', COUNT(*) FROM VehicleFeatures
UNION ALL
SELECT 'Vehicles', COUNT(*) FROM Vehicles
UNION ALL
SELECT 'Customers', COUNT(*) FROM Customers
UNION ALL
SELECT 'Reservations', COUNT(*) FROM Reservations
UNION ALL
SELECT 'Rentals', COUNT(*) FROM Rentals
UNION ALL
SELECT 'Invoices', COUNT(*) FROM Invoices
UNION ALL
SELECT 'Payments', COUNT(*) FROM Payments
UNION ALL
SELECT 'Deposits', COUNT(*) FROM Deposits
UNION ALL
SELECT 'VehicleInspections', COUNT(*) FROM VehicleInspections
UNION ALL
SELECT 'MaintenanceRecords', COUNT(*) FROM MaintenanceRecords;
