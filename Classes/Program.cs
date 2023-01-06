namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var currentCar = new Car()
            {
                Make = "Ford",
                Model = "Focus",
                Year = 2010
            };

            Console.WriteLine($" My current car is a {currentCar.Year} {currentCar.Make} {currentCar.Model}.");


        }
    }
}
