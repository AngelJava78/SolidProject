using DependencyInjection.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Entities
{
    public class CollectionDocument : IPrintable
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public void Print()
        {
            Console.WriteLine($"Printing collection document: {Id}. Date: {Date:dd-MM-yyyy hh:mm:ss}. Amount: {Amount:c}");
        }
    }
}
