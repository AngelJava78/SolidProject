using Single.Entities;
using System;
using System.Collections.Generic;

namespace Single
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                Name = "Angel",
                LastName = "Javier"
            };
            var cheese = new Product
            {
                Description = "Cheese",
                Price = 90
            };
            var rice = new Product
            {
                Description = "Rice",
                Price = 30
            };
            var beans = new Product
            {
                Description = "Beans",
                Price = 48
            };
            var invoice = new Invoice
            {
                Id = 1,
                Date = DateTime.Now,
                Customer = customer,
                Items = new List<Item>
                {
                    new Item
                    {
                        Product = cheese,
                        Quantity = 5,
                        DiscountRate= 5
                    },
                    new Item
                    {
                        Product = rice,
                        Quantity= 1,
                        DiscountRate= 10
                    },
                    new Item
                    {
                        Product = beans,
                        Quantity= 2,
                        DiscountRate = 15
                    }
                }
            };
            Console.WriteLine("Invoice data");
            Console.WriteLine($"Id: {invoice.Id}");
            Console.WriteLine($"Datetime: {invoice.Date.ToString("dd-MM-yyyy hh:mm:ss")}");
            Console.WriteLine($"Customer: {invoice.Customer.Name} {invoice.Customer.LastName}");
            Console.WriteLine($"Total: {invoice.GetTotal():c}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
