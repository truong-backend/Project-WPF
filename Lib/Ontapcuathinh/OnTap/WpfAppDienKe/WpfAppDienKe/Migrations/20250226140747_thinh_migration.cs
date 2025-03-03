using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfAppDienKe.Migrations
{
    public partial class thinh_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "khachhang",
                columns: table => new
                {
                    makh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tenkh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    diachi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachhang", x => x.makh);
                });

            migrationBuilder.CreateTable(
                name: "kysudung",
                columns: table => new
                {
                    maky = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tungay = table.Column<DateTime>(type: "datetime", nullable: true),
                    denngay = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kysudung", x => x.maky);
                });

            migrationBuilder.CreateTable(
                name: "nhanvien",
                columns: table => new
                {
                    manv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tennv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dienthoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    diachi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanvien", x => x.manv);
                });

            migrationBuilder.CreateTable(
                name: "dienke",
                columns: table => new
                {
                    madk = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ngaydk = table.Column<DateTime>(type: "datetime", nullable: true),
                    makh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dienke", x => x.madk);
                    table.ForeignKey(
                        name: "FK_dienke_khachhang",
                        column: x => x.makh,
                        principalTable: "khachhang",
                        principalColumn: "makh");
                });

            migrationBuilder.CreateTable(
                name: "sudungdien",
                columns: table => new
                {
                    maky = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    madk = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    chisocu = table.Column<int>(type: "int", nullable: true),
                    chisomoi = table.Column<int>(type: "int", nullable: true),
                    manv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sudungdien", x => new { x.maky, x.madk });
                    table.ForeignKey(
                        name: "FK_sudungdien_dienke",
                        column: x => x.madk,
                        principalTable: "dienke",
                        principalColumn: "madk");
                    table.ForeignKey(
                        name: "FK_sudungdien_kysudung",
                        column: x => x.maky,
                        principalTable: "kysudung",
                        principalColumn: "maky");
                    table.ForeignKey(
                        name: "FK_sudungdien_nhanvien",
                        column: x => x.manv,
                        principalTable: "nhanvien",
                        principalColumn: "manv");
                });

            migrationBuilder.CreateIndex(
                name: "IX_dienke_makh",
                table: "dienke",
                column: "makh");

            migrationBuilder.CreateIndex(
                name: "IX_sudungdien_madk",
                table: "sudungdien",
                column: "madk");

            migrationBuilder.CreateIndex(
                name: "IX_sudungdien_manv",
                table: "sudungdien",
                column: "manv");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sudungdien");

            migrationBuilder.DropTable(
                name: "dienke");

            migrationBuilder.DropTable(
                name: "kysudung");

            migrationBuilder.DropTable(
                name: "nhanvien");

            migrationBuilder.DropTable(
                name: "khachhang");
        }
    }
}
