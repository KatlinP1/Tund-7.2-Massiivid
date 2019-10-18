using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace isikukood
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            Console.WriteLine("Enter your id code: ");
            id = Console.ReadLine();
            bool idValid;
            idValid = CheckIDLength(id);

            

            if (idValid)
            {
                GetGender(id);
                GetYear(id);
                //Console.WriteLine("OK");
            }
            else
            {
                GetGender(id);
                //Console.WriteLine("Not OK");
            }

            Console.ReadLine();
        }
        public static void GetGender(string idCode)
        {
            int firstNumber = int.Parse(idCode[0].ToString());
            if (firstNumber == 4|| firstNumber == 6|| firstNumber == 2)
            {
                Console.WriteLine("Hello, Madame!");
            }
            else
            {
                Console.WriteLine("Hello, Sir");
            }
            
        }

        public static void GetYear(string idCode)
        {
            string year = idCode.Substring(1,2);
            string fullYear = $"19{year}";
            Console.WriteLine($"Your year of birth is : {fullYear}");

        }
        public static bool CheckIDLength(string idCode)
        {
            bool isValid;
            if(idCode.Length == 11)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }
        

        

        
    }
}
