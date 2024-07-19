namespace ManagementProduct.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int StockQuantity { get; private set; }
        public decimal CostPrice { get; private set; }
        public decimal SalePrice { get; private set; }
        public string Notes { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Product(string name, int stockQuantity, decimal costPrice, decimal salePrice, string notes)
        {
            Name = name;
            StockQuantity = stockQuantity;
            CostPrice = costPrice;
            SalePrice = salePrice;
            Notes = notes;
            CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);
        }

        public void UpdateProduct(string name, int stockQuantity, decimal costPrice, decimal salePrice, string notes)
        {
            Name = name;
            StockQuantity = stockQuantity;
            CostPrice = costPrice;
            SalePrice = salePrice;
            Notes = notes;
        }
    }

}
