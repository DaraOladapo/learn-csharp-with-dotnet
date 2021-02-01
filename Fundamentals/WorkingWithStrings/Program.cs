using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStringValue="Today",secondStringValue="is", thirdStringValue="a good day.";
            var firstConcatenation = firstStringValue+" "+secondStringValue +" " +thirdStringValue;
            Console.WriteLine(firstConcatenation);
            Console.WriteLine("{0} {1} {2}", firstStringValue, secondStringValue, thirdStringValue);
            var thirdConcatenation = $"{firstStringValue} {secondStringValue} {thirdStringValue}";
            Console.WriteLine(thirdConcatenation);

            Console.WriteLine($"{firstStringValue}\n{secondStringValue}\t{thirdStringValue}");
        }
    }
}
