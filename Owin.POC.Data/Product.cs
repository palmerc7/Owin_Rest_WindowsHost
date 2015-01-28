using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.POC.Data
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public decimal RetailPrice { get; set; }
        public int QtyInStock { get; set; }
    }
}
