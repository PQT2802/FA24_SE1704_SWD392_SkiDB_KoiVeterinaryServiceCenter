using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultImageMappings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("1fbc189a-8642-451c-90fc-b37a5b24440e"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("25b3edf9-05b0-4851-9c88-b96e569c9f39"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("2927a1ca-bf5f-49ba-a33e-113a40a77c99"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3216b4af-edf9-44c3-94bb-6f66c317354d"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("47091cb7-6806-460e-a60f-a25f61abf45d"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("53e90abf-0c34-4ec7-83b7-6b9dbcfbc31b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("59497446-6835-401c-8bc1-62eefe22fa3e"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("6c4ddaf5-5b63-4112-8d4d-fffe77b01b44"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("7035ac12-6b7f-472d-b4e0-6ad2a06aa783"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("83e7de91-11a5-441f-a5e7-94d6ecbcf01a"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("93f193be-045e-48d4-a5cd-5ad792d62d6b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("967f650b-1b45-44a3-9644-400ea0db3aa9"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("a4773db8-0d34-4d78-8cd3-13ad2a006f55"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("ba5c906b-e9ab-42a3-a3ee-0577acf073bc"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("be7dbc96-b41e-40ff-b5e9-80422fb1cf8a"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("c1406147-0c0c-4137-9ca4-55e1e50bbbdc"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("8a7205bf-02f2-46d8-8381-133cf7d32726"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("9b4089a0-42cb-4e08-a88f-e825bb85f052"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("dee45b24-72b0-481d-8ddb-96a277110424"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("36d69c86-7f59-4b99-881c-31155d152674"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("3c88b3a2-0871-486d-99a0-1599ce2d0f37"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("41ab5918-1e12-4081-ba2a-7b1d0e5a9259"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("6d85ebf4-c1c3-420c-820b-e86129778a35"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("783ff7c9-cb6f-4f4b-8414-7a0884c3bc3f"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("957d257f-c97c-4e64-9706-57c6986fa68e"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("a72429cb-573e-4ac3-bd4b-9e2f33c94a55"));

            migrationBuilder.AddColumn<string>(
                name: "ImageMappingsJson",
                table: "EmailTemplate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbcbb-bbbb-bcbb-bbbb-bbcbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3512), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3506), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3500), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3484), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3497), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3494), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3503), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3509), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3487), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "CreateDate", "ImageMappingsJson", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3469), "{}", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("01696679-1d6f-40cf-a6d4-c75545a500bc"), "Hi, Doctor! My koi fish seems sluggish and isn’t eating. I’m really worried.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 19, 42, 3, 379, DateTimeKind.Local).AddTicks(5637) },
                    { new Guid("090961ba-3370-4fce-a0f2-f8540e9290a5"), "I have some time, do you need anything?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5617) },
                    { new Guid("124ed5e1-d335-47c3-86bb-5585d08bb3f9"), "Algae can affect water quality. I recommend checking the pH and ammonia levels. You can use a water testing kit for this.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 5, 19, 45, 3, 379, DateTimeKind.Local).AddTicks(5648) },
                    { new Guid("3fd4e50e-83f9-4b35-ab2b-1725abec2956"), "I want to ask you about the new project.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5620) },
                    { new Guid("4daf524b-80bc-4a17-a72e-0b2aa055c435"), "I'm good, thank you! How about you?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5613) },
                    { new Guid("603b14ae-7524-4475-b697-597cc19e571d"), "The water temperature is 20°C, and the water seems clear, but I noticed a bit of green algae.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 19, 44, 3, 379, DateTimeKind.Local).AddTicks(5646) },
                    { new Guid("61b986d4-4d68-4730-9437-b3b4391c59f9"), "Hello! I’m the veterinarian. How can I assist with your koi fish?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5635) },
                    { new Guid("6cc4a494-a0ae-40ed-96ba-a3d03fd496aa"), "I see. Can you tell me the water temperature and the condition of the water?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 5, 19, 43, 3, 379, DateTimeKind.Local).AddTicks(5642) },
                    { new Guid("7ae2c6a1-403a-4d9b-b77b-de13ad3c5dd8"), "Hello, how are you?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5609) },
                    { new Guid("b872fc8b-fc01-49c4-973d-e9d0dd610772"), "You're welcome, always happy to help.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5633) },
                    { new Guid("e5449f8b-bc2e-4b7e-afa9-1750b000cf94"), "Sure! What do you need to know?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5625) },
                    { new Guid("ebd8abec-0de1-4a1a-9169-34e79461abbe"), "I’ll send you a summary.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5629) },
                    { new Guid("ed6bbbc1-8757-4b90-83e4-cd4c2e5019cb"), "Do you have detailed information about the progress?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5627) },
                    { new Guid("f530f9bd-f658-4a9b-9b06-78011b689dd0"), "Thank you, Doctor! I’ll check and get back if I need more help.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 19, 46, 3, 379, DateTimeKind.Local).AddTicks(5651) },
                    { new Guid("f677f58b-b51c-4461-bd87-9b3c557fc1af"), "Thank you, I’ll review it right away.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5631) },
                    { new Guid("fd15480b-297c-4cfb-8f17-a5bc32e1a789"), "I'm good too. Are you free today?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(5615) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a87-0230-428b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca4801df-081c-4db5-a416-b04891797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("018c5c59-c40c-4aa1-8279-600e121f746c"), null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5743), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") },
                    { new Guid("33d7da65-89d3-4201-b802-3c24eaad0276"), null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5747), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") },
                    { new Guid("d45e3fb8-da06-40e9-9d7e-7f266e2db7bd"), null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5750), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") }
                });

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("b87a3240-e68a-4f38-8f14-7a56f7b9d123"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4373), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4424), new DateTime(2024, 11, 10, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4421), new DateTime(2024, 11, 9, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4370), new DateTime(2024, 11, 11, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4380), new DateTime(2024, 11, 7, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4377), new DateTime(2024, 11, 6, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(4383), new DateTime(2024, 11, 8, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("231862f0-802e-4f17-b5ad-a8c503c45f75"), 1000.00m, null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(7859), false, null, null, new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") },
                    { new Guid("2ea5b33b-4ebb-4467-917b-13214d3f68be"), 1000.00m, null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(7863), false, null, null, new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") },
                    { new Guid("4b41d0e2-2132-485b-bede-1af1bfeb29da"), 1000.00m, null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(7845), false, null, null, new Guid("4feb4940-94dc-4aed-b580-ee116b668704") },
                    { new Guid("51f5578f-ce4b-4139-bb95-7a94173627ec"), 1000.00m, null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(7868), false, null, null, new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359") },
                    { new Guid("744124f4-0efc-4333-ba85-0f0f6d6493d5"), 1000.00m, null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(7872), false, null, null, new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e") },
                    { new Guid("a50b294f-b8e8-4b1f-90df-cfabae458550"), 1000.00m, null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(7866), false, null, null, new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac") },
                    { new Guid("b7187ab7-6738-4827-9532-dc5d2d878ce1"), 1000.00m, null, new DateTime(2024, 11, 5, 12, 41, 3, 379, DateTimeKind.Utc).AddTicks(7851), false, null, null, new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("01696679-1d6f-40cf-a6d4-c75545a500bc"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("090961ba-3370-4fce-a0f2-f8540e9290a5"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("124ed5e1-d335-47c3-86bb-5585d08bb3f9"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3fd4e50e-83f9-4b35-ab2b-1725abec2956"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("4daf524b-80bc-4a17-a72e-0b2aa055c435"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("603b14ae-7524-4475-b697-597cc19e571d"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("61b986d4-4d68-4730-9437-b3b4391c59f9"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("6cc4a494-a0ae-40ed-96ba-a3d03fd496aa"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("7ae2c6a1-403a-4d9b-b77b-de13ad3c5dd8"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("b872fc8b-fc01-49c4-973d-e9d0dd610772"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("e5449f8b-bc2e-4b7e-afa9-1750b000cf94"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("ebd8abec-0de1-4a1a-9169-34e79461abbe"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("ed6bbbc1-8757-4b90-83e4-cd4c2e5019cb"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("f530f9bd-f658-4a9b-9b06-78011b689dd0"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("f677f58b-b51c-4461-bd87-9b3c557fc1af"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("fd15480b-297c-4cfb-8f17-a5bc32e1a789"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("018c5c59-c40c-4aa1-8279-600e121f746c"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("33d7da65-89d3-4201-b802-3c24eaad0276"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("d45e3fb8-da06-40e9-9d7e-7f266e2db7bd"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("231862f0-802e-4f17-b5ad-a8c503c45f75"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("2ea5b33b-4ebb-4467-917b-13214d3f68be"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("4b41d0e2-2132-485b-bede-1af1bfeb29da"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("51f5578f-ce4b-4139-bb95-7a94173627ec"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("744124f4-0efc-4333-ba85-0f0f6d6493d5"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("a50b294f-b8e8-4b1f-90df-cfabae458550"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("b7187ab7-6738-4827-9532-dc5d2d878ce1"));

            migrationBuilder.DropColumn(
                name: "ImageMappingsJson",
                table: "EmailTemplate");

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbcbb-bbbb-bcbb-bbbb-bbcbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6816), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6810), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6799), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6808), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6805), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6813), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("1fbc189a-8642-451c-90fc-b37a5b24440e"), "The water temperature is 20°C, and the water seems clear, but I noticed a bit of green algae.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 3, 20, 46, 13, 141, DateTimeKind.Local).AddTicks(8915) },
                    { new Guid("25b3edf9-05b0-4851-9c88-b96e569c9f39"), "I’ll send you a summary.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8886) },
                    { new Guid("2927a1ca-bf5f-49ba-a33e-113a40a77c99"), "Algae can affect water quality. I recommend checking the pH and ammonia levels. You can use a water testing kit for this.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 3, 20, 47, 13, 141, DateTimeKind.Local).AddTicks(8918) },
                    { new Guid("3216b4af-edf9-44c3-94bb-6f66c317354d"), "I'm good too. Are you free today?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8873) },
                    { new Guid("47091cb7-6806-460e-a60f-a25f61abf45d"), "Hi, Doctor! My koi fish seems sluggish and isn’t eating. I’m really worried.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 3, 20, 44, 13, 141, DateTimeKind.Local).AddTicks(8895) },
                    { new Guid("53e90abf-0c34-4ec7-83b7-6b9dbcfbc31b"), "You're welcome, always happy to help.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8890) },
                    { new Guid("59497446-6835-401c-8bc1-62eefe22fa3e"), "Hello! I’m the veterinarian. How can I assist with your koi fish?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8893) },
                    { new Guid("6c4ddaf5-5b63-4112-8d4d-fffe77b01b44"), "Sure! What do you need to know?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8880) },
                    { new Guid("7035ac12-6b7f-472d-b4e0-6ad2a06aa783"), "I have some time, do you need anything?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8875) },
                    { new Guid("83e7de91-11a5-441f-a5e7-94d6ecbcf01a"), "Hello, how are you?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8867) },
                    { new Guid("93f193be-045e-48d4-a5cd-5ad792d62d6b"), "I see. Can you tell me the water temperature and the condition of the water?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 3, 20, 45, 13, 141, DateTimeKind.Local).AddTicks(8912) },
                    { new Guid("967f650b-1b45-44a3-9644-400ea0db3aa9"), "Thank you, I’ll review it right away.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8888) },
                    { new Guid("a4773db8-0d34-4d78-8cd3-13ad2a006f55"), "Do you have detailed information about the progress?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8884) },
                    { new Guid("ba5c906b-e9ab-42a3-a3ee-0577acf073bc"), "Thank you, Doctor! I’ll check and get back if I need more help.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 3, 20, 48, 13, 141, DateTimeKind.Local).AddTicks(8920) },
                    { new Guid("be7dbc96-b41e-40ff-b5e9-80422fb1cf8a"), "I want to ask you about the new project.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8877) },
                    { new Guid("c1406147-0c0c-4137-9ca4-55e1e50bbbdc"), "I'm good, thank you! How about you?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(8870) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a87-0230-428b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca4801df-081c-4db5-a416-b04891797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("8a7205bf-02f2-46d8-8381-133cf7d32726"), null, new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(9030), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") },
                    { new Guid("9b4089a0-42cb-4e08-a88f-e825bb85f052"), null, new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(9024), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") },
                    { new Guid("dee45b24-72b0-481d-8ddb-96a277110424"), null, new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(9026), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") }
                });

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("b87a3240-e68a-4f38-8f14-7a56f7b9d123"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7654), new DateTime(2024, 11, 5, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7669), new DateTime(2024, 11, 3, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7667), new DateTime(2024, 11, 9, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7651), new DateTime(2024, 11, 4, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7661), new DateTime(2024, 11, 7, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7657), new DateTime(2024, 11, 6, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 3, 13, 43, 13, 141, DateTimeKind.Utc).AddTicks(7664), new DateTime(2024, 11, 8, 20, 43, 13, 141, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("36d69c86-7f59-4b99-881c-31155d152674"), 1000.00m, null, new DateTime(2024, 11, 3, 13, 43, 13, 142, DateTimeKind.Utc).AddTicks(1062), false, null, null, new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e") },
                    { new Guid("3c88b3a2-0871-486d-99a0-1599ce2d0f37"), 1000.00m, null, new DateTime(2024, 11, 3, 13, 43, 13, 142, DateTimeKind.Utc).AddTicks(1044), false, null, null, new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73") },
                    { new Guid("41ab5918-1e12-4081-ba2a-7b1d0e5a9259"), 1000.00m, null, new DateTime(2024, 11, 3, 13, 43, 13, 142, DateTimeKind.Utc).AddTicks(1060), false, null, null, new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359") },
                    { new Guid("6d85ebf4-c1c3-420c-820b-e86129778a35"), 1000.00m, null, new DateTime(2024, 11, 3, 13, 43, 13, 142, DateTimeKind.Utc).AddTicks(1055), false, null, null, new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") },
                    { new Guid("783ff7c9-cb6f-4f4b-8414-7a0884c3bc3f"), 1000.00m, null, new DateTime(2024, 11, 3, 13, 43, 13, 142, DateTimeKind.Utc).AddTicks(1040), false, null, null, new Guid("4feb4940-94dc-4aed-b580-ee116b668704") },
                    { new Guid("957d257f-c97c-4e64-9706-57c6986fa68e"), 1000.00m, null, new DateTime(2024, 11, 3, 13, 43, 13, 142, DateTimeKind.Utc).AddTicks(1046), false, null, null, new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") },
                    { new Guid("a72429cb-573e-4ac3-bd4b-9e2f33c94a55"), 1000.00m, null, new DateTime(2024, 11, 3, 13, 43, 13, 142, DateTimeKind.Utc).AddTicks(1057), false, null, null, new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac") }
                });
        }
    }
}
