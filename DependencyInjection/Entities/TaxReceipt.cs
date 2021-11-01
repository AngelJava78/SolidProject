using DependencyInjection.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Entities
{
    public abstract class TaxReceipt
    {
        protected TaxReceipt(decimal amount)
        {
            Amount = amount;
        }
        public decimal Amount { get; set; }
    }
}
