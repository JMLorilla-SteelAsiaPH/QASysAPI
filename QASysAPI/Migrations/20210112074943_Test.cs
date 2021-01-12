using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QASysAPI.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "prod");

            migrationBuilder.CreateTable(
                name: "barcode",
                schema: "prod",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    product_line_id = table.Column<string>(maxLength: 50, nullable: true),
                    material_number = table.Column<string>(maxLength: 50, nullable: true),
                    product_code = table.Column<string>(maxLength: 50, nullable: true),
                    file_number = table.Column<string>(maxLength: 50, nullable: true),
                    bundle_number = table.Column<string>(maxLength: 50, nullable: true),
                    shift_number = table.Column<string>(maxLength: 10, nullable: true),
                    grade_id = table.Column<int>(nullable: false),
                    diameter_id = table.Column<int>(nullable: false),
                    spacing_id = table.Column<int>(nullable: false),
                    length_id = table.Column<int>(nullable: false),
                    standard_id = table.Column<int>(nullable: false),
                    quantity = table.Column<float>(nullable: false),
                    uom = table.Column<string>(maxLength: 50, nullable: true),
                    status = table.Column<int>(nullable: false),
                    last_date_time = table.Column<DateTime>(nullable: false),
                    last_user = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barcode", x => x.id);
                });

            migrationBuilder.InsertData(
                schema: "prod",
                table: "barcode",
                columns: new[] { "id", "bundle_number", "diameter_id", "file_number", "grade_id", "last_date_time", "last_user", "length_id", "material_number", "product_code", "product_line_id", "quantity", "shift_number", "spacing_id", "standard_id", "status", "uom" },
                values: new object[] { 1, "BUND01", 2, "FILE01", 1, new DateTime(2021, 1, 12, 15, 49, 43, 587, DateTimeKind.Local), "jmlorilla", 4, "13CB", "667ABC", "12AB", 2.5f, "SHFT01", 3, 5, 1, "TESTUOM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "barcode",
                schema: "prod");
        }
    }
}
