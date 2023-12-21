using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site.Web.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "e6109539-0958-4d37-a42a-c8d0359cccd5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "19e9823f-2901-44bd-b0e7-95f1c82ef152");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "2282bbe4-b35d-453d-af28-97e7b6ef23cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49bc9875-c198-47d0-a161-5326619a1d5a", "AQAAAAIAAYagAAAAEOGpZcVz5DKEFWa+pTIOH6AHx81Cdy7bX3lDdJ4hG0gNdK58VR6+lVzQ4WOsaYOTFA==", "720a9465-d0df-43d5-9962-84731c3d812e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03e1c4dc-a403-4f85-840d-5c7d7328ee21", "AQAAAAIAAYagAAAAELHZ6cVqeKbo4wdrQSUyhOCfceosPQP3JDt79sK8esfCEC0jRCnj8UUYRnm3QO72kg==", "29428c30-598c-4288-8be6-6603fceff1f3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -3,
                column: "ConcurrencyStamp",
                value: "ce726c90-5370-4223-ae76-7ef1a1b1a9bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -2,
                column: "ConcurrencyStamp",
                value: "86a5dc0f-3aa3-4cfe-ae64-a56614f40d97");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: -1,
                column: "ConcurrencyStamp",
                value: "9d9f0222-56fe-4df0-bd9b-f64a43e89dec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c8ed666-0924-4790-884d-9ddb1e186828", "AQAAAAIAAYagAAAAEM3Inr7VqmGYBXUihGTCHopYyxrXh1wAorBjBv03cTNC79rKz7WM2N3PN9e2s8/Y9w==", "40cdc2cf-95db-44d4-a6ca-95ca807d290b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "358e0644-4edc-432b-b5f2-6cc57ce081ef", "AQAAAAIAAYagAAAAEPksCLpMk/g6pGfrTUSuXV2xTKjEwh9Re+ti2ob9Gq+cH3gDIYtkAWmp0cAL0x/rBA==", "37e72725-4eea-4a9f-9b90-9f24ad83d58f" });
        }
    }
}
