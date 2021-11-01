using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitution.Entities
{
    public class DeliveryGuide : Document
    {
        public DeliveryGuide(int id, DateTime date, int quantity) : base(id, date)
        {
            Quantity = quantity;
            acronym = "DG";
        }

        public int Quantity { get; set; }
        public override string GetDescription()
        {
            return $"{acronym}. Id: {Id}. Fecha: {Date:dd-MM-yyyy hh:mm:ss} with {Quantity} items.";
        }

    }
}
