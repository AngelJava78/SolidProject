using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Entities
{
    public class AccountingDocument
    {

        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int Id { get; set; }
        public AccountingDocumentType AccountingDocumentType { get; set; }
        public string GetDescription()
        {
            var description = string.Empty;
            switch (AccountingDocumentType)
            {
                case AccountingDocumentType.Invoice:
                    description = $"I-{Id.ToString().PadLeft(10,'0')}";
                    break;
                case AccountingDocumentType.CreditNote:
                    description = $"CN-{Id.ToString().PadLeft(5, '0')}";
                    break;
                case AccountingDocumentType.DebitNote:
                    description = $"DN-{Id.ToString().PadLeft(8, '0')}";
                    break;
                default:
                    description = "N/D";
                    break;

            }
            return description;
        }
    }
}
