using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoard.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Body", "Group", "Subject" },
                values: new object[] { 1, "Very loud, rude, teens throwing a party in the SW Neighborhood", "SW Neighborhood Watch", "Loud Party" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Body", "Group", "Subject" },
                values: new object[] { 2, "Good times, bring all your friends", "Gen zs unite", "Block party" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);
        }
    }
}
