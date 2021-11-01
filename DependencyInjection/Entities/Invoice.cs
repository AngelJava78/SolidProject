using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Entities
{
    public class Invoice : AccountingDocument
    {
        public Invoice(int id, DateTime date, decimal amount) : base(id, date, amount)
        {
            acronym = "I";
        }

        public override decimal GetTotal()
        {
            return Amount * 1.21m;
        }
    }
}
