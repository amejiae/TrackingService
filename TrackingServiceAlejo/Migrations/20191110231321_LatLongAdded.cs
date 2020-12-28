using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackingServiceAlejo.Migrations
{
    public partial class LatLongAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeviceId",
                table: "Trackings",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Lattitude",
                table: "Trackings",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Trackings",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Trackings");

            migrationBuilder.DropColumn(
                name: "Lattitude",
                table: "Trackings");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Trackings");
        }
    }
}
