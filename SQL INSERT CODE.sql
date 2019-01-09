﻿SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [ImgUrl], [Date]) VALUES (0, 'Products are sourced from where they grow', 'S o u r c e', 'Our expert of the innovation team tells you about it. Donec ullamcorper nulla non metus auctor fringilla. Sed Posuere Consectetur est at lobortis. Maecenas faucibus mollis interdum. Sed posuere consectetur est at lobortis.', 'We travel around the world to find inspiration for our products' , 'J. ter Heijde (Innovation team Verstegen)', 'Integer posuere erat a ante venenatis daplibus', 'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting.', 'images/Stories/field-worker.jpg', GETDATE())
SET IDENTITY_INSERT [dbo].[Blogs] OFF

SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [ImgUrl], [Date]) VALUES (1, 'We process everything in our own factory', ' ', 'Our expert of the innovation team tells you about it. Donec ullamcorper nulla non metus auctor fringilla. Sed Posuere Consectetur est at lobortis. Maecenas faucibus mollis interdum. Sed posuere consectetur est at lobortis.', 'We travel around the world to find inspiration for our products' , 'J. ter Heijde (Innovation team Verstegen)', 'Integer posuere erat a ante venenatis daplibus', 'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting.', 'images/Stories/lab-worker.jpg', GETDATE())
SET IDENTITY_INSERT [dbo].[Blogs] OFF

SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [ImgUrl], [Date]) VALUES (2, 'Standard and custom made products', 'C u s t o m  v s  s t a n d a r d', 'Our expert of the innovation team tells you about it. Donec ullamcorper nulla non metus auctor fringilla. Sed Posuere Consectetur est at lobortis. Maecenas faucibus mollis interdum. Sed posuere consectetur est at lobortis.', 'We travel around the world to find inspiration for our products' , 'J. ter Heijde (Innovation team Verstegen)', 'Integer posuere erat a ante venenatis daplibus', 'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting.','images/Stories/chef-worker.jpg', GETDATE())
SET IDENTITY_INSERT [dbo].[Blogs] OFF

SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [ImgUrl], [Date]) VALUES (3, 'The product is important, but partnership is everything', ' ', 'Our expert of the innovation team tells you about it. Donec ullamcorper nulla non metus auctor fringilla. Sed Posuere Consectetur est at lobortis. Maecenas faucibus mollis interdum. Sed posuere consectetur est at lobortis.', 'We travel around the world to find inspiration for our products' , 'J. ter Heijde (Innovation team Verstegen)', 'Integer posuere erat a ante venenatis daplibus', 'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting.', 'images/Stories/hand-seasoning.jpg', GETDATE())
SET IDENTITY_INSERT [dbo].[Blogs] OFF

SET IDENTITY_INSERT [dbo].[Contacts] ON
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country] ,[Province], [Tel], [Email], [ImgUrl]) VALUES (0, 'Jan den Heijer', 'Director of Sales & Marketing Food Industry', 'The Netherland', 'Zuid-Holland', '+31(0)622571514', 'hhensen@verstegen.nl', '/images/icons/persoon_img.svg')
SET IDENTITY_INSERT [dbo].[Contacts] OFF

SET IDENTITY_INSERT [dbo].[Contacts] ON
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country] ,[Province], [Tel], [Email], [ImgUrl]) VALUES (1, 'Gerrit de Jong', 'Director of Sales & Marketing Food Industry', 'The Netherland' , 'Zuid-Holland', '+31(0)532534344', 'gdjong@verstegen.nl', '/images/icons/persoon_img.svg')
SET IDENTITY_INSERT [dbo].[Contacts] OFF

SET IDENTITY_INSERT [dbo].[Categorys] ON
INSERT INTO [dbo].[Categorys] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (0, 'How we Work', 'hww')
SET IDENTITY_INSERT [dbo].[Categorys] OFF

SET IDENTITY_INSERT [dbo].[BlogCategorys] ON
INSERT INTO [dbo].[BlogCategorys] ([BlogCategoryId], [BlogId], [CategoryId]) VALUES (0, 0, 0)
SET IDENTITY_INSERT [dbo].[BlogCategorys] OFF

SET IDENTITY_INSERT [dbo].[BlogCategorys] ON
INSERT INTO [dbo].[BlogCategorys] ([BlogCategoryId], [BlogId], [CategoryId]) VALUES (1, 1, 0)
SET IDENTITY_INSERT [dbo].[BlogCategorys] OFF

SET IDENTITY_INSERT [dbo].[BlogCategorys] ON
INSERT INTO [dbo].[BlogCategorys] ([BlogCategoryId], [BlogId], [CategoryId]) VALUES (2, 2, 0)
SET IDENTITY_INSERT [dbo].[BlogCategorys] OFF

SET IDENTITY_INSERT [dbo].[BlogCategorys] ON
INSERT INTO [dbo].[BlogCategorys] ([BlogCategoryId], [BlogId], [CategoryId]) VALUES (3, 3, 0)
SET IDENTITY_INSERT [dbo].[BlogCategorys] OFF

SET IDENTITY_INSERT [dbo].[Recipes] ON
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration]) VALUES (1, N'Sausage', N'Meat', N'For 5 sausages', N'sausages.jpg', N'nog doen', N'nog doen')
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration]) VALUES (2, N'Burger', N'Meat', N'For 4 burgers', N'burger.jpg', N'Maal de rundersnippers één maal door de 3 mm plaat._Meng het gehakt met World Spice Blend Mediterranean, water en Binding Vero Pure tot voldoende binding.', N'Parmazaan vlokken_Verse Tijm')
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration]) VALUES (3, N'Salmon', N'Fish', N'For 5 plates', N'salmon.jpg', N'nog doen', N'nog doen')
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration]) VALUES (4, N'Oatmeal with fruits', N'Vega', N'For 2 bowls', N'oatmeal-fruits.jpg', N'nog doen', N'nog doen')
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration]) VALUES (5, N'Pancakes', N'Vega', N'For 10 pancakes', N'pancakes.jpg', N'nog doen', N'nog doen')
SET IDENTITY_INSERT [dbo].[Recipes] OFF


SET IDENTITY_INSERT [dbo].[Ingredients] ON
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (1, N'Rundersnippers 85/15', NULL, 860, 68.8, 2)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (2, N'Water', NULL, 60, 20, 2)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (3, N'Snijbare Champignonsaus', NULL, 250, 20, 2)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (4, N'World Spice Blend Mediterranean', NULL, 40, 3.2, 2)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (5, N'Binding Vero Pure', NULL, 40, 3.2, 2)
SET IDENTITY_INSERT [dbo].[Ingredients] OFF









