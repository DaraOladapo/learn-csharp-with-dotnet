using System;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;
            Console.WriteLine("What year were you born?");
            string userInput = Console.ReadLine();
            try
            {
                int userYearOfBirth = int.Parse(userInput);
                userAge = DateTime.Now.Year - userYearOfBirth;
                Console.WriteLine($"Your age is {userAge}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Sorry, your input was not right.\n{e.Message}");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
