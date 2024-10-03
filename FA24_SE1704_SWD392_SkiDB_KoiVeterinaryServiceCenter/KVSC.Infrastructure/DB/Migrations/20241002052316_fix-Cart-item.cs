using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KVSC.Infrastructure.DB.Migrations
{
    /// <inheritdoc />
    public partial class fixCartitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_CustomerId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_PetService_PetServiceId",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_PetServiceId",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CustomerId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "PetServiceId",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Cart");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Cart",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_UserId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cart");

            migrationBuilder.AddColumn<Guid>(
                name: "PetServiceId",
                table: "CartItem",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "CartItem",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Cart",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_PetServiceId",
                table: "CartItem",
                column: "PetServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CustomerId",
                table: "Cart",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_CustomerId",
                table: "Cart",
                column: "CustomerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_PetService_PetServiceId",
                table: "CartItem",
                column: "PetServiceId",
                principalTable: "PetService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
