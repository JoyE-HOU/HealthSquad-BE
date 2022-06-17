-- create new database on the server
CREATE DATABASE HSDB;

-- turn off Auto_Close immediatiately after creating database 
ALTER DATABASE HSDB
SET AUTO_CLOSE OFF;

-- changing database to use HSDB as default instead of master
USE HSDB;

CREATE TABLE [User](
    ID INT PRIMARY KEY,
    Username NVARCHAR(MAX),
    Password NVARCHAR(60) NOT NULL
);

CREATE TABLE Medication(
    ID INT PRIMARY KEY,
    Name NVARCHAR(MAX) NOT NULL,
    Description NVARCHAR(MAX),
    Dosage NVARCHAR(MAX),
    Directions NVARCHAR(MAX),
    Count INT NOT NULL CHECK (Count>=1) DEFAULT 1
);

CREATE TABLE Prescription(
    ID INT PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES [User](ID) NOT NULL,
    MedicationID INT FOREIGN KEY REFERENCES Medication(ID) NOT NULL
);

CREATE TABLE Reminder(
    ID INT PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES [User](ID) NOT NULL,
    PrescriptionID INT FOREIGN KEY REFERENCES Prescription(ID) NOT NULL,
    Alert TIME NOT NULL
);