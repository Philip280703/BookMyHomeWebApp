using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookMyHomeWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Timestamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "postnummerOgByEF",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "BrugerEF",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "BookingEF",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "BoligEF",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "AresseEF",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "AnmeldelseEF",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "postnummerOgByEF");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "BrugerEF");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "BookingEF");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "BoligEF");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "AresseEF");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "AnmeldelseEF");
        }
    }
}
