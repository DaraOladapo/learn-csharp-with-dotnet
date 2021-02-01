using System;

namespace CreatingAndCallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5, c;
            int d = 65, e = 54, f;
            c = Subtract(a, b);
            Console.WriteLine(c);
            f = Subtract(d, e);
            Console.WriteLine(f);
        }
        static int Subtract(int firstValue, int secondValue)
        {
            int result = 0;
            if (firstValue > secondValue)
            {
                result = firstValue = secondValue;
            }
            else
            {
                result = secondValue - firstValue;
            }
            return result;
        }
    }
}
