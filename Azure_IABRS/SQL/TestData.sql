USE [testsForNAD]
GO

INSERT INTO [dbo].[Institution]
           ([name] ,[Domain])
     VALUES
           ('Conestoga','conestogac.on.ca'),
		   ('U Waterloo','uwaterloo.ca'),
		   ('U Guelph', 'uoguelph.ca')
GO




USE [testsForNAD]
GO

INSERT INTO [dbo].[Book]
           ([Title])
     VALUES
           ('Code Complete 2nd Edition'),
		   ('murachs C# 2010'),
		   ('murachs HTML/CSS'),
		   ('murachs MySQL'),
		   ('murachs Servlets and JSP'),
		   ('A Book on C'),
		   ('Professional ASP.NET MVC 4')
GO


USE [testsForNAD]
GO

INSERT INTO [dbo].[Course]
           ([Name],[Code],[StartDate]
           ,[EndDate]
           ,[InstitutionId])
     VALUES
           ('Software Dev Fund','INFO-1823','2019-9-4','2020-4-20',1),
		    ('Digial Fund','INFO-1623','2019-9-4','2020-4-20',1),
			 ('C Programming','PROG-1843','2019-9-4','2020-4-20',1),
			  ('System Programming','PROG-1423','2019-9-4','2020-4-20',1),
			   ('Data Structures','PROG-1853','2019-9-5','2020-4-15',2),
			   ('Networking','INFO-1983','2019-9-5','2020-4-15',2),
			   ('Basket Weaving','LIB-1003','2019-9-4','2020-4-19',3),
			   ('Calculus','MATH-1003','2019-9-4','2020-4-19',3)
GO




USE [testsForNAD]
GO

INSERT INTO [dbo].[Permission]
           ([Name]
           ,[Value])
     VALUES
           ('PostBook',1),
		   ('RemoveAnyPost',2),
		   ('SearchBooks',3),
		   ('SetAsOfficialBook',4),
		   ('BuyBook',5),
		   ('SellBook',6),
		   ('AddInstitution',7),
		   ('AddSysAdmin',8),
		   ('RemoveOwnPost',9),
		   ('RemoveInstitutionPost',10),
		   ('RemoveAdmin',11),
		   ('RemoveInstitution',12),
		   ('RemoveUser',13)
GO

USE [testsForNAD]
GO

INSERT INTO [dbo].[Group]
           ([Name])
     VALUES
           ('SysAdmin'), ('InstituteAdmin'), ('User'), ('InstituteUser')
GO
USE [testsForNAD]
GO
INSERT INTO [dbo].[GroupPermission]
           ([GroupId]
           ,[PermissionId])
     VALUES
	 --sysAdmin
           (1 , 2),(1 , 3),(1 , 7),(1 , 8), (1 , 11),(1 , 12),(1 , 13),
	--InstituteAdmin
		   (2, 3),(2, 4),(2, 10),(2, 13),
	--User
		   (3, 1),(3, 3),(3, 5),(3, 6),(3, 9),
	--InstituteUser
		   (4, 1),(4, 3),(4, 4),(4, 6),(4, 9) 
GO



