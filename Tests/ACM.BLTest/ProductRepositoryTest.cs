using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                Name = "shoe",
                Description = "for feet"
            };
            // act
            var actual = productRepository.Retrieve(1);
            // assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Description, actual.Description);
        }
        [TestMethod]
        public void SaveTestValid()
        {
            // arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(1)
            {
                Price = 16M,
                Description = "wild flower seed pack",
                Name = "wfseeds",
                HasChanges = true
            };

            // act 
            var actual = productRepository.Save(updatedProduct);

            // assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // arrange
            var productRepository = new ProductRepository();
            var product = new Product(1)
            {
                Price = null,
                Description = "product description",
                Name = "product name",
                HasChanges = true,
            };
            // act
            var actual = productRepository.Save(product);
            // assert
            Assert.AreEqual(false, actual);
        }
    }
}
