using System;

namespace InterfacesAndEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car {
                Make="Toyota",
                Model="CH-R",
                Year=2020,
                TransmissionType=Transmission.Automatic,
                FuelLevel=15.3
             };
            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} has a/an {myCar.TransmissionType.ToString().ToLower()} transmission.");
            // myCar.Drive();
            // myCar.Drive();
            // myCar.Drive();
            // myCar.Drive();
            // myCar.Drive();
            // myCar.Drive();
            // var stopFuelLevel = myCar.Stop();
            // Console.WriteLine($"Fuel level = {myCar.FuelLevel}");
            // myCar.Drive();
            // myCar.Drive();
            // stopFuelLevel = myCar.Stop();
            // Console.WriteLine($"Fuel level = {myCar.FuelLevel}");
        }
    }
    class Car:ICar
    {
        public string Make{ get; set; }
        public string Model{ get; set; }
        public int Year{ get; set; }
        public Transmission TransmissionType { get; set; }
        
        
        public double FuelLevel { get; set; } = 5;
        public void Drive(){
            Console.WriteLine("Driving...");
            FuelLevel -= 0.2;
        }
        public double Stop(){
            Console.WriteLine("Stopping...");
            return FuelLevel;
        }
    }

    enum Transmission{
        Automatic,
        Manaul,
        SemiAutomatic
    }
    interface ICar
    {
        void Drive();
        double Stop();
    }
}
