using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterInvoice.Migrations
{
    /// <inheritdoc />
    public partial class addedforeignkeyinEItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Items");
        }
    }
}
