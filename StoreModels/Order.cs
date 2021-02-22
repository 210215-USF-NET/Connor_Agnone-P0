using System;

namespace StoreModels
{
    public class Order
    {
        private Customer OrderCustomer{ get; set; } 
        private float OrderTotal { get; set; }
        private Location OrderLocation { get; set; }

    }
}
