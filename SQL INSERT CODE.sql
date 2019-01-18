﻿SET IDENTITY_INSERT [dbo].[Themes] ON
INSERT INTO [dbo].[Themes] ([ThemeId], [Name], [ImgUrl], [IconUrl]) VALUES (0, N'Easter 2018', N'easter.jpg', N'images/icons/easter-egg-icon.svg')
INSERT INTO [dbo].[Themes] ([ThemeId], [Name], [ImgUrl], [IconUrl]) VALUES (1, N'Summer 2018', N'bbq.jpg', N'images/icons/bbq-icon.svg')
INSERT INTO [dbo].[Themes] ([ThemeId], [Name], [ImgUrl], [IconUrl]) VALUES (2, N'Christmas 2018', N'christmas-2018.jpg', N'images/icons/christmas-snowflake-icon.svg')
INSERT INTO [dbo].[Themes] ([ThemeId], [Name], [ImgUrl], [IconUrl]) VALUES (3, N'Feast!', N'feast.jpg', N'images/icons/chicken-icon.svg')
INSERT INTO [dbo].[Themes] ([ThemeId], [Name], [ImgUrl], [IconUrl]) VALUES (4, N'Cocktails', N'cocktails.jpg', N'images/icons/cocktail-glass-icon.svg')
INSERT INTO [dbo].[Themes] ([ThemeId], [Name], [ImgUrl], [IconUrl]) VALUES (5, N'Christmas', N'christmas.jpg', N'images/icons/globe-icon.svg')
SET IDENTITY_INSERT [dbo].[Themes] OFF

SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [Bullet], [ImgUrl], [Date], [ThemeId], [Type]) VALUES (0, N'Products are sourced from where they grow', N'S o u r c e', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                Aenean ultricies enim ac risus placerat, sed pretium justo dictum. Sed sed erat efficitur, efficitur quam eu, aliquet velit.
                Sed in erat id nisl tincidunt placerat quis in urna. Nam venenatis suscipit enim, id ultrices tellus egestas et.
                Fusce aliquet laoreet dui, vitae eleifend nisi vehicula non. Suspendisse nec facilisis risus, in feugiat ex.
                Donec a dignissim diam. Nullam vulputate tortor eu sem molestie venenatis. Morbi et ligula libero.', N'We travel around the world to find inspiration for our products', N'J. ter Heijde (Innovation team Verstegen)', N'Integer posuere erat a ante venenatis daplibus', N'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting.', N'', N'images/Stories/field-worker.jpg', N'2019-01-09 18:32:16', 0, N'hww')
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [Bullet], [ImgUrl], [Date], [ThemeId], [Type]) VALUES (1, N'We process everything in our own factory', N' ', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                Aenean ultricies enim ac risus placerat, sed pretium justo dictum. Sed sed erat efficitur, efficitur quam eu, aliquet velit.
                Sed in erat id nisl tincidunt placerat quis in urna. Nam venenatis suscipit enim, id ultrices tellus egestas et.
                Fusce aliquet laoreet dui, vitae eleifend nisi vehicula non. Suspendisse nec facilisis risus, in feugiat ex.
                Donec a dignissim diam. Nullam vulputate tortor eu sem molestie venenatis. Morbi et ligula libero.', N'We travel around the world to find inspiration for our products', N'J. ter Heijde (Innovation team Verstegen)', N'Integer posuere erat a ante venenatis daplibus', N'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting.', N'', N'images/Stories/lab-worker.jpg', N'2019-01-09 18:32:16', 0, N'hww')
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [Bullet], [ImgUrl], [Date], [ThemeId], [Type]) VALUES (2, N'Standard and custom made products', N'C u s t o m  v s  s t a n d a r d', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                Aenean ultricies enim ac risus placerat, sed pretium justo dictum. Sed sed erat efficitur, efficitur quam eu, aliquet velit.
                Sed in erat id nisl tincidunt placerat quis in urna. Nam venenatis suscipit enim, id ultrices tellus egestas et.
                Fusce aliquet laoreet dui, vitae eleifend nisi vehicula non. Suspendisse nec facilisis risus, in feugiat ex.
                Donec a dignissim diam. Nullam vulputate tortor eu sem molestie venenatis. Morbi et ligula libero.', N'We travel around the world to find inspiration for our products', N'J. ter Heijde (Innovation team Verstegen)', N'Integer posuere erat a ante venenatis daplibus', N'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting.', N'', N'images/Stories/chef-worker.jpg', N'2019-01-09 18:32:16', 0, N'hww')
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [Bullet], [ImgUrl], [Date], [ThemeId], [Type]) VALUES (3, N'The product is important, but partnership is everything', N' ', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                Aenean ultricies enim ac risus placerat, sed pretium justo dictum. Sed sed erat efficitur, efficitur quam eu, aliquet velit.
                Sed in erat id nisl tincidunt placerat quis in urna. Nam venenatis suscipit enim, id ultrices tellus egestas et.
                Fusce aliquet laoreet dui, vitae eleifend nisi vehicula non. Suspendisse nec facilisis risus, in feugiat ex.
                Donec a dignissim diam. Nullam vulputate tortor eu sem molestie venenatis. Morbi et ligula libero.', N'We travel around the world to find inspiration for our products', N'J. ter Heijde (Innovation team Verstegen)', N'Integer posuere erat a ante venenatis daplibus', N'Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting.', N'', N'images/Stories/hand-seasoning.jpg', N'2019-01-09 18:32:16', 0, N'hww')
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [Bullet], [ImgUrl], [Date], [ThemeId], [Type]) VALUES (5, N'Creative and surprising innovations', N'C o m p a n y p r o f i l e', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi non dignissim neque. Praesent tincidunt ullamcorper ultrices. Aenean sagittis mi ut tortor sollicitudin scelerisque. Sed vel porttitor dolor. Aenean tempus eros.', NULL, NULL, NULL, NULL, N'Family-owned business since 1886_We work with local farmers to produce the purest herbs and spices_We manage every step of the way ourselves, from transport to our in-house grinding and safe food processing', N'images/Stories/company-profile.jpg', N'2019-01-18 00:00:00', 0, N'aww')
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [Bullet], [ImgUrl], [Date], [ThemeId], [Type]) VALUES (6, N'Verstegen throwback: our old cars', N'Onze oude autos doen het nog steeds!', N'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using', N'The food sector is constantly developing, and so is Verstegen.
                    It is for this reason that Verstegen has been a major player since the company was founded in 1886.
                    That is over 130 years of anticipation, creation and inspiration and - above all - providing the best quality.
                    Based on partnership and trust, we work closely with our associates on new trends, demands and products, with consideration for today and tomorrow.', NULL, N'Our old cars', N'The food sector is constantly developing, and so is Verstegen.
                    It is for this reason that Verstegen has been a major player since the company was founded in 1886.
                    That is over 130 years of anticipation, creation and inspiration and - above all - providing the best quality.
                    Based on partnership and trust, we work closely with our associates on new trends, demands and products, with consideration for today and tomorrow.', NULL, N'images/Stories/old-car.jpg', N'2019-01-18 14:35:29', NULL, N'News')
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [Bullet], [ImgUrl], [Date], [ThemeId], [Type]) VALUES (7, N'"Bio marinades: hones & sustaininable"', N'Marinade is lekker!', N'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using', N'The food sector is constantly developing, and so is Verstegen.
                    It is for this reason that Verstegen has been a major player since the company was founded in 1886.
                    That is over 130 years of anticipation, creation and inspiration and - above all - providing the best quality.
                    Based on partnership and trust, we work closely with our associates on new trends, demands and products, with consideration for today and tomorrow.', NULL, N'Our old cars', N'The food sector is constantly developing, and so is Verstegen.
                    It is for this reason that Verstegen has been a major player since the company was founded in 1886.
                    That is over 130 years of anticipation, creation and inspiration and - above all - providing the best quality.
                    Based on partnership and trust, we work closely with our associates on new trends, demands and products, with consideration for today and tomorrow.', NULL, N'images/Stories/spareribs.jpg', N'2019-01-18 14:35:29', NULL, N'Story')
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [Bullet], [ImgUrl], [Date], [ThemeId], [Type]) VALUES (10, N'We love working on innovations, together', N'T e a m', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean ultricies enim ac risus placerat, sed pretium justo dictum. Sed sed erat efficitur, efficitur quam eu, aliquet velit. Sed in erat id nisl tincidunt placerat quis in urna. Nam venenatis suscipit enim, id ultrices tellus egestas et. Fusce aliquet laoreet dui, vitae eleifend nisi vehicula non. Suspendisse nec facilisis risus, in feugiat ex. Donec a dignissim diam. Nullam vulputate tortor eu sem molestie venenatis. Morbi et ligula libero.', NULL, NULL, NULL, NULL, NULL, N'images/Stories/office-team.jpg', N'2019-01-18 00:00:00', 0, N'aww')
INSERT INTO [dbo].[Blogs] ([BlogId], [Title], [Subject], [Text], [Quote], [QuoteFrom], [SubTitle], [SubText], [Bullet], [ImgUrl], [Date], [ThemeId], [Type]) VALUES (11, N'Sustainability', NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean ultricies enim ac risus placerat, sed pretium justo dictum. Sed sed erat efficitur, efficitur quam eu, aliquet velit. Sed in erat id nisl tincidunt placerat quis in urna. Nam venenatis suscipit enim, id ultrices tellus egestas et. Fusce aliquet laoreet dui, vitae eleifend nisi vehicula non. Suspendisse nec facilisis risus, in feugiat ex. Donec a dignissim diam. Nullam vulputate tortor eu sem molestie venenatis. Morbi et ligula libero.', NULL, NULL, NULL, NULL, NULL, N'images/Stories/field-worker.jpg', N'2019-01-18 00:00:00', 0, NULL)
SET IDENTITY_INSERT [dbo].[Blogs] OFF


SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (0, N'Potato, Vegetable, Fruit', N'pvf')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (1, N'Ready-made, Salads', N'rms')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (2, N'Meat, Fish, Vegetarian, Chicken', N'mfvc')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (3, N'Cheese, Meats, Delicasies', N'cmd')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (4, N'Dairy, Eggs', N'de')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (5, N'Bakery', N'bk')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (6, N'Cereal, Sandwich filling, Refreshment ', N'csr')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (7, N'Soda, Juices, Coffee, Tea', N'sjct')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (8, N'Beer, Liquor, Apperception', N'bla')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (9, N'Pasta, Rice, International', N'pri')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (10, N'Soups, Canned, Sauces, Additives', N'scsa')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (11, N'Candy, Cookies, Chips', N'ccc')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (12, N'Frozen food', N'ff')
INSERT INTO [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryValue]) VALUES (13, N'Conscious eating', N'ce')
SET IDENTITY_INSERT [dbo].[Categories] OFF

SET IDENTITY_INSERT [dbo].[Contacts] ON
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country], [Province], [Tel], [Email], [ImgUrl]) VALUES (1, N'Gerrit de Jong', N'Web Developer', N'The Netherland', N'Zuid-Holland', N'+31(0)532534344', N'gdjong@verstegen.nl', N'/images/icons/persoon_img.svg')
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country], [Province], [Tel], [Email], [ImgUrl]) VALUES (2, N'Tom van Velden', N'Director of Sales & Marketing Food Industry', N'The Netherland', N'Zuid-Holland', N'+31(0)532534344', N'gdjong@verstegen.nl', N'/images/icons/persoon_img.svg')
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country], [Province], [Tel], [Email], [ImgUrl]) VALUES (3, N'Jonathan de Greef', N'Director of Sales & Marketing Food Industry', N'The Netherland', N'Zuid-Holland', N'+31(0)532534344', N'gdjong@verstegen.nl', N'/images/icons/persoon_img.svg')
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country], [Province], [Tel], [Email], [ImgUrl]) VALUES (4, N'Joost de Niet', N'Director of Sales & Marketing Food Industry', N'The Netherland', N'Zuid-Holland', N'+31(0)532534344', N'gdjong@verstegen.nl', N'/images/icons/persoon_img.svg')
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country], [Province], [Tel], [Email], [ImgUrl]) VALUES (5, N'Thijs van Rheenen', N'Director of Sales & Marketing Food Industry', N'The Netherland', N'Zuid-Holland', N'+31(0)532534344', N'gdjong@verstegen.nl', N'/images/icons/persoon_img.svg')
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country], [Province], [Tel], [Email], [ImgUrl]) VALUES (6, N'Mustafa', N'Director of Sales & Marketing Food Industry', N'The Netherland', N'Zuid-Holland', N'+31(0)532534344', N'gdjong@verstegen.nl', N'/images/icons/persoon_img.svg')
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country], [Province], [Tel], [Email], [ImgUrl]) VALUES (7, N'Erik Engelgeer', N'Director of Sales & Marketing Food Industry', N'The Netherland', N'Zuid-Holland', N'+31(0)532534344', N'gdjong@verstegen.nl', N'/images/icons/persoon_img.svg')
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country], [Province], [Tel], [Email], [ImgUrl]) VALUES (8, N'Adeel Shanis', N'Director of Sales & Marketing Food Industry', N'The Netherland', N'Zuid-Holland', N'+31(0)532534344', N'gdjong@verstegen.nl', N'/images/icons/persoon_img.svg')
INSERT INTO [dbo].[Contacts] ([ContactId], [Name], [Function], [Country], [Province], [Tel], [Email], [ImgUrl]) VALUES (15, N'Papi', N'Veranderde functie', N'The Netherlands', N'The Netherlands', N'0655545343', N'pk@live.nl', N'/images/icons/persoon_img.svg')
SET IDENTITY_INSERT [dbo].[Contacts] OFF

SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([ProductId], [Title], [Type], [CategoryId], [Description], [Contents], [ProductDetails], [ImgUrl], [AltString]) VALUES (0, N'Kruidenmix', N'Meat', 2, N'Koop
Zonder zout eten hoeft helemaal niet smaakloos te zijn. Als je maar de juiste ingrediënten gebruikt. En dat is precies wat wij hebben gedaan: door de juiste smaakvolle kruiden en specerijen te gebruiken breng je ook zonder zout je gerecht heerlijk op smaak.', N'40g', N'Buiten koeling houdbaar_Diepvriesbesteding_Droog bewaren_Diepvriesbesteding_Droog bewaren', N'https://store.verstegen.eu/media/catalog/product/cache/1/thumbnail/218x163/9df78eab33525d08d6e5fb8d27136e95/3/9/3990_3.jpg', N'Kruidenmix voor gehakt')
INSERT INTO [dbo].[Products] ([ProductId], [Title], [Type], [CategoryId], [Description], [Contents], [ProductDetails], [ImgUrl], [AltString]) VALUES (1, N'Mix voor aardappel', N'Potato', 0, N'Koop
Wat velen niet weten is dat wij naast de bekende mixen voor gehakt en kip ook verschillende mixen hebben voor je maaltijd. Met deze mixen kun je met één zakje je gehele maaltijd op smaak brengen. Heerlijke winterse Hachee, Goulash of Chili con Carne of verschillende stamppotten, met Verstegen chef je het allemaal zelf.', N'80g', N'Buiten koeling houdbaar_Diepvriesbesteding_Droog bewaren_Diepvriesbesteding_Droog bewaren', N'https://store.verstegen.eu/media/catalog/product/cache/1/thumbnail/218x163/9df78eab33525d08d6e5fb8d27136e95/4/0/4002_4.jpg', N'Mix voor aardappellen')
INSERT INTO [dbo].[Products] ([ProductId], [Title], [Type], [CategoryId], [Description], [Contents], [ProductDetails], [ImgUrl], [AltString]) VALUES (2, N'Krispi citroen en dille', N'Fish', 2, N'Met onze Krispi kruidenmmixen zorg je op een eenvoudige manier voor een heerlijk krokant laagje op je gerecht. De speciale combinatie van het krokante van cornflakes met de beste kruiden en specerijen geeft je vis, vlees of kip een zeer smaakvolle en krokante smaak.', N'50g', N'Buiten koeling houdbaar_Diepvriesbesteding_Droog bewaren_Diepvriesbesteding_Droog bewaren', N'https://store.verstegen.eu/media/catalog/product/cache/1/thumbnail/218x163/9df78eab33525d08d6e5fb8d27136e95/3/6/3639_2.jpg', N'Krispi citroen en dille')
INSERT INTO [dbo].[Products] ([ProductId], [Title], [Type], [CategoryId], [Description], [Contents], [ProductDetails], [ImgUrl], [AltString]) VALUES (3, N'Prei groentenfinish', N'Vegetables', 0, N'Door deze mix toe te voegen aan uw groente, maakt u van uw vertrouwde groente weer een bijzonder gerecht. Bovendien zijn alle Verstegen groentenmixen vrij van kunstmatige geur-, kleur- en smaakstoffen.', N'15g', N'Buiten koeling houdbaar_Diepvriesbesteding_Droog bewaren_Diepvriesbesteding_Droog bewaren', N'https://store.verstegen.eu/media/catalog/product/cache/1/thumbnail/218x163/9df78eab33525d08d6e5fb8d27136e95/4/0/4098_3.jpg', N'Groentenfinish voor prei')
INSERT INTO [dbo].[Products] ([ProductId], [Title], [Type], [CategoryId], [Description], [Contents], [ProductDetails], [ImgUrl], [AltString]) VALUES (4, N'Honingmoster saus', N'Sauces', 10, N'Smaak: Honing / Mosterd', N'80ml', N'Buiten koeling houdbaar_Diepvriesbesteding_Droog bewaren_Diepvriesbesteding_Droog bewaren', N'https://store.verstegen.eu/media/catalog/product/cache/1/thumbnail/218x163/9df78eab33525d08d6e5fb8d27136e95/6/4/6460_12.jpg', N'Honingmosterd saus')
INSERT INTO [dbo].[Products] ([ProductId], [Title], [Type], [CategoryId], [Description], [Contents], [ProductDetails], [ImgUrl], [AltString]) VALUES (5, N'Mix voor sate', N'Meat', 2, N'Smaak: specifiek', N'25g', N'Buiten koeling houdbaar_Diepvriesbesteding_Droog bewaren_Diepvriesbesteding_Droog bewaren', N'https://store.verstegen.eu/media/catalog/product/cache/1/thumbnail/218x163/9df78eab33525d08d6e5fb8d27136e95/8/2/8234_1.jpg', N'Mix voor sate')
INSERT INTO [dbo].[Products] ([ProductId], [Title], [Type], [CategoryId], [Description], [Contents], [ProductDetails], [ImgUrl], [AltString]) VALUES (6, N'Hollandaise saus', N'Sauces', 10, N'Hollandaise saus', N'80ml', N'Koop
In handige 80 ml cups. Deze saus is heerlijk bij vis, kip en varkensvlees, maar uiteraard ook bij groenten, zoals asperges. De cupjes zijn ideaal voor eenmalig gebruik. De saus kan in de magnetron opgewarmd worden, doordat de verpakking magnetronbestendig is. Let op: prik we gaatjes in de folie. Afhankelijk van type en vermogen van je magnetron adviseren wij 30 seconden op 600 W. Of je warmt het even op in een pan. Dat kan natuurlijk ook.', N'https://store.verstegen.eu/media/catalog/product/cache/1/thumbnail/218x163/9df78eab33525d08d6e5fb8d27136e95/5/3/5394_21.jpg', N'Hollandaise saus')
SET IDENTITY_INSERT [dbo].[Products] OFF

SET IDENTITY_INSERT [dbo].[Recipes] ON
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [SubTitle], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration], [ThemeId], [CategoryId]) VALUES (0, N'Sausage', N'Grilled pork sausages', N'Meat', N'For 5 sausages', N'images/recipes/preview/sausages.jpg', N'Grind the meat_make sausage_grill the sausage and you''re done', N'BBQ Sauce_Garlic Sauce', 0, 2)
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [SubTitle], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration], [ThemeId], [CategoryId]) VALUES (1, N'Burger', N'Burgers with fries and coleslaw', N'Meat', N'For 5 burgers', N'images/recipes/preview/burger.jpg', N'Grill the burger on a high pit_(optional) grill the bread aswell_Slice some tomatoes_When the meat is done you can start building your burger!', N'BBQ Sauce_Bacon', 1, 2)
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [SubTitle], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration], [ThemeId], [CategoryId]) VALUES (2, N'Salmon', N'Salmon with fresh vegetables', N'Fish', N'For 5 plates', N'images/recipes/preview/salmon.jpg', N'Slice the salmon_Bake the vegetables with some oil_grill the salmon_serve together in a bowl', N'Dill_Rucola', 2, 2)
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [SubTitle], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration], [ThemeId], [CategoryId]) VALUES (3, N'Oatmeal', N'Oatmeal with fresh fruits', N'Breakfast', N'For 2 bowls', N'images/recipes/preview/oatmeal-fruits.jpg', N'Warm up some milk and put it in a bowl_Add the oatmeal_Add any fruits you fancy_enjoy your meal!', N'Fresh mint_Extra fruits', 3, 6)
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [SubTitle], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration], [ThemeId], [CategoryId]) VALUES (4, N'Pancakes', N'Pancakes with fruits', N'Breakfast', N'For 10 pancakes', N'images/recipes/preview/pancakes.jpg', N'Add the flour, milk and eggs in a bowl_Mix the contents for 2 minutes_Warm up a pan and make some pancakes', N'Sugar_Bacon', 4, 6)
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [SubTitle], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration], [ThemeId], [CategoryId]) VALUES (6, N'Pasta Pesto', N'Pasta with fresh pesto and spinach', N'Pasta', N'For 3 bowls', N'images/recipes/preview/pasta-pesto.jpg', N'Boil the pasta for 10 minutes_Cook the chicken in the meantime_When the pasta is done, combine with the chicken_Final touch, add the pesto ', N'Pine nuts_Rucola', 5, 9)
INSERT INTO [dbo].[Recipes] ([RecipeId], [Title], [SubTitle], [Type], [AmountOfPeople], [ImgUrl], [Procedure], [Decoration], [ThemeId], [CategoryId]) VALUES (7, N'Nasi', N'Nasi with chicken', N'Rice', N'For 4 bowls', N'images/recipes/preview/nasi.jpg', N'Cook the rice_Bake the vegetables_serve together', N'Saté_Crispy onions', 0, 9)
SET IDENTITY_INSERT [dbo].[Recipes] OFF

SET IDENTITY_INSERT [dbo].[Ingredients] ON
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (0, N'Rundersnippers 85/15', NULL, 860, 68.8, 0)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (1, N'Water', NULL, 60, 20, 0)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (2, N'Snijbare Champignonsaus', NULL, 250, 20, 0)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (3, N'World Spice Blend Mediterranean', NULL, 40, 3.2, 0)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (4, N'Binding Vero Pure', NULL, 40, 3.2, 0)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (5, N'Gehakt', NULL, 860, 68.8, 1)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (6, N'IJsbergsla', NULL, 60, 20, 1)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (7, N'Bacon', NULL, 250, 20, 1)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (8, N'World Spice Blend Mediterranean', NULL, 40, 3.2, 1)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (9, N'Binding Vero Pure', NULL, 40, 3.2, 1)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (10, N'Zalmfilet', NULL, 860, 68.8, 2)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (11, N'Peper', NULL, 2, 3, 2)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (12, N'Wokgroenten', NULL, 250, 20, 2)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (13, N'World Spice Blend Mediterranean', NULL, 40, 3.2, 2)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (14, N'Binding Vero Pure', NULL, 40, 3.2, 2)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (15, N'Oatmeal', NULL, 860, 68.8, 3)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (16, N'Melk', NULL, 60, 20, 3)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (17, N'Bosvruchten', NULL, 250, 20, 3)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (18, N'Suiker', NULL, 10, 3.2, 3)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (19, N'Binding Vero Pure', NULL, 40, 3.2, 3)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (20, N'Bloem', NULL, 860, 68.8, 4)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (21, N'Melk', NULL, 60, 20, 4)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (22, N'Eieren', NULL, 250, 20, 4)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (23, N'World Spice Blend Mediterranean', NULL, 40, 3.2, 4)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (24, N'Binding Vero Pure', NULL, 40, 3.2, 4)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (25, N'Pasta', NULL, 860, 68.8, 6)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (26, N'Verse Pesto', NULL, 60, 20, 6)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (27, N'Cherry tomaten', NULL, 250, 20, 6)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (28, N'World Spice Blend Mediterranean', NULL, 40, 3.2, 6)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (29, N'Binding Vero Pure', NULL, 40, 3.2, 6)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (30, N'Rijst', NULL, 860, 68.8, 7)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (31, N'Kip', NULL, 60, 20, 7)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (32, N'Wokgroenten', NULL, 250, 20, 7)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (33, N'World Spice Blend Mediterranean', NULL, 40, 3.2, 7)
INSERT INTO [dbo].[Ingredients] ([IngredientId], [Name], [ArticleNumber], [Gram], [Percentage], [RecipeId]) VALUES (34, N'Binding Vero Pure', NULL, 40, 3.2, 7)
SET IDENTITY_INSERT [dbo].[Ingredients] OFF