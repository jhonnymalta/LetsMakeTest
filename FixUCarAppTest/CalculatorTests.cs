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
        [TestCase(10)]
        [TestCase(8)]
        public void IsOddNumber_InputOneInt_ReturnIfIsOdd(int a)
        {
            //Arrange
            Calculator calc = new();

            //Act
            var result = calc.IsOddNumber(a);

            //Assert
            Assert.That(result, Is.EqualTo(true));


        }

        [Test]
        [TestCase(10,ExpectedResult = true)]
        [TestCase(13,ExpectedResult = false)]
        public bool IsOddNumber_InputOneInt_ReturnTrueIfOdd(int a)
        {
            //Arrange
            Calculator calc = new();

            //Act
            return calc.IsOddNumber(a);

            
        }

        [Test]
        [TestCase(5.4,10.5)]
        [TestCase(5.46,10.53)]
        public void AddNumbers_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            //Arrange
            Calculator calc = new();

            //Act
            double result = calc.addNumbersDouble(a, b);

            //Assert
            ClassicAssert.AreEqual(15.9,result,.1);

        }


        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            //Arrange
            Calculator calc = new();
            List<int> expectedOddRange = new List<int>() { 5, 7, 9 };

            //Act
            List<int> result = calc.GetOddRange(5, 10);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Empty);
                Assert.That(result.Count, Is.EqualTo(3));
                Assert.That(result, Is.Ordered);
                Assert.That(result, Is.EquivalentTo(expectedOddRange));
                ClassicAssert.AreEqual(expectedOddRange, result);
                ClassicAssert.Contains(7, result);
            });
            
           
        }
    }
}
