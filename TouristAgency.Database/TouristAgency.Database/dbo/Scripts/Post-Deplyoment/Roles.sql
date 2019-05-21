USE TouristAgency;

IF OBJECT_ID('tempdb..#tempRole') is not null	
	DROP TABLE #tempUserAccount;

CREATE TABLE #tempRole (
    [RoleId]   INT NOT NULL,
    [RoleName] NVARCHAR (50) NOT NULL,
);


INSERT INTO #tempRole VALUES
(1, 'Administrator'),
(2, 'Manager'),
(3, 'Agent');

SET IDENTITY_INSERT dbo.Role ON; 

MERGE Role AS TARGET
USING #tempRole AS SOURCE 
ON (TARGET.RoleId = SOURCE.RoleId) 
WHEN NOT MATCHED BY TARGET 
THEN INSERT (RoleId, [RoleName]) 
VALUES (SOURCE.RoleId, SOURCE.[RoleName]);

SET IDENTITY_INSERT dbo.Role OFF; 

DROP TABLE #tempRole;