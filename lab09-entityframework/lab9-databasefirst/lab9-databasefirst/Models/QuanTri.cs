using System;
using System.Collections.Generic;

namespace lab9_databasefirst.Models;

public partial class QuanTri
{
    public int Id { get; set; }

    public string TaiKhoan { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string? TrangThai { get; set; }
}
