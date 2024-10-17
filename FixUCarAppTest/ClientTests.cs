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
    public class ClientTests
    {
        private Client client;
        [SetUp]
        public void Setup()
        {
            client = new Client();
        }

        [Test]
        public void CombineName_InputFirstAndLastName_ReturnUserName()
        {          

            //Act
            string userName = client.GenerateUserLogin("Dorival", "Silva");

            //Assert
            ClassicAssert.That(userName, Is.EqualTo("DorivalSilva-123"));
            ClassicAssert.That(userName, Does.Contain("-"));
            ClassicAssert.That(userName, Does.EndWith("123"));

        }

        [Test]
        public void DiscountCheck_DefaultDiscount_ReturnDiscountInRange()
        {
            int result = client.Discount;

            ClassicAssert.That(result, Is.InRange(10, 25));
        }

        [Test]
        public void UserNamer_EmpytFirstName_ThrowsException()
        {
            var exceptionDetails = Assert.Throws<ArgumentException>(() => client.GenerateUserLogin("", "Tuner"));
            ClassicAssert.AreEqual("Empty First Name", exceptionDetails.Message);
        }

        [Test]
        public void ClientType_CreateNaturalPersonWithDocumentNumberLike11Digits_ReturnNaturalPerson()
        {
            //Arrange
            var documentNumber = "12345698763";
            
            //Act
            var result = client.GetClientType(documentNumber);

            //Assert
            Assert.That(result,Is.TypeOf<NaturalPerson>());
        }

        [Test]
        [TestCase(600,ExpectedResult = "C")]
        [TestCase(300,ExpectedResult = "D")]
        [TestCase(755,ExpectedResult = "B")]
        [TestCase(920,ExpectedResult = "A")]        
        public string PowerConfiability_InputSerasaScore_ReturnConfiability(int score)
        {
            return client.PowerConfiability(score);
             
        }
    }
}
