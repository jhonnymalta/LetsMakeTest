using FixUCarApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixUCarAppTest
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
                int result = calc.addNumbers(2, 50);

            //Assert
            ClassicAssert.AreEqual(52, result);
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddNumber_InputOneInt_GetCorrectAddition(int a)
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool result = calc.IsOddNumber(a);

            //Assert
            Assert.That(result,Is.EqualTo(false));
        }
    }
}
