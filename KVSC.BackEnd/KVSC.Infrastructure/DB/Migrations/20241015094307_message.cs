using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class message : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "RoleName",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "RoleName",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "RoleName",
                value: "Veterinarian");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "RoleName",
                value: "Staff");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "RoleName",
                value: "Customer");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 9, 43, 4, 219, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 9, 43, 4, 219, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 9, 43, 4, 219, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 9, 43, 4, 219, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 9, 43, 4, 219, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 9, 43, 4, 219, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 9, 43, 4, 219, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 9, 43, 4, 219, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 9, 43, 4, 219, DateTimeKind.Utc).AddTicks(6585));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "RoleName",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "RoleName",
                value: "manager");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "RoleName",
                value: "veterinarian");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "RoleName",
                value: "staff");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "RoleName",
                value: "customer");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 0, 5, 156, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 0, 5, 156, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 0, 5, 156, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 0, 5, 156, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 0, 5, 156, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 0, 5, 156, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 0, 5, 156, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 0, 5, 156, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 0, 5, 156, DateTimeKind.Utc).AddTicks(2383));
        }
    }
}
