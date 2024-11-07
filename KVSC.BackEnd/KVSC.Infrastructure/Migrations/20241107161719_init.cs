﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComboService",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                columns: table => new
                {
                    EmailTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageMappingsJson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplate", x => x.EmailTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetHabitat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HabitatType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetHabitat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetServiceCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicableTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServiceCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    role = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeneralType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecificType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetHabitatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetType_PetHabitat_PetHabitatId",
                        column: x => x.PetHabitatId,
                        principalTable: "PetHabitat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetService",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetServiceCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TravelCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetService_PetServiceCategory_PetServiceCategoryId",
                        column: x => x.PetServiceCategoryId,
                        principalTable: "PetServiceCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_User_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_User_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserEmail",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmail", x => new { x.UserID, x.EmailTemplateId });
                    table.ForeignKey(
                        name: "FK_UserEmail_EmailTemplate_EmailTemplateId",
                        column: x => x.EmailTemplateId,
                        principalTable: "EmailTemplate",
                        principalColumn: "EmailTemplateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEmail_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veterinarian",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarian", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veterinarian_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LastHealthCheck = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthStatus = table.Column<int>(type: "int", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pet_PetType_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pet_User_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComboServiceItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComboServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboServiceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComboServiceItem_ComboService_ComboServiceId",
                        column: x => x.ComboServiceId,
                        principalTable: "ComboService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComboServiceItem_PetService_PetServiceId",
                        column: x => x.PetServiceId,
                        principalTable: "PetService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_PetService_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "PetService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rating_User_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PetServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OrderHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_PetService_PetServiceId",
                        column: x => x.PetServiceId,
                        principalTable: "PetService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VeterinarianSchedule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VeterinarianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeterinarianSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VeterinarianSchedule_Veterinarian_VeterinarianId",
                        column: x => x.VeterinarianId,
                        principalTable: "Veterinarian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PetServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ComboServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointment_ComboService_ComboServiceId",
                        column: x => x.ComboServiceId,
                        principalTable: "ComboService",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointment_PetService_PetServiceId",
                        column: x => x.PetServiceId,
                        principalTable: "PetService",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointment_Pet_PetId",
                        column: x => x.PetId,
                        principalTable: "Pet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointment_User_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VeterinarianId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TravelCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_PetService_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "PetService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Pet_PetId",
                        column: x => x.PetId,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_User_VeterinarianId",
                        column: x => x.VeterinarianId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentVeterinarian",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VeterinarianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentVeterinarian", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentVeterinarian_Appointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentVeterinarian_Veterinarian_VeterinarianId",
                        column: x => x.VeterinarianId,
                        principalTable: "Veterinarian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalAmountStatus = table.Column<bool>(type: "bit", nullable: false),
                    depositStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Appointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceReport",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Recommendations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasPrescription = table.Column<bool>(type: "bit", nullable: false),
                    PrescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceReport_Appointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrescriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescription_ServiceReport_ServiceReportId",
                        column: x => x.ServiceReportId,
                        principalTable: "ServiceReport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionDetail",
                columns: table => new
                {
                    PrescriptionDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionDetail", x => x.PrescriptionDetailId);
                    table.ForeignKey(
                        name: "FK_PrescriptionDetail_Prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionDetail_Product_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "EmailTemplate",
                columns: new[] { "EmailTemplateId", "Body", "CreateBy", "CreateDate", "ImageMappingsJson", "IsDelete", "Subject", "Type", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your service titled '{{ServiceTitle}}' has been deactivated for the following reason:</p>\r\n                    <p>{{DeactivationReason}}</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(137), "{}", false, "Service Deactivation Notification", "DeactivateService", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(138) },
                    { new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your account has been deactivated. If you think this is a mistake, please contact our support team.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(129), "{}", false, "Account Deactivation", "DeactivateUser", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(129) },
                    { new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>We are pleased to inform you that your appointment for koi fish care has been approved.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(122), "{}", false, "Appointment Approval Notification", "ApproveAppointment", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(123) },
                    { new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"), "\r\n                <!DOCTYPE html>\r\n\r\n<html lang=\"en\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:v=\"urn:schemas-microsoft-com:vml\">\r\n<head>\r\n<title></title>\r\n<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\"/>\r\n<meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\"/><!--[if mso]><xml><o:OfficeDocumentSettings><o:PixelsPerInch>96</o:PixelsPerInch><o:AllowPNG/></o:OfficeDocumentSettings></xml><![endif]--><!--[if !mso]><!-->\r\n<link href=\"https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900\" rel=\"stylesheet\" type=\"text/css\"/><!--<![endif]-->\r\n<style>\r\n		* {\r\n			box-sizing: border-box;\r\n		}\r\n\r\n		body {\r\n			margin: 0;\r\n			padding: 0;\r\n		}\r\n\r\n		a[x-apple-data-detectors] {\r\n			color: inherit !important;\r\n			text-decoration: inherit !important;\r\n		}\r\n\r\n		#MessageViewBody a {\r\n			color: inherit;\r\n			text-decoration: none;\r\n		}\r\n\r\n		p {\r\n			line-height: inherit\r\n		}\r\n\r\n		.desktop_hide,\r\n		.desktop_hide table {\r\n			mso-hide: all;\r\n			display: none;\r\n			max-height: 0px;\r\n			overflow: hidden;\r\n		}\r\n\r\n		.image_block img+div {\r\n			display: none;\r\n		}\r\n\r\n		sup,\r\n		sub {\r\n			font-size: 75%;\r\n			line-height: 0;\r\n		}\r\n\r\n		@media (max-width:660px) {\r\n\r\n			.desktop_hide table.icons-inner,\r\n			.social_block.desktop_hide .social-table {\r\n				display: inline-block !important;\r\n			}\r\n\r\n			.icons-inner {\r\n				text-align: center;\r\n			}\r\n\r\n			.icons-inner td {\r\n				margin: 0 auto;\r\n			}\r\n\r\n			.image_block div.fullWidth {\r\n				max-width: 100% !important;\r\n			}\r\n\r\n			.mobile_hide {\r\n				display: none;\r\n			}\r\n\r\n			.row-content {\r\n				width: 100% !important;\r\n			}\r\n\r\n			.stack .column {\r\n				width: 100%;\r\n				display: block;\r\n			}\r\n\r\n			.mobile_hide {\r\n				min-height: 0;\r\n				max-height: 0;\r\n				max-width: 0;\r\n				overflow: hidden;\r\n				font-size: 0px;\r\n			}\r\n\r\n			.desktop_hide,\r\n			.desktop_hide table {\r\n				display: table !important;\r\n				max-height: none !important;\r\n			}\r\n		}\r\n	</style><!--[if mso ]><style>sup, sub { font-size: 100% !important; } sup { mso-text-raise:10% } sub { mso-text-raise:-10% }</style> <![endif]-->\r\n</head>\r\n<body class=\"body\" style=\"background-color: #f8f8f9; margin: 0; padding: 0; -webkit-text-size-adjust: none; text-size-adjust: none;\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"nl-container\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n	<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n							<tr>\r\n								<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n							</tr>\r\n						</table>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-left:40px;padding-right:40px;width:100%;\">\r\n					<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n						<div class=\"fullWidth\" style=\"max-width: 352px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{Img1_2x}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"352\" /></div>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-top:50px;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n							<tr>\r\n								<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n							</tr>\r\n						</table>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n					<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:30px;line-height:120%;text-align:center;mso-line-height-alt:36px;\">\r\n						<p style=\"margin: 0; word-break: break-word;\"><span style=\"word-break: break-word; color: #2b303a;\"><strong>Appointment Confirmation</strong></span></p>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n					<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:center;mso-line-height-alt:22.5px;\">\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\">\r\n								Hello {Name},\r\n							</span>\r\n						</p>\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\">\r\n								We’re confirming your appointment with us for our Koi care service. Please review the details below and click the button to view the appointment information.\r\n							</span>\r\n						</p>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n					<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:left;mso-line-height-alt:22.5px;\">\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\"><strong>Appointment Date:</strong> {AppointmentDate}</span>\r\n						</p>\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\"><strong>Time:</strong> {AppointmentTime}</span>\r\n						</p>\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\"><strong>Service:</strong> {ServiceName}</span>\r\n						</p>\r\n						<p style=\"margin: 0; word-break: break-word;\">\r\n							<span style=\"word-break: break-word; color: #808389;\"><strong>Pet:</strong> {PetName}</span>\r\n						</p>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"button_block block-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-left:10px;padding-right:10px;padding-top:15px;text-align:center;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<!--[if mso]>\r\n					<v:roundrect xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:w=\"urn:schemas-microsoft-com:office:word\" style=\"height:62px;width:222px;v-text-anchor:middle;\" arcsize=\"97%\" stroke=\"false\" fillcolor=\"#1aa19c\">\r\n					<w:anchorlock/>\r\n					<v:textbox inset=\"0px,0px,0px,0px\">\r\n					<center dir=\"false\" style=\"color:#ffffff;font-family:Tahoma, sans-serif;font-size:16px\">\r\n					<![endif]-->\r\n						<div style=\"background-color:#1aa19c;border-radius:60px;color:#ffffff;display:inline-block;font-family:Montserrat, sans-serif;font-size:16px;padding:15px 30px;text-align:center;text-decoration:none;\">\r\n							<a href=\"{AppointmentDetailURL}\" style=\"color: #ffffff; text-decoration: none; display: inline-block; line-height: 32px;\">\r\n								<strong>View Appointment Details</strong>\r\n							</a>\r\n						</div>\r\n						<!--[if mso]></center></v:textbox></v:roundrect><![endif]-->\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-8\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n							<tr>\r\n								<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n							</tr>\r\n						</table>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n\r\n\r\n		<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n			<tr>\r\n				<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n					<div align=\"center\" class=\"alignment\">\r\n						<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n							<tr>\r\n								<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n							</tr>\r\n						</table>\r\n					</div>\r\n				</td>\r\n			</tr>\r\n		</table>\r\n	</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #2b303a; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"width:100%;\">\r\n<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n<div style=\"max-width: 640px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{footer}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"640\"/></div>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:10px;padding-right:10px;padding-top:28px;text-align:center;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social-table\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; display: inline-block;\" width=\"208px\">\r\n<tr>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.facebook.com\" target=\"_blank\"><img alt=\"Facebook\" height=\"auto\" src=\"{facebook2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Facebook\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.twitter.com\" target=\"_blank\"><img alt=\"Twitter\" height=\"auto\" src=\"{twitter2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Twitter\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.instagram.com\" target=\"_blank\"><img alt=\"Instagram\" height=\"auto\" src=\"{instagram2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Instagram\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.linkedin.com\" target=\"_blank\"><img alt=\"LinkedIn\" height=\"auto\" src=\"{linkedin2x}\" style=\"display: block; height: auto; border: 0;\" title=\"LinkedIn\" width=\"32\"/></a></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:25px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 1px solid #555961;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"icons_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; text-align: center; line-height: 0;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"vertical-align: middle; color: #1e0e4b; font-family: 'Inter', sans-serif; font-size: 15px; padding-bottom: 5px; padding-top: 5px; text-align: center;\"><!--[if vml]><table align=\"center\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"display:inline-block;padding-left:0px;padding-right:0px;mso-table-lspace: 0pt;mso-table-rspace: 0pt;\"><![endif]-->\r\n<!--[if !vml]><!-->\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table><!-- End -->\r\n</body>\r\n</html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(110), "{\"facebook2x\":\"EmailTemplate/c387781f-57b2-4daa-8dbb-74ae478b3527_facebook2x.png\",\"footer\":\"EmailTemplate/8d6faaac-8b6f-4ec9-a169-af2c3fdf0a1f_footer.png\",\"Img1_2x\":\"EmailTemplate/63acd16b-f91d-4158-957d-a0f873fd9bd0_Img1_2x.png\",\"instagram2x\":\"EmailTemplate/b0c0fa7e-ee9b-45d7-a804-07f37d96008b_instagram2x.png\",\"linkedin2x\":\"EmailTemplate/202c8e61-533b-4ffb-9639-a038de869c0c_linkedin2x.png\",\"twitter2x\":\"EmailTemplate/e576f46a-a7de-4ad3-81dd-7297fbde391d_twitter2x.png\"}", false, "Appointment Booking Notification", "MakeAppointment", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(111) },
                    { new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>We regret to inform you that your appointment for koi services has been rejected for the following reason:</p>\r\n                    <p>{{RejectionReason}}</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(119), "{}", false, "Appointment Rejection Notification", "RejectAppointment", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(120) },
                    { new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Thank you for registering with the Koi Veterinary Service Center. Please confirm your account by clicking the link below:</p>\r\n                    <p><a href='{{ConfirmationLink}}'>Confirm Account</a></p>\r\n                    <p>If you did not register, please ignore this email.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(116), "{}", false, "Account Confirmation", "ConfirmationAccount", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(117) },
                    { new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your account has been successfully activated. You can now log in and start using our koi veterinary services.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(126), "{}", false, "Ac", "ActivateUser", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(126) },
                    { new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"), "\r\n                <html>\r\n                <body>\r\n                    <p>Dear {{UserName}},</p>\r\n                    <p>Your requested koi service titled '{{ServiceTitle}}' has been successfully updated.</p>\r\n                    <p>If you have any questions or need further assistance, please feel free to reach out to us.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(134), "{}", false, "Service Update Notification", "UpdateService", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(135) },
                    { new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your password has been successfully reset. You can now log in with your new password.</p>\r\n                    <p>If you did not request this change, please contact our support team immediately.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(113), "{}", false, "Your Password Has Been Reset", "ResetPassword", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(114) },
                    { new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), "\r\n                <!DOCTYPE html>\r\n\r\n<html lang=\"en\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:v=\"urn:schemas-microsoft-com:vml\">\r\n<head>\r\n<title></title>\r\n<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\"/>\r\n<meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\"/><!--[if mso]><xml><o:OfficeDocumentSettings><o:PixelsPerInch>96</o:PixelsPerInch><o:AllowPNG/></o:OfficeDocumentSettings></xml><![endif]--><!--[if !mso]><!-->\r\n<link href=\"https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900\" rel=\"stylesheet\" type=\"text/css\"/><!--<![endif]-->\r\n<style>\r\n		* {\r\n			box-sizing: border-box;\r\n		}\r\n\r\n		body {\r\n			margin: 0;\r\n			padding: 0;\r\n		}\r\n\r\n		a[x-apple-data-detectors] {\r\n			color: inherit !important;\r\n			text-decoration: inherit !important;\r\n		}\r\n\r\n		#MessageViewBody a {\r\n			color: inherit;\r\n			text-decoration: none;\r\n		}\r\n\r\n		p {\r\n			line-height: inherit\r\n		}\r\n\r\n		.desktop_hide,\r\n		.desktop_hide table {\r\n			mso-hide: all;\r\n			display: none;\r\n			max-height: 0px;\r\n			overflow: hidden;\r\n		}\r\n\r\n		.image_block img+div {\r\n			display: none;\r\n		}\r\n\r\n		sup,\r\n		sub {\r\n			font-size: 75%;\r\n			line-height: 0;\r\n		}\r\n\r\n		@media (max-width:660px) {\r\n\r\n			.desktop_hide table.icons-inner,\r\n			.social_block.desktop_hide .social-table {\r\n				display: inline-block !important;\r\n			}\r\n\r\n			.icons-inner {\r\n				text-align: center;\r\n			}\r\n\r\n			.icons-inner td {\r\n				margin: 0 auto;\r\n			}\r\n\r\n			.image_block div.fullWidth {\r\n				max-width: 100% !important;\r\n			}\r\n\r\n			.mobile_hide {\r\n				display: none;\r\n			}\r\n\r\n			.row-content {\r\n				width: 100% !important;\r\n			}\r\n\r\n			.stack .column {\r\n				width: 100%;\r\n				display: block;\r\n			}\r\n\r\n			.mobile_hide {\r\n				min-height: 0;\r\n				max-height: 0;\r\n				max-width: 0;\r\n				overflow: hidden;\r\n				font-size: 0px;\r\n			}\r\n\r\n			.desktop_hide,\r\n			.desktop_hide table {\r\n				display: table !important;\r\n				max-height: none !important;\r\n			}\r\n		}\r\n	</style><!--[if mso ]><style>sup, sub { font-size: 100% !important; } sup { mso-text-raise:10% } sub { mso-text-raise:-10% }</style> <![endif]-->\r\n</head>\r\n<body class=\"body\" style=\"background-color: #f8f8f9; margin: 0; padding: 0; -webkit-text-size-adjust: none; text-size-adjust: none;\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"nl-container\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #1aa19c; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #fff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-left:40px;padding-right:40px;width:100%;\">\r\n<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n<div class=\"fullWidth\" style=\"max-width: 352px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{Img1_2x}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"352\"/></div>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-3\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-top:50px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n	<tr>\r\n	<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n	<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:30px;line-height:120%;text-align:center;mso-line-height-alt:36px;\">\r\n	<p style=\"margin: 0; word-break: break-word;\"><span style=\"word-break: break-word; color: #2b303a;\"><strong>Verify Your Email Account</strong></span></p>\r\n	</div>\r\n	</td>\r\n	</tr>\r\n	</table>\r\n	<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"paragraph_block block-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; word-break: break-word;\" width=\"100%\">\r\n	<tr>\r\n	<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px;\">\r\n	<div style=\"color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;font-size:15px;line-height:150%;text-align:center;mso-line-height-alt:22.5px;\">\r\n	<p style=\"margin: 0; word-break: break-word;\">\r\n	<span style=\"word-break: break-word; color: #808389;\">\r\n	We're so glad you're here. To start accessing our Koi care services, please verify your email. It only takes a moment!\r\n	</span>\r\n	</p>\r\n	<p style=\"margin: 0; word-break: break-word;\">\r\n	<span style=\"word-break: break-word; color: #808389;\">\r\n	Simply click the link below to confirm your email and unlock full access to our platform.\r\n	</span>\r\n	</p>\r\n	</div>\r\n	</td>\r\n	</tr>\r\n	</table>\r\n	<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"button_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n	<tr>\r\n	<td class=\"pad\" style=\"padding-left:10px;padding-right:10px;padding-top:15px;text-align:center;\">\r\n	<div align=\"center\" class=\"alignment\"><!--[if mso]>\r\n	<v:roundrect xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:w=\"urn:schemas-microsoft-com:office:word\" style=\"height:62px;width:222px;v-text-anchor:middle;\" arcsize=\"97%\" stroke=\"false\" fillcolor=\"#1aa19c\">\r\n	<w:anchorlock/>\r\n	<v:textbox inset=\"0px,0px,0px,0px\">\r\n	<center dir=\"false\" style=\"color:#ffffff;font-family:Tahoma, sans-serif;font-size:16px\">\r\n	<![endif]-->\r\n	<div style=\"background-color:#1aa19c;border-radius:60px;color:#ffffff;display:inline-block;font-family:Montserrat, sans-serif;font-size:16px;padding:15px 30px;text-align:center;text-decoration:none;\">\r\n		<a href=\"{VerifyURL}\" style=\"color: #ffffff; text-decoration: none; display: inline-block; line-height: 32px;\">\r\n			<strong>Confirm Your Email</strong>\r\n		</a>\r\n	</div>\r\n	<!--[if mso]></center></v:textbox></v:roundrect><![endif]-->\r\n	</div>\r\n	</td>\r\n	</tr>\r\n	</table>\r\n	\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:12px;padding-top:60px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-5\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f8f8f9; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"20\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 0px solid #BBBBBB;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #2b303a; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 4px solid #1AA19C;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"image_block block-2\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"width:100%;\">\r\n<div align=\"center\" class=\"alignment\" style=\"line-height:10px\">\r\n<div style=\"max-width: 640px;\"><img alt=\"I'm an image\" height=\"auto\" src=\"{footer}\" style=\"display: block; height: auto; border: 0; width: 100%;\" title=\"I'm an image\" width=\"640\"/></div>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social_block block-4\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:10px;padding-right:10px;padding-top:28px;text-align:center;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"social-table\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; display: inline-block;\" width=\"208px\">\r\n<tr>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.facebook.com\" target=\"_blank\"><img alt=\"Facebook\" height=\"auto\" src=\"{facebook2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Facebook\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.twitter.com\" target=\"_blank\"><img alt=\"Twitter\" height=\"auto\" src=\"{twitter2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Twitter\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.instagram.com\" target=\"_blank\"><img alt=\"Instagram\" height=\"auto\" src=\"{instagram2x}\" style=\"display: block; height: auto; border: 0;\" title=\"Instagram\" width=\"32\"/></a></td>\r\n<td style=\"padding:0 10px 0 10px;\"><a href=\"https://www.linkedin.com\" target=\"_blank\"><img alt=\"LinkedIn\" height=\"auto\" src=\"{linkedin2x}\" style=\"display: block; height: auto; border: 0;\" title=\"LinkedIn\" width=\"32\"/></a></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"divider_block block-6\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:25px;\">\r\n<div align=\"center\" class=\"alignment\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt;\" width=\"100%\">\r\n<tr>\r\n<td class=\"divider_inner\" style=\"font-size: 1px; line-height: 1px; border-top: 1px solid #555961;\"><span style=\"word-break: break-word;\"> </span></td>\r\n</tr>\r\n</table>\r\n</div>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row row-7\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff;\" width=\"100%\">\r\n<tbody>\r\n<tr>\r\n<td>\r\n<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"row-content stack\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #ffffff; color: #000000; width: 640px; margin: 0 auto;\" width=\"640\">\r\n<tbody>\r\n<tr>\r\n<td class=\"column column-1\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; font-weight: 400; text-align: left; padding-bottom: 5px; padding-top: 5px; vertical-align: top; border-top: 0px; border-right: 0px; border-bottom: 0px; border-left: 0px;\" width=\"100%\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"icons_block block-1\" role=\"presentation\" style=\"mso-table-lspace: 0pt; mso-table-rspace: 0pt; text-align: center; line-height: 0;\" width=\"100%\">\r\n<tr>\r\n<td class=\"pad\" style=\"vertical-align: middle; color: #1e0e4b; font-family: 'Inter', sans-serif; font-size: 15px; padding-bottom: 5px; padding-top: 5px; text-align: center;\"><!--[if vml]><table align=\"center\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\" style=\"display:inline-block;padding-left:0px;padding-right:0px;mso-table-lspace: 0pt;mso-table-rspace: 0pt;\"><![endif]-->\r\n<!--[if !vml]><!-->\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table>\r\n</td>\r\n</tr>\r\n</tbody>\r\n</table><!-- End -->\r\n</body>\r\n</html>", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(93), "{\"facebook2x\":\"EmailTemplate/e1fbe444-69f1-43f1-ac5a-5ce3e42a1e05_facebook2x.png\",\"footer\":\"EmailTemplate/305d75fc-b361-464e-937e-a495da6e4040_footer.png\",\"Img1_2x\":\"EmailTemplate/3b589f60-80a7-482c-9190-671f68b4a072_Img1_2x.jpg\",\"instagram2x\":\"EmailTemplate/39dd2a42-10b4-4449-a17e-cc5652ca7866_instagram2x.png\",\"linkedin2x\":\"EmailTemplate/54a2a542-a077-4d05-9c7a-e04c5335bf4d_linkedin2x.png\",\"twitter2x\":\"EmailTemplate/2564da8a-64ff-4fab-956e-dc0dd15c3b02_twitter2x.png\"}", false, "Account Activation", "VerifyEmail", "System", new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(105) }
                });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("01c227ba-e577-4d8e-844d-9e0b713dbd3e"), "Could it be something with the tank setup? I haven’t changed anything, though.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 4, 16, 42, 16, 894, DateTimeKind.Utc).AddTicks(3004) },
                    { new Guid("0f36879b-25c2-4c7b-80d7-9fb4e79ea1b0"), "I have some time, do you need anything?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2922) },
                    { new Guid("1573dda8-5e35-414b-bbb2-42e7ea5c2464"), "Thank you, Doctor! I will try changing the food. Hopefully, they will eat better.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new DateTime(2024, 11, 5, 16, 23, 16, 894, DateTimeKind.Utc).AddTicks(2984) },
                    { new Guid("207b49eb-a2b9-4636-83d5-ad0a1ddf1e84"), "Sounds good. Don’t worry, we’ll do everything we can to help your Koi recover.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 4, 16, 57, 16, 894, DateTimeKind.Utc).AddTicks(3012) },
                    { new Guid("2a69ea12-1fc9-4c11-89d1-5fcece36d597"), "I'm good, thank you! How about you?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2917) },
                    { new Guid("406f7ffa-4e40-4876-8101-96ff54d71100"), "Thank you, doctor. I’ll bring in a water sample as well. Hopefully, we can find what’s wrong.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 4, 16, 52, 16, 894, DateTimeKind.Utc).AddTicks(3009) },
                    { new Guid("42d323e9-6e65-4a5b-9d2e-f13a26dbef31"), "Hi, Doctor! I would like to ask about the diet for my Koi fish. They seem to be picky eaters.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new DateTime(2024, 11, 5, 16, 19, 16, 894, DateTimeKind.Utc).AddTicks(2970) },
                    { new Guid("4d2358b0-5ad9-4557-be1f-3b3f80c44df8"), "Do you have detailed information about the progress?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2932) },
                    { new Guid("59484891-2e24-49ba-9454-66c9ade9f4c5"), "Algae can affect water quality. I recommend checking the pH and ammonia levels. You can use a water testing kit for this.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 6, 16, 21, 16, 894, DateTimeKind.Utc).AddTicks(2962) },
                    { new Guid("5be957ee-a79f-4402-a363-a7d033d03947"), "It could be due to poor water conditions or unsuitable food. Could you let me know the water temperature and what type of food you are using?", new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 16, 20, 16, 894, DateTimeKind.Utc).AddTicks(2973) },
                    { new Guid("62454d30-fc96-46f3-89dc-03e0486be575"), "Sure! What do you need to know?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2929) },
                    { new Guid("772ffbac-b3e8-483f-87d6-576563e4e48c"), "Hi, Doctor! My koi fish seems sluggish and isn’t eating. I’m really worried.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 6, 16, 18, 16, 894, DateTimeKind.Utc).AddTicks(2944) },
                    { new Guid("7d8d5c26-f34e-492c-9735-741382f0bc94"), "It’s possible. Even minor changes in water temperature or pH can stress Koi. I’d suggest we test the water, and I can also examine your fish for any signs of disease.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 4, 16, 47, 16, 894, DateTimeKind.Utc).AddTicks(3006) },
                    { new Guid("8b38fbe0-3627-4d35-9659-e8f85e5cfe65"), "The temperature is fine, but you might want to try switching to a different food, like ABC, to see if they respond better.", new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 16, 22, 16, 894, DateTimeKind.Utc).AddTicks(2981) },
                    { new Guid("8dbeddc4-0489-4f7c-8834-b4cd36c1953a"), "Thank you, I’ll review it right away.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2937) },
                    { new Guid("96ad1a96-92ad-42f2-b4e4-ab26703878d8"), "Hello! I’m Dr. Smith, the veterinarian. I see you have an appointment regarding your Koi fish. How can I assist you today?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 4, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2989) },
                    { new Guid("9b31da98-6753-4df4-b879-b105ed2c8218"), "I’ll send you a summary.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2934) },
                    { new Guid("a12bd30c-7289-49ba-b68a-ed305ff41a18"), "Hello, how are you?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2911) },
                    { new Guid("a348fd07-d0d6-46b1-8ac3-7d21bee06c31"), "I see. Can you tell me the water temperature and the condition of the water?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 6, 16, 19, 16, 894, DateTimeKind.Utc).AddTicks(2949) },
                    { new Guid("b1b98c61-8f1a-41cf-b74b-a62a919f8444"), "You're welcome, always happy to help.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2939) },
                    { new Guid("bf9236e0-cf1d-409e-88af-95f9ab47b459"), "Hello! I am a veterinarian specializing in Koi fish. What can I assist you with today?", new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 16, 18, 16, 894, DateTimeKind.Utc).AddTicks(2968) },
                    { new Guid("c26d00bd-3a1a-4caa-a390-6892aba15950"), "Thank you, Doctor! I’ll check and get back if I need more help.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 6, 16, 22, 16, 894, DateTimeKind.Utc).AddTicks(2965) },
                    { new Guid("cb629d99-7076-4e44-aa86-95c4b24f41f4"), "The water temperature is 24 degrees Celsius, and I'm feeding them XYZ brand pellets.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new DateTime(2024, 11, 5, 16, 21, 16, 894, DateTimeKind.Utc).AddTicks(2976) },
                    { new Guid("cf750413-2613-4ef9-a731-21e371faa19f"), "Hello! I’m the veterinarian. How can I assist with your koi fish?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 6, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2941) },
                    { new Guid("d4b52719-b0d0-49b7-9951-d5f120a8f8bd"), "Yes, actually! It hasn’t been eating as much as it used to, and sometimes it seems to swim sideways.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 4, 16, 32, 16, 894, DateTimeKind.Utc).AddTicks(2997) },
                    { new Guid("d50baebc-f9ab-4121-9691-ea1f54075a9c"), "Hello, doctor! My Koi fish has been acting strange lately, staying at the bottom of the tank and losing color.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 4, 16, 22, 16, 894, DateTimeKind.Utc).AddTicks(2992) },
                    { new Guid("e2434c1a-4fba-40e8-b576-56f151e58c57"), "That sounds concerning. Reduced appetite and unusual swimming can indicate a range of issues, from water quality problems to internal infections.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 4, 16, 37, 16, 894, DateTimeKind.Utc).AddTicks(3000) },
                    { new Guid("e63d8fda-8379-4b5d-b6f4-d375bd501385"), "I see. Those can be signs of stress or possibly an infection. Have you noticed any other symptoms, such as loss of appetite or unusual swimming behavior?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 4, 16, 27, 16, 894, DateTimeKind.Utc).AddTicks(2994) },
                    { new Guid("eb5c328b-9195-4828-a839-6cd96547259b"), "I'm good too. Are you free today?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2919) },
                    { new Guid("f04a33a4-db85-427d-9270-711018ff442a"), "You're welcome! If you have any more questions, feel free to ask.", new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 5, 16, 24, 16, 894, DateTimeKind.Utc).AddTicks(2986) },
                    { new Guid("f8e1675d-3e87-4060-a806-118c626eecdb"), "The water temperature is 20°C, and the water seems clear, but I noticed a bit of green algae.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 6, 16, 20, 16, 894, DateTimeKind.Utc).AddTicks(2960) },
                    { new Guid("f9ee923b-34e6-4d5e-94dc-32ae1889d237"), "I want to ask you about the new project.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(2927) }
                });

            migrationBuilder.InsertData(
                table: "PetHabitat",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "HabitatType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2810), "Freshwater Pond", false, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2813), "Saltwater Pond", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PetServiceCategory",
                columns: new[] { "Id", "ApplicableTo", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "IsOnline", "ModifiedBy", "ModifiedDate", "Name", "ServiceType" },
                values: new object[,]
                {
                    { new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"), "Koi Fish", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(785), "Safe transportation services for Koi fish.", false, false, null, null, "Koi Transportation", "Transportation" },
                    { new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"), "Koi Fish", null, new DateTime(2024, 11, 6, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(777), "Guidance and assistance in breeding Koi fish.", false, true, null, null, "Koi Breeding Assistance", "Breeding" },
                    { new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"), "Koi Fish", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(762), "Testing water quality parameters to ensure a healthy environment for Koi.", false, false, null, null, "Water Quality Testing", "Testing" },
                    { new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"), "Ponds", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(774), "Regular maintenance services for Koi ponds to ensure optimal conditions.", false, false, null, null, "Pond Maintenance", "Maintenance" },
                    { new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"), "Koi Fish", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(752), "A standard health check for Koi fish to monitor their overall well-being and prevent diseases.", false, false, null, null, "Health Check", "Health" },
                    { new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), "Koi Fish", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(768), "Treatment services for Koi suffering from fungal infections.", false, false, null, null, "Fungal Treatment", "Treatment" },
                    { new Guid("ca3801df-081c-4db5-a416-b04791797d92"), "Koi Enthusiasts", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(790), "Workshops on Koi care and pond management.", false, false, null, null, "Educational Workshops", "Education" },
                    { new Guid("ca4801df-081c-4db5-a416-b04891797d92"), "Koi Enthusiasts and Pond Owners", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(793), "Advisory sessions on best practices in Koi care, pond management, and maintenance for Koi enthusiasts.", false, false, null, null, "Koi Care Advisory", "Advisory" },
                    { new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"), "Koi Fish", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(770), "Services to treat and prevent parasites in Koi fish.", false, true, null, null, "Parasite Treatment Consultation", "Treatment" },
                    { new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"), "Koi Fish", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(787), "Emergency medical services for Koi in distress.", false, false, null, null, "Emergency Care", "Emergency" },
                    { new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), "Koi Fish", null, new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(758), "Specialized feeding service for Koi fish, ensuring proper nutrition and dietary requirements.", false, false, null, null, "Feeding Service", "Feeding" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2329), "Medicines for Koi fish treatments.", false, null, null, "Medicines" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2333), "Products for water conditioning and treatment.", false, null, null, "Water Treatment" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2335), "Equipment and accessories for Koi ponds.", false, null, null, "Pond Equipment" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2337), "Food and nutritional supplements for Koi fish.", false, null, null, "Food & Nutrition" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2338), "Devices and kits for monitoring Koi health.", false, null, null, "Health Monitoring" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2342), "Products for cleaning and maintaining Koi ponds.", false, null, null, "Cleaning & Maintenance" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2344), "Supplies for Koi breeding and spawning.", false, null, null, "Breeding Supplies" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2346), "Materials and accessories for pond landscaping.", false, null, null, "Pond Landscaping" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2348), "Tools and equipment for safe fish transportation.", false, null, null, "Fish Transportation" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2349), "Essential supplies for emergency situations with Koi fish.", false, null, null, "Emergency Supplies" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Manager" },
                    { 3, "Veterinarian" },
                    { 4, "Staff" },
                    { 5, "Customer" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "IsDeleted", "IsEmailConfirmed", "ModifiedBy", "ModifiedDate", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "Username", "role" },
                values: new object[,]
                {
                    { new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), "123 Main St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(350), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff2@gmail.com", "Staff_2", false, false, null, null, "String123!", "123456789", null, "Staff_2", 4 },
                    { new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"), "369 Larch St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(417), new DateTime(1983, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer18@gmail.com", "Customer_18", false, false, null, null, "String123!", "456789012", null, "Customer_18", 5 },
                    { new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), "123 Main St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(329), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian1@gmail.com", "Veterinarian_1", false, false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Veterinarian_1", 3 },
                    { new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), "123 Main St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(332), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian2@gmail.com", "Veterinarian_2", false, false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Veterinarian_2", 3 },
                    { new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "123 Main St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(359), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer3@gmail.com", "Customer_3", false, false, null, null, "String123!", "123456789", null, "Customer_3", 5 },
                    { new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"), "357 Fir St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(393), new DateTime(1988, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer13@gmail.com", "Customer_13", false, false, null, null, "String123!", "012345678", null, "Customer_13", 5 },
                    { new Guid("4feb4940-94dc-4aed-b580-ee116b668704"), "123 Main St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(316), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", false, false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Admin", 1 },
                    { new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), "123 Main St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(338), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", "Staff_1", false, false, null, null, "String123!", "123456789", null, "Staff_1", 4 },
                    { new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"), "321 Maple St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(371), new DateTime(1994, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer6@gmail.com", "Customer_6", false, false, null, null, "String123!", "345678901", null, "Customer_6", 5 },
                    { new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"), "147 Palm St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(412), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer16@gmail.com", "Customer_16", false, false, null, null, "String123!", "234567890", null, "Customer_16", 5 },
                    { new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"), "789 Pine St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(368), new DateTime(1993, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer5@gmail.com", "Customer_5", false, false, null, null, "String123!", "234567890", null, "Customer_5", 5 },
                    { new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"), "369 Redwood St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(407), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer15@gmail.com", "Customer_15", false, false, null, null, "String123!", "987654321", null, "Customer_15", 5 },
                    { new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"), "753 Cherry St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(385), new DateTime(1998, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer10@gmail.com", "Customer_10", false, false, null, null, "String123!", "789012345", null, "Customer_10", 5 },
                    { new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), "123 Main St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(325), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "manager@gmail.com", "Manager", false, false, null, null, "String123!", "123456789", null, "Manager", 2 },
                    { new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), "123 Main St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(356), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer2@gmail.com", "Customer_2", false, false, null, null, "String123!", "123456789", null, "Customer_2", 5 },
                    { new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"), "159 Willow St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(382), new DateTime(1997, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer9@gmail.com", "Customer_9", false, false, null, null, "String123!", "678901234", null, "Customer_9", 5 },
                    { new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"), "258 Spruce St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(396), new DateTime(1987, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer14@gmail.com", "Customer_14", false, false, null, null, "String123!", "123456789", null, "Customer_14", 5 },
                    { new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"), "690 Cedar St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(423), new DateTime(1981, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer20@gmail.com", "Customer_20", false, false, null, null, "String123!", "678901234", null, "Customer_20", 5 },
                    { new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"), "987 Birch St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(378), new DateTime(1996, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer8@gmail.com", "Customer_8", false, false, null, null, "String123!", "567890123", null, "Customer_8", 5 },
                    { new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"), "456 Elm St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(361), new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer4@gmail.com", "Customer_4", false, false, null, null, "String123!", "987654321", null, "Customer_4", 5 },
                    { new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234"), "456 Elm St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(335), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian3@gmail.com", "Veterinarian_3", false, false, null, null, "String456!", "987654321", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Veterinarian_3", 3 },
                    { new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), "123 Main St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(353), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@gmail.com", "Customer_1", false, false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Customer_1", 5 },
                    { new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"), "258 Acacia St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(415), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer17@gmail.com", "Customer_17", false, false, null, null, "String123!", "345678901", null, "Customer_17", 5 },
                    { new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"), "852 Oak St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(388), new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer11@gmail.com", "Customer_11", false, false, null, null, "String123!", "890123456", null, "Customer_11", 5 },
                    { new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"), "654 Cedar St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(373), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer7@gmail.com", "Customer_7", false, false, null, null, "String123!", "456789012", null, "Customer_7", 5 },
                    { new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"), "963 Sycamore St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(390), new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer12@gmail.com", "Customer_12", false, false, null, null, "String123!", "901234567", null, "Customer_12", 5 },
                    { new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"), "579 Fir St", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(420), new DateTime(1982, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer19@gmail.com", "Customer_19", false, false, null, null, "String123!", "567890123", null, "Customer_19", 5 }
                });

            migrationBuilder.InsertData(
                table: "PetService",
                columns: new[] { "Id", "AvailableFrom", "AvailableTo", "BasePrice", "CreatedBy", "CreatedDate", "Duration", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "PetServiceCategoryId", "TravelCost" },
                values: new object[,]
                {
                    { new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"), new DateTime(2024, 10, 31, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1021), new DateTime(2025, 2, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1021), 75.00m, null, new DateTime(2024, 10, 30, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1022), "1.5 hours", "User/67b458d2-710a-4763-bbb4-f8a3225acd71_KoiSerrivce.jpg", false, null, null, "Fungal Treatment", new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), 20.00m },
                    { new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), new DateTime(2024, 11, 5, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1004), new DateTime(2024, 12, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1005), 20.00m, null, new DateTime(2024, 11, 4, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1006), "45 minutes", "User/69df3fd9-3a05-493d-a331-682f85ab1fac_cham-soc-chua-benh-ca-koi-1.jpg", false, null, null, "Water Quality Testing", new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"), 5.00m },
                    { new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"), new DateTime(2024, 11, 6, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 12, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1016), 30.00m, null, new DateTime(2024, 11, 5, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1017), "1 hours", "User/ec0b365c-82a9-4aba-9ad1-0d781647680f_k5-1.jpg", false, null, null, "Koi Feeding Service", new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), 15.00m },
                    { new Guid("39ebc58b-6731-491d-949d-82f387dce82e"), new DateTime(2024, 11, 4, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1009), new DateTime(2025, 1, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1010), 29.99m, null, new DateTime(2024, 11, 3, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1011), "30 minutes", "User/e3f49113-32b5-4717-99f5-2b19f26843ee_ho-ca-koi-nhat-ban-4ff43497-b734-4264-8250-72770f0131a9.webp", false, null, null, "Koi Feeding Service", new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), 10.00m },
                    { new Guid("7253ea62-e419-40dc-bc70-e069611587dd"), new DateTime(2024, 11, 2, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1031), new DateTime(2025, 3, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1032), 150.00m, null, new DateTime(2024, 11, 1, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1033), "2 hours", "User/7dc80870-0593-4bdf-bcae-50096866d7ba_15_mau_ho_ca_Koi_mini_dep_phu_hop_voi_moi_khong_gian_05.png", false, null, null, "Koi Fish Health Check Service", new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"), 20.00m },
                    { new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), new DateTime(2024, 11, 2, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(998), new DateTime(2025, 2, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(999), 100.00m, null, new DateTime(2024, 11, 1, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1000), "2 hours", "User/86b2e5a0-2c2f-4613-9a87-95c9c1c0d736_90.jpg", false, null, null, "Parasite Treatment", new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"), 25.00m },
                    { new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"), new DateTime(2024, 11, 1, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1026), new DateTime(2024, 12, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1027), 40.00m, null, new DateTime(2024, 10, 31, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1027), "1 hours", "User/9ee75b2d-fc24-4b09-8b00-bd33d99b2a82_logo-hinh-3-1617430490365932845093.webp", false, null, null, "Educational Workshops", new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"), 12.00m },
                    { new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"), new DateTime(2024, 11, 3, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 12, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1039), 60.00m, null, new DateTime(2024, 11, 2, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1040), "1 hours", "User/e3f49113-32b5-4717-99f5-2b19f26843ee_ho-ca-koi-nhat-ban-4ff43497-b734-4264-8250-72770f0131a9.webp", false, null, null, "Pond Maintenance", new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"), 15.00m },
                    { new Guid("c33e3a87-0230-428b-8c06-ee91b7e8cc21"), new DateTime(2024, 11, 2, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1052), new DateTime(2025, 1, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1053), 20.00m, null, new DateTime(2024, 11, 1, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1054), "1 hours", "User/ec0b365c-82a9-4aba-9ad1-0d781647680f_k5-1.jpg", false, null, null, "Koi Care Advisory", new Guid("ca4801df-081c-4db5-a416-b04891797d92"), 0m },
                    { new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), new DateTime(2024, 11, 4, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(984), new DateTime(2025, 1, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(985), 150.00m, null, new DateTime(2024, 11, 3, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(990), "3 hours", "User/7dc80870-0593-4bdf-bcae-50096866d7ba_15_mau_ho_ca_Koi_mini_dep_phu_hop_voi_moi_khong_gian_05.png", false, null, null, "Emergency Care", new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"), 30.00m }
                });

            migrationBuilder.InsertData(
                table: "PetType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "GeneralType", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetHabitatId", "SpecificType" },
                values: new object[,]
                {
                    { new Guid("e1111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1882), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Koi Fish" },
                    { new Guid("e2222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1889), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Goldfish" },
                    { new Guid("e3333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1892), "Reptile", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Turtle" },
                    { new Guid("e4444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1894), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Dog" },
                    { new Guid("e5555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1896), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Cat" },
                    { new Guid("e6666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1899), "Bird", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Parrot" },
                    { new Guid("e7777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1901), "Bird", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Canary" },
                    { new Guid("e8888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1903), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Betta Fish" },
                    { new Guid("e9999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1905), "Reptile", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Iguana" },
                    { new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1909), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Hamster" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Price", "ProductCategoryId", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2140), "Medicine to treat parasite infections in Koi.", "https://example.com/image1.jpg", false, null, null, "Anti-Parasite Medication", 50.00m, new Guid("11111111-1111-1111-1111-111111111111"), 100 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2145), "Water conditioner for Koi ponds.", "https://example.com/image2.jpg", false, null, null, "Water Conditioner", 25.00m, new Guid("22222222-2222-2222-2222-222222222222"), 200 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2148), "Nutritional supplement to enhance Koi growth.", "https://example.com/image3.jpg", false, null, null, "Koi Growth Supplement", 35.00m, new Guid("11111111-1111-1111-1111-111111111111"), 150 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2151), "Stabilizes the pH level of pond water.", "https://example.com/image4.jpg", false, null, null, "Pond pH Stabilizer", 40.00m, new Guid("22222222-2222-2222-2222-222222222222"), 80 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2154), "Treatment for fungal infections in Koi.", "https://example.com/image5.jpg", false, null, null, "Fungal Treatment for Koi", 60.00m, new Guid("11111111-1111-1111-1111-111111111111"), 120 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2156), "Replacement filter for Koi ponds.", "https://example.com/image6.jpg", false, null, null, "Koi Pond Filter", 75.00m, new Guid("22222222-2222-2222-2222-222222222222"), 60 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2159), "Antibiotic for treating bacterial infections in Koi.", "https://example.com/image7.jpg", false, null, null, "Koi Antibiotic", 45.00m, new Guid("11111111-1111-1111-1111-111111111111"), 90 },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2164), "Prevents algae buildup in Koi ponds.", "https://example.com/image8.jpg", false, null, null, "Algae Control Solution", 30.00m, new Guid("22222222-2222-2222-2222-222222222222"), 170 },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2167), "Controls parasite infections in Koi.", "https://example.com/image9.jpg", false, null, null, "Parasite Control Solution", 55.00m, new Guid("11111111-1111-1111-1111-111111111111"), 100 },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2169), "Increases oxygen levels in Koi ponds.", "https://example.com/image10.jpg", false, null, null, "Oxygen Booster for Ponds", 65.00m, new Guid("22222222-2222-2222-2222-222222222222"), 130 }
                });

            migrationBuilder.InsertData(
                table: "Veterinarian",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "LicenseNumber", "ModifiedBy", "ModifiedDate", "Qualifications", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1179), false, "VN789012", null, null, "PhD in Veterinary Science", "Fish Surgery", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") },
                    { new Guid("b87a3240-e68a-4f38-8f14-7a56f7b9d123"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1182), false, "VN345678", null, null, "Master's in Veterinary Medicine", "Aquatic Animal Medicine", new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234") },
                    { new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1176), false, "VN123456", null, null, "Doctor of Veterinary Medicine (DVM)", "Aquatic Veterinary Medicine", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("7754b2f1-5a6d-4e16-8720-9a3384a36944"), 1000.00m, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(6371), false, null, null, new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73") },
                    { new Guid("84024f36-0fd7-46ed-9ca9-ca152bf90f9d"), 1000.00m, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(6380), false, null, null, new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") },
                    { new Guid("a3762f69-024e-4a2b-9d78-846ed54a6b13"), 1000.00m, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(6386), false, null, null, new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359") },
                    { new Guid("b630522b-ec2a-4e60-8f6e-83c2affaddb0"), 1000.00m, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(6367), false, null, null, new Guid("4feb4940-94dc-4aed-b580-ee116b668704") },
                    { new Guid("d19e077b-6f88-46b4-84fc-5272d5f75758"), 1000.00m, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(6383), false, null, null, new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac") },
                    { new Guid("d6a34376-b9d3-4bda-90a3-2306f69f59dd"), 1000.00m, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(6378), false, null, null, new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") },
                    { new Guid("f0c983e0-27d6-47ff-9862-f79749d6b55a"), 1000.00m, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(6391), false, null, null, new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AcceptedDate", "AppointmentDate", "ComboServiceId", "CompletedDate", "CreatedBy", "CreatedDate", "CustomerId", "EndDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetId", "PetServiceId", "Status" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 9, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1446), null, null, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1447), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), null, false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "Pending" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 10, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1453), null, null, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1454), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), null, false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Pending" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1457), null, null, null, new DateTime(2024, 11, 5, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1457), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), null, false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "InProgress" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 10, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1460), null, null, null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1461), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), null, false, null, null, null, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Pending" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 6, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1465), null, null, null, new DateTime(2024, 11, 4, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1465), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), null, false, null, null, null, new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"), "Reported" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 5, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1469), null, null, null, new DateTime(2024, 11, 2, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1469), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), null, false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Reported" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 2, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1473), null, new DateTime(2024, 11, 4, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1473), null, new DateTime(2024, 10, 31, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1474), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), null, false, null, null, null, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Completed" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), null, new DateTime(2024, 11, 4, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1478), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1478), null, new DateTime(2024, 11, 2, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1479), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), null, false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Completed" },
                    { new Guid("bbbbbcbb-bbbb-bcbb-bbbb-bbcbbbbbbbbb"), null, new DateTime(2024, 11, 4, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1482), null, null, null, new DateTime(2024, 11, 2, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1483), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), null, false, null, null, null, new Guid("c33e3a87-0230-428b-8c06-ee91b7e8cc21"), "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "Id", "Age", "Color", "CreatedBy", "CreatedDate", "Gender", "HealthStatus", "ImageUrl", "IsDeleted", "LastHealthCheck", "Length", "ModifiedBy", "ModifiedDate", "Name", "Note", "OwnerId", "PetTypeId", "Quantity", "Weight" },
                values: new object[,]
                {
                    { new Guid("f1111111-1111-1111-1111-111111111111"), 3, "Orange and White", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1733), "Male", 1, "https://example.com/koi1.jpg", false, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, null, null, "Koi Fish 1", "Healthy with vibrant colors.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("e1111111-1111-1111-1111-111111111111"), 5, 2.0 },
                    { new Guid("f2222222-2222-2222-2222-222222222222"), 4, "Red and White", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1746), "Female", 2, "https://example.com/koi2.jpg", false, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, null, null, "Koi Fish 2", "Slight issue with fins, under observation.", new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), new Guid("e1111111-1111-1111-1111-111111111111"), 3, 3.0 },
                    { new Guid("f3333333-3333-3333-3333-333333333333"), 2, "Yellow and White", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1750), "Male", 1, "https://example.com/koi3.jpg", false, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, null, null, "Koi Fish 3", "In great condition, regular feeding.", new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new Guid("e1111111-1111-1111-1111-111111111111"), 10, 2.0 },
                    { new Guid("f4444444-4444-4444-4444-444444444444"), 1, "Black and White", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1755), "Female", 1, "https://example.com/koi4.jpg", false, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, null, null, "Koi Fish 4", "Newly purchased, adjusting to pond.", new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), new Guid("e1111111-1111-1111-1111-111111111111"), 7, 3.0 },
                    { new Guid("f5555555-5555-5555-5555-555555555555"), 5, "Blue and White", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1760), "Male", 1, "https://example.com/koi5.jpg", false, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, null, null, "Koi Fish 5", "Strong swimmer, excellent condition.", new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), new Guid("e1111111-1111-1111-1111-111111111111"), 2, 3.0 },
                    { new Guid("f6666666-6666-6666-6666-666666666666"), 2, "White", null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1765), "Female", 1, "https://example.com/koi6.jpg", false, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28.0, null, null, "Koi Fish 6", "Excellent appetite, feeding well.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("e1111111-1111-1111-1111-111111111111"), 4, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(3133), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), "Excellent service!", false, null, null, 5, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed") },
                    { new Guid("2cfd1ae3-556a-49c3-9c29-7cbb194976a3"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(3150), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") },
                    { new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(3137), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), "Good service but could be faster.", false, null, null, 4, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405") },
                    { new Guid("d4434a43-873d-4b5f-bfd7-82b359801909"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(3146), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") },
                    { new Guid("fbf9aef6-7a43-458f-992a-8cb94c434cab"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(3141), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") }
                });

            migrationBuilder.InsertData(
                table: "VeterinarianSchedule",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Date", "EndTime", "IsAvailable", "IsDeleted", "ModifiedBy", "ModifiedDate", "StartTime", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1293), new DateTime(2024, 11, 12, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1277), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 13, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1311), new DateTime(2024, 11, 10, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1277), new TimeSpan(0, 21, 0, 0, 0), true, false, null, null, new TimeSpan(0, 17, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1308), new DateTime(2024, 11, 9, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1277), new TimeSpan(0, 12, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1289), new DateTime(2024, 11, 11, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1277), new TimeSpan(0, 12, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1302), new DateTime(2024, 11, 7, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1277), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 13, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1296), new DateTime(2024, 11, 13, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1277), new TimeSpan(0, 12, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1305), new DateTime(2024, 11, 8, 23, 17, 16, 894, DateTimeKind.Local).AddTicks(1277), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 13, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AcceptedDate", "AppointmentDate", "ComboServiceId", "CompletedDate", "CreatedBy", "CreatedDate", "CustomerId", "EndDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetId", "PetServiceId", "Status" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 9, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1427), null, null, null, new DateTime(2024, 11, 6, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1429), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), null, false, null, null, new Guid("f1111111-1111-1111-1111-111111111111"), new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Waiting" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 6, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1434), null, null, null, new DateTime(2024, 11, 4, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1435), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), null, false, null, null, new Guid("f1111111-1111-1111-1111-111111111111"), new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Reported" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 5, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1439), null, new DateTime(2024, 11, 6, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1439), null, new DateTime(2024, 11, 2, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1443), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), null, false, null, null, new Guid("f3333333-3333-3333-3333-333333333333"), new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Completed" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentVeterinarian",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("55555555-bbbb-5555-bbbb-555555555555"), new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1597), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-bbbb-5555-cccc-555555555555"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1616), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-bbbb-5555-dddd-555555555555"), new Guid("bbbbbcbb-bbbb-bcbb-bbbb-bbcbbbbbbbbb"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1620), false, null, null, new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("55555555-cccc-5555-cccc-555555555555"), new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1609), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-ddcc-5555-cccc-555555555555"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1614), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-dddd-5555-cccc-555555555555"), new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1611), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "ServiceReport",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "HasPrescription", "IsCompleted", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionId", "Recommendations", "ReportContent", "ReportDate" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2454), true, true, false, null, null, new Guid("22222222-2222-2222-2222-222222222222"), "Apply antifungal medication.", "Fungal infection treatment recommended.", new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2473), false, true, false, null, null, null, "Monitor fish for 48 hours.", "Emergency care completed, fish stable.", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666666"), new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2476), false, true, false, null, null, null, "Maintain current diet, no changes needed.", "Feeding routine assessment, nutrition levels adequate.", new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2478), false, true, false, null, null, null, "Fish arrived safely. No action needed.", "Transportation completed successfully.", new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88888888-8888-8888-8888-888888888888"), new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2481), false, true, false, null, null, null, "Monitor breeding progress over the next 10 days.", "Koi breeding assistance provided. Successful pairing observed.", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99999999-9999-9999-9999-999999999999"), new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2484), false, true, false, null, null, null, "Replace filter immediately to prevent water contamination.", "Water quality testing performed. Filter replacement needed.", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2487), true, true, false, null, null, new Guid("33333333-3333-3333-3333-333333333333"), "Apply antiseptic and monitor healing progress.", "Health check performed. Minor injuries found.", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppointmentVeterinarian",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("11111111-aaaa-1111-aaaa-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1588), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("22222222-aaaa-2222-aaaa-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1592), false, null, null, new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("33333333-aaaa-3333-aaaa-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(1594), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionDate", "ServiceReportId" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2598), false, null, null, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2601), false, null, null, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") }
                });

            migrationBuilder.InsertData(
                table: "ServiceReport",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "HasPrescription", "IsCompleted", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionId", "Recommendations", "ReportContent", "ReportDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2461), false, true, false, null, null, null, "Regular water testing recommended.", "Report for Koi health check, everything looks fine.", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2464), true, true, false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Follow the prescribed medicine.", "Parasite treatment required for Koi.", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2470), false, true, false, null, null, null, "Adjust pH levels in the water.", "Water quality test completed, minor adjustments needed.", new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionDate", "ServiceReportId" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 7, 16, 17, 16, 894, DateTimeKind.Utc).AddTicks(2592), false, null, null, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22222222-2222-2222-2222-222222222222") });

            migrationBuilder.InsertData(
                table: "PrescriptionDetail",
                columns: new[] { "PrescriptionDetailId", "MedicineId", "PrescriptionId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), 150.00m, 3 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), 50.00m, 1 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), new Guid("22222222-2222-2222-2222-222222222222"), 200.00m, 4 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), new Guid("33333333-3333-3333-3333-333333333333"), 250.00m, 5 },
                    { new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), 100.00m, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ComboServiceId",
                table: "Appointment",
                column: "ComboServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CustomerId",
                table: "Appointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PetId",
                table: "Appointment",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PetServiceId",
                table: "Appointment",
                column: "PetServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentVeterinarian_AppointmentId",
                table: "AppointmentVeterinarian",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentVeterinarian_VeterinarianId",
                table: "AppointmentVeterinarian",
                column: "VeterinarianId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CustomerId",
                table: "Cart",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_PetServiceId",
                table: "CartItem",
                column: "PetServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductId",
                table: "CartItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ComboServiceItem_ComboServiceId",
                table: "ComboServiceItem",
                column: "ComboServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ComboServiceItem_PetServiceId",
                table: "ComboServiceItem",
                column: "PetServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_PetId",
                table: "OrderItem",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ServiceId",
                table: "OrderItem",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_VeterinarianId",
                table: "OrderItem",
                column: "VeterinarianId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_AppointmentId",
                table: "Payment",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_OwnerId",
                table: "Pet",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_PetTypeId",
                table: "Pet",
                column: "PetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PetService_PetServiceCategoryId",
                table: "PetService",
                column: "PetServiceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PetType_PetHabitatId",
                table: "PetType",
                column: "PetHabitatId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_ServiceReportId",
                table: "Prescription",
                column: "ServiceReportId",
                unique: true,
                filter: "[ServiceReportId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionDetail_MedicineId",
                table: "PrescriptionDetail",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionDetail_PrescriptionId",
                table: "PrescriptionDetail",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_CustomerId",
                table: "Rating",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ServiceId",
                table: "Rating",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReport_AppointmentId",
                table: "ServiceReport",
                column: "AppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserId",
                table: "Transaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmail_EmailTemplateId",
                table: "UserEmail",
                column: "EmailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Veterinarian_UserId",
                table: "Veterinarian",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VeterinarianSchedule_VeterinarianId",
                table: "VeterinarianSchedule",
                column: "VeterinarianId");

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
                name: "AppointmentVeterinarian");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "ComboServiceItem");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PrescriptionDetail");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "UserEmail");

            migrationBuilder.DropTable(
                name: "VeterinarianSchedule");

            migrationBuilder.DropTable(
                name: "Wallet");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "EmailTemplate");

            migrationBuilder.DropTable(
                name: "Veterinarian");

            migrationBuilder.DropTable(
                name: "ServiceReport");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "ComboService");

            migrationBuilder.DropTable(
                name: "PetService");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "PetServiceCategory");

            migrationBuilder.DropTable(
                name: "PetType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "PetHabitat");
        }
    }
}
