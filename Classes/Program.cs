namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car dreamCar = new Car("Hyundai", "Accent", 2018);
            Car defaultCar = new Car();

            Console.WriteLine($"One of my dream cars is a {dreamCar.Year} {dreamCar.Make} {dreamCar.Model}.");
            Console.WriteLine($"However, I remember being in a {defaultCar.Year} {defaultCar.Make} {defaultCar.Model} when I was younger.");
        }
    }
}
