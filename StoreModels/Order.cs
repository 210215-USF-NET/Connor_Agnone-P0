using System;
using System.Collections.Generic;
namespace StoreModels
{
    public class Order
    {
        private float OrderTotal { get; set; }
        private List<Inventory> OrderItems { get; set; }
    }
}
