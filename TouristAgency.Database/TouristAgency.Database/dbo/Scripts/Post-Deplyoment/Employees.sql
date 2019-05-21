USE TouristAgency;

IF OBJECT_ID('tempdb..#tempEmployee') is not null	
	DROP TABLE #tempUserAccount;

CREATE TABLE #tempEmployee (
    [EmployeeId]  INT NOT NULL,
    [FirstName]   NVARCHAR (50)  NOT NULL,
    [LastName]    NVARCHAR (50)  NOT NULL,
    [DateOfBirth] DATETIME       NOT NULL,
    [Address]     NVARCHAR (100) NOT NULL,
    [PhoneNumber] NVARCHAR (12)  NOT NULL,
    [UserId]      INT            NOT NULL
);

INSERT INTO #tempEmployee VALUES
(1, 'John', 'Doe', GETUTCDATE(), '123 Main St','000/111-111', 2),
(2, 'Jane', 'Doe', GETUTCDATE(), 'Second Street','000/222-222', 3),
(3, 'Kevin', 'Smith', GETUTCDATE(), 'Norton Haven','000/333-333', 4),
(4, 'Wayne', 'Adams', GETUTCDATE(), '11 Paris Avenue','000/444-444', 5);

SET IDENTITY_INSERT dbo.Employee ON; 

MERGE Employee AS TARGET
USING #tempEmployee AS SOURCE 
ON (TARGET.EmployeeId = SOURCE.EmployeeId) 
WHEN NOT MATCHED BY TARGET 
THEN INSERT (EmployeeId, FirstName, LastName, DateOfBirth, Address, PhoneNumber, UserId) 
VALUES (SOURCE.EmployeeId, SOURCE.FirstName, SOURCE.LastName, SOURCE.DateOfBirth, SOURCE.Address, SOURCE.PhoneNumber, SOURCE.UserId);

SET IDENTITY_INSERT dbo.Employee OFF; 

DROP TABLE #tempEmployee;