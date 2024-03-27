using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingHotelRooms.Migrations
{
    public partial class Rolex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Rooms");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22174cf0–9gg2–4cfe-afbf-59f706d72c99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a9923d3-4ab4-4e47-8752-3e228c2ce9a1", "AQAAAAEAACcQAAAAEIlQyL1UrGU2pPbvE1wjqUYqEaINSFIgredhf8lJnx67oxxxT4/9FYk4+XXqnUWXUw==", "2ff1f8c1-76ec-4cc0-9906-d86133bdb3bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "960213f0-dsa8–42de-afbf-59kmkkmk72aaa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1946071c-705d-4b6e-8b84-05516363825b", "AQAAAAEAACcQAAAAEO6Kt2M6Rnac/XQIqIEU5i9/EN6ZgaHrIdHLdnJWHh3yEBCS1s8gARBj2EOMwZ1c/A==", "70e7b97f-28f2-48a6-bf21-f1c124f97d43" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "43635MGGJIRAO",
                column: "OrderDate",
                value: new DateTime(2023, 10, 27, 14, 6, 7, 547, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "9GADGDSHS1256",
                column: "OrderDate",
                value: new DateTime(2023, 10, 27, 14, 6, 7, 542, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "GADGDHGS1251",
                column: "OrderDate",
                value: new DateTime(2023, 10, 27, 14, 6, 7, 547, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "GHDHREU4746",
                column: "OrderDate",
                value: new DateTime(2023, 10, 27, 14, 6, 7, 547, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "GTG5WR8T23",
                column: "OrderDate",
                value: new DateTime(2023, 10, 27, 14, 6, 7, 547, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5,
                column: "IsAvailable",
                value: true);
        }
    }
}
