using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemo.Core.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("0440a7c3-d4d4-4e61-a429-d77f88e1baaf"), "Isabella Rodriguez", "123-456-7897" },
                    { new Guid("0a0fe0b9-4ab0-461b-a742-802f1ef4aec6"), "Emma Lee", "123-456-7801" },
                    { new Guid("2c5fe80d-e82d-4f00-9c9d-34fa5d02a5ec"), "Ava Hernandez", "123-456-7899" },
                    { new Guid("386bc9f2-f6f6-484c-8c3b-2ed671b99ef4"), "Michael Brown", "123-456-7892" },
                    { new Guid("3a6e36b4-70eb-4c78-99e6-2bb54fffe191"), "Olivia Davis", "123-456-7895" },
                    { new Guid("3c591b9d-ddfa-471d-b653-e4dfeedd51d7"), "Liam Garcia", "123-456-7896" },
                    { new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8"), "Emily Johnson", "123-456-7891" },
                    { new Guid("57e69e95-0e9f-4727-845f-37e5c0233574"), "Mia Lewis", "123-456-7803" },
                    { new Guid("8fd65b94-2805-41d5-94e1-6403174b20ce"), "John Smith", "123-456-7890" },
                    { new Guid("95075645-37c2-401f-a879-c5e223a0447b"), "Sebastian Kim", "123-456-7800" },
                    { new Guid("976aad69-027e-4112-974b-5d37385e458d"), "Matthew Jones", "123-456-7894" },
                    { new Guid("a114403b-629f-4b69-b1dd-cab3308875bc"), "Lucas Martinez", "123-456-7898" },
                    { new Guid("b399e175-0b33-438e-9c08-b4fa4a2e5c59"), "Sophia Williams", "123-456-7893" },
                    { new Guid("bbdb6ba4-9e3b-43c6-829f-bb3a2723db92"), "William Clark", "123-456-7802" },
                    { new Guid("e760ee67-3140-47c2-8634-946fdf44a873"), "Henry Young", "123-456-7804" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Amount", "CustomerId", "OrderNumber" },
                values: new object[,]
                {
                    { new Guid("01f08be3-d92f-4dcc-8b8a-b376a9486573"), 100.50m, new Guid("a114403b-629f-4b69-b1dd-cab3308875bc"), 19 },
                    { new Guid("04de6182-c351-460c-9760-43e077a7f31d"), 200.50m, new Guid("386bc9f2-f6f6-484c-8c3b-2ed671b99ef4"), 9 },
                    { new Guid("0ccb12cc-e43c-4c3b-b334-ed3360bf74e8"), 100.50m, new Guid("0440a7c3-d4d4-4e61-a429-d77f88e1baaf"), 17 },
                    { new Guid("1dfbf4ff-c3d4-44f4-a21d-d85d754ecea0"), 100.50m, new Guid("57e69e95-0e9f-4727-845f-37e5c0233574"), 32 },
                    { new Guid("20b8a648-ccf4-4726-8579-47b2deac0aaa"), 200.50m, new Guid("bbdb6ba4-9e3b-43c6-829f-bb3a2723db92"), 30 },
                    { new Guid("33543d58-9e6f-40bb-a85e-74aa7c8eb9cb"), 200.50m, new Guid("0440a7c3-d4d4-4e61-a429-d77f88e1baaf"), 16 },
                    { new Guid("343154f4-26fc-4a1a-b647-cb7677c7e974"), 100.50m, new Guid("a114403b-629f-4b69-b1dd-cab3308875bc"), 21 },
                    { new Guid("3afc0387-1d03-43a1-b9c8-eb757011c68d"), 200.50m, new Guid("0a0fe0b9-4ab0-461b-a742-802f1ef4aec6"), 27 },
                    { new Guid("40db7b6d-7bd1-43c6-9e6e-e8d168bfff8f"), 200.50m, new Guid("3c591b9d-ddfa-471d-b653-e4dfeedd51d7"), 15 },
                    { new Guid("43066a60-68e4-4ac9-b8f3-7a55e48549c1"), 100.50m, new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8"), 3 },
                    { new Guid("45637736-2e95-4859-9a24-d0e77adc26f5"), 200.50m, new Guid("0a0fe0b9-4ab0-461b-a742-802f1ef4aec6"), 28 },
                    { new Guid("49c29393-1b1b-41f2-8735-e3039322c93f"), 200.50m, new Guid("57e69e95-0e9f-4727-845f-37e5c0233574"), 31 },
                    { new Guid("514bca15-7964-4bf6-85be-57f43796be31"), 100.50m, new Guid("3c591b9d-ddfa-471d-b653-e4dfeedd51d7"), 14 },
                    { new Guid("5ce02d9c-0309-423a-ba1d-4a4afb7c6543"), 200.50m, new Guid("976aad69-027e-4112-974b-5d37385e458d"), 11 },
                    { new Guid("7d278dad-b049-48b8-87e5-c5e604130b2d"), 100.50m, new Guid("386bc9f2-f6f6-484c-8c3b-2ed671b99ef4"), 8 },
                    { new Guid("7f66b17e-a23d-4848-ba90-9d174261368a"), 100.50m, new Guid("976aad69-027e-4112-974b-5d37385e458d"), 10 },
                    { new Guid("8c8f3c28-ba21-46e8-af60-dbbf0faaa8ca"), 200.50m, new Guid("a114403b-629f-4b69-b1dd-cab3308875bc"), 23 },
                    { new Guid("993fe5bd-cd1e-4794-ba9f-8f28e23056cc"), 200.50m, new Guid("386bc9f2-f6f6-484c-8c3b-2ed671b99ef4"), 7 },
                    { new Guid("9b91223d-0b9a-4ecf-acf6-f6959a43bfa1"), 200.50m, new Guid("3c591b9d-ddfa-471d-b653-e4dfeedd51d7"), 13 },
                    { new Guid("9ed6bcac-a364-4724-838b-14c99017b64e"), 200.50m, new Guid("bbdb6ba4-9e3b-43c6-829f-bb3a2723db92"), 29 },
                    { new Guid("ae2aa7de-47f3-4fac-ac78-2d2252bc9e3f"), 100.50m, new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8"), 5 },
                    { new Guid("b40f6572-1915-4ac6-81b4-2e2983f6b6b0"), 200.50m, new Guid("0440a7c3-d4d4-4e61-a429-d77f88e1baaf"), 18 },
                    { new Guid("b705da3e-bc99-4230-84ea-7d5e4b1bae6e"), 100.50m, new Guid("8fd65b94-2805-41d5-94e1-6403174b20ce"), 1 },
                    { new Guid("b71694f2-5dae-4af1-ae50-96702f5dce99"), 200.50m, new Guid("57e69e95-0e9f-4727-845f-37e5c0233574"), 33 },
                    { new Guid("bd24708a-8dd3-4e58-92f0-24e5112f8cd4"), 200.50m, new Guid("8fd65b94-2805-41d5-94e1-6403174b20ce"), 2 },
                    { new Guid("c35deeb7-dbc1-4adc-8eb9-57e11015d13f"), 200.50m, new Guid("2c5fe80d-e82d-4f00-9c9d-34fa5d02a5ec"), 25 },
                    { new Guid("c9aec803-36c3-465a-bbf4-5b3c098dcff8"), 200.50m, new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8"), 4 },
                    { new Guid("cb5add99-075f-4d82-b684-0e15232ddc2f"), 200.50m, new Guid("a114403b-629f-4b69-b1dd-cab3308875bc"), 20 },
                    { new Guid("d651559f-adc6-4097-aaf6-652fa2b47f5e"), 200.50m, new Guid("a114403b-629f-4b69-b1dd-cab3308875bc"), 22 },
                    { new Guid("e08fad3b-a9af-40dd-ad0a-4045f1b85e70"), 200.50m, new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8"), 6 },
                    { new Guid("e62af2e6-f3e6-42a5-a020-7fdf1fdb0bc8"), 200.50m, new Guid("95075645-37c2-401f-a879-c5e223a0447b"), 26 },
                    { new Guid("f0e053cf-b43b-4cc1-93e9-5edfa834ffb2"), 200.50m, new Guid("3a6e36b4-70eb-4c78-99e6-2bb54fffe191"), 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
