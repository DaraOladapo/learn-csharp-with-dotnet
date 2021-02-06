using System;
using System.Collections.Generic;
using System.Linq;

namespace UsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
             var Cars = new List<Car>() {
                new Car(){ Make="Ford", Model="Focus", Year=2018, TransmissionType=Transmission.Automatic, FuelLevel=55},
                new Car(){ Make="Ford", Model="Eco Sport", Year=2016, TransmissionType=Transmission.Manual, FuelLevel=70},
                new Car(){ Make="Ford", Model="Mondeo", Year=2020, TransmissionType=Transmission.Automatic, FuelLevel=60},
                new Car(){ Make="Ford", Model="F150", Year=2000, TransmissionType=Transmission.Manual, FuelLevel=55},
                new Car(){ Make="Ford", Model="Galaxy", Year=2018, TransmissionType=Transmission.Automatic, FuelLevel=32.5},
            };
            // foreach(var car in Cars){
            //     if(car.TransmissionType==Transmission.Manual){
            //         Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            //     }
            Console.WriteLine("All manual transmission cars");
            var allManualCars = Cars.Where(c => c.TransmissionType == Transmission.Manual).ToList();
            PrintCars(allManualCars);

            Console.WriteLine("All automatic transmission cars");
            var allAutomaticCars = Cars.Where(c => c.TransmissionType == Transmission.Automatic).ToList();
            PrintCars(allAutomaticCars);

            Console.WriteLine("All cars older than 2017");
            var allNewCars = Cars.Where(c => c.Year > 2017).ToList();
            PrintCars(allNewCars);

            void PrintCars(List<Car> cars){
                foreach (var car in cars)
                {
                    Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
                }
            }
        }
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Transmission TransmissionType { get; set; }
        public double FuelLevel { get; set; } = 5;
    }
    enum Transmission{
        Automatic,
        Manual,
        SemiAutomatic
    }
