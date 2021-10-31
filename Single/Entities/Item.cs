using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single.Entities
{
    public class Item
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int DiscountRate { get; set; }
        public decimal GetSubtotal()
        {
            return (Quantity * Product.Price) - (Quantity * Product.Price * DiscountRate / 100);
        }
    }
}
