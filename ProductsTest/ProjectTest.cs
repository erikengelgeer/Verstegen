using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using Verstegen;
using Verstegen.Controllers;
using Microsoft.AspNetCore.Mvc;
using Verstegen.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsTest
{
    public class UnitTest1
    {
        private string databaseName;

        private MyContext GetInMemoryDatabase()
        {
            MyContext db = getContext(true);
            if (db.Recipes.Count() == 0) {
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

        [Fact]
        public void TestProducts1()
        {
            MyContext TestDb = GetInMemoryDatabase();
            var control = new ProductsController(TestDb);
            var result = control.Index(1);

            var Categories = control.ViewBag.Categories.Count;
            var Products = control.ViewBag.Products.Count;

            Assert.Equal(3, Categories);
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

        //Deze test controlleert of de juiste page wordt opgehaald, of de totaal juiste object wordt,
        //of de juiste ojbject worden opgehaald, opgehaalden juiste view
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
    }
}
