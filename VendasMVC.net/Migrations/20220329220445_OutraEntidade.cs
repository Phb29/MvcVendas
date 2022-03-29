using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendasMVC.net.Migrations
{
    public partial class OutraEntidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departamento",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nascimentodata = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalarioBase = table.Column<double>(type: "float", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendedor_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroVenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    montante = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroVenda_Vendedor_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistroVenda_VendedorId",
                table: "RegistroVenda",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroVenda");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departamento",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
