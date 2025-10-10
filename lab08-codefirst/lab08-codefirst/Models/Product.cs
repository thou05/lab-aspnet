namespace lab08_codefirst.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Image { get; set; }
        public DateTime ProductDate { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
