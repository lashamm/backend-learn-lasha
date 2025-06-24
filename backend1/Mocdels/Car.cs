using backend1.Enums;

namespace backend1.Mocdels
{
    internal class Car
    {
        private decimal _price;
        private DateTime _date;
        public CarBrand Brand { get; init; }
        public string Model { get; init; }
        public DateTime Year {
            get
            {
                return _date;
            }
            init {
                if (DateTime.Now < value)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _date = value;
                }
            } }
        public decimal Price { get
            {
                return _price;
            } set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price cannot be negative");
                }
                else
                {
                    _price = value;
                }
            } }
        public string Color { get; set; }
        public string Country { get; init; }



        public Car() { }

        public Car(
            CarBrand brand,
            string model,
            DateTime year,
            int price,
            string color,
            string country
            )
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Color = color;
            Country = country;
        }

        public void Print() {
            Console.WriteLine($"{Brand}, {Model} " +
                $"\nyear: {Year}, " +
                $"\nprice: {Price}$, " +
                $"\ncolor: {Color}, " +
                $"\ncountry: {Country} "
                );
        }
    }
}
