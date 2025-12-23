INSERT INTO Departments (Name) VALUES
(N'ИТ-отдел'),
(N'Бухгалтерия');

INSERT INTO Employees (Name, DepartmentId) VALUES
(N'Иванов И.И.', 1),
(N'Петров П.П.', 1),
(N'Сидорова С.С.', 2);

INSERT INTO EquipmentTypes (Name) VALUES
(N'Системный блок'),
(N'Ноутбук');

INSERT INTO Equipments (InventoryNumber, Name, EquipmentTypeId, SerialNumber, EmployeeId, RegistrationDate, Status) VALUES
(N'PC-0001', N'Системный блок №1', 1, N'SN123', 1, '2024-01-10', N'В работе'),
(N'NB-0001', N'Ноутбук №1',        2, N'SN456', 2, '2024-02-15', N'В работе');

INSERT INTO SoftwareLicenses (Name, Manufacturer, LicenseKey, ExpiryDate) VALUES
(N'Windows 11 Pro', N'Microsoft', N'XXXXX-XXXXX-XXXXX', '2026-12-31'),
(N'Office 2021',    N'Microsoft', N'OOOOO-OOOOO-OOOOO', '2025-06-30');

INSERT INTO InstalledSoftware (EquipmentId, SoftwareLicenseId, InstallDate) VALUES
(1, 1, '2024-01-11'),
(1, 2, '2024-01-12'),
(2, 2, '2024-02-16');
