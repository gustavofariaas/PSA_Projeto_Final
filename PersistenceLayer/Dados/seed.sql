use TodoDB

SET IDENTITY_INSERT [dbo].[Categorias] ON
INSERT INTO [dbo].[Categorias] ([CategoriaId], [CategoriaNome]) VALUES (1, 'Console')
INSERT INTO [dbo].[Categorias] ([CategoriaId], [CategoriaNome]) VALUES (2, 'Eletrodomestico')
INSERT INTO [dbo].[Categorias] ([CategoriaId], [CategoriaNome]) VALUES (3, 'Eletronico')
SET IDENTITY_INSERT [dbo].[Categorias] OFF


SET IDENTITY_INSERT [dbo].[Status] ON
INSERT INTO [dbo].[Status] ([StatusId], [StatusNome]) VALUES (1, 'Anunciado')
INSERT INTO [dbo].[Status] ([StatusId], [StatusNome]) VALUES (2, 'Vendido')
SET IDENTITY_INSERT [dbo].[Status] OFF

SET IDENTITY_INSERT [dbo].[Produtos] ON
INSERT INTO [dbo].[Produtos] ([ProdutoId], [ProdutoNome], [Descricao], [Preco], [Local], [CategoriaID]) VALUES (1, 'Playstation 4','é um videogame',1000.00,'Porto Alegre',1)
INSERT INTO [dbo].[Produtos] ([ProdutoId], [ProdutoNome], [Descricao], [Preco], [Local], [CategoriaID]) VALUES (2, 'Micro-ondas Brastemp','é um micro-ondas usado',1000.00,'Porto Alegre',2)
INSERT INTO [dbo].[Produtos] ([ProdutoId], [ProdutoNome], [Descricao], [Preco], [Local], [CategoriaID]) VALUES (3, 'TV Sony 4k','39 polegadas',1000.00,'Porto Alegre',3)
SET IDENTITY_INSERT [dbo].[Produtos] OFF

SET IDENTITY_INSERT [dbo].[Vendas] ON
INSERT INTO [dbo].[Vendas] ([VendaID], [DescricaoVenda], [ProdutoID], [StatusID],[isSold]) VALUES (1, 'Vendo Playstation 4', 1, 1, 0)
INSERT INTO [dbo].[Vendas] ([VendaID], [DescricaoVenda], [ProdutoID], [StatusID],[isSold]) VALUES (2, 'Vendo Micro-ondas Brastemp', 2, 1, 0)
INSERT INTO [dbo].[Vendas] ([VendaID], [DescricaoVenda], [ProdutoID], [StatusID],[isSold]) VALUES (3, 'Vendo TV Sony 4k', 3, 1, 0)
SET IDENTITY_INSERT [dbo].[Vendas] OFF



