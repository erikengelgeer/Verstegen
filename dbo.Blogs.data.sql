SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subtitle], [Text], [ImgUrl], [Date]) VALUES (0, 'Products are sourced from where they grow', 'S o u r c e', 'Our expert of the innovation team tells you about it. Donec ullamcorper nulla non metus auctor fringilla. Sed Posuere Consectetur est at lobortis. Maecenas faucibus mollis interdum. Sed posuere consectetur est at lobortis.', 'images/Stories/field-worker.jpg', GETDATE())
SET IDENTITY_INSERT [dbo].[Blogs] OFF

SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subtitle], [Text], [ImgUrl], [Date]) VALUES (1, 'We process everything in our own factory', ' ', 'Our expert of the innovation team tells you about it. Donec ullamcorper nulla non metus auctor fringilla. Sed Posuere Consectetur est at lobortis. Maecenas faucibus mollis interdum. Sed posuere consectetur est at lobortis.', 'images/Stories/lab-worker.jpg', GETDATE())
SET IDENTITY_INSERT [dbo].[Blogs] OFF

SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subtitle], [Text], [ImgUrl], [Date]) VALUES (2, 'Standard and custom made products', 'C u s t o m  v s  s t a n d a r d', 'Our expert of the innovation team tells you about it. Donec ullamcorper nulla non metus auctor fringilla. Sed Posuere Consectetur est at lobortis. Maecenas faucibus mollis interdum. Sed posuere consectetur est at lobortis.', 'images/Stories/chef-worker.jpg', GETDATE())
SET IDENTITY_INSERT [dbo].[Blogs] OFF

SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subtitle], [Text], [ImgUrl], [Date]) VALUES (3, 'The product is important, but partnership is everything', ' ', 'Our expert of the innovation team tells you about it. Donec ullamcorper nulla non metus auctor fringilla. Sed Posuere Consectetur est at lobortis. Maecenas faucibus mollis interdum. Sed posuere consectetur est at lobortis.', 'images/Stories/hand-seasoning.jpg', GETDATE())
SET IDENTITY_INSERT [dbo].[Blogs] OFF

SET IDENTITY_INSERT [dbo].[Contacts] ON
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country] ,[Province], [Tel], [Email], [ImgUrl]) VALUES (0, 'Jan den Heijer', 'Director of Sales & Marketing Food Industry', 'The Netherland', 'Zuid-Holland', '+31(0)622571514', 'hhensen@verstegen.nl', '/images/icons/persoon_img.svg')
SET IDENTITY_INSERT [dbo].[Contacts] OFF

SET IDENTITY_INSERT [dbo].[Contacts] ON
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country] ,[Province], [Tel], [Email], [ImgUrl]) VALUES (1, 'Gerrit de Jong', 'Director of Sales & Marketing Food Industry', 'The Netherland' , 'Zuid-Holland', '+31(0)532534344', 'gdjong@verstegen.nl', '/images/icons/persoon_img.svg')
SET IDENTITY_INSERT [dbo].[Contacts] OFF







