using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finances.Dal.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "finances",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "text", nullable: false),
                    period = table.Column<string>(type: "text", nullable: false),
                    total_wasted_sum = table.Column<double>(type: "double precision", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    saving_goal = table.Column<double>(type: "double precision", nullable: false),
                    amount_of_money = table.Column<double>(type: "double precision", nullable: false),
                    debt = table.Column<double>(type: "double precision", nullable: false),
                    income = table.Column<double>(type: "double precision", nullable: false),
                    average_wasted = table.Column<double>(type: "double precision", nullable: false),
                    average_surplus = table.Column<double>(type: "double precision", nullable: false),
                    mounts_to_goal = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_finances", x => new { x.user_id, x.period });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "finances");
        }
    }
}
