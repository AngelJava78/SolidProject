using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Entities
{
    public class ElectronicInvoice : Document
    {
        public ElectronicInvoice(int id, DateTime date) : base(id, date)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"Printing by email this electronic invoice: {Id}. Date: {Date:dd-MM-yyyy hh:mm:ss}");
        }

        public override void Send()
        {
            Console.WriteLine($"Sending by email this electronic invoice: {Id}. Date: {Date:dd-MM-yyyy hh:mm:ss}");
        }
    }
}
