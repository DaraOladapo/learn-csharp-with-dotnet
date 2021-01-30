using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 3; i <= 100; i+=3)
            // {
            //     Console.WriteLine(i);
            // }
            // int[] myNumbers={1,2,4,5,66};
            // foreach (var number in myNumbers)
            // {
            //     Console.WriteLine(number);
            // }
            int counter=5;
            do
            {
                Console.WriteLine("{will run at least once} - Today is a beautiful day");
                counter++;
            } while (counter<=5);
            while (counter<=5)
            {
                Console.WriteLine("{may new run} - Today is a beautiful day");
                counter++;
            }
        }
    }
}
