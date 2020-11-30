use TodoDB

SET IDENTITY_INSERT [dbo].[Produto] ON
INSERT INTO [dbo].[Produto] ([ProdutoId], [Nome], [Description], [Preco], [Local], [CategoriaID]) VALUES (1, 'Playstation 4','é um videogame',1000.00,'Porto Alegre',1)
INSERT INTO [dbo].[Produto] ([ProdutoId], [Nome], [Description], [Preco], [Local], [CategoriaID]) VALUES (2, 'Xbox One','é um videogame',1000.00,'Porto Alegre',1)
INSERT INTO [dbo].[Produto] ([ProdutoId], [Nome], [Description], [Preco], [Local], [CategoriaID]) VALUES (3, 'Nintendo Switch','é um videogame',1000.00,'Porto Alegre',1)
SET IDENTITY_INSERT [dbo].[Produto] OFF

SET IDENTITY_INSERT [dbo].[Venda] ON
INSERT INTO [dbo].[Venda] ([VendaID], [DiasAposPost], [Status], [ProdutoID]) VALUES (1, 10, 'Anuncionado', 1)
INSERT INTO [dbo].[Venda] ([VendaID], [DiasAposPost], [Status], [ProdutoID]) VALUES (2, 20, 'Anuncionado', 2)
INSERT INTO [dbo].[Venda] ([VendaID], [DiasAposPost], [Status], [ProdutoID]) VALUES (3, 30, 'Anuncionado', 3)
SET IDENTITY_INSERT [dbo].[Venda] OFF


SET IDENTITY_INSERT [dbo].[Categoria] ON
INSERT INTO [dbo].[Categoria] ([CategoriaId], [Nome]) VALUES (1, 'Console')
SET IDENTITY_INSERT [dbo].[Categoria] OFF


SET IDENTITY_INSERT [dbo].[Status] ON
INSERT INTO [dbo].[Status] ([StatusId], [StatusNome]) VALUES (1, 'Anunciado')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
