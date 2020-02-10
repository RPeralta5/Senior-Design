CREATE TABLE ApplicantInformation
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [InsurerRole] VARCHAR(50) NULL, 
    [NameInsured] VARCHAR(MAX) NULL, 
    [Dba] VARCHAR(MAX) NULL, 
    [MailingAddress] VARCHAR(50) NULL, 
    [City] VARCHAR(50) NULL, 
    [State] VARCHAR(50) NULL, 
    [Zipcode] VARCHAR(50) NULL, 
    [ContactPerson] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [HomeNumber] VARCHAR(50) NULL, 
    [BusinessNumber] VARCHAR(50) NULL, 
    [Fax] VARCHAR(50) NULL, 
    [Website] VARCHAR(50) NULL
)
