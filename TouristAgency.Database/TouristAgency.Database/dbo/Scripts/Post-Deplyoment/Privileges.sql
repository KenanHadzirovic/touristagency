USE TouristAgency;

IF OBJECT_ID('tempdb..#tempPrivilege') is not null	
	DROP TABLE #tempUserAccount;

CREATE TABLE #tempPrivilege (
    [PrivilegeId] INT NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Description] TEXT NULL,
);


INSERT INTO #tempPrivilege VALUES
(1, 'Can Create User','Users with this privilege can create new users.'),
(2, 'Can Create Role', 'Users with this privilege can create new roles.'),
(3, 'Can Add Tour','Users with this privilege can add new Tours');

SET IDENTITY_INSERT dbo.Privilege ON; 

MERGE Privilege AS TARGET
USING #tempPrivilege AS SOURCE 
ON (TARGET.PrivilegeId = SOURCE.[PrivilegeId]) 
WHEN NOT MATCHED BY TARGET 
THEN INSERT ([PrivilegeId], [Name], [Description]) 
VALUES (SOURCE.[PrivilegeId], SOURCE.[Name], SOURCE.[Description]);

SET IDENTITY_INSERT dbo.Employee OFF; 

DROP TABLE #tempPrivilege;