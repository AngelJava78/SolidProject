using LiskovSustitution.Entities;
using System;

namespace LiskovSustitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            Document invoice = new Invoice(66423, DateTime.Now);
            Document creditNote = new CreditNote(441, DateTime.Now);
            Document debitNote = new DebitNote(345, DateTime.Now);
            DeliveryGuide guide = new DeliveryGuide(3331, DateTime.Now, 10);

            printer.PrintDocument(invoice);
            printer.PrintDocument(creditNote);
            printer.PrintDocument(debitNote);
            printer.PrintDeliveryGuide(guide);
        }
    }
}
