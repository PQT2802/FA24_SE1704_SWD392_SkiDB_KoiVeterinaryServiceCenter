using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddWalletToUse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("1520ec64-3b26-477d-bb95-9878f84b7645"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("1605f839-4090-4ca9-aad1-4b1713c860f0"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("227754c5-59c1-4f97-a5d9-f981823a5944"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("33a4f6a9-a0e0-4a06-b01b-02bccd5c375d"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("5c7f8bdb-12b5-4e60-9c96-51de4edc75e0"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("685f298c-713f-4a26-8b5b-1ccbc7953d19"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("85ecc08c-1735-4b50-aaff-86ec8355d666"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("9ab0648e-1d79-4682-8760-31fe9da18751"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("eb2452f0-f826-42f8-bb38-47c3b37dcc2b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("fcb9c314-0849-456f-b0f1-f4da00daaa58"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2fe081e4-2a58-4e4d-a74f-cd91decafd5f"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("4eabd503-41a8-4806-8976-94c625137167"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("8e3aa2fb-be57-421f-a16d-503f4e64007a"));

            migrationBuilder.CreateTable(
                name: "Wallet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallet_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("0de7f5b7-cab7-4d59-a4ea-bb12b1b7c680"), "Cảm ơn bạn, tôi sẽ xem xét ngay.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5763) },
                    { new Guid("3d2ccfa2-9761-456e-8aa2-f12532bb84b9"), "Tôi sẽ gửi cho bạn một bản tóm tắt.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5760) },
                    { new Guid("43926e8d-2441-413e-a235-c7e4a0c52b0b"), "Bạn có thông tin chi tiết về tiến độ không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5758) },
                    { new Guid("45ddfd99-cb06-4385-8e0c-c944f56dbb7c"), "Mình muốn hỏi bạn về dự án mới.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5750) },
                    { new Guid("9473677d-0fb6-495f-8f21-a75479c6f21a"), "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5743) },
                    { new Guid("94dc1201-e077-4e8c-bf6e-6b7cd82e3fb0"), "Chào bạn, bạn có khỏe không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5713) },
                    { new Guid("9e9fac05-37a1-4d6c-ae4b-95d24702563b"), "Không có gì, mình luôn sẵn lòng giúp đỡ.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5765) },
                    { new Guid("b9bfdb62-6d55-40d0-8eda-7c976905a424"), "Mình có chút thời gian, bạn cần gì không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5748) },
                    { new Guid("dd8fdc1f-a874-4af8-8120-f1bed9b2fe69"), "Chắc chắn rồi! Bạn cần biết gì?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5756) },
                    { new Guid("fbe88b85-2816-4253-a8b6-543de6da5459"), "Mình cũng tốt, hôm nay bạn có rảnh không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(5746) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("5a9181ce-50a9-4fc3-ad17-121f428de3ec"), null, new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5871), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") },
                    { new Guid("66a0c41b-4410-4fd7-b69b-1541ae7fd7f7"), null, new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5868), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") },
                    { new Guid("fe4fa761-a775-43d4-a92c-5fea62b42dbe"), null, new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5866), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") }
                });

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3657), new DateTime(2024, 11, 5, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3672), new DateTime(2024, 11, 3, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3669), new DateTime(2024, 11, 2, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3651), new DateTime(2024, 11, 4, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3663), new DateTime(2024, 10, 31, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3660), new DateTime(2024, 10, 30, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 36, 23, 622, DateTimeKind.Utc).AddTicks(3666), new DateTime(2024, 11, 1, 21, 36, 23, 622, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_UserId",
                table: "Wallet",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wallet");

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("0de7f5b7-cab7-4d59-a4ea-bb12b1b7c680"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3d2ccfa2-9761-456e-8aa2-f12532bb84b9"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("43926e8d-2441-413e-a235-c7e4a0c52b0b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("45ddfd99-cb06-4385-8e0c-c944f56dbb7c"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("9473677d-0fb6-495f-8f21-a75479c6f21a"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("94dc1201-e077-4e8c-bf6e-6b7cd82e3fb0"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("9e9fac05-37a1-4d6c-ae4b-95d24702563b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("b9bfdb62-6d55-40d0-8eda-7c976905a424"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("dd8fdc1f-a874-4af8-8120-f1bed9b2fe69"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("fbe88b85-2816-4253-a8b6-543de6da5459"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("5a9181ce-50a9-4fc3-ad17-121f428de3ec"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("66a0c41b-4410-4fd7-b69b-1541ae7fd7f7"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("fe4fa761-a775-43d4-a92c-5fea62b42dbe"));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("1520ec64-3b26-477d-bb95-9878f84b7645"), "Bạn có thông tin chi tiết về tiến độ không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3383) },
                    { new Guid("1605f839-4090-4ca9-aad1-4b1713c860f0"), "Mình muốn hỏi bạn về dự án mới.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3379) },
                    { new Guid("227754c5-59c1-4f97-a5d9-f981823a5944"), "Mình cũng tốt, hôm nay bạn có rảnh không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3374) },
                    { new Guid("33a4f6a9-a0e0-4a06-b01b-02bccd5c375d"), "Không có gì, mình luôn sẵn lòng giúp đỡ.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3391) },
                    { new Guid("5c7f8bdb-12b5-4e60-9c96-51de4edc75e0"), "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3372) },
                    { new Guid("685f298c-713f-4a26-8b5b-1ccbc7953d19"), "Chắc chắn rồi! Bạn cần biết gì?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3381) },
                    { new Guid("85ecc08c-1735-4b50-aaff-86ec8355d666"), "Mình có chút thời gian, bạn cần gì không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3377) },
                    { new Guid("9ab0648e-1d79-4682-8760-31fe9da18751"), "Chào bạn, bạn có khỏe không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3366) },
                    { new Guid("eb2452f0-f826-42f8-bb38-47c3b37dcc2b"), "Tôi sẽ gửi cho bạn một bản tóm tắt.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3387) },
                    { new Guid("fcb9c314-0849-456f-b0f1-f4da00daaa58"), "Cảm ơn bạn, tôi sẽ xem xét ngay.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(3389) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("2fe081e4-2a58-4e4d-a74f-cd91decafd5f"), null, new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3517), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") },
                    { new Guid("4eabd503-41a8-4806-8976-94c625137167"), null, new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3524), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") },
                    { new Guid("8e3aa2fb-be57-421f-a16d-503f4e64007a"), null, new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3521), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") }
                });

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 827, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(584), new DateTime(2024, 10, 29, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 10, 27, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(598), new DateTime(2024, 10, 26, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(581), new DateTime(2024, 10, 28, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(593), new DateTime(2024, 10, 31, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(587), new DateTime(2024, 10, 30, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 25, 1, 35, 58, 828, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 10, 25, 8, 35, 58, 828, DateTimeKind.Local).AddTicks(563) });
        }
    }
}
