CREATE TABLE [dbo].[Table]
(
	[CarId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] NCHAR(10) NULL, 
    [DailyPrice] DECIMAL NULL, 
    [Description] NCHAR(50) NULL
)
