using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using Verstegen;
using Verstegen.Controllers;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;
using Microsoft.EntityFrameworkCore;
using Verstegen.Models;

namespace ProductsTest
{
    public class UnitTest1
    {
        private string databaseName;

        private MyContext GetInMemoryDatabase()
        {
            MyContext db = getContext(true);
            if (db.Recipes.Count() == 0)
            {
                db.Add(new Category { CategoryId = 10, CategoryName = "Potato, Vegetable, Fruit", CategoryValue = "pvf" });
                db.Add(new Category { CategoryId = 11, CategoryName = "Ready-made, Salads", CategoryValue = "rms" });
                db.Add(new Category { CategoryId = 12, CategoryName = "Meat, Fish, Vegetarian, Chicken", CategoryValue = "mfvc" });
                db.Add(new Product { ProductId = 10, Title = "Kruidenmix", Type = "Meat", CategoryId = 12, Description = "Kruidenmix description", Contents = "40g", ProductDetails = "Buiten koeling bewaren", ImgUrl = "https://store.verstegen.eu/media/catalog/product/cache/1/thumbnail/218x163/9df78eab33525d08d6e5fb8d27136e95/3/9/3990_3.jpg", AltString = "Kruidenmix voor gehakt" });
                db.Add(new Product { ProductId = 11, Title = "Mix voor aardappelen", Type = "Potato", CategoryId = 10, Description = "Mix voor aardappelen", Contents = "80g", ProductDetails = "Buiten koeling bewaren", ImgUrl = "https://store.verstegen.eu/media/catalog/product/cache/1/thumbnail/218x163/9df78eab33525d08d6e5fb8d27136e95/4/0/4002_4.jpg", AltString = "Mix voor aardappelen" });
                db.Add(new Blog { BlogId = 10, Title = "Blog 1", Subject = "Blog 1 subject", Text = "Blog 1 text", Quote = "Blog 1 quote", QuoteFrom = "Blog 1 quote from", SubTitle = "Blog 1 subtitle", SubText = "Blog 1 subtext", Bullet = "", ImgUrl = "images/Stories/hand-seasoning.jpg", ThemeId = 1, Type = "hww" });
                db.Add(new Blog { BlogId = 11, Title = "Blog 2", Subject = "Blog 2 subject", Text = "Blog 2 text", Quote = "Blog 2 quote", QuoteFrom = "Blog 2 quote from", SubTitle = "Blog 2 subtitle", SubText = "Blog 2 subtext", Bullet = "", ImgUrl = "images/Stories/hand-seasoning.jpg", ThemeId = 0, Type = "hww" });
                db.Add(new Contact { ContactId = 10, Name = "Conact name 1", Function = "Function 1", Country = "The Netherlands", Province = "Zuid-Holland", Tel = "+31(0)532534344", Email = "contact1@contact.nl", ImgUrl = "/images/icons/persoon_img.svg" });
                db.Add(new Contact { ContactId = 11, Name = "Conact name 2", Function = "Function 2", Country = "The Netherlands", Province = "Zuid-Holland", Tel = "+31(0)532534344", Email = "contact2@contact.nl", ImgUrl = "/images/icons/persoon_img.svg" });
                db.Add(new Ingredient { IngredientId = 10, Name = "Ingredient 1", Gram = 80, Percentage = 30.5, RecipeId = 0 });
                db.Add(new Ingredient { IngredientId = 11, Name = "Ingredient 2", Gram = 40, Percentage = 20, RecipeId = 1 });
                db.Add(new Recipe { RecipeId = 10, Title = "Recepi title 1", SubTitle = "Sub title 1", Type = "Meat", AmountOfPeople = "For 4 people", ImgUrl = "images/recipes/preview/sausages.jpg", Procedure = "Recept procedure 1", Decoration = "Recept 1 decoration", ThemeId = 0, CategoryId = 0 });
                db.Add(new Recipe { RecipeId = 11, Title = "Recepi title 2", SubTitle = "Sub title 2", Type = "Rice", AmountOfPeople = "For 5 people", ImgUrl = "images/recipes/preview/nasi.jpg", Procedure = "Recept procedure 2", Decoration = "Recept 2 decoration", ThemeId = 1, CategoryId = 1 });
                db.Add(new Theme { ThemeId = 10, Name = "Theme 1 name", ImgUrl = "bbq.jpg", IconUrl = "images/icons/bbq-icon.svg" });
                db.Add(new Theme { ThemeId = 11, Name = "Theme 2 name", ImgUrl = "cocktails.jpg", IconUrl = "images/icons/cocktail-glass-icon.svg" });

                db.SaveChanges();
                db = getContext(false);
            }
            return db;
        }

        private MyContext getContext(bool NewDb)
        {
            if (NewDb)
            {
                this.databaseName = "TestDb";
            }

            var options = new DbContextOptionsBuilder<MyContext>().EnableSensitiveDataLogging()
                .UseInMemoryDatabase(this.databaseName).Options;

            return new MyContext(options);
        }

        // Deze test controlleert of de juiste view wordt gereturned als er een ongeldig id mee wordt gegeven.
        [Fact]
        public void TestCorrectProductViews()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new ProductsController(TestDb);

            var UnvalidResult = control.Product(-1);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(UnvalidResult);
            Assert.Equal("Products", redirectToActionResult.ControllerName);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        // Deze test controlleert of het juiste aantal categoriën en producten wordt meegegeven aan de view.
        [Fact]
        public void TestAmountOfProducts()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new ProductsController(TestDb);
            var result = control.Index(1);
            var view = Assert.IsType<ViewResult>(result);

            var Categories = control.ViewBag.Categories.Count;
            var Products = control.ViewBag.Products.Count;

            Assert.Equal(3, Categories);
            Assert.Equal(2, Products);
        }

        // Deze test controlleert of het juiste product wordt meegegeven aan de view.
        [Fact]
        public void TestSingleProduct()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new ProductsController(TestDb);
            var result = control.Product(11);
            var view = Assert.IsType<ViewResult>(result);

            Product ViewProduct = control.ViewBag.Product;

            Assert.Equal(11, ViewProduct.ProductId);
        }

        // Deze test controlleert of de juiste types wordt meegegeven met het juiste aantal.
        [Fact]
        public void TestCorrectProductTypes()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new ProductsController(TestDb);
            var result = control.Index(1);

            string FirstExpected = "Meat (1)";
            string SecondExpected = "Potato (1)";

            List<string> Expected = new List<string>();

            Expected.Add(FirstExpected);
            Expected.Add(SecondExpected);

            List<string> types = control.ViewBag.Types;

            for (int i = 0; i < types.Count(); i++)
            {
                Assert.Equal(Expected[i], types[i]);
            }
        }

        [Fact]
        public void TestRecipes1()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var controller = new RecipesController(TestDb);

            var result1 = controller.Recipe(-1);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result1);
            Assert.Equal("Recipes", redirectToActionResult.ControllerName);
            Assert.Equal("Index", redirectToActionResult.ActionName);

            var result2 = controller.Recipe(10);
            var viewResult = Assert.IsType<ViewResult>(result2);

            Recipe Recipe = controller.ViewBag.Recipe;
            Assert.Equal("For 4 people", Recipe.AmountOfPeople);

            Assert.Equal(2, TestDb.Recipes.ToList().Count);
            Assert.Single(TestDb.Recipes.Where(r => r.Type == "Meat").ToList());
            Assert.Single(TestDb.Recipes.Where(r => r.Type == "Rice").ToList());
        }

        // Deze test controlleert of de juiste page wordt opgehaald, of de totaal juiste object wordt,
        //of de juiste ojbject worden opgehaald, opgehaalden juiste view
        [Fact]
        public void Test_IndexViewType()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var controller = new ContactController(TestDb);

            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestContacts_Index_ReturnsAViewResult()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var controller = new ContactController(TestDb);

            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Contact>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }


        [Fact]
        public void TestSearch1()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var controller = new SearchController(TestDb);

            //Test1 - Juiste pagina index
            var result1 = controller.Index("Rice", -2);
            int page = controller.ViewBag.Page;
            Assert.Equal(1, page);

            //Test2 - Totaal objecten
            var result2 = controller.Index("Meat", 1);
            int bag = controller.ViewBag.TestList.Count;
            Assert.Equal(2, bag);

            //Test3 - Testen of juiste Object wordt opgehaald
            Assert.True(TestDb.Recipes.Where(r => r.Type == "Meat").First().Equals(controller.ViewBag.TestList[0]));

            //Test4 - Juiste view
            Assert.IsType<ViewResult>(result2);
        }

        // Deze test controlleert of het crud systeem van Contactpersoon alle entries naar de tabel stuurt.
        [Fact]
        public void TestContactTabel()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new AdminController(TestDb);
            var result = control.AllContacts();

            List<Contact> ExpectedContacts = TestDb.Contacts.ToList();
            List<Contact> contacts = control.ViewBag.contacts;
            int ContactsCount = contacts.Count();

            Assert.Equal(2, ContactsCount);

            for (int i = 0; i < ContactsCount; i++)
            {
                Assert.Equal(ExpectedContacts[i].ContactId, contacts[i].ContactId);
            }
        }

        // Deze test controlleert van CRUD: Create functie voor contactpersoon. 
        // Een met geldige data en een met ongeldige data.
        [Fact]
        public void TestCreateContact()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new AdminController(TestDb);
            Contact TestContact1 = new Contact { ContactId = 12, Name = "Test contactname", Function = "Test Function", Country = "The Netherlands", Province = "Zuid-Holland", Tel = "+31(0)532534344", Email = "test@test.nl", ImgUrl = "/images/icons/persoon_img.svg" };
            var result1 = control.CreateContact(TestContact1);

            var ContactResult1 = false;
            List<Contact> AllContacts = TestDb.Contacts.ToList();

            for (int i = 0; i < AllContacts.Count(); i++)
            {
                if (TestContact1.ContactId == AllContacts[i].ContactId)
                {
                    ContactResult1 = true;
                }
                else
                {
                    ContactResult1 = false;
                }
            }

            Assert.True(ContactResult1);
        }

        // Deze test controlleert van CRUD: Edit van een contactpersoon. 
        // Checkt of de juiste gegevens worden meegegeven aan de view.
        [Fact]
        public void TestGetEditContact()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new AdminController(TestDb);
            Contact TestContact = new Contact { ContactId = 12, Name = "Test", Function = "Test", Country = "The Netherlands", Province = "Zuid-Holland", Tel = "+31(0)532534344", Email = "contact1@contact.nl", ImgUrl = "/images/icons/persoon_img.svg" };
            TestDb.Add(TestContact);
            var result1 = control.EditContact(TestContact.ContactId);

            Contact ViewContact = control.ViewBag.Contact;

            Assert.Equal(TestContact.ContactId, ViewContact.ContactId);
        }

        // Deze test controlleer van CRUD: Edit van een contactpersoon.
        // Checkt of de juiste entry wordt aangepast.
        [Fact]
        public void TestEditContact()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new AdminController(TestDb);
            Contact TestContact = new Contact { ContactId = 12, Name = "Test", Function = "Test", Country = "The Netherlands", Province = "Zuid-Holland", Tel = "+31(0)532534344", Email = "contact1@contact.nl", ImgUrl = "/images/icons/persoon_img.svg" };

            Assert.Equal("Test", TestContact.Name);

            TestDb.Add(TestContact);
            TestContact.Name = "ChangedName";
            var result = control.EditContact(TestContact.ContactId, TestContact);
            var name = "";
            List<Contact> AllContacts = TestDb.Contacts.ToList();

            for (int i = 0; i < AllContacts.Count(); i++)
            {
                if (AllContacts[i].ContactId == 12)
                {
                    name = AllContacts[i].Name;
                }
            }

            Assert.Equal("ChangedName", name);
        }

        // Deze test controlleer van CRUD: Delete van een contactpersoon.
        // Checkt of de juiste entry wordt verwijderd.
        [Fact]
        public void TestDeleteContact()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new AdminController(TestDb);
            Contact TestContact = new Contact { ContactId = 13, Name = "Test", Function = "Test", Country = "The Netherlands", Province = "Zuid-Holland", Tel = "+31(0)532534344", Email = "contact1@contact.nl", ImgUrl = "/images/icons/persoon_img.svg" };
            TestDb.Add(TestContact);

            List<Contact> AllContacts = TestDb.Contacts.ToList();

            for (int i = 0; i < AllContacts.Count(); i++)
            {
                if (AllContacts[i].ContactId == TestContact.ContactId)
                {
                    Assert.True(true);
                }
            }

            control.DeleteContact(TestContact.ContactId);
            var DeleteResult = false;
            List<Contact> AllContacts2 = TestDb.Contacts.ToList();

            for (int i = 0; i < AllContacts2.Count(); i++)
            {
                if (AllContacts[i].ContactId != TestContact.ContactId)
                {
                    DeleteResult = true;
                }
                else
                {
                    DeleteResult = false;
                }
            }

            Assert.True(DeleteResult);
        }

        //Inspiration correct value Test
        [Fact]
        public void TestInspirationProduct()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var controller = new InspirationController(TestDb);

            var result = controller.Index(1, 12);

            var Products = controller.ViewBag.Products.Count;

            Assert.Equal(1, Products);
        }

        //Inspiration correct views test
        [Fact]
        public void TestCorrectInspirationView()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new InspirationController(TestDb);

            var result1 = control.Theme(-1);
            var result2 = control.Details(-1);

            var redirectToIndex1 = Assert.IsType<RedirectToActionResult>(result1);
            var redirectToIndex2 = Assert.IsType<RedirectToActionResult>(result2);

            Assert.Equal("Index", redirectToIndex1.ActionName);
            Assert.Equal("Index", redirectToIndex2.ActionName);
        }

        //Inspiration correct views test
        [Fact]
        public void TestInspiration2()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new InspirationController(TestDb);

            var result1 = control.Theme(-1);
            var result2 = control.Details(-1);

            var redirectToIndex1 = Assert.IsType<RedirectToActionResult>(result1);
            var redirectToIndex2 = Assert.IsType<RedirectToActionResult>(result2);

            Assert.Equal("Index", redirectToIndex1.ActionName);
            Assert.Equal("Index", redirectToIndex2.ActionName);
        }
    }
}
