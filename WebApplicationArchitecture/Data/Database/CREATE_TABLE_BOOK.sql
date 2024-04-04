CREATE TABLE Book (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(100),
    Author VARCHAR(100),
    Genre VARCHAR(50),
    PublicationYear INT,
    ISBN VARCHAR(20),
    Price DECIMAL(10,2),
    InsertDate DATETIME,
    AlterDate DATETIME NULL
);