using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ltt_231230910_de01.Migrations
{
    /// <inheritdoc />
    public partial class v : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LttComputer",
                columns: table => new
                {
                    lttComId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lttComName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lttComPrice = table.Column<double>(type: "float", nullable: false),
                    lttComImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lttComStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LttComputer", x => x.lttComId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LttComputer");
        }
    }
}
