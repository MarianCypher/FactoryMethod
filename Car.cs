using System;
using Racing;

namespace Automotive;
/* zawiera klase Car z modyfikatorami dostepu sealed oraz konstruktor z modyfikatorem dostepu internal
 */
sealed class Car
{
    //properties
    public string Brand { get; set; }
    public string Model { get; set; }
    public double MaxSpeed { get; set; }
    public int HorsePower { get; set; }
    //constructor TO-NE-NE
    //method
    internal static Car CreateCar(string brand, string model, double maxSpeed, int horsePower)
    {
        return new Car { Brand = brand, Model = model, MaxSpeed = maxSpeed, HorsePower = horsePower };
    }
}