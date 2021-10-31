using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Entities
{
    public sealed class Invoice : AccountingDocument
    {
        public override string GetDescription()
        {
            return  $"I-{Id.ToString().PadLeft(10, '0')}";
        }
    }
}
