using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WRR.BL;

namespace WRR.BLTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            User user = new User
            {
                FirstName = "Hamid",
                LastName = "Khbl"
            };
            string expected = "Hamid Khbl";
            // Act
            string actual = user.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            User user = new User
            {
                FirstName = "Hamid",
            };
            string expected = "Hamid";
            // Act
            string actual = user.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            User user = new User
            {
                LastName = "Khbl",
            };
            string expected = "Khbl";
            // Act
            string actual = user.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var user = new User
            {
                Email = "hamidkhbl@gmail.com",
                Username = "hamidkhbl"
            };
            var expected = true;

            // Act
            var actual = user.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateSpaceUsername()
        {
            // Arrange
            var user = new User
            {
                Email = "hamidkhbl@gmail.com",
                Username = " "
            };
            var expected = false;

            // Act
            var actual = user.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmail()
        {
            // Arrange
            var user = new User
            {
                Username = "Hamidkhbl"
            };
            var expected = false;

            // Act
            var actual = user.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
