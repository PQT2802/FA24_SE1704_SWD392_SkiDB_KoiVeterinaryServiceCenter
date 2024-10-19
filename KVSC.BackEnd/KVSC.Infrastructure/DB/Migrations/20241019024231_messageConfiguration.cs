using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class messageConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("18e0d975-2517-454d-8256-32148d32c34f"), "Không có gì, mình luôn sẵn lòng giúp đỡ.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(847) },
                    { new Guid("2b20f58c-69df-46f6-8c97-8584df3add3a"), "Mình cũng tốt, hôm nay bạn có rảnh không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(805) },
                    { new Guid("43131588-00c0-4fad-b606-4f77bc73b033"), "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(797) },
                    { new Guid("44f16d92-1527-4a2a-89c5-8d16ee1cf81a"), "Chào bạn, bạn có khỏe không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(782) },
                    { new Guid("4d9ef831-89db-4c96-b10a-36370873f3e6"), "Chắc chắn rồi! Bạn cần biết gì?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(824) },
                    { new Guid("5a5b017a-91e5-4677-bc0d-9e3b9f130a35"), "Mình muốn hỏi bạn về dự án mới.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(819) },
                    { new Guid("a1fc5f33-f4d6-491c-8be7-b629d7db0388"), "Cảm ơn bạn, tôi sẽ xem xét ngay.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(838) },
                    { new Guid("b6e06804-1f71-4760-9007-c11e58790d6e"), "Mình có chút thời gian, bạn cần gì không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(810) },
                    { new Guid("cfd9aa41-4907-4307-8401-9ded1af62f42"), "Bạn có thông tin chi tiết về tiến độ không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(828) },
                    { new Guid("da6546e4-d2e2-4ae0-9f66-506e34afb735"), "Tôi sẽ gửi cho bạn một bản tóm tắt.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 19, 9, 42, 29, 898, DateTimeKind.Local).AddTicks(833) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 898, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 898, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 42, 29, 896, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 894, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 894, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 894, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 894, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 894, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 894, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 894, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 894, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 894, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 10, 22, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1546), new DateTime(2024, 10, 20, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1539), new DateTime(2024, 10, 19, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1511), new DateTime(2024, 10, 21, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 10, 24, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 10, 23, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 42, 29, 897, DateTimeKind.Utc).AddTicks(1531), new DateTime(2024, 10, 25, 9, 42, 29, 897, DateTimeKind.Local).AddTicks(1476) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("18e0d975-2517-454d-8256-32148d32c34f"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("2b20f58c-69df-46f6-8c97-8584df3add3a"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("43131588-00c0-4fad-b606-4f77bc73b033"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("44f16d92-1527-4a2a-89c5-8d16ee1cf81a"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("4d9ef831-89db-4c96-b10a-36370873f3e6"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("5a5b017a-91e5-4677-bc0d-9e3b9f130a35"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("a1fc5f33-f4d6-491c-8be7-b629d7db0388"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("b6e06804-1f71-4760-9007-c11e58790d6e"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("cfd9aa41-4907-4307-8401-9ded1af62f42"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("da6546e4-d2e2-4ae0-9f66-506e34afb735"));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7240), new DateTime(2024, 10, 22, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7298), new DateTime(2024, 10, 20, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7295), new DateTime(2024, 10, 19, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7236), new DateTime(2024, 10, 21, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7248), new DateTime(2024, 10, 24, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7245), new DateTime(2024, 10, 23, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 35, 23, 208, DateTimeKind.Utc).AddTicks(7252), new DateTime(2024, 10, 25, 9, 35, 23, 208, DateTimeKind.Local).AddTicks(7219) });
        }
    }
}
