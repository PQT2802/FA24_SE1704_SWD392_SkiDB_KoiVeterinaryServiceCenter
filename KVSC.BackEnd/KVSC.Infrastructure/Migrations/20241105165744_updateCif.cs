using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateCif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbcbb-bbbb-bcbb-bbbb-bbcbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "AppointmentVeterinarian",
                keyColumn: "Id",
                keyValue: new Guid("55555555-cccc-5555-cccc-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1029), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1016), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(997), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1004), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1026), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1001), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "Body", "CreateDate", "ImageMappingsJson", "Type", "UpdateDate" },
                values: new object[] { "\r\n                <!DOCTYPE html>\r\n\r\n<html lang=\"en\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:v=\"urn:schemas-microsoft-com:vml\">\r\n<head>\r\n<title></title>\r\n<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\"/>\r\n<meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\"/><!--[if mso]><xml><o:OfficeDocumentSettings><o:PixelsPerInch>96</o:PixelsPerInch><o:AllowPNG/></o:OfficeDocumentSettings></xml><![endif]--><!--[if !mso]><!-->\r\n<link href=\"https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900\" rel=\"stylesheet\" type=\"text/css\"/><!--<![endif]-->\r\n<style>\r\n		* {\r\n			box-sizing: border-box;\r\n		}\r\n\r\n		body {\r\n			margin: 0;\r\n			padding: 0;\r\n		}\r\n\r\n		a[x-apple-data-detectors] {\r\n			color: inherit !important;\r\n			text-decoration: inherit !important;\r\n		}\r\n\r\n		#MessageViewBody a {\r\n			color: inherit;\r\n			text-decoration: none;\r\n		}\r\n\r\n		p {\r\n			line-height: inherit\r\n		}\r\n\r\n		.desktop_hide,\r\n		.desktop_hide table {\r\n			mso-hide: all;\r\n			display: none;\r\n			max-height: 0px;\r\n			overflow: hidden;\r\n		}\r\n\r\n		.image_block img+div {\r\n			display: none;\r\n		}\r\n\r\n		sup,\r\n		sub {\r\n			font-size: 75%;\r\n			line-height: 0;\r\n		}\r\n\r\n		@media (max-width:660px) {\r\n\r\n			.desktop_hide table.icons-inner,\r\n			.social_block.desktop_hide .social-table {\r\n				display: inline-block !important;\r\n			}\r\n\r\n			.icons-inner {\r\n				text-align: center;\r\n			}\r\n\r\n			.icons-inner td {\r\n				margin: 0 auto;\r\n			}\r\n\r\n			.image_block div.fullWidth {\r\n				max-width: 100% !important;\r\n			}\r\n\r\n			.mobile_hide {\r\n				display: none;\r\n			}\r\n\r\n			.row-content {\r\n				width: 100% !important;\r\n			}\r\n\r\n			.stack .column {\r\n				width: 100%;\r\n				display: block;\r\n			}\r\n\r\n			.mobile_hide {\r\n				min-height: 0;\r\n				max-height: 0;\r\n				max-width: 0;\r\n				overflow: hidden;\r\n				font-size: 0px;\r\n			}\r\n\r\n			.desktop_hide,\r\n			.desktop_hide table {\r\n				display: table !important;\r\n				max-height: none !important;\r\n			}\r\n		}\r\n	</style><!--[if mso ]><style>sup, sub { font-size: 100% !important; } sup { mso-text-raise:10% } sub { mso-text-raise:-10% }</style> <![endif]-->\r\n</head>\r\n<body class=\"body\" style=\"background-color: #f8f8f9; margin: 0; padding: 0; -webkit-text-size-adjust: none; text-size-adjust: none;\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"nl-container\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-left:40px;padding-right:40px;width:100%;\">\r\n<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n<div class=\"fullWidth\" style=\"max-width: 352px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{Img1_2x}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"352\"/></div>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-top:50px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n	<tr>\r\n	<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n	<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:30px;line-height:120%;text-align:center;mso-line-height-alt:36px;\">\r\n	<p style=\"margin: 0; word-break: break-word;\"><span style=\"word-break: break-word; color: #2b303a;\"><strong>Verify Your Email Account</strong></span></p>\r\n	</div>\r\n	</td>\r\n	</tr>\r\n	</table>\r\n	<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n	<tr>\r\n	<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n	<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:center;mso-line-height-alt:22.5px;\">\r\n	<p style=\"margin: 0; word-break: break-word;\">\r\n	<span style=\"word-break: break-word; color: #808389;\">\r\n	We're so glad you're here. To start accessing our Koi care services, please verify your email. It only takes a moment!\r\n	</span>\r\n	</p>\r\n	<p style=\"margin: 0; word-break: break-word;\">\r\n	<span style=\"word-break: break-word; color: #808389;\">\r\n	Simply click the link below to confirm your email and unlock full access to our platform.\r\n	</span>\r\n	</p>\r\n	</div>\r\n	</td>\r\n	</tr>\r\n	</table>\r\n	<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"button_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n	<tr>\r\n	<td class=\"pad\" style=\"padding-left:10px;padding-right:10px;padding-top:15px;text-align:center;\">\r\n	<div align=\"center\" class=\"alignment\"><!--[if mso]>\r\n	<v:roundrect xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:w=\"urn:schemas-microsoft-com:office:word\" style=\"height:62px;width:222px;v-text-anchor:middle;\" arcsize=\"97%\" stroke=\"false\" fillcolor=\"#1aa19c\">\r\n	<w:anchorlock/>\r\n	<v:textbox inset=\"0px,0px,0px,0px\">\r\n	<center dir=\"false\" style=\"color:#ffffff;font-family:Tahoma, sans-serif;font-size:16px\">\r\n	<![endif]-->\r\n	<div style=\"background-color:#1aa19c;border-radius:60px;color:#ffffff;display:inline-block;font-family:Montserrat, sans-serif;font-size:16px;padding:15px 30px;text-align:center;text-decoration:none;\">\r\n		<a href=\"{VerifyURL}\" style=\"color: #ffffff; text-decoration: none; display: inline-block; line-height: 32px;\">\r\n			<strong>Confirm Your Email</strong>\r\n		</a>\r\n	</div>\r\n	<!--[if mso]></center></v:textbox></v:roundrect><![endif]-->\r\n	</div>\r\n	</td>\r\n	</tr>\r\n	</table>\r\n	\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #2b303a; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"width:100%;\">\r\n<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n<div style=\"max-width: 640px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{footer}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"640\"/></div>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:10px;padding-right:10px;padding-top:28px;text-align:center;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social-table\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; display: inline-block;\" width=\"208px\">\r\n<tr>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.facebook.com\" target=\"_blank\"><img alt=\"Facebook\" height=\"auto\" src=\"{facebook2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Facebook\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.twitter.com\" target=\"_blank\"><img alt=\"Twitter\" height=\"auto\" src=\"{twitter2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Twitter\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.instagram.com\" target=\"_blank\"><img alt=\"Instagram\" height=\"auto\" src=\"{instagram2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Instagram\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.linkedin.com\" target=\"_blank\"><img alt=\"LinkedIn\" height=\"auto\" src=\"{linkedin2x}\" style=\"display: block; height: auto; border: 0;\" title=\"LinkedIn\" width=\"32\"/></a></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:25px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 1px solid #555961;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"icons_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; text-align: center; line-height: 0;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"vertical-align: middle; color: #1e0e4b; font-family: 'Inter', sans-serif; font-size: 15px; padding-bottom: 5px; padding-top: 5px; text-align: center;\"><!--[if vml]><table align=\"center\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"display:inline-block;padding-left:0px;padding-right:0px;mso-table-lspace: 0pt;mso-table-rspace: 0pt;\"><![endif]-->\r\n<!--[if !vml]><!-->\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table><!-- End -->\r\n</body>\r\n</html>", new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(973), "{\"facebook2x\":\"EmailTemplate/e1fbe444-69f1-43f1-ac5a-5ce3e42a1e05_facebook2x.png\",\"footer\":\"EmailTemplate/305d75fc-b361-464e-937e-a495da6e4040_footer.png\",\"Img1_2x\":\"EmailTemplate/3b589f60-80a7-482c-9190-671f68b4a072_Img1_2x.jpg\",\"instagram2x\":\"EmailTemplate/39dd2a42-10b4-4449-a17e-cc5652ca7866_instagram2x.png\",\"linkedin2x\":\"EmailTemplate/54a2a542-a077-4d05-9c7a-e04c5335bf4d_linkedin2x.png\",\"twitter2x\":\"EmailTemplate/2564da8a-64ff-4fab-956e-dc0dd15c3b02_twitter2x.png\"}", "VerifyEmail", new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("104844ca-f002-4fb8-9d23-aca8efc6af38"), "I'm good too. Are you free today?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3719) },
                    { new Guid("19cd5302-99c7-4a11-8928-380647003117"), "Algae can affect water quality. I recommend checking the pH and ammonia levels. You can use a water testing kit for this.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 6, 0, 1, 43, 268, DateTimeKind.Local).AddTicks(3752) },
                    { new Guid("2798fc1e-0835-41c0-b980-42cc514a6368"), "I want to ask you about the new project.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3726) },
                    { new Guid("29e7fe9d-e163-49a5-9374-98dfd5509eba"), "I’ll send you a summary.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3735) },
                    { new Guid("3a72cc07-8e44-4865-922f-41cae24381fc"), "Thank you, Doctor! I’ll check and get back if I need more help.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 6, 0, 2, 43, 268, DateTimeKind.Local).AddTicks(3757) },
                    { new Guid("50d56e05-f869-4726-a6ab-3f97992b25fc"), "I have some time, do you need anything?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3722) },
                    { new Guid("6c18ef5d-fb0e-420d-a68a-9e15bdd5e6e8"), "The water temperature is 20°C, and the water seems clear, but I noticed a bit of green algae.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 6, 0, 0, 43, 268, DateTimeKind.Local).AddTicks(3750) },
                    { new Guid("86d285a3-8358-4ea3-9e39-6b93ecb1e280"), "Thank you, I’ll review it right away.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3737) },
                    { new Guid("937932c6-5c99-4770-8881-8ceb0b5aa07b"), "Sure! What do you need to know?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3728) },
                    { new Guid("9e1058d4-41c1-4763-9924-5a7f7b63b8e5"), "I see. Can you tell me the water temperature and the condition of the water?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 5, 23, 59, 43, 268, DateTimeKind.Local).AddTicks(3748) },
                    { new Guid("bf93c0e6-741e-426d-aece-5cf32916b482"), "Hello, how are you?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3714) },
                    { new Guid("c4befe4e-b9e4-4acb-93b7-b3b6c4fc3fc3"), "I'm good, thank you! How about you?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3717) },
                    { new Guid("cb006555-2fac-4f70-afeb-e1d367c72723"), "Hello! I’m the veterinarian. How can I assist with your koi fish?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3742) },
                    { new Guid("cdd1463f-a32a-4f5d-a9de-4e978faf356b"), "Do you have detailed information about the progress?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3731) },
                    { new Guid("d6cf1dd0-850d-4f5f-b959-20b65e821c2b"), "You're welcome, always happy to help.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(3740) },
                    { new Guid("d989dc75-a7cd-4acf-b707-a7189480c188"), "Hi, Doctor! My koi fish seems sluggish and isn’t eating. I’m really worried.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 5, 23, 58, 43, 268, DateTimeKind.Local).AddTicks(3744) }
                });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "PetHabitat",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("c33e3a87-0230-428b-8c06-ee91b7e8cc21"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "PetService",
                keyColumn: "Id",
                keyValue: new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca3801df-081c-4db5-a416-b04791797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("ca4801df-081c-4db5-a416-b04891797d92"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "PetServiceCategory",
                keyColumn: "Id",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e2222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e3333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e4444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e5555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e6666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e7777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e8888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("e9999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "PetType",
                keyColumn: "Id",
                keyValue: new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("1be9efc7-1ac7-421a-a404-5c94c16284ed"), null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3866), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") },
                    { new Guid("2f4b50b1-3969-4a7f-b89c-e26563ef12c9"), null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3864), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") },
                    { new Guid("72dae271-5832-4a56-ad84-8c9b7414abdf"), null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3871), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") }
                });

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "ServiceReport",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("b87a3240-e68a-4f38-8f14-7a56f7b9d123"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Veterinarian",
                keyColumn: "Id",
                keyValue: new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2053), new DateTime(2024, 11, 5, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2068), new DateTime(2024, 11, 10, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2065), new DateTime(2024, 11, 9, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2048), new DateTime(2024, 11, 11, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2058), new DateTime(2024, 11, 7, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2055), new DateTime(2024, 11, 6, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "VeterinarianSchedule",
                keyColumn: "Id",
                keyValue: new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(2063), new DateTime(2024, 11, 8, 23, 57, 43, 268, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("4747b09b-55ed-4d24-bb66-fbde510a2466"), 1000.00m, null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(6859), false, null, null, new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") },
                    { new Guid("5371a6f4-647b-4cb6-9b50-adbcbf3cd3e9"), 1000.00m, null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(6862), false, null, null, new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac") },
                    { new Guid("68958d7c-8564-49c1-976d-37c715be082d"), 1000.00m, null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(6867), false, null, null, new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e") },
                    { new Guid("6e4ea544-d1ae-4a5b-bba5-a1194af24938"), 1000.00m, null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(6850), false, null, null, new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") },
                    { new Guid("71800e9e-32f0-4946-8ad2-b145487535f4"), 1000.00m, null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(6846), false, null, null, new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73") },
                    { new Guid("a86f93d7-d319-4a51-b8ff-546cfe2bd391"), 1000.00m, null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(6842), false, null, null, new Guid("4feb4940-94dc-4aed-b580-ee116b668704") },
                    { new Guid("a96fde2c-8c16-4baa-b3ab-31ecdce29c74"), 1000.00m, null, new DateTime(2024, 11, 5, 16, 57, 43, 268, DateTimeKind.Utc).AddTicks(6865), false, null, null, new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("104844ca-f002-4fb8-9d23-aca8efc6af38"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("19cd5302-99c7-4a11-8928-380647003117"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("2798fc1e-0835-41c0-b980-42cc514a6368"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("29e7fe9d-e163-49a5-9374-98dfd5509eba"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("3a72cc07-8e44-4865-922f-41cae24381fc"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("50d56e05-f869-4726-a6ab-3f97992b25fc"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("6c18ef5d-fb0e-420d-a68a-9e15bdd5e6e8"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("86d285a3-8358-4ea3-9e39-6b93ecb1e280"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("937932c6-5c99-4770-8881-8ceb0b5aa07b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("9e1058d4-41c1-4763-9924-5a7f7b63b8e5"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("bf93c0e6-741e-426d-aece-5cf32916b482"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("c4befe4e-b9e4-4acb-93b7-b3b6c4fc3fc3"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("cb006555-2fac-4f70-afeb-e1d367c72723"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("cdd1463f-a32a-4f5d-a9de-4e978faf356b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("d6cf1dd0-850d-4f5f-b959-20b65e821c2b"));

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: new Guid("d989dc75-a7cd-4acf-b707-a7189480c188"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("1be9efc7-1ac7-421a-a404-5c94c16284ed"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("2f4b50b1-3969-4a7f-b89c-e26563ef12c9"));

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: new Guid("72dae271-5832-4a56-ad84-8c9b7414abdf"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("4747b09b-55ed-4d24-bb66-fbde510a2466"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("5371a6f4-647b-4cb6-9b50-adbcbf3cd3e9"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("68958d7c-8564-49c1-976d-37c715be082d"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("6e4ea544-d1ae-4a5b-bba5-a1194af24938"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("71800e9e-32f0-4946-8ad2-b145487535f4"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("a86f93d7-d319-4a51-b8ff-546cfe2bd391"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("a96fde2c-8c16-4baa-b3ab-31ecdce29c74"));

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
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3512), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3506), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3500), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3484), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3497), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3494), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3503), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3509), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3487), new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "EmailTemplate",
                keyColumn: "EmailTemplateId",
                keyValue: new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                columns: new[] { "Body", "CreateDate", "ImageMappingsJson", "Type", "UpdateDate" },
                values: new object[] { "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>You have a new appointment notification for your koi fish:</p>\r\n                    <p>{{AppointmentDetails}}</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3469), "{}", "AppointmentNotification", new DateTime(2024, 11, 5, 19, 41, 3, 379, DateTimeKind.Local).AddTicks(3480) });

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
    }
}
