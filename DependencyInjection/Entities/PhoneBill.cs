using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Entities
{
    public class PhoneBill : TaxReceipt
    {
        public PhoneBill(decimal amount, string paymentCode): base(amount)
        {
            PaymentCodeBar = paymentCode;
        }
        public string PaymentCodeBar { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Printing phone bill: {PaymentCodeBar}. Amount: {Amount:c}");
        }
    }
}
