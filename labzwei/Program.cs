using System;

namespace Lab2_1
{
    //Створити клас із ім'ям Address
    class Address
    {
        //У тілі класу потрібно створити поля: index, country, city, street, house, apartment.
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

    }
    class Program
    {
        static void Main()
        {
            Address address = new Address
            {
                Index = "03117",
                Country = "Ukraine",
                City = "Kyiv",
                Street = "Prospekt Peremohy",
                House = "67B",
                Apartment = "25"
            };
            // Виведіть на екран значення полів, що описують адресу.
            Console.WriteLine($"Street: {address.Street}");
            Console.WriteLine($"House: {address.House}");
            Console.WriteLine($"Apartment: {address.Apartment}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"Country: {address.Country}");
            Console.WriteLine($"Index: {address.Index}");

            Console.ReadKey();
        }
    }
}
