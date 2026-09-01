-- Create the database
CREATE DATABASE GeographyDB;
USE GeographyDB;

-- Table for Continents
CREATE TABLE Continents (
    ContinentID INT PRIMARY KEY AUTO_INCREMENT,
    ContinentName VARCHAR(50) NOT NULL UNIQUE
);

-- Table for Countries
CREATE TABLE Countries (
    CountryID INT PRIMARY KEY AUTO_INCREMENT,
    CountryName VARCHAR(100) NOT NULL UNIQUE,
    Capital VARCHAR(100),
    Population BIGINT,
    Area DECIMAL(10,2), -- Area in square kilometers
    ContinentID INT,
    FOREIGN KEY (ContinentID) REFERENCES Continents(ContinentID)
);

-- Table for Cities
CREATE TABLE Cities (
    CityID INT PRIMARY KEY AUTO_INCREMENT,
    CityName VARCHAR(100) NOT NULL,
    Population BIGINT,
    CountryID INT,
    IsCapital BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

-- Table for Regions (e.g., states, provinces)
CREATE TABLE Regions (
    RegionID INT PRIMARY KEY AUTO_INCREMENT,
    RegionName VARCHAR(100) NOT NULL,
    CountryID INT,
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

-- Table for Rivers
CREATE TABLE Rivers (
    RiverID INT PRIMARY KEY AUTO_INCREMENT,
    RiverName VARCHAR(100) NOT NULL UNIQUE,
    Length DECIMAL(10,2), -- Length in kilometers
    Source VARCHAR(100),
    Mouth VARCHAR(100)
);

-- Table for Mountains
CREATE TABLE Mountains (
    MountainID INT PRIMARY KEY AUTO_INCREMENT,
    MountainName VARCHAR(100) NOT NULL UNIQUE,
    Height DECIMAL(10,2), -- Height in meters
    Location VARCHAR(100)
);

-- Table for Lakes
CREATE TABLE Lakes (
    LakeID INT PRIMARY KEY AUTO_INCREMENT,
    LakeName VARCHAR(100) NOT NULL UNIQUE,
    SurfaceArea DECIMAL(10,2), -- Area in square kilometers
    Depth DECIMAL(10,2), -- Maximum depth in meters
    CountryID INT,
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

-- Table for Borders (Country-to-Country relationships)
CREATE TABLE CountryBorders (
    BorderID INT PRIMARY KEY AUTO_INCREMENT,
    Country1ID INT,
    Country2ID INT,
    BorderLength DECIMAL(10,2), -- Length in kilometers
    FOREIGN KEY (Country1ID) REFERENCES Countries(CountryID),
    FOREIGN KEY (Country2ID) REFERENCES Countries(CountryID),
    CONSTRAINT unique_border UNIQUE (Country1ID, Country2ID)
);

-- Table for Oceans
CREATE TABLE Oceans (
    OceanID INT PRIMARY KEY AUTO_INCREMENT,
    OceanName VARCHAR(100) NOT NULL UNIQUE,
    Area DECIMAL(15,2) -- Area in square kilometers
);

-- Table for Seas
CREATE TABLE Seas (
    SeaID INT PRIMARY KEY AUTO_INCREMENT,
    SeaName VARCHAR(100) NOT NULL UNIQUE,
    Area DECIMAL(15,2),
    OceanID INT,
    FOREIGN KEY (OceanID) REFERENCES Oceans(OceanID)
);
