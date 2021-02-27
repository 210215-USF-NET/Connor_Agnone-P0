namespace StoreModels
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int? ProductID { get; set; }
        public override string ToString() => $"Product Details:\n\tName: {this.ProductName}\n\tPrice: ${this.ProductPrice}";
    }
}