using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleId");

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("4e7a85df-b6e4-405e-85f2-8cb6a55fd4ea"), "Tôi sẽ gửi cho bạn một bản tóm tắt.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3623) },
                    { new Guid("53ed499c-59f6-4b5a-80ea-85d07b8d0057"), "Chào bạn, bạn có khỏe không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3597) },
                    { new Guid("642e253a-1659-4d6e-98f2-51646e5a8a12"), "Không có gì, mình luôn sẵn lòng giúp đỡ.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3628) },
                    { new Guid("6e3c7f1f-1586-4dac-a132-dc2ee7425b26"), "Mình cũng tốt, hôm nay bạn có rảnh không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3606) },
                    { new Guid("8e2072ff-0653-46a8-a46d-a8845eb58229"), "Chắc chắn rồi! Bạn cần biết gì?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3617) },
                    { new Guid("9e56c0e4-89dc-4363-8c94-7aeb867ec11b"), "Mình muốn hỏi bạn về dự án mới.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3614) },
                    { new Guid("b531a5cc-d0a6-41b3-822e-45021217547b"), "Cảm ơn bạn, tôi sẽ xem xét ngay.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3625) },
                    { new Guid("d9dd4ee3-f38f-4ad0-a760-904d061114a9"), "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3603) },
                    { new Guid("fb20517d-7a55-415e-9676-a7ba754dc445"), "Bạn có thông tin chi tiết về tiến độ không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3620) },
                    { new Guid("fff6f310-420b-4c45-9b23-9211a612bd99"), "Mình có chút thời gian, bạn cần gì không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(3609) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 16, 38, 1, 352, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 352, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 352, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 352, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 352, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 352, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 352, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 352, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 352, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 352, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(722), new DateTime(2024, 10, 22, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(739), new DateTime(2024, 10, 20, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(735), new DateTime(2024, 10, 19, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(718), new DateTime(2024, 10, 21, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(729), new DateTime(2024, 10, 24, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(726), new DateTime(2024, 10, 23, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 9, 38, 1, 353, DateTimeKind.Utc).AddTicks(732), new DateTime(2024, 10, 25, 16, 38, 1, 353, DateTimeKind.Local).AddTicks(697) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("4e7a85df-b6e4-405e-85f2-8cb6a55fd4ea"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("53ed499c-59f6-4b5a-80ea-85d07b8d0057"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("642e253a-1659-4d6e-98f2-51646e5a8a12"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("6e3c7f1f-1586-4dac-a132-dc2ee7425b26"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("8e2072ff-0653-46a8-a46d-a8845eb58229"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("9e56c0e4-89dc-4363-8c94-7aeb867ec11b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("b531a5cc-d0a6-41b3-822e-45021217547b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("d9dd4ee3-f38f-4ad0-a760-904d061114a9"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("fb20517d-7a55-415e-9676-a7ba754dc445"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("fff6f310-420b-4c45-9b23-9211a612bd99"));

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "RoleId");

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 4, 39, 28, 743, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 4, 39, 28, 743, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 4, 39, 28, 743, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 4, 39, 28, 743, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 4, 39, 28, 743, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 4, 39, 28, 743, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 4, 39, 28, 743, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 4, 39, 28, 743, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 4, 39, 28, 743, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7821), new DateTime(2024, 10, 22, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 10, 20, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 10, 19, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7816), new DateTime(2024, 10, 21, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 10, 24, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7824), new DateTime(2024, 10, 23, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7833), new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798) });
        }
    }
}
