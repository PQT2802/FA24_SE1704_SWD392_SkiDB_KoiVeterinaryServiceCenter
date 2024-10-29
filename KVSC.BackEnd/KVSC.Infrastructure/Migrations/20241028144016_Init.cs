using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KVSC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SystemTransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                        name: "FK_Payment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Message",
                columns: new[] { "Id", "Content", "RecipientId", "SenderId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("0531f045-c921-49d2-87ca-c8ee7259a013"), "Mình vẫn khỏe, cảm ơn bạn! Bạn thì sao?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8550) },
                    { new Guid("05914ef7-495b-41f9-92b9-610096d85056"), "Cảm ơn bạn, tôi sẽ xem xét ngay.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8584) },
                    { new Guid("0f40309f-5fb6-4480-81a2-e58d7c91081e"), "Tôi hiểu. Bạn có thể cho tôi biết nhiệt độ nước và tình trạng nước trong hồ không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 10, 28, 21, 42, 13, 387, DateTimeKind.Local).AddTicks(8623) },
                    { new Guid("170579da-bdc7-41ce-99fc-4fabd2cc4e7c"), "Tôi sẽ gửi cho bạn một bản tóm tắt.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8579) },
                    { new Guid("2f7bb034-4578-4e9c-8746-9bf3b4c06faa"), "Mình muốn hỏi bạn về dự án mới.", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8567) },
                    { new Guid("37ff70d9-9871-4ef5-8090-6f2b9e08c1dc"), "Chào bạn, bạn có khỏe không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8541) },
                    { new Guid("420cd961-e72c-4223-b326-716d257b7bd6"), "Cảm ơn bác sĩ! Tôi sẽ kiểm tra và liên lạc lại nếu cần thêm giúp đỡ.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 28, 21, 45, 13, 387, DateTimeKind.Local).AddTicks(8637) },
                    { new Guid("79c71c97-dd91-4724-9af3-902e6355e9ce"), "Xin chào! Tôi là bác sĩ thú y, bạn cần tôi giúp gì về cá koi của bạn?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8608) },
                    { new Guid("90ff55f9-793a-4b71-855f-27256512afc8"), "Chào bác sĩ! Con koi của tôi có dấu hiệu lờ đờ và không ăn. Tôi rất lo lắng.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 28, 21, 41, 13, 387, DateTimeKind.Local).AddTicks(8615) },
                    { new Guid("a6059ecc-05d3-4804-b58b-9d595f250393"), "Nhiệt độ nước là 20 độ C và nước có vẻ trong, nhưng tôi thấy một ít tảo xanh.", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 28, 21, 43, 13, 387, DateTimeKind.Local).AddTicks(8628) },
                    { new Guid("b1ef6218-bb84-45e6-a0aa-2a753f837634"), "Chắc chắn rồi! Bạn cần biết gì?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8571) },
                    { new Guid("b95a467c-d9a3-4eca-82fc-fd3346c3ddf9"), "Bạn có thông tin chi tiết về tiến độ không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8575) },
                    { new Guid("c120837e-cc1b-4f8a-95fe-1cebdd5fdcb1"), "Không có gì, mình luôn sẵn lòng giúp đỡ.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8594) },
                    { new Guid("c2085a09-76f3-4bdc-955d-a3ddc22040f3"), "Mình có chút thời gian, bạn cần gì không?", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8562) },
                    { new Guid("eda78bfa-c548-4734-9f4a-28731e06b1fd"), "Mình cũng tốt, hôm nay bạn có rảnh không?", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(8554) },
                    { new Guid("ffa8290e-ba60-4ff7-aac0-f987a51c8105"), "Tảo có thể ảnh hưởng đến chất lượng nước. Tôi khuyên bạn nên kiểm tra pH và amoniac trong nước. Có thể sử dụng bộ thử nghiệm nước để làm điều này.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), new DateTime(2024, 10, 28, 21, 44, 13, 387, DateTimeKind.Local).AddTicks(8632) }
                });

            migrationBuilder.InsertData(
                table: "PetHabitat",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "HabitatType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(8389), "Freshwater Pond", false, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(8394), "Saltwater Pond", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PetServiceCategory",
                columns: new[] { "Id", "ApplicableTo", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "ServiceType" },
                values: new object[,]
                {
                    { new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"), "Koi Fish", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3931), "Safe transportation services for Koi fish.", false, null, null, "Koi Transportation", "Transportation" },
                    { new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"), "Koi Fish", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3927), "Guidance and assistance in breeding Koi fish.", false, null, null, "Koi Breeding Assistance", "Breeding" },
                    { new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"), "Koi Fish", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3878), "Testing water quality parameters to ensure a healthy environment for Koi.", false, null, null, "Water Quality Testing", "Testing" },
                    { new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"), "Ponds", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3922), "Regular maintenance services for Koi ponds to ensure optimal conditions.", false, null, null, "Pond Maintenance", "Maintenance" },
                    { new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"), "Koi Fish", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3840), "A standard health check for Koi fish to monitor their overall well-being and prevent diseases.", false, null, null, "Health Check", "Health" },
                    { new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), "Koi Fish", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3907), "Treatment services for Koi suffering from fungal infections.", false, null, null, "Fungal Treatment", "Treatment" },
                    { new Guid("ca3801df-081c-4db5-a416-b04791797d92"), "Koi Enthusiasts", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3940), "Workshops on Koi care and pond management.", false, null, null, "Educational Workshops", "Education" },
                    { new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"), "Koi Fish", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3917), "Services to treat and prevent parasites in Koi fish.", false, null, null, "Parasite Treatment", "Treatment" },
                    { new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"), "Koi Fish", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3936), "Emergency medical services for Koi in distress.", false, null, null, "Emergency Care", "Emergency" },
                    { new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), "Koi Fish", null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(3873), "Specialized feeding service for Koi fish, ensuring proper nutrition and dietary requirements.", false, null, null, "Feeding Service", "Feeding" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7179), "Medicines for Koi fish treatments.", false, null, null, "Medicines" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7554), "Products for water conditioning and treatment.", false, null, null, "Water Treatment" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7559), "Equipment and accessories for Koi ponds.", false, null, null, "Pond Equipment" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7562), "Food and nutritional supplements for Koi fish.", false, null, null, "Food & Nutrition" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7568), "Devices and kits for monitoring Koi health.", false, null, null, "Health Monitoring" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7571), "Products for cleaning and maintaining Koi ponds.", false, null, null, "Cleaning & Maintenance" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7574), "Supplies for Koi breeding and spawning.", false, null, null, "Breeding Supplies" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7576), "Materials and accessories for pond landscaping.", false, null, null, "Pond Landscaping" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7579), "Tools and equipment for safe fish transportation.", false, null, null, "Fish Transportation" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7582), "Essential supplies for emergency situations with Koi fish.", false, null, null, "Emergency Supplies" }
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
                    { new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), "123 Main St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2388), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff2@gmail.com", "Staff_2", false, null, null, "String123!", "123456789", null, "Staff_2", 4 },
                    { new Guid("0f43fda0-fbde-4079-8ae4-66da674c8455"), "369 Larch St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3204), new DateTime(1983, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer18@gmail.com", "Customer_18", false, null, null, "String123!", "456789012", null, "Customer_18", 5 },
                    { new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), "123 Main St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2371), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian1@gmail.com", "Veterinarian_1", false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Veterinarian_1", 3 },
                    { new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), "123 Main St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2376), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian2@gmail.com", "Veterinarian_2", false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Veterinarian_2", 3 },
                    { new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "123 Main St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2419), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer3@gmail.com", "Customer_3", false, null, null, "String123!", "123456789", null, "Customer_3", 5 },
                    { new Guid("4b171e29-8041-4d4d-a96d-4f7efc1f635b"), "357 Fir St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3178), new DateTime(1988, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer13@gmail.com", "Customer_13", false, null, null, "String123!", "012345678", null, "Customer_13", 5 },
                    { new Guid("4feb4940-94dc-4aed-b580-ee116b668704"), "123 Main St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2322), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Admin", 1 },
                    { new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), "123 Main St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2382), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", "Staff_1", false, null, null, "String123!", "123456789", null, "Staff_1", 4 },
                    { new Guid("6b1f16be-c12a-4709-95d4-f0c623239823"), "321 Maple St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2433), new DateTime(1994, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer6@gmail.com", "Customer_6", false, null, null, "String123!", "345678901", null, "Customer_6", 5 },
                    { new Guid("79a27f2e-e21b-49b1-99a3-e66b18c5cba0"), "147 Palm St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3192), new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer16@gmail.com", "Customer_16", false, null, null, "String123!", "234567890", null, "Customer_16", 5 },
                    { new Guid("a1d5c6e2-4f26-4860-9f3e-563a07f1cbf6"), "789 Pine St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2428), new DateTime(1993, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer5@gmail.com", "Customer_5", false, null, null, "String123!", "234567890", null, "Customer_5", 5 },
                    { new Guid("a255eb98-d5b4-4e57-bbff-1de8c6b844b0"), "369 Redwood St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3188), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer15@gmail.com", "Customer_15", false, null, null, "String123!", "987654321", null, "Customer_15", 5 },
                    { new Guid("a41b99c8-7d70-4c8c-9bc3-e249f93c9278"), "753 Cherry St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3164), new DateTime(1998, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer10@gmail.com", "Customer_10", false, null, null, "String123!", "789012345", null, "Customer_10", 5 },
                    { new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), "123 Main St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2363), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "manager@gmail.com", "Manager", false, null, null, "String123!", "123456789", null, "Manager", 2 },
                    { new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), "123 Main St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2415), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer2@gmail.com", "Customer_2", false, null, null, "String123!", "123456789", null, "Customer_2", 5 },
                    { new Guid("c30d6f58-b8e0-4fb4-b10c-f9c2af7a3622"), "159 Willow St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3156), new DateTime(1997, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer9@gmail.com", "Customer_9", false, null, null, "String123!", "678901234", null, "Customer_9", 5 },
                    { new Guid("c4e31a0b-982b-43e5-bb52-93b7c2e4b307"), "258 Spruce St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3183), new DateTime(1987, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer14@gmail.com", "Customer_14", false, null, null, "String123!", "123456789", null, "Customer_14", 5 },
                    { new Guid("c5e4f6e5-bd3c-4fd5-b3d7-8a7f9c8e3b44"), "690 Cedar St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3212), new DateTime(1981, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer20@gmail.com", "Customer_20", false, null, null, "String123!", "678901234", null, "Customer_20", 5 },
                    { new Guid("ca28f1ab-1cfc-4e99-835f-e44c65756bb3"), "987 Birch St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2441), new DateTime(1996, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer8@gmail.com", "Customer_8", false, null, null, "String123!", "567890123", null, "Customer_8", 5 },
                    { new Guid("d13e5c69-8d8a-4b67-b378-0e2de003816b"), "456 Elm St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2423), new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer4@gmail.com", "Customer_4", false, null, null, "String123!", "987654321", null, "Customer_4", 5 },
                    { new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), "123 Main St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2410), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@gmail.com", "Customer_1", false, null, null, "String123!", "123456789", "User/0c08ff89-61a7-4b57-9c1d-ac6f3c57907b_Screenshot 2024-01-17 155826.png", "Customer_1", 5 },
                    { new Guid("e3c1e155-dbc4-40a8-8a5a-091557942c55"), "258 Acacia St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3199), new DateTime(1984, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer17@gmail.com", "Customer_17", false, null, null, "String123!", "345678901", null, "Customer_17", 5 },
                    { new Guid("e79cb43f-3b60-4d8d-84c5-579c1d6c80e4"), "852 Oak St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3169), new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer11@gmail.com", "Customer_11", false, null, null, "String123!", "890123456", null, "Customer_11", 5 },
                    { new Guid("f1f55d2a-b96f-4c74-b89e-e4c29a1d8e2e"), "654 Cedar St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(2437), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer7@gmail.com", "Customer_7", false, null, null, "String123!", "456789012", null, "Customer_7", 5 },
                    { new Guid("f81253a8-7937-4c29-80d3-bcfa0522f9e8"), "963 Sycamore St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3174), new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer12@gmail.com", "Customer_12", false, null, null, "String123!", "901234567", null, "Customer_12", 5 },
                    { new Guid("fe29d53f-44b8-40b5-8672-bb37f6b5c8c5"), "579 Fir St", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(3208), new DateTime(1982, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer19@gmail.com", "Customer_19", false, null, null, "String123!", "567890123", null, "Customer_19", 5 }
                });

            migrationBuilder.InsertData(
                table: "PetService",
                columns: new[] { "Id", "AvailableFrom", "AvailableTo", "BasePrice", "CreatedBy", "CreatedDate", "Duration", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "PetServiceCategoryId", "TravelCost" },
                values: new object[,]
                {
                    { new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"), new DateTime(2024, 10, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 75.00m, null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4168), "1.5 hours", "https://example.com/image4.jpg", false, null, null, "Fungal Treatment", new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), 20.00m },
                    { new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), new DateTime(2024, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), 20.00m, null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4147), "45 minutes", "https://example.com/image3.jpg", false, null, null, "Water Quality Testing", new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"), 5.00m },
                    { new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 30.00m, null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4161), "1 hour", "https://example.com/image2.jpg", false, null, null, "Koi Feeding Service", new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), 15.00m },
                    { new Guid("39ebc58b-6731-491d-949d-82f387dce82e"), new DateTime(2024, 10, 3, 22, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 2, 10, 20, 0, DateTimeKind.Unspecified), 29.99m, null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4154), "30 minutes", "https://example.com/image.jpg", false, null, null, "Koi Feeding Service", new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), 10.00m },
                    { new Guid("7253ea62-e419-40dc-bc70-e069611587dd"), new DateTime(2024, 10, 4, 14, 2, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 14, 2, 32, 0, DateTimeKind.Unspecified), 1.00m, null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4621), "string", "string", false, null, null, "string", new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"), 0.00m },
                    { new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), new DateTime(2024, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), 100.00m, null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4136), "2 hours", "https://example.com/image5.jpg", false, null, null, "Parasite Treatment", new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"), 25.00m },
                    { new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"), new DateTime(2024, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), 40.00m, null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4549), "1 hour", "https://example.com/image8.jpg", false, null, null, "Educational Workshops", new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"), 12.00m },
                    { new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 60.00m, null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4628), "1 hour", "https://example.com/image6.jpg", false, null, null, "Pond Maintenance", new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"), 15.00m },
                    { new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), new DateTime(2024, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), 150.00m, null, new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4127), "3 hours", "https://example.com/image7.jpg", false, null, null, "Emergency Care", new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"), 30.00m }
                });

            migrationBuilder.InsertData(
                table: "PetType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "GeneralType", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetHabitatId", "SpecificType" },
                values: new object[,]
                {
                    { new Guid("e1111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6746), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Koi Fish" },
                    { new Guid("e2222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6752), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Goldfish" },
                    { new Guid("e3333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6756), "Reptile", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Turtle" },
                    { new Guid("e4444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6760), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Dog" },
                    { new Guid("e5555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6763), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Cat" },
                    { new Guid("e6666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6767), "Bird", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Parrot" },
                    { new Guid("e7777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6770), "Bird", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Canary" },
                    { new Guid("e8888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6774), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Betta Fish" },
                    { new Guid("e9999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6780), "Reptile", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Iguana" },
                    { new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6784), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Hamster" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Price", "ProductCategoryId", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6967), "Medicine to treat parasite infections in Koi.", "https://example.com/image1.jpg", false, null, null, "Anti-Parasite Medication", 50.00m, new Guid("11111111-1111-1111-1111-111111111111"), 100 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6974), "Water conditioner for Koi ponds.", "https://example.com/image2.jpg", false, null, null, "Water Conditioner", 25.00m, new Guid("22222222-2222-2222-2222-222222222222"), 200 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6979), "Nutritional supplement to enhance Koi growth.", "https://example.com/image3.jpg", false, null, null, "Koi Growth Supplement", 35.00m, new Guid("11111111-1111-1111-1111-111111111111"), 150 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6984), "Stabilizes the pH level of pond water.", "https://example.com/image4.jpg", false, null, null, "Pond pH Stabilizer", 40.00m, new Guid("22222222-2222-2222-2222-222222222222"), 80 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6988), "Treatment for fungal infections in Koi.", "https://example.com/image5.jpg", false, null, null, "Fungal Treatment for Koi", 60.00m, new Guid("11111111-1111-1111-1111-111111111111"), 120 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6993), "Replacement filter for Koi ponds.", "https://example.com/image6.jpg", false, null, null, "Koi Pond Filter", 75.00m, new Guid("22222222-2222-2222-2222-222222222222"), 60 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7000), "Antibiotic for treating bacterial infections in Koi.", "https://example.com/image7.jpg", false, null, null, "Koi Antibiotic", 45.00m, new Guid("11111111-1111-1111-1111-111111111111"), 90 },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7004), "Prevents algae buildup in Koi ponds.", "https://example.com/image8.jpg", false, null, null, "Algae Control Solution", 30.00m, new Guid("22222222-2222-2222-2222-222222222222"), 170 },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7008), "Controls parasite infections in Koi.", "https://example.com/image9.jpg", false, null, null, "Parasite Control Solution", 55.00m, new Guid("11111111-1111-1111-1111-111111111111"), 100 },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7012), "Increases oxygen levels in Koi ponds.", "https://example.com/image10.jpg", false, null, null, "Oxygen Booster for Ponds", 65.00m, new Guid("22222222-2222-2222-2222-222222222222"), 130 }
                });

            migrationBuilder.InsertData(
                table: "Veterinarian",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "LicenseNumber", "ModifiedBy", "ModifiedDate", "Qualifications", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(4819), false, "VN789012", null, null, "PhD in Veterinary Science", "Fish Surgery", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") },
                    { new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(4809), false, "VN123456", null, null, "Doctor of Veterinary Medicine (DVM)", "Aquatic Veterinary Medicine", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AcceptedDate", "AppointmentDate", "ComboServiceId", "CompletedDate", "CreatedBy", "CreatedDate", "CustomerId", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetId", "PetServiceId", "Status" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 3, 13, 30, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5287), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "Waiting" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5294), new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Waiting" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5300), new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "InProgress" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5306), new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), false, null, null, null, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "InProgress" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5317), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "Reported" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5327), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Reported" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5334), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), false, null, null, null, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Completed" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), null, new DateTime(2024, 11, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5348), new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "Id", "Age", "Color", "CreatedBy", "CreatedDate", "Gender", "HealthStatus", "ImageUrl", "IsDeleted", "LastHealthCheck", "Length", "ModifiedBy", "ModifiedDate", "Name", "Note", "OwnerId", "PetTypeId", "Quantity", "Weight" },
                values: new object[,]
                {
                    { new Guid("f1111111-1111-1111-1111-111111111111"), 3, "Orange and White", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6044), "Male", 1, "https://example.com/koi1.jpg", false, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, null, null, "Koi Fish 1", "Healthy with vibrant colors.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("e1111111-1111-1111-1111-111111111111"), 5, 2.5 },
                    { new Guid("f2222222-2222-2222-2222-222222222222"), 4, "Red and White", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6067), "Female", 2, "https://example.com/koi2.jpg", false, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, null, null, "Koi Fish 2", "Slight issue with fins, under observation.", new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), new Guid("e1111111-1111-1111-1111-111111111111"), 3, 3.0 },
                    { new Guid("f3333333-3333-3333-3333-333333333333"), 2, "Yellow and White", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6081), "Male", 1, "https://example.com/koi3.jpg", false, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, null, null, "Koi Fish 3", "In great condition, regular feeding.", new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new Guid("e1111111-1111-1111-1111-111111111111"), 10, 2.2000000000000002 },
                    { new Guid("f4444444-4444-4444-4444-444444444444"), 1, "Black and White", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6088), "Female", 1, "https://example.com/koi4.jpg", false, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, null, null, "Koi Fish 4", "Newly purchased, adjusting to pond.", new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), new Guid("e1111111-1111-1111-1111-111111111111"), 7, 1.8 },
                    { new Guid("f5555555-5555-5555-5555-555555555555"), 5, "Blue and White", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6096), "Male", 1, "https://example.com/koi5.jpg", false, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, null, null, "Koi Fish 5", "Strong swimmer, excellent condition.", new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), new Guid("e1111111-1111-1111-1111-111111111111"), 2, 3.5 },
                    { new Guid("f6666666-6666-6666-6666-666666666666"), 2, "White", null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(6155), "Female", 1, "https://example.com/koi6.jpg", false, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28.0, null, null, "Koi Fish 6", "Excellent appetite, feeding well.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("e1111111-1111-1111-1111-111111111111"), 4, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Feedback", "IsDeleted", "ModifiedBy", "ModifiedDate", "Score", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("0d98cd62-09ae-45ba-af62-a9472d18086d"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(9467), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Average experience.", false, null, null, 3, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8") },
                    { new Guid("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(9450), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), "Excellent service!", false, null, null, 5, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed") },
                    { new Guid("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(9458), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), "Good service but could be faster.", false, null, null, 4, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405") },
                    { new Guid("38211085-691c-465e-9edc-c5395421dfce"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(9473), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Not satisfied with the waiting time.", false, null, null, 2, new Guid("39ebc58b-6731-491d-949d-82f387dce82e") },
                    { new Guid("eb4fab56-ab57-4ae9-94d6-bac3329a4a8e"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(9478), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "Very professional and caring staff.", false, null, null, 5, new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87") }
                });

            migrationBuilder.InsertData(
                table: "VeterinarianSchedule",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Date", "EndTime", "IsAvailable", "IsDeleted", "ModifiedBy", "ModifiedDate", "StartTime", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5001), new DateTime(2024, 10, 29, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4965), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 13, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5027), new DateTime(2024, 11, 3, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4965), new TimeSpan(0, 21, 0, 0, 0), true, false, null, null, new TimeSpan(0, 17, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5022), new DateTime(2024, 11, 2, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4965), new TimeSpan(0, 12, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(4994), new DateTime(2024, 10, 28, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4965), new TimeSpan(0, 12, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5011), new DateTime(2024, 10, 31, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4965), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 13, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5006), new DateTime(2024, 10, 30, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4965), new TimeSpan(0, 12, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5016), new DateTime(2024, 11, 1, 21, 40, 13, 387, DateTimeKind.Local).AddTicks(4965), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 13, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AcceptedDate", "AppointmentDate", "ComboServiceId", "CompletedDate", "CreatedBy", "CreatedDate", "CustomerId", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetId", "PetServiceId", "Status" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5264), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, new Guid("f1111111-1111-1111-1111-111111111111"), new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Pending" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5273), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, new Guid("f1111111-1111-1111-1111-111111111111"), new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Waiting" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5281), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), false, null, null, new Guid("f3333333-3333-3333-3333-333333333333"), new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentVeterinarian",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("44444444-aaaa-4444-aaaa-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5522), false, null, null, new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("55555555-aaaa-5555-aaaa-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5673), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-bbbb-5555-bbbb-555555555555"), new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5683), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-cccc-5555-cccc-555555555555"), new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5688), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "ServiceReport",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "HasPrescription", "IsCompleted", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionId", "Recommendations", "ReportContent", "ReportDate" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7748), true, true, false, null, null, new Guid("22222222-2222-2222-2222-222222222222"), "Apply antifungal medication.", "Fungal infection treatment recommended.", new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7782), false, true, false, null, null, null, "Monitor fish for 48 hours.", "Emergency care completed, fish stable.", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666666"), new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7786), false, true, false, null, null, null, "Maintain current diet, no changes needed.", "Feeding routine assessment, nutrition levels adequate.", new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7790), false, true, false, null, null, null, "Fish arrived safely. No action needed.", "Transportation completed successfully.", new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88888888-8888-8888-8888-888888888888"), new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7795), false, true, false, null, null, null, "Monitor breeding progress over the next 10 days.", "Koi breeding assistance provided. Successful pairing observed.", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99999999-9999-9999-9999-999999999999"), new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7799), false, true, false, null, null, null, "Replace filter immediately to prevent water contamination.", "Water quality testing performed. Filter replacement needed.", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7804), true, true, false, null, null, new Guid("33333333-3333-3333-3333-333333333333"), "Apply antiseptic and monitor healing progress.", "Health check performed. Minor injuries found.", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AppointmentVeterinarian",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("11111111-aaaa-1111-aaaa-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5508), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("22222222-aaaa-2222-aaaa-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5513), false, null, null, new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("33333333-aaaa-3333-aaaa-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(5517), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionDate", "ServiceReportId" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7966), false, null, null, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7970), false, null, null, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") }
                });

            migrationBuilder.InsertData(
                table: "ServiceReport",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "HasPrescription", "IsCompleted", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionId", "Recommendations", "ReportContent", "ReportDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7763), false, true, false, null, null, null, "Regular water testing recommended.", "Report for Koi health check, everything looks fine.", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7771), true, true, false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Follow the prescribed medicine.", "Parasite treatment required for Koi.", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7777), false, true, false, null, null, null, "Adjust pH levels in the water.", "Water quality test completed, minor adjustments needed.", new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionDate", "ServiceReportId" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 28, 14, 40, 13, 387, DateTimeKind.Utc).AddTicks(7960), false, null, null, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22222222-2222-2222-2222-222222222222") });

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
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId");

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
                name: "IX_Veterinarian_UserId",
                table: "Veterinarian",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VeterinarianSchedule_VeterinarianId",
                table: "VeterinarianSchedule",
                column: "VeterinarianId");
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
                name: "VeterinarianSchedule");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Product");

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
