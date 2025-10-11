using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab9_codefirst.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }
        public int MaKH { get; set; }

        public DateTime NgayHoaDon { get; set; }
        public DateTime NgayNhan { get; set; }
        public string HoTenKH { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string TongTriGia { get; set; }
        public bool TrangThai { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual List<ChiTietHD> ChiTietHDs { get; set; }
    }
}
