CREATE TABLE [dbo].[Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TaskName] NVARCHAR(50) NOT NULL, 
    [Monday] BIT NOT NULL, 
    [Tuesday] BIT NOT NULL, 
    [Wednesday] BIT NOT NULL, 
    [Thursday] BIT NOT NULL, 
    [Friday] BIT NOT NULL, 
    [Saturday] BIT NOT NULL, 
    [Sunday] BIT NOT NULL
)
