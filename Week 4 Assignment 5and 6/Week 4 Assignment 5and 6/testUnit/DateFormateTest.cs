using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnit
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormate dateFormatter;

        [SetUp]
        public void Setup()
        {
            dateFormatter = new DateFormate();
        }

        [Test]
        public void FormatDate_ValidDate_ReturnsFormattedDate()
        {
            string result = dateFormatter.FormatDate("2025-02-22");
            Assert.AreEqual("22-02-2025", result);
        }

        [Test]
        public void FormatDate_InvalidDate_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => dateFormatter.FormatDate("22-02-2025"));
        }

        [Test]
        public void FormatDate_EmptyString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => dateFormatter.FormatDate(""));
        }

        [Test]
        public void FormatDate_NullInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => dateFormatter.FormatDate(null));
        }
    }
}
