CREATE TABLE [dbo].[Malfunction]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Priority] NVARCHAR(50) NULL, 
    [StartTime] DATETIME NULL, 
    [EndTime] DATETIME NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [Status] NVARCHAR(50) NULL, 
    [MachineId] INT NULL
    FOREIGN KEY(MachineId) REFERENCES Machine(Id)
)
