using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Entities
{
    public abstract class AccountingDocument
    {

        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int Id { get; set; }
        //public AccountingDocumentType AccountingDocumentType { get; set; }
        public abstract string GetDescription();
    }
}
