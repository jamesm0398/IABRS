
DELETE FROM [dbo].[Institution] WHERE Id > 3
SET IDENTITY_INSERT [dbo].[Institution] ON
INSERT INTO [dbo].[Institution] ([Id], [name], [Domain]) VALUES (1, N'Conestoga', N'conestogac.on.ca')
INSERT INTO [dbo].[Institution] ([Id], [name], [Domain]) VALUES (2, N'U Waterloo', N'uwaterloo.ca')
INSERT INTO [dbo].[Institution] ([Id], [name], [Domain]) VALUES (3, N'U Guelph', N'uoguelph.ca')

SET IDENTITY_INSERT [dbo].[Institution] OFF

SELECT * FROM [dbo].[Institution] 

SELECT * FROM [dbo].[AspNetUsers] 