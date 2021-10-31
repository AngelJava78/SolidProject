using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Entities
{
    public sealed class DebitNote : AccountingDocument
    {
        public override string GetDescription()
        {
            return $"DN-{Id.ToString().PadLeft(8, '0')}";
        }
    }
}
