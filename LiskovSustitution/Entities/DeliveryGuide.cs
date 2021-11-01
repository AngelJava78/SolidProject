using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitution.Entities
{
    public class DeliveryGuide 
    {
        public DeliveryGuide(int id, DateTime date, int quantity) 
        {
            Id = id;
            Date = date;
            Quantity = quantity;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string GetDescription()
        {
            return $"Delivery guide: Id: {Id}. Fecha: {Date:dd-MM-yyyy hh:mm:ss} with {Quantity} items.";
        }

        public string Print()
        {
            return $"Printing: {GetDescription()}";
        }
    }
}
