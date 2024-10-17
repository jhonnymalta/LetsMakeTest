using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixUCarApp
{
    public class Client
    {
        public int Discount = 15;

        public string GenerateUserLogin(string firstName,string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Empty First Name");
            }
            return $"{firstName}{lastName}-123";
        }

        public ClientType GetClientType(string document)
        {
            if(document.Length != 11 && document.Length != 14)
            {
                throw new ArgumentException("Invalid Document Number");
            }
            if (document.Length.Equals(11))
            {
                return new NaturalPerson();
            }
            return new LegalPerson();
        }

        public int ApplyClientDiscount()
        {
            return Discount = 20;
        }

        public string PowerConfiability(int SerasaScore)
        {
            var result = SerasaScore switch
            {

                int n when n <= 500 => "D",
                int n when n > 500 && n <= 700 => "C",
                int n when n > 700 && n <= 850 => "B",
                int n when n > 850 => "A",
                _ => "Invalid"

            };
            return result;
        }
    }
}
