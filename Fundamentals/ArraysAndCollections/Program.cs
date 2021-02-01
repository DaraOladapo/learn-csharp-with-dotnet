using System;
using System.Collections.Generic;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
        //   int[] myNumbers={1,2,4,5};
        //   Console.WriteLine(myNumbers[3]);
        //   int[] myNiceNumbers=new int[2];
        // myNiceNumbers[0]=1;
        // myNiceNumbers[1]=5;
        // foreach (var number in myNiceNumbers)
        // {
        //     Console.WriteLine(number);
        // }
        // for (int i = 0; i < myNiceNumbers.Length; i++)
        // {
        //     Console.WriteLine(myNiceNumbers[i]);
        // }
        // List<string> people=new List<string>();
        // people.Add("Dara");
        // people.Add("Smith");
        // people.Add("James");
        // foreach (var person in people)
        // {
        //     Console.WriteLine(person);
        // }
        Dictionary<string, string> accessCodes=new Dictionary<string,string>();
        accessCodes.Add("Main Gate", "1234Pass");
        accessCodes.Add("Door", "Pass1234");
        var mainGateCode=accessCodes["Main Gate"];
        Console.WriteLine(mainGateCode);
        }
    }
}
