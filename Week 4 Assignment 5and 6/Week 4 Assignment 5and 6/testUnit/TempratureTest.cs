using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnit
{

    [TestFixture]
    public class TemperatureConverterTests
    {
        [Test]
        public void CelsiusToFahrenheit_ValidCelsius_ReturnsCorrectFahrenheit()
        {
            Assert.AreEqual(32, TemperatureConverter.CelsiusToFahrenheit(0), 0.001);
            Assert.AreEqual(212, TemperatureConverter.CelsiusToFahrenheit(100), 0.001);
            Assert.AreEqual(-40, TemperatureConverter.CelsiusToFahrenheit(-40), 0.001);
        }

        [Test]
        public void FahrenheitToCelsius_ValidFahrenheit_ReturnsCorrectCelsius()
        {
            Assert.AreEqual(0, TemperatureConverter.FahrenheitToCelsius(32), 0.001);
            Assert.AreEqual(100, TemperatureConverter.FahrenheitToCelsius(212), 0.001);
            Assert.AreEqual(-40, TemperatureConverter.FahrenheitToCelsius(-40), 0.001);
        }
    }

}
