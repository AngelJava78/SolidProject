using DependencyInjection.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Entities
{
    public abstract class AccountingDocument 
    {
        protected string acronym;
        protected AccountingDocument(int id, DateTime date, decimal amount)
        {
            Id = id;
            Date = date;
            Amount = amount;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public abstract decimal GetTotal();

    }
}
