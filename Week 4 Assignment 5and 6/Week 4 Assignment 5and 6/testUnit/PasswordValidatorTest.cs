using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnit
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        private PassWordValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new PassWordValidator();
        }

        [Test]
        public void Password_WithValidCriteria_ShouldReturnTrue()
        {
            Assert.IsTrue(validator.IsValid("StrongPass1"));
        }

        [Test]
        public void Password_TooShort_ShouldReturnFalse()
        {
            Assert.IsFalse(validator.IsValid("Shor1"));
        }

        [Test]
        public void Password_MissingUppercase_ShouldReturnFalse()
        {
            Assert.IsFalse(validator.IsValid("weakpassword1"));
        }

        [Test]
        public void Password_MissingDigit_ShouldReturnFalse()
        {
            Assert.IsFalse(validator.IsValid("NoDigitsHere"));
        }

        [Test]
        public void Password_EmptyString_ShouldReturnFalse()
        {
            Assert.IsFalse(validator.IsValid(""));
        }

        [Test]
        public void Password_Null_ShouldReturnFalse()
        {
            Assert.IsFalse(validator.IsValid(null));
        }
    }

}
