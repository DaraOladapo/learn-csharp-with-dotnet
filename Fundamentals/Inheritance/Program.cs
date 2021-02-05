using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTesla = new ElectricCar() { 
                Make="Tesla",
                Model="Model S",
                Year=2021,
                BatteryCapacity=50000
            };
            Console.Write($"{myTesla.Make} {myTesla.Model} has a battery capacity of {myTesla.BatteryCapacity}kwh");
        }
    }
    }
    class Car{
        public Car(){
            Console.WriteLine("Creating a car");
        }
        public Car(string make, string model, int year){
            this.Make = make;
            this.Model = model;
            this.Year = year;
            Console.WriteLine($"{this.Make} {this.Model} {this.Year} has been created.");
        }
        public string Make;
        public string Model;
        public int Year;

        public void Drive(){
             Console.WriteLine($"{this.Make} {this.Model} {this.Year} is moving.");
        }
    }
class ElectricCar:Car{
        public double BatteryCapacity;
        public void Charge() {
            Console.WriteLine("Charge increased");
        }
    }
static class Utility
{
    public static void PrintDetails(Car car)
    {
        Console.WriteLine($"{car.Make} was access {DateTime.Now.ToShortDateString()}");
    }
}
