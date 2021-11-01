using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitution.Entities
{
    public class DebitNote : Document
    {
        public DebitNote(int id, DateTime date): base(id, date)
        {
            acronym = "DN";
        }
    }
}
