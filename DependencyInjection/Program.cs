using DependencyInjection.Entities;
using DependencyInjection.Framework;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice(73520, DateTime.Now, 167.98m);
            var creditNote = new CreditNote(68344, DateTime.Now, 421.99m);
            var guide = new DeliveryGuide(10823, DateTime.Now, 7);
            var electricalBill = new ElectricalBill(531.68m, "ABC-123");
            var phoneBill = new PhoneBill(599.99m, "57020091");

            var printer = new Printer();
            printer.Print(invoice);
            printer.Print(creditNote);
            printer.Print(guide);
            printer.Print(electricalBill);
            printer.Print(phoneBill);
        }
    }
}
