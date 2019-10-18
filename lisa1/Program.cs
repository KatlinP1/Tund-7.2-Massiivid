using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lisa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm arvutab sünniaasta alusel vanust

            int DateOfBirth;
            Console.WriteLine("Insert your date of birth: ");
            DateOfBirth = int.Parse(Console.ReadLine());
            CalculateAge(DateOfBirth);

            Console.ReadLine();

        }
        public static void CalculateAge (int DateOfBirth)
        {
            Console.WriteLine($"you are {2019- DateOfBirth}");
        }
    }
}
