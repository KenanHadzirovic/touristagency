USE TouristAgency;

IF OBJECT_ID('tempdb..#tempUserAccount') is not null	
	DROP TABLE #tempUserAccount;

CREATE TABLE #tempUserAccount (
    [UserAccountId]   INT NOT NULL,
    [Username] NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (300) NOT NULL
);

INSERT INTO #tempUserAccount VALUES
(2, 'johndoe', 'password'),
(3, 'janedoe', 'password'),
(4, 'kevinsmith', 'password'),
(5, 'wayneadams', 'password');

SET IDENTITY_INSERT dbo.UserAccount ON; 

MERGE UserAccount AS TARGET
USING #tempUserAccount AS SOURCE 
ON (TARGET.UserAccountId = SOURCE.UserAccountId) 
WHEN NOT MATCHED BY TARGET 
THEN INSERT (UserAccountId, Username, Password) VALUES (SOURCE.UserAccountId, SOURCE.Username, SOURCE.Password);

SET IDENTITY_INSERT dbo.UserAccount OFF; 

DROP TABLE #tempUserAccount