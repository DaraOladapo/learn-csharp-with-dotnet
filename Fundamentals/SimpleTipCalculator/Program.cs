using System;

namespace SimpleTipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tip calculator.\nPlease enter amount of purchase.");
            double purchaseAmount=double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the tip percentage you want to give.");
            double tipPercentage=double.Parse(Console.ReadLine());
            double tipAmount=0,totalPayable=0;
            if(tipPercentage>20.0)
            {
                   Console.WriteLine("Tip is above allowed limit. We will set this at maximum");
                   tipPercentage=20.0;
             }
            if(tipPercentage<0.0)
            {
                tipPercentage=0;
            }
            tipAmount=tipPercentage/100*purchaseAmount;
            totalPayable=purchaseAmount+tipAmount;
            Console.WriteLine($"Total amount to pay: {totalPayable:c}\nTotal Purchase: {purchaseAmount:c}\nTip Amount: {tipAmount:c}");

        }
    }
}
