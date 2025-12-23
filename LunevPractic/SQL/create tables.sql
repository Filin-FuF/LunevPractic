CREATE TABLE Departments (
    Id           INT IDENTITY(1,1) PRIMARY KEY,
    Name         NVARCHAR(100) NOT NULL
);

CREATE TABLE Employees (
    Id           INT IDENTITY(1,1) PRIMARY KEY,
    Name         NVARCHAR(100) NOT NULL,
    DepartmentId INT NOT NULL
);

CREATE TABLE EquipmentTypes (
    Id           INT IDENTITY(1,1) PRIMARY KEY,
    Name         NVARCHAR(100) NOT NULL
);

CREATE TABLE Equipments (
    Id              INT IDENTITY(1,1) PRIMARY KEY,
    InventoryNumber NVARCHAR(50)  NOT NULL UNIQUE,
    Name            NVARCHAR(100) NOT NULL,
    EquipmentTypeId INT           NOT NULL,
    SerialNumber    NVARCHAR(100) NOT NULL,
    EmployeeId      INT           NULL,
    RegistrationDate DATE         NOT NULL,
    Status          NVARCHAR(20)  NOT NULL
);

CREATE TABLE SoftwareLicenses (
    Id           INT IDENTITY(1,1) PRIMARY KEY,
    Name         NVARCHAR(100) NOT NULL,
    Manufacturer NVARCHAR(100) NOT NULL,
    LicenseKey   NVARCHAR(100) NOT NULL,
    ExpiryDate   DATE          NOT NULL
);

CREATE TABLE InstalledSoftware (
    EquipmentId       INT NOT NULL,
    SoftwareLicenseId INT NOT NULL,
    InstallDate       DATE NOT NULL,
    CONSTRAINT PK_InstalledSoftware PRIMARY KEY (EquipmentId, SoftwareLicenseId)
);

CREATE TABLE EquipmentMoveHistories (
    Id            INT IDENTITY(1,1) PRIMARY KEY,
    EquipmentId   INT        NOT NULL,
    MoveDate      DATETIME   NOT NULL,
    OldEmployeeId INT        NULL,
    NewEmployeeId INT        NULL
);
