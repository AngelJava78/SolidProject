using LiskovSustitution.Entities;
using System;

namespace LiskovSustitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var invoice = new Invoice(66423, DateTime.Now);
            var creditNote = new CreditNote(441, DateTime.Now);
            var guide = new DeliveryGuide(3331, DateTime.Now, 10);

            printer.PrintInvoice(invoice);
            printer.PrintCreditNote(creditNote);
            printer.PrintDeliveryGuide(guide);
        }
    }
}
