CREATE TABLE [dbo].[Products](
	[Id] [int] Primary Key,
	[Name] [text] 
) 
GO

CREATE TABLE [dbo].[Categories](
	[Id] [int] Primary Key,
	[Name] [text] 
) 
GO

CREATE TABLE [dbo].[ProductCategories](
	[ProductId] [int] Foreign Key References Products(Id),
	[CategoryId] [int] Foreign Key References Categories(Id),
	Primary Key (ProductId,CategoryId)
) 
GO


INSERT INTO [dbo].[Products]
           ([Id]
           ,[Name])
     VALUES
           (1, 'Stels'),
		   (2, 'Harry Potter'),
		   (3, 'BMW')
GO

INSERT INTO [dbo].[Categories]
           ([Id]
           ,[Name])
     VALUES
           (1, 'Bike'),
		   (2, 'Book'),
		   (3, 'Car')

		  
GO
INSERT INTO [dbo].[ProductCategories]
           ([ProductId]
           ,[CategoryId])
     VALUES
           (1, 1),
           (2, 2)
		  
GO

SELECT 
       [P].[Name]
      ,[C].[Name]
  FROM  [dbo].[Products] AS [P]
  LEFT JOIN [dbo].ProductCategories AS [PC]
  ON [P].Id = [PC].ProductId
  LEFT JOIN [dbo].Categories AS[C]
  ON [PC].CategoryId = [C].Id
