using Microsoft.AspNetCore.Mvc;
using System;
using Verstegen.Controllers;
using Xunit;


namespace inspirationTest
{
    public class InspirationTests
    {
        private int id;

        [Fact]
        public void Test1()
        {
            InspirationController i = new InspirationController();
            var result = i.Details();

            var viewResult = Assert.IsType<ViewResult>(result);

            var message = viewResult.ViewData["Details"];
            Assert.Equal("Inspiration Details page", message);
        }
    }
}
