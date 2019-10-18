using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lisa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spacecounter- loeb tühikuid lause sees

            string userSentence;
            Console.WriteLine("Enter your sentence: ");
            userSentence = Console.ReadLine();

            CountSpaces(userSentence);
            Console.ReadLine();

        }
        public static void CountSpaces(string sentence)
        {
            int counter = 0;
            foreach (char symbol in sentence)
            {
                if (symbol == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are {counter} spaces in your sentence.");
        }
        
    }
}
