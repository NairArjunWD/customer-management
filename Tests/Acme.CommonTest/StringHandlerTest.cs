using System;
using Xunit;
using Acme.Common;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.Equal(expected, actual);
        }

        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}