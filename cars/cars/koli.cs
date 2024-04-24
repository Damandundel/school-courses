using System;
namespace car
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double quantity;
        private double consumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Quantity { get; set; }
        public double Consumption { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.Quantity = 200;
            this.Consumption = 200;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double Quantity, double Consumption)
            : this(make, model, year)
        {
            this.Quantity = Quantity;
            this.Consumption = Consumption;
        }
    }
}


