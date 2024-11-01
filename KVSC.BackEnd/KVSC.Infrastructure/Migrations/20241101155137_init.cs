using System;
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
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                columns: new[] { "EmailTemplateId", "Body", "CreateBy", "CreateDate", "IsDelete", "Subject", "Type", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your service titled '{{ServiceTitle}}' has been deactivated for the following reason:</p>\r\n                    <p>{{DeactivationReason}}</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7026), false, "Service Deactivation Notification", "DeactivateService", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7027) },
                    { new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your account has been deactivated. If you think this is a mistake, please contact our support team.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7020), false, "Account Deactivation", "DeactivateUser", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7021) },
                    { new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>We are pleased to inform you that your appointment for koi fish care has been approved.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7015), false, "Appointment Approval Notification", "ApproveAppointment", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7016) },
                    { new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>We received a request to reset your password. Click the link below to reset your password:</p>\r\n                    <p><a href='{{ResetLink}}'>Reset Password</a></p>\r\n                    <p>If you did not request a password reset, please ignore this email.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7001), false, "Password Reset Request", "ForgetPassword", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7001) },
                    { new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>We regret to inform you that your appointment for koi services has been rejected for the following reason:</p>\r\n                    <p>{{RejectionReason}}</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7012), false, "Appointment Rejection Notification", "RejectAppointment", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7013) },
                    { new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Thank you for registering with the Koi Veterinary Service Center. Please confirm your account by clicking the link below:</p>\r\n                    <p><a href='{{ConfirmationLink}}'>Confirm Account</a></p>\r\n                    <p>If you did not register, please ignore this email.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7010), false, "Account Confirmation", "ConfirmationAccount", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7010) },
                    { new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your account has been successfully activated. You can now log in and start using our koi veterinary services.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7018), false, "Account Activation", "ActivateUser", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7018) },
                    { new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"), "\r\n                <html>\r\n                <body>\r\n                    <p>Dear {{UserName}},</p>\r\n                    <p>Your requested koi service titled '{{ServiceTitle}}' has been successfully updated.</p>\r\n                    <p>If you have any questions or need further assistance, please feel free to reach out to us.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7023), false, "Service Update Notification", "UpdateService", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7024) },
                    { new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>Your password has been successfully reset. You can now log in with your new password.</p>\r\n                    <p>If you did not request this change, please contact our support team immediately.</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7007), false, "Your Password Has Been Reset", "ResetPassword", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7008) },
                    { new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), "\r\n                <html>\r\n                <body>\r\n                    <p>Hello {{UserName}},</p>\r\n                    <p>You have a new appointment notification for your koi fish:</p>\r\n                    <p>{{AppointmentDetails}}</p>\r\n                    <p>Best regards,<br>Koi Veterinary Service Center</p>\r\n                </body>\r\n                </html>", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(6986), false, "New Appointment Notification", "AppointmentNotification", "System", new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(6996) }
                });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("0e2f2684-fe0e-49db-927a-3e5fa44f6bd6"), "The water temperature is 20°C, and the water seems clear, but I noticed a bit of green algae.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 1, 22, 54, 35, 471, DateTimeKind.Local).AddTicks(9691) },
                    { new Guid("2285342d-c81f-4835-beeb-4d4ac638d3fa"), "Hello, how are you?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9649) },
                    { new Guid("2736382f-7590-4c0e-8368-cb778703792d"), "You're welcome, always happy to help.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9680) },
                    { new Guid("47579140-fc6e-4429-a276-9ebb42d49328"), "Hello! I’m the veterinarian. How can I assist with your koi fish?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9682) },
                    { new Guid("50c971db-b05d-446d-b116-29ade33e6446"), "I see. Can you tell me the water temperature and the condition of the water?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 1, 22, 53, 35, 471, DateTimeKind.Local).AddTicks(9689) },
                    { new Guid("53a34b14-e16a-4308-a7da-24a50f740e77"), "I have some time, do you need anything?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9663) },
                    { new Guid("5676ea5c-5312-4a5f-9ebe-ffd5c55aadbf"), "Hi, Doctor! My koi fish seems sluggish and isn’t eating. I’m really worried.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 1, 22, 52, 35, 471, DateTimeKind.Local).AddTicks(9685) },
                    { new Guid("584b9941-dbc2-4fb7-8a20-99553e599ec3"), "I'm good too. Are you free today?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9660) },
                    { new Guid("66b0230d-2dfa-4bf0-9272-c0a0d14d2155"), "Thank you, I’ll review it right away.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9678) },
                    { new Guid("ae09f60c-4470-4e42-b1ec-dbd6eb2d19b4"), "Thank you, Doctor! I’ll check and get back if I need more help.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 1, 22, 56, 35, 471, DateTimeKind.Local).AddTicks(9698) },
                    { new Guid("b0d9f02d-f786-44c8-a87e-5b9d9432c138"), "I want to ask you about the new project.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9666) },
                    { new Guid("c687238e-5e4b-4fb9-85bd-0b7749debe72"), "Algae can affect water quality. I recommend checking the pH and ammonia levels. You can use a water testing kit for this.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 11, 1, 22, 55, 35, 471, DateTimeKind.Local).AddTicks(9696) },
                    { new Guid("d84fd31b-77aa-43e9-b609-192f9d79290a"), "I’ll send you a summary.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9675) },
                    { new Guid("dec1a464-7701-481b-bac5-93f525c6c15c"), "Sure! What do you need to know?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9668) },
                    { new Guid("e6411b5d-347e-4117-b121-df0dd2a7944c"), "Do you have detailed information about the progress?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9673) },
                    { new Guid("f320df62-cde4-4a76-b65e-c9bca16db8dd"), "I'm good, thank you! How about you?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(9658) }
                });

            migrationBuilder.InsertData(
                table: "PetHabitat",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "HabitatType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9535), "Freshwater Pond", false, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9538), "Saltwater Pond", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PetServiceCategory",
                columns: new[] { "Id", "ApplicableTo", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "IsOnline", "ModifiedBy", "ModifiedDate", "Name", "ServiceType" },
                values: new object[,]
                {
                    { new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"), "Koi Fish", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7548), "Safe transportation services for Koi fish.", false, false, null, null, "Koi Transportation", "Transportation" },
                    { new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"), "Koi Fish", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7545), "Guidance and assistance in breeding Koi fish.", false, false, null, null, "Koi Breeding Assistance", "Breeding" },
                    { new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"), "Koi Fish", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7530), "Testing water quality parameters to ensure a healthy environment for Koi.", false, false, null, null, "Water Quality Testing", "Testing" },
                    { new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"), "Ponds", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7538), "Regular maintenance services for Koi ponds to ensure optimal conditions.", false, false, null, null, "Pond Maintenance", "Maintenance" },
                    { new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"), "Koi Fish", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7512), "A standard health check for Koi fish to monitor their overall well-being and prevent diseases.", false, false, null, null, "Health Check", "Health" },
                    { new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), "Koi Fish", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7533), "Treatment services for Koi suffering from fungal infections.", false, false, null, null, "Fungal Treatment", "Treatment" },
                    { new Guid("ca3801df-081c-4db5-a416-b04791797d92"), "Koi Enthusiasts", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7556), "Workshops on Koi care and pond management.", false, false, null, null, "Educational Workshops", "Education" },
                    { new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"), "Koi Fish", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7536), "Services to treat and prevent parasites in Koi fish.", false, true, null, null, "Parasite Treatment Consultation", "Treatment" },
                    { new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"), "Koi Fish", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7550), "Emergency medical services for Koi in distress.", false, false, null, null, "Emergency Care", "Emergency" },
                    { new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), "Koi Fish", null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7527), "Specialized feeding service for Koi fish, ensuring proper nutrition and dietary requirements.", false, false, null, null, "Feeding Service", "Feeding" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8988), "Medicines for Koi fish treatments.", false, null, null, "Medicines" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8991), "Products for water conditioning and treatment.", false, null, null, "Water Treatment" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8993), "Equipment and accessories for Koi ponds.", false, null, null, "Pond Equipment" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8995), "Food and nutritional supplements for Koi fish.", false, null, null, "Food & Nutrition" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8996), "Devices and kits for monitoring Koi health.", false, null, null, "Health Monitoring" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8998), "Products for cleaning and maintaining Koi ponds.", false, null, null, "Cleaning & Maintenance" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8999), "Supplies for Koi breeding and spawning.", false, null, null, "Breeding Supplies" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9003), "Materials and accessories for pond landscaping.", false, null, null, "Pond Landscaping" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9005), "Tools and equipment for safe fish transportation.", false, null, null, "Fish Transportation" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9006), "Essential supplies for emergency situations with Koi fish.", false, null, null, "Emergency Supplies" }
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
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "IsDeleted", "ModifiedBy", "ModifiedDate", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "Username", "role" },
                values: new object[,]
                {
                    { new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), "123 Main St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7217), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff2@gmail.com", "Staff_2", false, null, null, "String123!", "123456789", null, "Staff_2", 4 },
                    { new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"), "369 Larch St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7271), new DateTime(1983, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer18@gmail.com", "Customer_18", false, null, null, "String123!", "456789012", null, "Customer_18", 5 },
                    { new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), "123 Main St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7191), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian1@gmail.com", "Veterinarian_1", false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Veterinarian_1", 3 },
                    { new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), "123 Main St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7193), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian2@gmail.com", "Veterinarian_2", false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Veterinarian_2", 3 },
                    { new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "123 Main St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7225), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer3@gmail.com", "Customer_3", false, null, null, "String123!", "123456789", null, "Customer_3", 5 },
                    { new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"), "357 Fir St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7255), new DateTime(1988, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer13@gmail.com", "Customer_13", false, null, null, "String123!", "012345678", null, "Customer_13", 5 },
                    { new Guid("4feb4940-94dc-4aed-b580-ee116b668704"), "123 Main St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7178), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Admin", 1 },
                    { new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), "123 Main St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7214), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", "Staff_1", false, null, null, "String123!", "123456789", null, "Staff_1", 4 },
                    { new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"), "321 Maple St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7238), new DateTime(1994, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer6@gmail.com", "Customer_6", false, null, null, "String123!", "345678901", null, "Customer_6", 5 },
                    { new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"), "147 Palm St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7266), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer16@gmail.com", "Customer_16", false, null, null, "String123!", "234567890", null, "Customer_16", 5 },
                    { new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"), "789 Pine St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7234), new DateTime(1993, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer5@gmail.com", "Customer_5", false, null, null, "String123!", "234567890", null, "Customer_5", 5 },
                    { new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"), "369 Redwood St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7263), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer15@gmail.com", "Customer_15", false, null, null, "String123!", "987654321", null, "Customer_15", 5 },
                    { new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"), "753 Cherry St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7248), new DateTime(1998, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer10@gmail.com", "Customer_10", false, null, null, "String123!", "789012345", null, "Customer_10", 5 },
                    { new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), "123 Main St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7187), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "manager@gmail.com", "Manager", false, null, null, "String123!", "123456789", null, "Manager", 2 },
                    { new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), "123 Main St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7222), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer2@gmail.com", "Customer_2", false, null, null, "String123!", "123456789", null, "Customer_2", 5 },
                    { new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"), "159 Willow St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7245), new DateTime(1997, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer9@gmail.com", "Customer_9", false, null, null, "String123!", "678901234", null, "Customer_9", 5 },
                    { new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"), "258 Spruce St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7261), new DateTime(1987, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer14@gmail.com", "Customer_14", false, null, null, "String123!", "123456789", null, "Customer_14", 5 },
                    { new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"), "690 Cedar St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7276), new DateTime(1981, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer20@gmail.com", "Customer_20", false, null, null, "String123!", "678901234", null, "Customer_20", 5 },
                    { new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"), "987 Birch St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7243), new DateTime(1996, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer8@gmail.com", "Customer_8", false, null, null, "String123!", "567890123", null, "Customer_8", 5 },
                    { new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"), "456 Elm St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7227), new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer4@gmail.com", "Customer_4", false, null, null, "String123!", "987654321", null, "Customer_4", 5 },
                    { new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234"), "456 Elm St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7211), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian3@gmail.com", "Veterinarian_3", false, null, null, "String456!", "987654321", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Veterinarian_3", 3 },
                    { new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), "123 Main St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7220), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@gmail.com", "Customer_1", false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Customer_1", 5 },
                    { new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"), "258 Acacia St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7269), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer17@gmail.com", "Customer_17", false, null, null, "String123!", "345678901", null, "Customer_17", 5 },
                    { new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"), "852 Oak St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7250), new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer11@gmail.com", "Customer_11", false, null, null, "String123!", "890123456", null, "Customer_11", 5 },
                    { new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"), "654 Cedar St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7240), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer7@gmail.com", "Customer_7", false, null, null, "String123!", "456789012", null, "Customer_7", 5 },
                    { new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"), "963 Sycamore St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7253), new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer12@gmail.com", "Customer_12", false, null, null, "String123!", "901234567", null, "Customer_12", 5 },
                    { new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"), "579 Fir St", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7274), new DateTime(1982, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer19@gmail.com", "Customer_19", false, null, null, "String123!", "567890123", null, "Customer_19", 5 }
                });

            migrationBuilder.InsertData(
                table: "PetService",
                columns: new[] { "Id", "AvailableFrom", "AvailableTo", "BasePrice", "CreatedBy", "CreatedDate", "Duration", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "PetServiceCategoryId", "TravelCost" },
                values: new object[,]
                {
                    { new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"), new DateTime(2024, 10, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 75.00m, null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7695), "1.5 hours", "https://example.com/image4.jpg", false, null, null, "Fungal Treatment", new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), 20.00m },
                    { new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), new DateTime(2024, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), 20.00m, null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7682), "45 minutes", "https://example.com/image3.jpg", false, null, null, "Water Quality Testing", new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"), 5.00m },
                    { new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 30.00m, null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7691), "1 hour", "https://example.com/image2.jpg", false, null, null, "Koi Feeding Service", new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), 15.00m },
                    { new Guid("39ebc58b-6731-491d-949d-82f387dce82e"), new DateTime(2024, 10, 3, 22, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 2, 10, 20, 0, DateTimeKind.Unspecified), 29.99m, null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7687), "30 minutes", "https://example.com/image.jpg", false, null, null, "Koi Feeding Service", new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), 10.00m },
                    { new Guid("7253ea62-e419-40dc-bc70-e069611587dd"), new DateTime(2024, 10, 4, 14, 2, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 14, 2, 32, 0, DateTimeKind.Unspecified), 1.00m, null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7707), "string", "string", false, null, null, "string", new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"), 0.00m },
                    { new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), new DateTime(2024, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), 100.00m, null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7678), "2 hours", "https://example.com/image5.jpg", false, null, null, "Parasite Treatment", new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"), 25.00m },
                    { new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"), new DateTime(2024, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), 40.00m, null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7700), "1 hour", "https://example.com/image8.jpg", false, null, null, "Educational Workshops", new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"), 12.00m },
                    { new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 60.00m, null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7711), "1 hour", "https://example.com/image6.jpg", false, null, null, "Pond Maintenance", new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"), 15.00m },
                    { new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), new DateTime(2024, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), 150.00m, null, new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7673), "3 hours", "https://example.com/image7.jpg", false, null, null, "Emergency Care", new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"), 30.00m }
                });

            migrationBuilder.InsertData(
                table: "PetType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "GeneralType", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetHabitatId", "SpecificType" },
                values: new object[,]
                {
                    { new Guid("e1111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8633), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Koi Fish" },
                    { new Guid("e2222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8641), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Goldfish" },
                    { new Guid("e3333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8644), "Reptile", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Turtle" },
                    { new Guid("e4444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8648), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Dog" },
                    { new Guid("e5555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8651), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Cat" },
                    { new Guid("e6666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8653), "Bird", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Parrot" },
                    { new Guid("e7777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8655), "Bird", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Canary" },
                    { new Guid("e8888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8657), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Betta Fish" },
                    { new Guid("e9999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8668), "Reptile", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Iguana" },
                    { new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8670), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Hamster" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Price", "ProductCategoryId", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8835), "Medicine to treat parasite infections in Koi.", "https://example.com/image1.jpg", false, null, null, "Anti-Parasite Medication", 50.00m, new Guid("11111111-1111-1111-1111-111111111111"), 100 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8843), "Water conditioner for Koi ponds.", "https://example.com/image2.jpg", false, null, null, "Water Conditioner", 25.00m, new Guid("22222222-2222-2222-2222-222222222222"), 200 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8846), "Nutritional supplement to enhance Koi growth.", "https://example.com/image3.jpg", false, null, null, "Koi Growth Supplement", 35.00m, new Guid("11111111-1111-1111-1111-111111111111"), 150 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8849), "Stabilizes the pH level of pond water.", "https://example.com/image4.jpg", false, null, null, "Pond pH Stabilizer", 40.00m, new Guid("22222222-2222-2222-2222-222222222222"), 80 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8851), "Treatment for fungal infections in Koi.", "https://example.com/image5.jpg", false, null, null, "Fungal Treatment for Koi", 60.00m, new Guid("11111111-1111-1111-1111-111111111111"), 120 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8853), "Replacement filter for Koi ponds.", "https://example.com/image6.jpg", false, null, null, "Koi Pond Filter", 75.00m, new Guid("22222222-2222-2222-2222-222222222222"), 60 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8856), "Antibiotic for treating bacterial infections in Koi.", "https://example.com/image7.jpg", false, null, null, "Koi Antibiotic", 45.00m, new Guid("11111111-1111-1111-1111-111111111111"), 90 },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8858), "Prevents algae buildup in Koi ponds.", "https://example.com/image8.jpg", false, null, null, "Algae Control Solution", 30.00m, new Guid("22222222-2222-2222-2222-222222222222"), 170 },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8861), "Controls parasite infections in Koi.", "https://example.com/image9.jpg", false, null, null, "Parasite Control Solution", 55.00m, new Guid("11111111-1111-1111-1111-111111111111"), 100 },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8865), "Increases oxygen levels in Koi ponds.", "https://example.com/image10.jpg", false, null, null, "Oxygen Booster for Ponds", 65.00m, new Guid("22222222-2222-2222-2222-222222222222"), 130 }
                });

            migrationBuilder.InsertData(
                table: "Veterinarian",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "LicenseNumber", "ModifiedBy", "ModifiedDate", "Qualifications", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7825), false, "VN789012", null, null, "PhD in Veterinary Science", "Fish Surgery", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") },
                    { new Guid("b87a3240-e68a-4f38-8f14-7a56f7b9d123"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7828), false, "VN345678", null, null, "Master's in Veterinary Medicine", "Aquatic Animal Medicine", new Guid("d78f90b4-9e62-4b45-9e6e-0a01e5931234") },
                    { new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(7821), false, "VN123456", null, null, "Doctor of Veterinary Medicine (DVM)", "Aquatic Veterinary Medicine", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") }
                });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("150d10ca-2ee5-44f6-99f9-87555f57a5c0"), 1000.00m, null, new DateTime(2024, 11, 1, 15, 51, 35, 472, DateTimeKind.Utc).AddTicks(2577), false, null, null, new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") },
                    { new Guid("3d78cd00-25de-420f-b1ef-faa875d1ff86"), 1000.00m, null, new DateTime(2024, 11, 1, 15, 51, 35, 472, DateTimeKind.Utc).AddTicks(2574), false, null, null, new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73") },
                    { new Guid("4ca8e18f-f84b-40e0-ac6d-65213b66196f"), 1000.00m, null, new DateTime(2024, 11, 1, 15, 51, 35, 472, DateTimeKind.Utc).AddTicks(2592), false, null, null, new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e") },
                    { new Guid("540d941b-510f-4ee9-9336-ef471fbd7db4"), 1000.00m, null, new DateTime(2024, 11, 1, 15, 51, 35, 472, DateTimeKind.Utc).AddTicks(2589), false, null, null, new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359") },
                    { new Guid("7bf4fb69-7e7b-4064-8e0f-5b79a3433e69"), 1000.00m, null, new DateTime(2024, 11, 1, 15, 51, 35, 472, DateTimeKind.Utc).AddTicks(2586), false, null, null, new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac") },
                    { new Guid("ae00b433-7958-44cc-abc1-6ccdcd90200c"), 1000.00m, null, new DateTime(2024, 11, 1, 15, 51, 35, 472, DateTimeKind.Utc).AddTicks(2570), false, null, null, new Guid("4feb4940-94dc-4aed-b580-ee116b668704") },
                    { new Guid("b9310983-75e4-4ab4-acbd-456915055b6c"), 1000.00m, null, new DateTime(2024, 11, 1, 15, 51, 35, 472, DateTimeKind.Utc).AddTicks(2584), false, null, null, new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AcceptedDate", "AppointmentDate", "ComboServiceId", "CompletedDate", "CreatedBy", "CreatedDate", "CustomerId", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetId", "PetServiceId", "Status" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 3, 13, 30, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8206), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "Waiting" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8212), new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Waiting" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8215), null, null, null, new DateTime(2024, 10, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "InProgress" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8220), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, null, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Waiting" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8226), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "Reported" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8230), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Reported" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8234), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), false, null, null, null, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Completed" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), null, new DateTime(2024, 11, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8238), new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "Id", "Age", "Color", "CreatedBy", "CreatedDate", "Gender", "HealthStatus", "ImageUrl", "IsDeleted", "LastHealthCheck", "Length", "ModifiedBy", "ModifiedDate", "Name", "Note", "OwnerId", "PetTypeId", "Quantity", "Weight" },
                values: new object[,]
                {
                    { new Guid("f1111111-1111-1111-1111-111111111111"), 3, "Orange and White", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8489), "Male", 1, "https://example.com/koi1.jpg", false, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, null, null, "Koi Fish 1", "Healthy with vibrant colors.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("e1111111-1111-1111-1111-111111111111"), 5, 2.0 },
                    { new Guid("f2222222-2222-2222-2222-222222222222"), 4, "Red and White", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8508), "Female", 2, "https://example.com/koi2.jpg", false, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, null, null, "Koi Fish 2", "Slight issue with fins, under observation.", new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), new Guid("e1111111-1111-1111-1111-111111111111"), 3, 3.0 },
                    { new Guid("f3333333-3333-3333-3333-333333333333"), 2, "Yellow and White", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8515), "Male", 1, "https://example.com/koi3.jpg", false, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, null, null, "Koi Fish 3", "In great condition, regular feeding.", new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new Guid("e1111111-1111-1111-1111-111111111111"), 10, 2.0 },
                    { new Guid("f4444444-4444-4444-4444-444444444444"), 1, "Black and White", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8519), "Female", 1, "https://example.com/koi4.jpg", false, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, null, null, "Koi Fish 4", "Newly purchased, adjusting to pond.", new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), new Guid("e1111111-1111-1111-1111-111111111111"), 7, 3.0 },
                    { new Guid("f5555555-5555-5555-5555-555555555555"), 5, "Blue and White", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8525), "Male", 1, "https://example.com/koi5.jpg", false, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, null, null, "Koi Fish 5", "Strong swimmer, excellent condition.", new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), new Guid("e1111111-1111-1111-1111-111111111111"), 2, 3.0 },
                    { new Guid("f6666666-6666-6666-6666-666666666666"), 2, "White", null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8530), "Female", 1, "https://example.com/koi6.jpg", false, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28.0, null, null, "Koi Fish 6", "Excellent appetite, feeding well.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("e1111111-1111-1111-1111-111111111111"), 4, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9804), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), "Excellent service!", false, null, null, 5, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed") },
                    { new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9807), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), "Good service but could be faster.", false, null, null, 4, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405") },
                    { new Guid("5a5bb4f1-d460-41e6-9565-d900e601973f"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9812), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") },
                    { new Guid("9b0e17ad-5e78-4fb8-b261-4ebbdad1ca8d"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9815), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") },
                    { new Guid("bfe9706c-700b-4d05-bbd4-45b4e9bfe344"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9820), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") }
                });

            migrationBuilder.InsertData(
                table: "VeterinarianSchedule",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Date", "EndTime", "IsAvailable", "IsDeleted", "ModifiedBy", "ModifiedDate", "StartTime", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8018), new DateTime(2024, 11, 5, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7930), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 13, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8044), new DateTime(2024, 11, 3, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7930), new TimeSpan(0, 21, 0, 0, 0), true, false, null, null, new TimeSpan(0, 17, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8041), new DateTime(2024, 11, 2, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7930), new TimeSpan(0, 12, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8014), new DateTime(2024, 11, 4, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7930), new TimeSpan(0, 12, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8031), new DateTime(2024, 11, 7, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7930), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 13, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8023), new DateTime(2024, 11, 6, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7930), new TimeSpan(0, 12, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8034), new DateTime(2024, 11, 1, 22, 51, 35, 471, DateTimeKind.Local).AddTicks(7930), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 13, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AcceptedDate", "AppointmentDate", "ComboServiceId", "CompletedDate", "CreatedBy", "CreatedDate", "CustomerId", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetId", "PetServiceId", "Status" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8184), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, new Guid("f1111111-1111-1111-1111-111111111111"), new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Pending" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8189), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, new Guid("f1111111-1111-1111-1111-111111111111"), new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Waiting" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8202), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), false, null, null, new Guid("f3333333-3333-3333-3333-333333333333"), new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentVeterinarian",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("44444444-aaaa-4444-aaaa-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8349), false, null, null, new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("55555555-aaaa-5555-aaaa-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8351), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-bbbb-5555-bbbb-555555555555"), new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8354), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-cccc-5555-cccc-555555555555"), new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8357), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-dddd-5555-cccc-555555555555"), new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8360), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "ServiceReport",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "HasPrescription", "IsCompleted", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionId", "Recommendations", "ReportContent", "ReportDate" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9110), true, true, false, null, null, new Guid("22222222-2222-2222-2222-222222222222"), "Apply antifungal medication.", "Fungal infection treatment recommended.", new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9126), false, true, false, null, null, null, "Monitor fish for 48 hours.", "Emergency care completed, fish stable.", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666666"), new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9131), false, true, false, null, null, null, "Maintain current diet, no changes needed.", "Feeding routine assessment, nutrition levels adequate.", new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9134), false, true, false, null, null, null, "Fish arrived safely. No action needed.", "Transportation completed successfully.", new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88888888-8888-8888-8888-888888888888"), new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9136), false, true, false, null, null, null, "Monitor breeding progress over the next 10 days.", "Koi breeding assistance provided. Successful pairing observed.", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99999999-9999-9999-9999-999999999999"), new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9139), false, true, false, null, null, null, "Replace filter immediately to prevent water contamination.", "Water quality testing performed. Filter replacement needed.", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9142), true, true, false, null, null, new Guid("33333333-3333-3333-3333-333333333333"), "Apply antiseptic and monitor healing progress.", "Health check performed. Minor injuries found.", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppointmentVeterinarian",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("11111111-aaaa-1111-aaaa-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8338), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("22222222-aaaa-2222-aaaa-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8344), false, null, null, new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("33333333-aaaa-3333-aaaa-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(8346), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionDate", "ServiceReportId" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9260), false, null, null, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9262), false, null, null, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") }
                });

            migrationBuilder.InsertData(
                table: "ServiceReport",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "HasPrescription", "IsCompleted", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionId", "Recommendations", "ReportContent", "ReportDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9117), false, true, false, null, null, null, "Regular water testing recommended.", "Report for Koi health check, everything looks fine.", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9121), true, true, false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Follow the prescribed medicine.", "Parasite treatment required for Koi.", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9124), false, true, false, null, null, null, "Adjust pH levels in the water.", "Water quality test completed, minor adjustments needed.", new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionDate", "ServiceReportId" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 15, 51, 35, 471, DateTimeKind.Utc).AddTicks(9248), false, null, null, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22222222-2222-2222-2222-222222222222") });

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
