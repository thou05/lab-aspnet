using System.ComponentModel.DataAnnotations;

namespace lab9_codefirst.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string HinhAnh { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; } = decimal.Zero;
        public string TrangThai { get; set; }
        public int MaLoai { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual List<ChiTietHD> ChiTietHDs { get; set; }
    }
}
