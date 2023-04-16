using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Parcial2_LondonoValenciaSebastian.Migrations
{
    /// <inheritdoc />
    public partial class createnewregister : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("24d3e3e2-74c4-425b-90f8-89ad29b0abbd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("36c45637-b123-467e-a588-b96329972fe9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("93f0d2f7-1206-4023-9aed-6eaba04bba16"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("b6aefdbb-682f-41fa-9094-bfc700334190"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("ddd3fbdb-fb96-42c6-8fca-fbce4384feb3"));

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "EntranceGate", "IsUsed", "UseDate" },
                values: new object[,]
                {
                    { new Guid("02553a4b-41fd-4c7f-ad45-c76d521c70f1"), null, false, null },
                    { new Guid("0297a28c-c453-450a-b8a7-68a1ffa78ffb"), null, false, null },
                    { new Guid("03a0500b-f7c4-4f35-b376-9edce4c5f146"), null, false, null },
                    { new Guid("043fb24c-0434-4f34-9c2e-fa59a3ff4591"), null, false, null },
                    { new Guid("06fbfc7d-b985-490c-9a23-3c19f13391d0"), null, false, null },
                    { new Guid("0b9bef11-5b01-4306-8a05-375d21c3ae35"), null, false, null },
                    { new Guid("19914aca-f321-4096-b493-cd42d8e4f366"), null, false, null },
                    { new Guid("33fe6e88-8250-40f0-9eb0-3bfa22e55ade"), null, false, null },
                    { new Guid("3be11a97-5e98-46eb-96e8-6bfabb9a8d90"), null, false, null },
                    { new Guid("42eb9221-d1ae-45f9-b1b6-7c19c5c0220a"), null, false, null },
                    { new Guid("479a3a38-fa7b-42bc-ba28-8cadefc05b35"), null, false, null },
                    { new Guid("4b042054-a1ab-4378-ab27-fe7692f7e80e"), null, false, null },
                    { new Guid("5dec9921-3a91-4c57-b0e6-e8c745590e38"), null, false, null },
                    { new Guid("5fe6d71f-c21b-498f-a989-271a824ba1a2"), null, false, null },
                    { new Guid("788b2abf-34e6-4fdb-83f9-0428211ae857"), null, false, null },
                    { new Guid("8f7fdc69-af66-4d2d-8ef1-6d4c984c35c4"), null, false, null },
                    { new Guid("9657eec4-ed56-4dad-ae3d-ceec2ce7c2f1"), null, false, null },
                    { new Guid("980e2529-c82b-48f4-a50e-a11540cca3c9"), null, false, null },
                    { new Guid("9f31afd5-550b-4f79-b874-d9ea10fb4964"), null, false, null },
                    { new Guid("a07c45c8-f523-4ff5-baeb-d1b2e36d387a"), null, false, null },
                    { new Guid("a5c43eab-43c8-4fc4-bc76-d150b2e59489"), null, false, null },
                    { new Guid("a85716fd-44cc-4d0f-a306-8539d3d277fc"), null, false, null },
                    { new Guid("abd2687f-ba6f-4c54-b32e-f196fc288748"), null, false, null },
                    { new Guid("b70c1de8-9b7d-47ac-9ffd-e91f01d0d03b"), null, false, null },
                    { new Guid("b8c8e5ad-f3ab-4ef8-8ebf-6c7cba7cf4b6"), null, false, null },
                    { new Guid("bd0a013c-7049-40f5-8f26-c53d4063ae42"), null, false, null },
                    { new Guid("dcff3ffc-a187-43c3-b399-b826a348f515"), null, false, null },
                    { new Guid("dd16bed7-d68f-4636-b21a-2464aaeb2700"), null, false, null },
                    { new Guid("e2214ab4-80ee-477a-b45f-a13c0c126aa2"), null, false, null },
                    { new Guid("fd55ac2e-74bc-4ebc-8b82-18f59e2c867f"), null, false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("02553a4b-41fd-4c7f-ad45-c76d521c70f1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("0297a28c-c453-450a-b8a7-68a1ffa78ffb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("03a0500b-f7c4-4f35-b376-9edce4c5f146"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("043fb24c-0434-4f34-9c2e-fa59a3ff4591"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("06fbfc7d-b985-490c-9a23-3c19f13391d0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("0b9bef11-5b01-4306-8a05-375d21c3ae35"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("19914aca-f321-4096-b493-cd42d8e4f366"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("33fe6e88-8250-40f0-9eb0-3bfa22e55ade"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("3be11a97-5e98-46eb-96e8-6bfabb9a8d90"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("42eb9221-d1ae-45f9-b1b6-7c19c5c0220a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("479a3a38-fa7b-42bc-ba28-8cadefc05b35"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("4b042054-a1ab-4378-ab27-fe7692f7e80e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("5dec9921-3a91-4c57-b0e6-e8c745590e38"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("5fe6d71f-c21b-498f-a989-271a824ba1a2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("788b2abf-34e6-4fdb-83f9-0428211ae857"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("8f7fdc69-af66-4d2d-8ef1-6d4c984c35c4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("9657eec4-ed56-4dad-ae3d-ceec2ce7c2f1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("980e2529-c82b-48f4-a50e-a11540cca3c9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("9f31afd5-550b-4f79-b874-d9ea10fb4964"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("a07c45c8-f523-4ff5-baeb-d1b2e36d387a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("a5c43eab-43c8-4fc4-bc76-d150b2e59489"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("a85716fd-44cc-4d0f-a306-8539d3d277fc"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("abd2687f-ba6f-4c54-b32e-f196fc288748"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("b70c1de8-9b7d-47ac-9ffd-e91f01d0d03b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("b8c8e5ad-f3ab-4ef8-8ebf-6c7cba7cf4b6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("bd0a013c-7049-40f5-8f26-c53d4063ae42"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("dcff3ffc-a187-43c3-b399-b826a348f515"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("dd16bed7-d68f-4636-b21a-2464aaeb2700"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("e2214ab4-80ee-477a-b45f-a13c0c126aa2"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("fd55ac2e-74bc-4ebc-8b82-18f59e2c867f"));

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
    }
}
