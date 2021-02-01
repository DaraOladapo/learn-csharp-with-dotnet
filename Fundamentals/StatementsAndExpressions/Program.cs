using System;

namespace StatementsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string myMessage = "Today is a beautiful day";
            int age = 5;
            if (age < 13)
            {
                string ageMessage = "You are too young";
                Console.WriteLine(ageMessage);
            }
        }
    }
}
