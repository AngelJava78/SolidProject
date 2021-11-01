using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitution.Entities
{
    public class Printer
    {
        public void PrintDocument(Document document)
        {
            Console.WriteLine(document.Print());
        }

        public void PrintDeliveryGuide(DeliveryGuide guide)
        {
            Console.WriteLine(guide.Print());
        }
    }
}
