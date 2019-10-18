using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tund
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            string gender;
            Console.WriteLine("Are you leaving or coming?");
            userAnswer = Console.ReadLine();
            Console.WriteLine("What is your gender");
            gender = Console.ReadLine();

            

            if (userAnswer.ToLower() == "coming") 
            {
                Hello(gender);
            }
            else if (userAnswer.ToLower() == "leaving")
            {
                Bye(gender);
            }
            else
            {
                Console.WriteLine("Not true!");
            }


            Console.ReadLine(); 
        }
        public static void Hello(string gender)
        {
            if (gender == "male")
            {
                Console.WriteLine("Hello, sir");
            }
            else if (gender == "female")
            {
                Console.WriteLine("Hello, madam");
            }
            
        } 
        public static void Bye(string gender)
        {
            if (gender == "male")
            {
                Console.WriteLine("Bye, sir");
            }
            else if (gender == "female")
            {
                Console.WriteLine("Bye, madam");
            }
            
        }
        

        
        

    }
}
