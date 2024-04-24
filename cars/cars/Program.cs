namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double Quantity = double.Parse(Console.ReadLine());
            double Consumption = double.Parse(Console.ReadLine());

            Car FirstCar = new Car();
            Console.WriteLine($"{FirstCar.Make} {FirstCar.Model} {FirstCar.Year} {FirstCar.Quantity} {FirstCar.Consumption}");

            Car SecondCar = new Car(make, model, year);
            Console.WriteLine($"{SecondCar.Make} {SecondCar.Model} {SecondCar.Year} {SecondCar.Quantity} {SecondCar.Consumption}");

            Car ThirdCar = new Car(make, model, year, Quantity, Consumption);
            Console.WriteLine($"{ThirdCar.Make} {ThirdCar.Model} {ThirdCar.Year} {ThirdCar.Quantity} {ThirdCar.Consumption}");


        }
    }
}
