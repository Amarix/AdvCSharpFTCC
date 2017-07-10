CREATE TABLE [Employee]
(
	[employee ID] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NOT NULL, 
    [address] NVARCHAR(50) NOT NULL, 
    [phone number] NVARCHAR(50) NOT NULL, 
    [position level] NCHAR(10) NOT NULL, 
    [pay rate] MONEY NOT NULL
)
