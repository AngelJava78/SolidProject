using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Entities
{
    public class ElectricalBill : TaxReceipt
    {
       public ElectricalBill(decimal amount, string paymentCode):base(amount)
        {
            PaymentCode = paymentCode;
        }
        public string PaymentCode { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Printing electrical bill: {PaymentCode}. Amount: {Amount:c}");
        }
    }
}
