using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingHotelRooms.Migrations
{
    public partial class AddBlogCreatedTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22174cf0–9gg2–4cfe-afbf-59f706d72c99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdca24e7-64bf-40f9-b144-c65f7239d2c5", "AQAAAAEAACcQAAAAEDRqg7J9EB0/8f+/mrDJrLDc+wStb3YJOusnVjsuCH7Or0ZjoF2m7w6jHYEgvE+dKA==", "15a73be1-f411-447f-90fc-d6739a33fea8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "960213f0-dsa8–42de-afbf-59kmkkmk72aaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4adf07c2-69b7-4e55-ab5f-2a1e40607a7c", "AQAAAAEAACcQAAAAEIXbUqR4cZ+Hgn/z7iRWqdHtLY6CU3JAoQIax+m5fzfMPOCo8lzxuiR8nS7tsuYlbQ==", "a338e100-eb63-4d86-a935-4c5a681e6772" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "43635MGGJIRAO",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "9GADGDSHS1256",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "GADGDHGS1251",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "GHDHREU4746",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "GTG5WR8T23",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 38, 6, 955, DateTimeKind.Local).AddTicks(8708));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22174cf0–9gg2–4cfe-afbf-59f706d72c99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fad645d-7003-4700-a3b7-9c3e230ec447", "AQAAAAEAACcQAAAAENuNUmWWI63GuUZN/1zVmFjbu8H2q+V4qxazgVGsbHBDcVdN/Jb8rp7k/jKFhN5R4w==", "4bf3867b-0d1f-4d99-8c05-e89335fc8fe0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "960213f0-dsa8–42de-afbf-59kmkkmk72aaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86d75de0-f272-47c2-b299-e5d297c705fa", "AQAAAAEAACcQAAAAEBNpty/E6gIvpjih/HLTx1nksoZO1erdtp4XbntB7vIpKfKsomFUDuU4oe15taf0nQ==", "f1c899ce-c1fa-4b79-a911-5c48046d88ef" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "43635MGGJIRAO",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 36, 40, 754, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "9GADGDSHS1256",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 36, 40, 754, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "GADGDHGS1251",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 36, 40, 754, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "GHDHREU4746",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 36, 40, 754, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "GTG5WR8T23",
                column: "OrderDate",
                value: new DateTime(2024, 3, 27, 19, 36, 40, 754, DateTimeKind.Local).AddTicks(7752));
        }
    }
}
