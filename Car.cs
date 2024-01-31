using System;
using Racing;

namespace Automotive;
/* zawiera klase Car z modyfikatorami dostepu sealed oraz konstruktor z modyfikatorem dostepu internal
 */
sealed class Car
{
    //properties
    public string Brand { get; }
    public string Model { get; }
    public double MaxSpeed { get; }
    public int HorsePower { get; }
    //constructor
    internal Car(string brand, string model, double maxSpeed, int horsePower)
    {
        Brand = brand;
        Model = model;
        MaxSpeed = maxSpeed;
        HorsePower = horsePower;
    }
    //methods
}
