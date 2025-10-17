using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab9_codefirst.Models
{
    [Table("LoaiSanPham")]
    public class LoaiSanPham
    {
        [Key]
        public int Id { get; set; }
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public bool TrangThai { get; set; }
        public virtual List<SanPham> SanPhams { get; set; }
    }
}
