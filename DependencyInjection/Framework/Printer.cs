using DependencyInjection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Framework
{
    public class Printer
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine($"Printing invoice: {invoice.Id}. Date: {invoice.Date:dd-MM-yyyy hh:mm:ss}. Total: {invoice.GetTotal():c}");
        }
        public void Print(CreditNote credit)
        {
            Console.WriteLine($"Printing credit note: {credit.Id}. Date: {credit.Date:dd-MM-yyyy hh:mm:ss}. Total: {credit.GetTotal():c}");
        }
        public void Print(ElectricalBill bill)
        {
            Console.WriteLine($"Printing electrical bill: {bill.PaymentCode}. Amount: {bill.Amount:c}");
        }
        public void Print(PhoneBill bill)
        {
            Console.WriteLine($"Printing phone bill: {bill.PaymentCodeBar}. Amount: {bill.Amount:c}");
        }
        public void Print(Payslip payslip)
        {
            Console.WriteLine($"Printing payslip: {payslip.EmployeeId}. Amount: {payslip.Total:c}");
        }
        public void Print(DeliveryGuide guide)
        {
            Console.WriteLine($"Printing delivery guide: {guide.Id}. Date: {guide.Date:dd-MM-yyyy hh:mm:ss}. Quantity: {guide.Quantity}");
        }


    }
}
