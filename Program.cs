using Automotive;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

namespace Racing
//Also known as: Virtual Constructor
/*Stwórz dwa projekty
 * 
 * Automotive
 * zawiera klase Car z modyfikatorami dostepu sealed oraz konstruktor z modyfikatorem dostepu internal
 * 
 * Racing
 * Racing zawierający aplikacje konsolową w której będą ścigać się Car
 * 
 * Spraw aby możliwe było tworzenie nowych instancji klasy Car w projekcie Racing
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Race!");
            Car firstCar = Car.CreateCar("Toyota", "Rav4", 240.5, 320);
            Console.WriteLine("A " + firstCar.Brand + " car was created, specifically the " + firstCar.Model + " model, with a maximum speed of " + firstCar.MaxSpeed + " and a number of " + firstCar.HorsePower + " horsepower.");
            
            Car secondCar = Car.CreateCar("Land Rover", "Defender", 190.3, 350);
            Console.WriteLine("A " + secondCar.Brand + " car was created, specifically the " + secondCar.Model + " model, with a maximum speed of " + secondCar.MaxSpeed + " and a number of " + secondCar.HorsePower + " horsepower.");

            Console.WriteLine("Race begins");
            if (firstCar.MaxSpeed > secondCar.MaxSpeed)
            {
                Console.WriteLine(firstCar.Brand + " is the WINNER!!!");
            }
            else
            {
                Console.WriteLine(secondCar.Brand + " is the WINNER!!!");
            }
        }
    }
}