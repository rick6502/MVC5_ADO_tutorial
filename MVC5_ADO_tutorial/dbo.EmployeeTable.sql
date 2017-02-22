CREATE TABLE [dbo].[Employee]
(
	[Id] INT  IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [FName] VARCHAR(50) NULL, 
    [MName] VARCHAR(50) NULL, 
    [LName] VARCHAR(50) NULL, 
    [EmailID] VARCHAR(50) NULL
)
