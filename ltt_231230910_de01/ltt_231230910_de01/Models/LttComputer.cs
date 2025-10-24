using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ltt_231230910_de01.Models
{
    [Table("LttComputer")]
    public class LttComputer
    {
        [Key]
        
        public int lttComId { get; set; }
        [Display(Name = "Tên sản phẩm")]
        public string lttComName { get; set; }

        [Range(100, 5000, ErrorMessage = "Price must be between 100 and 5000")]
        [Display(Name = "Giá")]
        public double lttComPrice { get; set; }
        

        [FileExtensions(Extensions = "jpg, png, gif, tiff")]
        [Display(Name = "Ảnh")]
        public string lttComImage { get; set; }
        [Display(Name = "Trạng thái")]
        public bool lttComStatus { get; set; }
    }
}
