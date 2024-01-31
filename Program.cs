using Automotive;
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
            Car ravka = new Car("Toyota", "Rav4", 240.5, 320);

            Console.WriteLine(ravka.Brand);
        }
    }
}