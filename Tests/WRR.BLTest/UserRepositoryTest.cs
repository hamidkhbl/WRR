using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WRR.BL;

namespace WRR.BLTest
{
    [TestClass]
    public class UserRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var userRepository = new UserRepository();
            var expected = new User(1)
            {
                Email = "hamidkhbl@gmail.com",
                FirstName = "Hamid",
                LastName = "Khbl"
            };

            // Act
            var actual = userRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.UserId, actual.UserId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
