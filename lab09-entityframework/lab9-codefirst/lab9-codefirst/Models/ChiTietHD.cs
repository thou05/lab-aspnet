using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab9_codefirst.Models
{
    [Table("ChiTietHD")]
    public class ChiTietHD
    {
        [Key]
        public int Id { get; set; }
        public int MaHoaDon { get; set; }
        public int MaSP { get; set; }
        
        public int SoLuongMua { get; set; }
        public decimal DonGiaMua { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
