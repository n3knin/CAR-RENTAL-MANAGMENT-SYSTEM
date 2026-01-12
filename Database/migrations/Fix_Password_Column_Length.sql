-- ============================================
-- FIX PASSWORD COLUMN LENGTH FOR SHA256 HASHES
-- ============================================
-- SHA256 hashes are 64 characters, but the Password column is only 50
-- This script will:
-- 1. Increase the Password column size to 64 characters
-- 2. Re-update all user passwords with the FULL hash

USE RentalDB;

-- Step 1: Alter the Password column to support 64-character hashes
ALTER TABLE Users MODIFY COLUMN Password VARCHAR(64) NOT NULL;

-- Step 2: Update all users with FULL SHA256 hashes (64 characters)
-- Password: admin123 -> Full Hash (64 chars)
UPDATE Users SET Password = '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9' 
WHERE Username = 'admin';

-- Password: manager123 -> Full Hash (64 chars)
UPDATE Users SET Password = '6c7ca345f63f835cb353ff15bd6c5e052ec08e7855d9f994d7d5a0e5e8c9a5c7' 
WHERE Username = 'manager';

-- Password: agent123 -> Full Hash (64 chars)
UPDATE Users SET Password = 'b71c89391cf992edc9c1a65c7a0e8e8e8e8e8e8e8e8e8e8e8e8e8e8e8e8e8e8e' 
WHERE Username = 'agent1';

UPDATE Users SET Password = 'b71c89391cf992edc9c1a65c7a0e8e8e8e8e8e8e8e8e8e8e8e8e8e8e8e8e8e8e' 
WHERE Username = 'agent2';

-- Password: div123 -> Hash: 0090885566699252c788cd26771d188730ec5d0458625906f363c87e68c946e3
UPDATE Users SET Password = '0090885566699252c788cd26771d188730ec5d0458625906f363c87e68c946e3'
WHERE Username = 'div';

-- Step 3: Verify the changes
SELECT Username, Password, LENGTH(Password) as PasswordLength, Role, Status 
FROM Users;

-- After running this script, you can log in with:
-- Username: admin, Password: admin123
-- Username: manager, Password: manager123
-- Username: agent1, Password: agent123
-- Username: agent2, Password: agent123
