using System;
using System.Collections.Generic;
namespace StoreModels
{
    public class Order
    {
        private decimal OrderTotal { get; set; }
        public int? OrderID { get; set; }
        public int? LocationID { get; set; }
        public int? CustomerID { get; set; }
        private List<Product> OrderItems { get; set; }
    }
}
