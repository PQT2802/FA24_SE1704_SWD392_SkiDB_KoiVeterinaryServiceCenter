using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePaymentWithStatuses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("1886d7b7-8866-4463-a674-1513d6601a18"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("251d8dd9-b8a8-4e98-a5c4-9ea3caf6de53"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3e8f854d-0c14-4a78-932d-67861803d351"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("675b79f2-2942-45b8-b8b6-bdb2857cbe1d"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("6fa32feb-1102-4982-a505-54ee3207c6dd"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("96d0341b-6fe4-4cc2-8cbe-b836d910a79f"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("9995790a-e8bb-4bc1-86a1-6f343aab2587"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("a1aedbf3-6422-44c8-8d8a-96cd50f25409"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("a36d2785-f6a1-4b69-87d9-2064dae923ac"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("c084dbbb-5ef8-401c-9ce0-82c418bffc5e"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("749314a4-410d-49bf-961b-2993979a3f22"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("8de8dd43-312e-4971-9abf-0b1ed1108c8a"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("978d15a3-8789-483e-9d2e-e5104b316321"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("389a68f0-c794-45a9-a4f9-41d4502a3713"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("5bda6523-694b-4c7b-9cb6-13ce533c571b"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("80dafa47-d6cc-47fc-a242-428275bd5924"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("874d904e-3edf-4c92-b7f9-3599e419f72e"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("e7355fc2-4d6b-4ff7-bc84-c18b1872630e"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("ef88ca85-1197-4598-871f-a6bcb3ccfa0f"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("f4b3be9a-e94a-4654-af77-c111641954ad"));

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Payment",
                newName: "totalAmountStatus");

            migrationBuilder.AddColumn<bool>(
                name: "depositStatus",
                table: "Payment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("0e5c5309-f063-4f9e-bf56-b743de950894"), "Bạn có thông tin chi tiết về tiến độ không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7917) },
                    { new Guid("1a743756-2343-423f-9045-a57b9c276557"), "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7906) },
                    { new Guid("1b58428a-034c-48a2-8c5f-917ea6bba6d3"), "Chắc chắn rồi! Bạn cần biết gì?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7915) },
                    { new Guid("37cb0943-543d-44da-ad4d-de86cc856f5e"), "Chào bạn, bạn có khỏe không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7903) },
                    { new Guid("3cfd2af2-b978-4768-9bb5-2d9bfd1afbcd"), "Mình cũng tốt, hôm nay bạn có rảnh không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7909) },
                    { new Guid("7594e69a-e031-4e4f-adf0-3a58bf9bb5de"), "Mình muốn hỏi bạn về dự án mới.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7913) },
                    { new Guid("808a04c7-8789-4992-819f-a1fec8c9b8b6"), "Tôi sẽ gửi cho bạn một bản tóm tắt.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7919) },
                    { new Guid("89b4b438-e380-4fcb-8df9-1de0f39a4ee1"), "Mình có chút thời gian, bạn cần gì không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7911) },
                    { new Guid("de0848c3-bb85-407b-94ae-a65e08ae3d49"), "Cảm ơn bạn, tôi sẽ xem xét ngay.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7922) },
                    { new Guid("ecf23e18-d4f9-49f0-8d50-0cfb27e89acc"), "Không có gì, mình luôn sẵn lòng giúp đỡ.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(7924) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("04866313-0536-44ce-9edd-972cac515232"), null, new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(8012), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") },
                    { new Guid("3414a198-c0bb-4093-8343-21b0d149eb78"), null, new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(8008), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") },
                    { new Guid("f5d955ac-5d0a-4bc3-9f81-ae57b67634b2"), null, new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(8006), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") }
                });

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6797), new DateTime(2024, 11, 5, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6812), new DateTime(2024, 11, 3, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6810), new DateTime(2024, 11, 2, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6794), new DateTime(2024, 11, 4, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6803), new DateTime(2024, 10, 31, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 11, 6, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 55, 52, 805, DateTimeKind.Utc).AddTicks(6807), new DateTime(2024, 11, 1, 0, 55, 52, 805, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("39ff4f37-faf1-4737-834e-b2b074819cad"), 1000.00m, null, new DateTime(2024, 10, 30, 17, 55, 52, 806, DateTimeKind.Utc).AddTicks(239), false, null, null, new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359") },
                    { new Guid("3eeccd78-90ff-4396-b6ac-3830574bd584"), 1000.00m, null, new DateTime(2024, 10, 30, 17, 55, 52, 806, DateTimeKind.Utc).AddTicks(226), false, null, null, new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") },
                    { new Guid("419606bc-b7ff-4c24-90e5-ec432e9c2f0c"), 1000.00m, null, new DateTime(2024, 10, 30, 17, 55, 52, 806, DateTimeKind.Utc).AddTicks(220), false, null, null, new Guid("4feb4940-94dc-4aed-b580-ee116b668704") },
                    { new Guid("4c2dbf79-db62-4c3e-81f3-b5e975312453"), 1000.00m, null, new DateTime(2024, 10, 30, 17, 55, 52, 806, DateTimeKind.Utc).AddTicks(224), false, null, null, new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73") },
                    { new Guid("4ea032ba-3b09-4b7f-bf11-5439a0a60fc6"), 1000.00m, null, new DateTime(2024, 10, 30, 17, 55, 52, 806, DateTimeKind.Utc).AddTicks(237), false, null, null, new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac") },
                    { new Guid("6b8adf99-9b74-4242-9e36-8f0778063c32"), 1000.00m, null, new DateTime(2024, 10, 30, 17, 55, 52, 806, DateTimeKind.Utc).AddTicks(241), false, null, null, new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e") },
                    { new Guid("a4c65dee-4ec4-43c4-9bd5-a904c96a1cc9"), 1000.00m, null, new DateTime(2024, 10, 30, 17, 55, 52, 806, DateTimeKind.Utc).AddTicks(234), false, null, null, new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("0e5c5309-f063-4f9e-bf56-b743de950894"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("1a743756-2343-423f-9045-a57b9c276557"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("1b58428a-034c-48a2-8c5f-917ea6bba6d3"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("37cb0943-543d-44da-ad4d-de86cc856f5e"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3cfd2af2-b978-4768-9bb5-2d9bfd1afbcd"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("7594e69a-e031-4e4f-adf0-3a58bf9bb5de"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("808a04c7-8789-4992-819f-a1fec8c9b8b6"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("89b4b438-e380-4fcb-8df9-1de0f39a4ee1"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("de0848c3-bb85-407b-94ae-a65e08ae3d49"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("ecf23e18-d4f9-49f0-8d50-0cfb27e89acc"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("04866313-0536-44ce-9edd-972cac515232"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("3414a198-c0bb-4093-8343-21b0d149eb78"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("f5d955ac-5d0a-4bc3-9f81-ae57b67634b2"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("39ff4f37-faf1-4737-834e-b2b074819cad"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("3eeccd78-90ff-4396-b6ac-3830574bd584"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("419606bc-b7ff-4c24-90e5-ec432e9c2f0c"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("4c2dbf79-db62-4c3e-81f3-b5e975312453"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("4ea032ba-3b09-4b7f-bf11-5439a0a60fc6"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("6b8adf99-9b74-4242-9e36-8f0778063c32"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("a4c65dee-4ec4-43c4-9bd5-a904c96a1cc9"));

            migrationBuilder.DropColumn(
                name: "depositStatus",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "totalAmountStatus",
                table: "Payment",
                newName: "Status");

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("1886d7b7-8866-4463-a674-1513d6601a18"), "Mình cũng tốt, hôm nay bạn có rảnh không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1397) },
                    { new Guid("251d8dd9-b8a8-4e98-a5c4-9ea3caf6de53"), "Mình muốn hỏi bạn về dự án mới.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1404) },
                    { new Guid("3e8f854d-0c14-4a78-932d-67861803d351"), "Cảm ơn bạn, tôi sẽ xem xét ngay.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1414) },
                    { new Guid("675b79f2-2942-45b8-b8b6-bdb2857cbe1d"), "Không có gì, mình luôn sẵn lòng giúp đỡ.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1416) },
                    { new Guid("6fa32feb-1102-4982-a505-54ee3207c6dd"), "Bạn có thông tin chi tiết về tiến độ không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1409) },
                    { new Guid("96d0341b-6fe4-4cc2-8cbe-b836d910a79f"), "Tôi sẽ gửi cho bạn một bản tóm tắt.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1411) },
                    { new Guid("9995790a-e8bb-4bc1-86a1-6f343aab2587"), "Chắc chắn rồi! Bạn cần biết gì?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1407) },
                    { new Guid("a1aedbf3-6422-44c8-8d8a-96cd50f25409"), "Chào bạn, bạn có khỏe không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1391) },
                    { new Guid("a36d2785-f6a1-4b69-87d9-2064dae923ac"), "Mình có chút thời gian, bạn cần gì không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1402) },
                    { new Guid("c084dbbb-5ef8-401c-9ce0-82c418bffc5e"), "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 23, 56, 53, 701, DateTimeKind.Local).AddTicks(1395) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("749314a4-410d-49bf-961b-2993979a3f22"), null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(1516), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") },
                    { new Guid("8de8dd43-312e-4971-9abf-0b1ed1108c8a"), null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(1511), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") },
                    { new Guid("978d15a3-8789-483e-9d2e-e5104b316321"), null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(1514), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") }
                });

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9684), new DateTime(2024, 11, 5, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9699), new DateTime(2024, 11, 3, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9696), new DateTime(2024, 11, 2, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9681), new DateTime(2024, 11, 4, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9691), new DateTime(2024, 10, 31, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9687), new DateTime(2024, 10, 30, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 56, 53, 700, DateTimeKind.Utc).AddTicks(9693), new DateTime(2024, 11, 1, 23, 56, 53, 700, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("389a68f0-c794-45a9-a4f9-41d4502a3713"), 1000.00m, null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(4784), false, null, null, new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359") },
                    { new Guid("5bda6523-694b-4c7b-9cb6-13ce533c571b"), 1000.00m, null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(4774), false, null, null, new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") },
                    { new Guid("80dafa47-d6cc-47fc-a242-428275bd5924"), 1000.00m, null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(4781), false, null, null, new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac") },
                    { new Guid("874d904e-3edf-4c92-b7f9-3599e419f72e"), 1000.00m, null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(4777), false, null, null, new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") },
                    { new Guid("e7355fc2-4d6b-4ff7-bc84-c18b1872630e"), 1000.00m, null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(4786), false, null, null, new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e") },
                    { new Guid("ef88ca85-1197-4598-871f-a6bcb3ccfa0f"), 1000.00m, null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(4766), false, null, null, new Guid("4feb4940-94dc-4aed-b580-ee116b668704") },
                    { new Guid("f4b3be9a-e94a-4654-af77-c111641954ad"), 1000.00m, null, new DateTime(2024, 10, 30, 16, 56, 53, 701, DateTimeKind.Utc).AddTicks(4771), false, null, null, new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73") }
                });
        }
    }
}
