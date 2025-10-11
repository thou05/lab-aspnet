using Microsoft.EntityFrameworkCore;

namespace lab9_codefirst.Models
{
    public class ShoppingCartDBContext : DbContext
    {
        public ShoppingCartDBContext(DbContextOptions<ShoppingCartDBContext> options) :
            base(options)
        { }

        public DbSet<QuanTri> QuanTris { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHD> ChiTietHDs { get; set; }
    }
}
