using System;

namespace SimpleCurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dara's GBP to USD Converter.\nWhat currency do you have? 1 for GBP, 2 for USD");
            var currencyFrom = (Currency)int.Parse(Console.ReadLine());
            Console.WriteLine("How much do you want to convert?");
            var amountToConvert = double.Parse(Console.ReadLine());
            var convertedAmount = CurrencyUtility.Convert(amountToConvert, currencyFrom);
            Console.WriteLine(convertedAmount);
        }
    }
    static class CurrencyUtility{
        public static double Convert(double amountValue, Currency currency){
            double returnAmount=0;
            if(currency==Currency.GBP){
               returnAmount= amountValue * 1.37;
            }
            if(currency==Currency.USD){
              returnAmount =amountValue / 1.37;
            }
            return returnAmount;
        }
    }    
    enum Currency{
        GBP=1,
        USD
    }
}
