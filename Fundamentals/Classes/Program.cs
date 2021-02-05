using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car myCar = new Car();
            // myCar.Make = "Toyota";
            // myCar.Model = "Prius";
            // myCar.Year = 2020;
            // Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");

            // Car myOtherCar = new Car() { Make="Ford", Model="Focus",Year= 2019};
            // Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model} {myOtherCar.Year}");

            Car myOtherNiceCar = new Car("Nissan", "Juke", 2020);
            myOtherNiceCar.Drive();
            Utility.PrintDetails(myOtherNiceCar);
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

    static class Utility{
        public static void PrintDetails(Car car){
            Console.WriteLine($"{car.Make} was access {DateTime.Now.ToShortDateString()}");
        }
    }
}
