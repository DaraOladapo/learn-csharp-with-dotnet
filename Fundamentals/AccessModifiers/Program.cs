using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
             PetrolCar myCar = new PetrolCar {
                Make="Toyota",
                Model="CH-R",
                Year=2020,
                FuelLevel=15.3
             };
            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");
            myCar.Drive();
            myCar.Drive();
            myCar.Drive();
            var stopFuelLevel = myCar.Stop();
            Console.WriteLine($"Fuel level = {myCar.FuelLevel}");
            myCar.Drive();
            myCar.Drive();
            stopFuelLevel = myCar.Stop();
            Console.WriteLine($"Fuel level = {myCar.FuelLevel}");
        }
    }
    class Car
    {
        internal string Make{ get; set; }
        internal string Model{ get; set; }
        public int Year{ get; set; }
        protected Transmission TransmissionType { get; set; }     
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
    class PetrolCar: Car
    {
        public PetrolCar(){
            this.TransmissionType = Transmission.Automatic;
            Console.WriteLine($"{this.TransmissionType}");
        }
    }
}
