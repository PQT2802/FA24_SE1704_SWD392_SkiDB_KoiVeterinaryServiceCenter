using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class moreVeterConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("158a9a4a-2f72-43a0-98fa-a966d2613038"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("21f359bd-037a-405d-9c46-41ee18dba6cc"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("25b62459-5ab3-4ad6-b8bd-ecb0cbfc1225"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3882f663-be31-4193-9fb8-de71a1194eb4"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3ae351a5-c318-48da-964e-5c579e76bd21"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3b8d58e4-79a2-4071-b767-f2ac3446c40f"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3f39b9fe-42ec-4277-9857-8e7711c26add"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("496a9c58-3639-4263-a665-185c34aee403"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("4b60b444-432e-4e3c-a480-30610ee14d95"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("7728ecf6-44f9-49f9-8382-8c380a1781b2"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("a574fb71-9c77-47dc-8d14-72c27aa8fd66"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("a7b116eb-8eb7-4737-af6c-758dc5ed7907"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("a86ff940-9953-4d94-a25e-1abb06f127eb"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("b56e7690-f294-4004-98aa-3e43ad5d2be4"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("d9886173-918d-49fe-a245-5071a2663d89"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("ed6311b9-5418-4a4c-8a81-b959ca1bd029"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("051c6cff-5270-4378-87f4-25c8ae339066"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("15567b45-c62d-47f3-8a69-327fbcb05318"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("bdfd6332-fc84-4d04-a1ea-c73924032ea6"));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("17e47d79-5042-4f5b-9753-8b449ad2be0d"), "Mình cũng tốt, hôm nay bạn có rảnh không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9299) },
                    { new Guid("1ef92f47-d929-4173-9d7c-27c85236c734"), "Chào bạn, bạn có khỏe không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9289) },
                    { new Guid("2d75c496-99b9-410d-835e-1c929566a471"), "Tôi hiểu. Bạn có thể cho tôi biết nhiệt độ nước và tình trạng nước trong hồ không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 10, 30, 11, 56, 26, 196, DateTimeKind.Local).AddTicks(9328) },
                    { new Guid("3ed22b62-b680-48ad-a8d1-af978e0d9ee6"), "Tảo có thể ảnh hưởng đến chất lượng nước. Tôi khuyên bạn nên kiểm tra pH và amoniac trong nước. Có thể sử dụng bộ thử nghiệm nước để làm điều này.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 10, 30, 11, 58, 26, 196, DateTimeKind.Local).AddTicks(9334) },
                    { new Guid("5aff160a-7ffc-4c4a-a1d9-3650626e46f6"), "Xin chào! Tôi là bác sĩ thú y, bạn cần tôi giúp gì về cá koi của bạn?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9322) },
                    { new Guid("6015d095-ba20-4b9b-80c0-8dfabdee78ba"), "Chào bác sĩ! Con koi của tôi có dấu hiệu lờ đờ và không ăn. Tôi rất lo lắng.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 11, 55, 26, 196, DateTimeKind.Local).AddTicks(9324) },
                    { new Guid("6b70bd45-66fc-4419-ba7f-6e1fe848cb9a"), "Không có gì, mình luôn sẵn lòng giúp đỡ.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9317) },
                    { new Guid("6faedd61-1c75-4a3b-961c-a331d647c407"), "Mình muốn hỏi bạn về dự án mới.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9304) },
                    { new Guid("7f1bf3a5-df96-427c-9705-697776cba514"), "Chắc chắn rồi! Bạn cần biết gì?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9307) },
                    { new Guid("8c07bb12-f36c-4b52-b092-425d6311bc1d"), "Tôi sẽ gửi cho bạn một bản tóm tắt.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9312) },
                    { new Guid("a7d5a6a0-8446-471b-b555-a77d408374c5"), "Cảm ơn bạn, tôi sẽ xem xét ngay.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9314) },
                    { new Guid("a9cb5d87-cf47-4b02-b7df-98908c9886c8"), "Cảm ơn bác sĩ! Tôi sẽ kiểm tra và liên lạc lại nếu cần thêm giúp đỡ.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 11, 59, 26, 196, DateTimeKind.Local).AddTicks(9336) },
                    { new Guid("b0fc7864-e1d8-4f93-9f5b-51a49c3d8be3"), "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9294) },
                    { new Guid("c62f68e6-91d1-4d8f-ab20-803ed6591a1f"), "Mình có chút thời gian, bạn cần gì không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9301) },
                    { new Guid("cd918684-9ad5-4869-906f-9ccefe715b49"), "Nhiệt độ nước là 20 độ C và nước có vẻ trong, nhưng tôi thấy một ít tảo xanh.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 11, 57, 26, 196, DateTimeKind.Local).AddTicks(9331) },
                    { new Guid("eb2fa0f4-387b-43fc-a000-6122dfb53e10"), "Bạn có thông tin chi tiết về tiến độ không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(9309) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("32d7b8ff-55bf-4ad5-88ed-bfaf75e5b1ea"), null, new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(9577), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") },
                    { new Guid("4103bc29-81fb-41ec-820d-f9ec87876bf1"), null, new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(9580), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") },
                    { new Guid("80bebe34-b585-4a87-9a03-85f4b584d108"), null, new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(9571), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") }
                });

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "IsDeleted", "ModifiedBy", "ModifiedDate", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "Username", "role" },
                values: new object[] { new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234"), "456 Elm St", null, new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(5497), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian3@gmail.com", "Veterinarian_3", false, null, null, "String456!", "987654321", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Veterinarian_3", 3 });

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6528), new DateTime(2024, 11, 5, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6547), new DateTime(2024, 11, 3, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6542), new DateTime(2024, 11, 2, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6524), new DateTime(2024, 11, 4, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6534), new DateTime(2024, 10, 31, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6531), new DateTime(2024, 10, 30, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6538), new DateTime(2024, 11, 1, 11, 54, 26, 196, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.InsertData(
                table: "Veterinarian",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "LicenseNumber", "ModifiedBy", "ModifiedDate", "Qualifications", "Specialty", "UserId" },
                values: new object[] { new Guid("b87a3240-e68a-4f38-8f14-7a56f7b9d123"), null, new DateTime(2024, 10, 30, 4, 54, 26, 196, DateTimeKind.Utc).AddTicks(6271), false, "VN345678", null, null, "Master's in Veterinary Medicine", "Aquatic Animal Medicine", new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("17e47d79-5042-4f5b-9753-8b449ad2be0d"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("1ef92f47-d929-4173-9d7c-27c85236c734"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("2d75c496-99b9-410d-835e-1c929566a471"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3ed22b62-b680-48ad-a8d1-af978e0d9ee6"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("5aff160a-7ffc-4c4a-a1d9-3650626e46f6"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("6015d095-ba20-4b9b-80c0-8dfabdee78ba"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("6b70bd45-66fc-4419-ba7f-6e1fe848cb9a"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("6faedd61-1c75-4a3b-961c-a331d647c407"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("7f1bf3a5-df96-427c-9705-697776cba514"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("8c07bb12-f36c-4b52-b092-425d6311bc1d"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("a7d5a6a0-8446-471b-b555-a77d408374c5"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("a9cb5d87-cf47-4b02-b7df-98908c9886c8"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("b0fc7864-e1d8-4f93-9f5b-51a49c3d8be3"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("c62f68e6-91d1-4d8f-ab20-803ed6591a1f"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("cd918684-9ad5-4869-906f-9ccefe715b49"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("eb2fa0f4-387b-43fc-a000-6122dfb53e10"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("32d7b8ff-55bf-4ad5-88ed-bfaf75e5b1ea"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("4103bc29-81fb-41ec-820d-f9ec87876bf1"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("80bebe34-b585-4a87-9a03-85f4b584d108"));

            migrationBuilder.DeleteData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("b87a3240-e68a-4f38-8f14-7a56f7b9d123"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234"));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("158a9a4a-2f72-43a0-98fa-a966d2613038"), "Chào bạn, bạn có khỏe không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7470) },
                    { new Guid("21f359bd-037a-405d-9c46-41ee18dba6cc"), "Xin chào! Tôi là bác sĩ thú y, bạn cần tôi giúp gì về cá koi của bạn?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7504) },
                    { new Guid("25b62459-5ab3-4ad6-b8bd-ecb0cbfc1225"), "Tôi sẽ gửi cho bạn một bản tóm tắt.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7496) },
                    { new Guid("3882f663-be31-4193-9fb8-de71a1194eb4"), "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7475) },
                    { new Guid("3ae351a5-c318-48da-964e-5c579e76bd21"), "Mình muốn hỏi bạn về dự án mới.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7488) },
                    { new Guid("3b8d58e4-79a2-4071-b767-f2ac3446c40f"), "Không có gì, mình luôn sẵn lòng giúp đỡ.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7501) },
                    { new Guid("3f39b9fe-42ec-4277-9857-8e7711c26add"), "Tảo có thể ảnh hưởng đến chất lượng nước. Tôi khuyên bạn nên kiểm tra pH và amoniac trong nước. Có thể sử dụng bộ thử nghiệm nước để làm điều này.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 10, 30, 9, 51, 1, 269, DateTimeKind.Local).AddTicks(7517) },
                    { new Guid("496a9c58-3639-4263-a665-185c34aee403"), "Mình có chút thời gian, bạn cần gì không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7483) },
                    { new Guid("4b60b444-432e-4e3c-a480-30610ee14d95"), "Chào bác sĩ! Con koi của tôi có dấu hiệu lờ đờ và không ăn. Tôi rất lo lắng.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 9, 48, 1, 269, DateTimeKind.Local).AddTicks(7506) },
                    { new Guid("7728ecf6-44f9-49f9-8382-8c380a1781b2"), "Mình cũng tốt, hôm nay bạn có rảnh không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7481) },
                    { new Guid("a574fb71-9c77-47dc-8d14-72c27aa8fd66"), "Cảm ơn bác sĩ! Tôi sẽ kiểm tra và liên lạc lại nếu cần thêm giúp đỡ.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 9, 52, 1, 269, DateTimeKind.Local).AddTicks(7519) },
                    { new Guid("a7b116eb-8eb7-4737-af6c-758dc5ed7907"), "Nhiệt độ nước là 20 độ C và nước có vẻ trong, nhưng tôi thấy một ít tảo xanh.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 9, 50, 1, 269, DateTimeKind.Local).AddTicks(7514) },
                    { new Guid("a86ff940-9953-4d94-a25e-1abb06f127eb"), "Chắc chắn rồi! Bạn cần biết gì?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7490) },
                    { new Guid("b56e7690-f294-4004-98aa-3e43ad5d2be4"), "Bạn có thông tin chi tiết về tiến độ không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7493) },
                    { new Guid("d9886173-918d-49fe-a245-5071a2663d89"), "Cảm ơn bạn, tôi sẽ xem xét ngay.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(7499) },
                    { new Guid("ed6311b9-5418-4a4c-8a81-b959ca1bd029"), "Tôi hiểu. Bạn có thể cho tôi biết nhiệt độ nước và tình trạng nước trong hồ không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 10, 30, 9, 49, 1, 269, DateTimeKind.Local).AddTicks(7512) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("051c6cff-5270-4378-87f4-25c8ae339066"), null, new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7657), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") },
                    { new Guid("15567b45-c62d-47f3-8a69-327fbcb05318"), null, new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7652), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") },
                    { new Guid("bdfd6332-fc84-4d04-a1ea-c73924032ea6"), null, new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7661), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") }
                });

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5605), new DateTime(2024, 11, 5, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 11, 3, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5617), new DateTime(2024, 11, 2, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5601), new DateTime(2024, 11, 4, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5611), new DateTime(2024, 10, 31, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5608), new DateTime(2024, 10, 30, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 47, 1, 269, DateTimeKind.Utc).AddTicks(5614), new DateTime(2024, 11, 1, 9, 47, 1, 269, DateTimeKind.Local).AddTicks(5580) });
        }
    }
}
