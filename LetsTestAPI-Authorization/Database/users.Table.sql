﻿CREATE TABLE [users].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Login] NVARCHAR(50) NOT NULL, 
    [IsActive] BIT NOT NULL DEFAULT 1
)
