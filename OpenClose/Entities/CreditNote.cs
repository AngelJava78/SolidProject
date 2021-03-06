using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Entities
{
    public sealed class CreditNote : AccountingDocument
    {
        public override string GetDescription()
        {
            return $"CN-{Id.ToString().PadLeft(5, '0')}";
        }
    }
}
