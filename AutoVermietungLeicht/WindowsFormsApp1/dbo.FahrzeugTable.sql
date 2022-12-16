CREATE TABLE [dbo].[Fahrzeug]
(
	[fNummer] INT NOT NULL PRIMARY KEY, 
    [bezeichnung] NVARCHAR(50) NOT NULL, 
    [kennzeichen] NVARCHAR(12) NOT NULL, 
    [preisProTag] FLOAT NOT NULL, 
    [typ] NCHAR(3) NOT NULL, 
    [ausgeliehen] BIT NOT NULL DEFAULT 0
)
