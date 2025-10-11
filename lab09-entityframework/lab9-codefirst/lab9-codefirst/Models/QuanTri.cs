using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab9_codefirst.Models
{
    [Table("QuanTri")]
    public class QuanTri
    {
        [Key]
        public int Id { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
    }
}
