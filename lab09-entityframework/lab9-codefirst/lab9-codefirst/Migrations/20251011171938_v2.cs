using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab9_codefirst.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_LoaiSanPham_LoaiSanPhamId",
                table: "SanPhams");

            migrationBuilder.AlterColumn<int>(
                name: "LoaiSanPhamId",
                table: "SanPhams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_LoaiSanPham_LoaiSanPhamId",
                table: "SanPhams",
                column: "LoaiSanPhamId",
                principalTable: "LoaiSanPham",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_LoaiSanPham_LoaiSanPhamId",
                table: "SanPhams");

            migrationBuilder.AlterColumn<int>(
                name: "LoaiSanPhamId",
                table: "SanPhams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_LoaiSanPham_LoaiSanPhamId",
                table: "SanPhams",
                column: "LoaiSanPhamId",
                principalTable: "LoaiSanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
