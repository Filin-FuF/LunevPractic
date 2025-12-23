ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_Departments
    FOREIGN KEY (DepartmentId) REFERENCES Departments(Id);

ALTER TABLE Equipments
ADD CONSTRAINT FK_Equipments_EquipmentTypes
    FOREIGN KEY (EquipmentTypeId) REFERENCES EquipmentTypes(Id),
    CONSTRAINT FK_Equipments_Employees
    FOREIGN KEY (EmployeeId) REFERENCES Employees(Id);

ALTER TABLE InstalledSoftware
ADD CONSTRAINT FK_InstalledSoftware_Equipments
    FOREIGN KEY (EquipmentId) REFERENCES Equipments(Id),
    CONSTRAINT FK_InstalledSoftware_SoftwareLicenses
    FOREIGN KEY (SoftwareLicenseId) REFERENCES SoftwareLicenses(Id);

ALTER TABLE EquipmentMoveHistories
ADD CONSTRAINT FK_Move_Equipment
    FOREIGN KEY (EquipmentId) REFERENCES Equipments(Id),
    CONSTRAINT FK_Move_OldEmployee
    FOREIGN KEY (OldEmployeeId) REFERENCES Employees(Id),
    CONSTRAINT FK_Move_NewEmployee
    FOREIGN KEY (NewEmployeeId) REFERENCES Employees(Id);
