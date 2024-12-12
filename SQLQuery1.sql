CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1), -- Auto-incremented ID
    Username NVARCHAR(50) NOT NULL UNIQUE, -- Unique username
    PasswordHash NVARCHAR(255) NOT NULL, -- Store a hashed password
    Email NVARCHAR(100) NOT NULL UNIQUE, -- Unique email
    CreatedAt DATETIME DEFAULT GETDATE() -- Date of registration
);
