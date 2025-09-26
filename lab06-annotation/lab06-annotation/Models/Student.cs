using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using Octokit;
using System.ComponentModel.DataAnnotations;

namespace lab06_annotation.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải từ 4 đến 100 ký tự")]
        [Display(Name = "Họ và tên")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email phải được nhập")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail\.com$",
                            ErrorMessage = "Email phải có đuôi @gmail.com")]
        public string? Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Ngành học không được để trống")]
        public Branch? Branch { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống")]
        public Gender? Gender { get; set; }

        public bool IsRegular { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Ngày sinh phải được nhập")]
        //[Range(typeof(DateTime), "1963-01-01", "2005-12-31")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Điểm phải được nhập")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng 0.0 đến 10.0")]
        [Display(Name = "Điểm")]
        public double Score { get; set; }
    }
}
