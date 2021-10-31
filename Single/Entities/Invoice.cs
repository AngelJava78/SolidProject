using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public List<Item> Items { get; set; }
        public decimal GetTotal()
        {
            var total = 0.0m;
            foreach (var item in Items)
            {
                total += item.GetSubtotal();
            }
            return total;
        }
    }
}
