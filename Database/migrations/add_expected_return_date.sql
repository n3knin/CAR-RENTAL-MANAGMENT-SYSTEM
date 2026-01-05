-- Migration: Add ExpectedReturnDate to rentals table
-- Date: 2026-01-05
-- Description: Adds ExpectedReturnDate column to track when vehicle should be returned

USE RentalDB;

-- Add the new column
ALTER TABLE rentals 
ADD COLUMN ExpectedReturnDate DATETIME NULL AFTER ActualPickupDate;

-- Optional: Update existing rentals with expected return date from reservations
UPDATE rentals r
INNER JOIN reservations res ON r.ReservationID = res.ID
SET r.ExpectedReturnDate = res.EndDate
WHERE r.ExpectedReturnDate IS NULL;

-- Verify the change
SELECT * FROM rentals LIMIT 5;
