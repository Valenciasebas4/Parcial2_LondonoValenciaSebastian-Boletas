using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Parcial2_LondonoValenciaSebastian.Migrations
{
    /// <inheritdoc />
    public partial class createnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsUsed = table.Column<bool>(type: "bit", nullable: true),
                    EntranceGate = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "EntranceGate", "IsUsed", "UseDate" },
                values: new object[,]
                {
                    { new Guid("24d3e3e2-74c4-425b-90f8-89ad29b0abbd"), null, false, null },
                    { new Guid("36c45637-b123-467e-a588-b96329972fe9"), null, false, null },
                    { new Guid("93f0d2f7-1206-4023-9aed-6eaba04bba16"), null, false, null },
                    { new Guid("b6aefdbb-682f-41fa-9094-bfc700334190"), null, false, null },
                    { new Guid("ddd3fbdb-fb96-42c6-8fca-fbce4384feb3"), null, false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
