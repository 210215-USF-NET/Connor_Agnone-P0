using System.Collections.Generic;
namespace StoreModels
{
    public class Location
    {
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public List<Inventory> Inventory { get; set; }
        public int? LocationID { get; set; }
        public override string ToString() => $"Location Details:\n\tName: {this.LocationName}\n\tAddress: {this.LocationAddress}";
    }
}