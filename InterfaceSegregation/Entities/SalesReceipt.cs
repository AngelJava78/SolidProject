using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Entities
{
    public class SalesReceipt : Document
    {
        public SalesReceipt(int id, DateTime date) : base(id, date)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"Printing by email this sales receipt: {Id}. Date: {Date:dd-MM-yyyy hh:mm:ss}");
        }
    }
}
