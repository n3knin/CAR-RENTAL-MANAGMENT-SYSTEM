-- Migration: Add IsCompleted to MaintenanceRecords
-- Date: 2026-01-11
-- Description: Adds IsCompleted boolean to track service status simply

USE RentalDB;

-- Rename Description to MaintenanceType and add IsCompleted
ALTER TABLE MaintenanceRecords 
CHANGE COLUMN Description MaintenanceType VARCHAR(100) NOT NULL,
ADD COLUMN IsCompleted BOOLEAN DEFAULT FALSE AFTER EndDate;

-- Update existing records: if EndDate exists, it's completed
UPDATE MaintenanceRecords 
SET IsCompleted = TRUE 
WHERE EndDate IS NOT NULL;
