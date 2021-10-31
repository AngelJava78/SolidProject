using OpenClose.Entities;
using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountingDocument invoice = new Invoice
            {
                Id = 9721,
                Amount = 1536.45m,
                Date = DateTime.Now,
                //AccountingDocumentType = AccountingDocumentType.Invoice
            };
            AccountingDocument creditNote = new CreditNote
            {
                Id = 9812,
                Amount = 4917.99m,
                Date = DateTime.Now,
                //AccountingDocumentType = AccountingDocumentType.CreditNote
            };
            AccountingDocument debitNote = new DebitNote
            {
                Id = 7736,
                Amount = 4917.99m,
                Date = DateTime.Now,
                //AccountingDocumentType = AccountingDocumentType.DebitNote
            };
            ShowDocument(invoice);
            ShowDocument(creditNote);
            ShowDocument(debitNote);
        }

        public static void ShowDocument(AccountingDocument document)
        {
            Console.WriteLine("Invoice data");
            Console.WriteLine($"Id: {document.GetDescription()}");
            Console.WriteLine($"Amount: {document.Amount:c}");
            Console.WriteLine($"Date: {document.Date.ToString("dd-MM-yyyy hh:mm:ss")}");
            Console.WriteLine($"Type: {document.GetType()}");
            Console.WriteLine("----------------------------");
        }
    }
}
