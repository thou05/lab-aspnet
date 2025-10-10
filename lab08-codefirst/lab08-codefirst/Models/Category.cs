using System.ComponentModel.DataAnnotations;

namespace lab08_codefirst.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string NameVN { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
