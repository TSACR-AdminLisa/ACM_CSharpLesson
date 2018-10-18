using System;
using Xunit;
using Acme.Common;

namespace Acme.CommonTest
{
    public class StringHandlingTest
    {
        [Fact]
        public void InsertSpacesTest()
        {
            //-- Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //-- Act
            var actual = source.InsertSpaces();

            Console.Write("Fuente: {0} - Valor Esperado: {1} - Valor Actual: {2}", source, expected, actual);

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesWithExistingSpacesTest()
        {
            //-- Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //-- Act
            var actual = source.InsertSpaces();

            Console.Write("Fuente: {0} - Valor Esperado: {1} - Valor Actual: {2}", source, expected, actual);

            //-- Assert
            Assert.Equal(expected, actual);
        }
    }
}
