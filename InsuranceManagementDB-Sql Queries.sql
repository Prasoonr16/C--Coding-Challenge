create database InsuranceManagementDB;

use InsuranceManagementDB;

-- Table for User class
CREATE TABLE [User]
(
    userId INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(50),
    password NVARCHAR(100),
    role NVARCHAR(20)
);

-- Table for Client class
CREATE TABLE Client(
    clientId INT PRIMARY KEY IDENTITY(1,1),
    clientName NVARCHAR(100),
    contactInfo NVARCHAR(200),
    policy NVARCHAR(50)
);

-- Table for Claim class
CREATE TABLE Claim(
    claimId INT PRIMARY KEY IDENTITY(1,1),
    claimNumber int,
    dateFiled DATETIME,
    claimAmount DECIMAL(18, 2) ,
    status VARCHAR(20),
    policy VARCHAR(50),
    clientId INT , -- Foreign key for Client
    FOREIGN KEY (clientId) REFERENCES Client(clientId)
);

alter table Claim
alter column claimNumber varchar(10);

-- Table for Payment class
CREATE TABLE Payment(
    paymentId INT PRIMARY KEY IDENTITY(1,1),
    paymentDate DATETIME,
    paymentAmount DECIMAL(18, 2),
    clientId INT NOT NULL, -- Foreign key for Client
    FOREIGN KEY (clientId) REFERENCES Client(clientId)
);

-- Inserting into User Table
INSERT INTO [User] (username, password, role) 
VALUES 
('admin', 'admin123', 'Admin'),
('john_doe', 'pass1234', 'Client'),
('neha_singh', 'neha!secure', 'Client'),
('rajiv_kumar', 'rajiv@2024', 'Client'),
('priya_sharma', 'priya$567', 'Client');

-- Inserting into Client Table
INSERT INTO Client(clientName, contactInfo, policy) 
VALUES 
('John Doe', 'john.doe@gmail.com, 9876543210', 'Health Policy'),
('Neha Singh', 'neha.singh@gmail.com, 9123456789', 'Car Insurance Policy'),
('Rajiv Kumar', 'rajiv.kumar@gmail.com, 9988776655', 'Home Insurance Policy'),
('Priya Sharma', 'priya.sharma@gmail.com, 9090909090', 'Life Insurance Policy'),
('Vikas Gupta', 'vikas.gupta@gmail.com, 9876543211', 'Travel Insurance Policy');

-- Inserting into Claim Table
INSERT INTO Claim(claimNumber, dateFiled, claimAmount, status, policy, clientId)
VALUES 
('CLM001', '2024-09-15', 100000.00, 'Approved', 'Health Policy', 1),  -- John Doe
('CLM002', '2024-08-20', 50000.00, 'Pending', 'Car Insurance Policy', 2),  -- Neha Singh
('CLM003', '2024-07-05', 250000.00, 'Rejected', 'Home Insurance Policy', 3),  -- Rajiv Kumar
('CLM004', '2024-10-01', 150000.00, 'Approved', 'Life Insurance Policy', 4),  -- Priya Sharma
('CLM005', '2024-09-28', 30000.00, 'Pending', 'Travel Insurance Policy', 5);  -- Vikas Gupta

-- Inserting into Payment Table
INSERT INTO Payment(paymentDate, paymentAmount, clientId)
VALUES
('2024-09-16', 100000.00, 1),  -- John Doe
('2024-08-25', 50000.00, 2),  -- Neha Singh
('2024-07-10', 250000.00, 3),  -- Rajiv Kumar
('2024-10-02', 150000.00, 4),  -- Priya Sharma
('2024-09-30', 30000.00, 5);  -- Vikas Gupta

create table Policy
(policyID int primary key,
policyName varchar(20));

INSERT INTO Policy (policyID, policyName)
VALUES 
(1, 'Health Insurance'),
(2, 'Car Insurance'),
(3, 'Life Insurance'),
(4, 'Home Insurance'),
(5, 'Travel Insurance');

select * from Policy;