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


INSERT INTO SoftwareLicenses (Name, Manufacturer, LicenseKey, ExpiryDate)
VALUES
(N'Windows 11 Pro', N'Microsoft', N'WIN11-PRO-XXXXX-AAAAA', '2027-12-31'),
(N'Microsoft Office 2021', N'Microsoft', N'OFF21-XXXXX-BBBBB', '2026-06-30'),
(N'Kaspersky Endpoint Security', N'Kaspersky', N'KASP-SEC-XXXXX-CCCCC', '2025-09-15'),
(N'Visual Studio 2022 Professional', N'Microsoft', N'VS22-PRO-XXXXX-DDDDD', '2028-01-01');


INSERT INTO InstalledSoftwares (EquipmentId, SoftwareLicenseId, InstallDate)
VALUES (1, 1, '2024-01-15');
INSERT INTO InstalledSoftwares (EquipmentId, SoftwareLicenseId, InstallDate)
VALUES (1, 2, '2024-01-16');
INSERT INTO InstalledSoftwares (EquipmentId, SoftwareLicenseId, InstallDate)
VALUES (1, 3, '2024-01-17');
INSERT INTO InstalledSoftwares (EquipmentId, SoftwareLicenseId, InstallDate)
VALUES (2, 1, '2024-02-10');
INSERT INTO InstalledSoftwares (EquipmentId, SoftwareLicenseId, InstallDate)
VALUES (2, 2, '2024-02-11');

