using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitution.Entities
{
    public class Printer
    {
        public void PrintDeliveryGuide(DeliveryGuide guide)
        {
            Console.WriteLine(guide.Print());
        }

        public void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine(invoice.Print());
        }

        public void PrintCreditNote(CreditNote creditNote)
        {
            Console.WriteLine(creditNote.Print());
        }
    }
}
