using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_4_Assignment_5and6_Testing;

namespace testUnit
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private readonly UserRegistration _userRegistration = new UserRegistration();

        [Test]
        public void RegisterUser_ValidInputs_DoesNotThrowException()
        {
            Assert.DoesNotThrow(() => _userRegistration.RegisterUser("testuser", "test@example.com", "securePass"));
        }

        [TestCase("", "test@example.com", "securePass")]
        [TestCase(null, "test@example.com", "securePass")]
        public void RegisterUser_InvalidUsername_ThrowsArgumentException(string username, string email, string password)
        {
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser(username, email, password));
        }

        [TestCase("testuser", "", "securePass")]
        [TestCase("testuser", "invalid-email", "securePass")]
        public void RegisterUser_InvalidEmail_ThrowsArgumentException(string username, string email, string password)
        {
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser(username, email, password));
        }

        [TestCase("testuser", "test@example.com", "123")]
        [TestCase("testuser", "test@example.com", "")]
        public void RegisterUser_InvalidPassword_ThrowsArgumentException(string username, string email, string password)
        {
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser(username, email, password));
        }
    }

}
