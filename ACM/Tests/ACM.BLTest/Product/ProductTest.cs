using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class ProductTest
    {
        [Fact]
        public void ValidateValid()
        {
            //--Arrange
            Product product = new Product();
            product.ProductName = "Computer Monitor";
            product.CurrentPrice = 100;

            var expected = true;

            //--Act
            var actual = product.Validate();

            //--Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingProductName()
        {
            //--Arrange
            Product product = new Product();
            product.CurrentPrice = 100;

            var expected = false;

            //--Act
            var actual = product.Validate();

            //--Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingCurrentPrice()
        {
            //--Arrange
            Product product = new Product();
            product.ProductName = "Computer Monitor";

            var expected = false;

            //--Act
            var actual = product.Validate();

            //--Assert
            Assert.Equal(expected, actual);
        }
    }
}
