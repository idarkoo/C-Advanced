using System;
using Task01.Classes;

namespace Task01
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Car myCar = new Car("Zastava", "101", "Bela", 45, true);
            Car myCar2 = new Car("Ficho", "500", "Siva", 75, true);


            
            Console.WriteLine(Car.GetCarStats(myCar));

            myCar.StartCar();
            myCar.StartLights();
            myCar.Drive("Sofija");
            GasStation.Refill(myCar);
            myCar.Drive("Sofija");
            GasStation.PumpUpTires(myCar);

            Console.WriteLine("-----------------------------------------------------------");


            Console.WriteLine(Car.GetCarStats(myCar2));

            myCar2.StartCar();
            myCar2.StartLights();
            myCar2.Drive("Sofija");
            GasStation.Refill(myCar2);
            GasStation.PumpUpTires(myCar2);

            Console.ReadLine();
        }
    }
}
