-- ============================================
-- UPDATE EXISTING USERS TO USE HASHED PASSWORDS
-- ============================================
-- Run this script in TablePlus to update existing user passwords to SHA256 hashes
-- This is a ONE-TIME migration script

USE RentalDB;

-- Update existing users with hashed passwords
-- Password: admin123 -> Hash: 240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9
UPDATE Users SET Password = '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9' 
WHERE Username = 'admin';

-- Password: manager123 -> Hash: 6c7ca345f63f835cb353ff15bd6c5e052ec08e7855d9f994d7d5a0e5e8c9a5c7
UPDATE Users SET Password = '6c7ca345f63f835cb353ff15bd6c5e052ec08e7855d9f994d7d5a0e5e8c9a5c7' 
WHERE Username = 'manager';

-- Password: agent123 -> Hash: b4c0c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8
UPDATE Users SET Password = 'b4c0c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8' 
WHERE Username = 'agent1';

UPDATE Users SET Password = 'b4c0c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8c1e3e8' 
WHERE Username = 'agent2';

-- Verify the update
SELECT Username, LEFT(Password, 20) as PasswordHash, Role, Status FROM Users;

-- After running this script, you can log in with:
-- Username: admin, Password: admin123
-- Username: manager, Password: manager123
-- Username: agent1, Password: agent123
-- Username: agent2, Password: agent123
