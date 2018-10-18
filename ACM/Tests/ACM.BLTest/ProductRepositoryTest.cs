using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveExisting()
        {
            //--Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "sunflowers",
                ProductDescription = "Assorted Siz",
                CurrentPrice = 15.96M
            };

            //--Act
            var actual = productRepository.Retrieve(2);

            //--Assert
            Assert.Equal(expected.ProductId, actual.ProductId);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
