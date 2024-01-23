namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "chevy";
            car1.Model = "1LE";
            car1.Year = "2019";
            Console.WriteLine($"my car is a {car1.Make} {car1.Model} {car1.Year}");
        }
        
    }
}
