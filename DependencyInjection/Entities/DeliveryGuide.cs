using DependencyInjection.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Entities
{
    public class DeliveryGuide: IPrintable
    {
        public DeliveryGuide(int id, DateTime date, int quantity)
        {
            Id = id;
            Date = date;
            Quantity = quantity;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

        public void Print()
        {
            Console.WriteLine($"Printing delivery guide: {Id}. Date: {Date:dd-MM-yyyy hh:mm:ss}. Quantity: {Quantity}");
        }
    }
}
