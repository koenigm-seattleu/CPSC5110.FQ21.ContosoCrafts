
//using Bunit;
//using NUnit.Framework;

//using ContosoCrafts.WebSite.Components;
//using Microsoft.Extensions.DependencyInjection;
//using ContosoCrafts.WebSite.Services;
//using System.Linq;

//namespace UnitTests.Components
//{
//    public class ProductListTests : BunitTestContext
//    {
//        #region TestSetup

//        [SetUp]
//        public void TestInitialize()
//        {
//        }

//        #endregion TestSetup

//        [Test]
//        public void ProductList_Default_Should_Return_Content()
//        {
//            // Arrange
//            Services.AddSingleton<JsonFileProductService>(TestHelper.ProductService);

//            // Act
//            var page = RenderComponent<ProductList>();

//            // Get the Cards retrned
//            var result = page.Markup;

//            // Assert
//            Assert.AreEqual(true, result.Contains("The Quantified Cactus: An Easy Plant Soil Moisture Sensor"));
//        }
//    }
//}