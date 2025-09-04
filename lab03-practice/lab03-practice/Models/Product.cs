namespace lab03_practice.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
         
        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/images/cook.png" },
                new Product() { Id = 2, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/images/cook.png" },
                new Product() { Id = 3, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/images/cook.png" }
                
            };
            return products;
        }
    }
}
