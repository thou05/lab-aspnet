namespace lab08_codefirst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
