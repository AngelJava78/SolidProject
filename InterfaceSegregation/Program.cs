using InterfaceSegregation.Entities;
using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new ElectronicInvoice(73520, DateTime.Now);
            var receipt = new SalesReceipt(68344, DateTime.Now);
            try
            {
                invoice.Print();
                invoice.Send();

                receipt.Print();
                receipt.Send();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.GetType()}");
                Console.WriteLine($"Message:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace:");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
