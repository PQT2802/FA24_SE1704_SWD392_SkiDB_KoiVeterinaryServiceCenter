using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KVSC.Infrastructure.DB.Migrations
{
    /// <inheritdoc />
    public partial class addpetServiceCate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PetService",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PetServiceCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicableTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServiceCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetService_PetServiceCategoryId",
                table: "PetService",
                column: "PetServiceCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PetService_PetServiceCategory_PetServiceCategoryId",
                table: "PetService",
                column: "PetServiceCategoryId",
                principalTable: "PetServiceCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetService_PetServiceCategory_PetServiceCategoryId",
                table: "PetService");

            migrationBuilder.DropTable(
                name: "PetServiceCategory");

            migrationBuilder.DropIndex(
                name: "IX_PetService_PetServiceCategoryId",
                table: "PetService");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PetService");
        }
    }
}
