using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab9_codefirst.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }

        public string HoTenKH { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayDangKy { get; set; }
        public bool TrangThai { get; set; }

    }
}
