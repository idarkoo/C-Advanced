using System;
namespace Task01.Classes
{
    public static class ExtensionCar
    {
        public static void Drive(this Car car, string place)
        {
            if (car.Fuel >= 50)
            {
                car.Fuel -= 50;
                Console.WriteLine($"{car.Brand} {car.Model} driving to {place}. Refuel. You now have {car.Fuel} liters of fuel");
            }
            else
            {
                Console.WriteLine($"Not enough fule to get to {place}");
            }
        }
    }
}
