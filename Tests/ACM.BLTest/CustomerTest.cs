using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);

        }

        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);

        }

        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.Equal(3, Customer.InstanceCount);
        }

        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }

        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
