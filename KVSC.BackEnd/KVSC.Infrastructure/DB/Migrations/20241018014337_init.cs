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
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LastHealthCheck = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthStatus = table.Column<int>(type: "int", nullable: false),
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
                table: "PetHabitat",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "HabitatType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9416), "Freshwater Pond", false, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9420), "Saltwater Pond", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "PetServiceCategory",
                columns: new[] { "Id", "ApplicableTo", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "ServiceType" },
                values: new object[,]
                {
                    { new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"), "Koi Fish", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7455), "Safe transportation services for Koi fish.", false, null, null, "Koi Transportation", "Transportation" },
                    { new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"), "Koi Fish", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7451), "Guidance and assistance in breeding Koi fish.", false, null, null, "Koi Breeding Assistance", "Breeding" },
                    { new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"), "Koi Fish", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7437), "Testing water quality parameters to ensure a healthy environment for Koi.", false, null, null, "Water Quality Testing", "Testing" },
                    { new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"), "Ponds", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7448), "Regular maintenance services for Koi ponds to ensure optimal conditions.", false, null, null, "Pond Maintenance", "Maintenance" },
                    { new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"), "Koi Fish", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7417), "A standard health check for Koi fish to monitor their overall well-being and prevent diseases.", false, null, null, "Health Check", "Health" },
                    { new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), "Koi Fish", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7441), "Treatment services for Koi suffering from fungal infections.", false, null, null, "Fungal Treatment", "Treatment" },
                    { new Guid("ca3801df-081c-4db5-a416-b04791797d92"), "Koi Enthusiasts", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7466), "Workshops on Koi care and pond management.", false, null, null, "Educational Workshops", "Education" },
                    { new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"), "Koi Fish", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7445), "Services to treat and prevent parasites in Koi fish.", false, null, null, "Parasite Treatment", "Treatment" },
                    { new Guid("fb21c5e6-5db5-4dab-99b1-9c5d51f0ab51"), "Koi Fish", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7459), "Emergency medical services for Koi in distress.", false, null, null, "Emergency Care", "Emergency" },
                    { new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), "Koi Fish", null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7433), "Specialized feeding service for Koi fish, ensuring proper nutrition and dietary requirements.", false, null, null, "Feeding Service", "Feeding" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8696), "Medicines for Koi fish treatments.", false, null, null, "Medicines" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8699), "Products for water conditioning and treatment.", false, null, null, "Water Treatment" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8700), "Equipment and accessories for Koi ponds.", false, null, null, "Pond Equipment" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8702), "Food and nutritional supplements for Koi fish.", false, null, null, "Food & Nutrition" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8704), "Devices and kits for monitoring Koi health.", false, null, null, "Health Monitoring" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8705), "Products for cleaning and maintaining Koi ponds.", false, null, null, "Cleaning & Maintenance" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8707), "Supplies for Koi breeding and spawning.", false, null, null, "Breeding Supplies" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8708), "Materials and accessories for pond landscaping.", false, null, null, "Pond Landscaping" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8711), "Tools and equipment for safe fish transportation.", false, null, null, "Fish Transportation" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8713), "Essential supplies for emergency situations with Koi fish.", false, null, null, "Emergency Supplies" }
                });

            migrationBuilder.InsertData(
                table: "Role",
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
                    { new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), "123 Main St", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(1734), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff2@gmail.com", "Staff_2", false, null, null, "String123!", "123456789", null, "Staff_2", 4 },
                    { new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), "123 Main St", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(1714), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian1@gmail.com", "Veterinarian_1", false, null, null, "String123!", "123456789", null, "Veterinarian_1", 3 },
                    { new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), "123 Main St", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(1726), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "veterinarian2@gmail.com", "Veterinarian_2", false, null, null, "String123!", "123456789", null, "Veterinarian_2", 3 },
                    { new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), "123 Main St", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(1743), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer3@gmail.com", "Customer_3", false, null, null, "String123!", "123456789", null, "Customer_3", 5 },
                    { new Guid("4feb4940-94dc-4aed-b580-ee116b668704"), "123 Main St", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(1692), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", false, null, null, "String123!", "123456789", null, "Admin", 1 },
                    { new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), "123 Main St", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(1730), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", "Staff_1", false, null, null, "String123!", "123456789", null, "Staff_1", 4 },
                    { new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), "123 Main St", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(1710), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "manager@gmail.com", "Manager", false, null, null, "String123!", "123456789", null, "Manager", 2 },
                    { new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), "123 Main St", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(1740), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer2@gmail.com", "Customer_2", false, null, null, "String123!", "123456789", null, "Customer_2", 5 },
                    { new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), "123 Main St", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(1738), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@gmail.com", "Customer_1", false, null, null, "String123!", "123456789", null, "Customer_1", 5 }
                });

            migrationBuilder.InsertData(
                table: "PetService",
                columns: new[] { "Id", "AvailableFrom", "AvailableTo", "BasePrice", "CreatedBy", "CreatedDate", "Duration", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "PetServiceCategoryId", "TravelCost" },
                values: new object[,]
                {
                    { new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"), new DateTime(2024, 10, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 75.00m, null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7588), "1.5 hours", "https://example.com/image4.jpg", false, null, null, "Fungal Treatment", new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), 20.00m },
                    { new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), new DateTime(2024, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), 20.00m, null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7576), "45 minutes", "https://example.com/image3.jpg", false, null, null, "Water Quality Testing", new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"), 5.00m },
                    { new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 30.00m, null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7584), "1 hour", "https://example.com/image2.jpg", false, null, null, "Koi Feeding Service", new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"), 15.00m },
                    { new Guid("39ebc58b-6731-491d-949d-82f387dce82e"), new DateTime(2024, 10, 3, 22, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 2, 10, 20, 0, DateTimeKind.Unspecified), 29.99m, null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7580), "30 minutes", "https://example.com/image.jpg", false, null, null, "Koi Feeding Service", new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"), 10.00m },
                    { new Guid("7253ea62-e419-40dc-bc70-e069611587dd"), new DateTime(2024, 10, 4, 14, 2, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 14, 2, 32, 0, DateTimeKind.Unspecified), 1.00m, null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7597), "string", "string", false, null, null, "string", new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"), 0.00m },
                    { new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), new DateTime(2024, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), 100.00m, null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7571), "2 hours", "https://example.com/image5.jpg", false, null, null, "Parasite Treatment", new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"), 25.00m },
                    { new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"), new DateTime(2024, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), 40.00m, null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7593), "1 hour", "https://example.com/image8.jpg", false, null, null, "Educational Workshops", new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"), 12.00m },
                    { new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 60.00m, null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7601), "1 hour", "https://example.com/image6.jpg", false, null, null, "Pond Maintenance", new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"), 15.00m },
                    { new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), new DateTime(2024, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), 150.00m, null, new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7565), "3 hours", "https://example.com/image7.jpg", false, null, null, "Emergency Care", new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"), 30.00m }
                });

            migrationBuilder.InsertData(
                table: "PetType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "GeneralType", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetHabitatId", "SpecificType" },
                values: new object[,]
                {
                    { new Guid("e1111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8414), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Koi Fish" },
                    { new Guid("e2222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8418), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Goldfish" },
                    { new Guid("e3333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8421), "Reptile", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Turtle" },
                    { new Guid("e4444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8424), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Dog" },
                    { new Guid("e5555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8428), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Cat" },
                    { new Guid("e6666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8430), "Bird", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Parrot" },
                    { new Guid("e7777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8432), "Bird", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Canary" },
                    { new Guid("e8888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8434), "Fish", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Betta Fish" },
                    { new Guid("e9999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8436), "Reptile", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Iguana" },
                    { new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8438), "Mammal", false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Hamster" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Price", "ProductCategoryId", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8529), "Medicine to treat parasite infections in Koi.", "https://example.com/image1.jpg", false, null, null, "Anti-Parasite Medication", 50.00m, new Guid("11111111-1111-1111-1111-111111111111"), 100 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8533), "Water conditioner for Koi ponds.", "https://example.com/image2.jpg", false, null, null, "Water Conditioner", 25.00m, new Guid("22222222-2222-2222-2222-222222222222"), 200 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8538), "Nutritional supplement to enhance Koi growth.", "https://example.com/image3.jpg", false, null, null, "Koi Growth Supplement", 35.00m, new Guid("11111111-1111-1111-1111-111111111111"), 150 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8541), "Stabilizes the pH level of pond water.", "https://example.com/image4.jpg", false, null, null, "Pond pH Stabilizer", 40.00m, new Guid("22222222-2222-2222-2222-222222222222"), 80 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8543), "Treatment for fungal infections in Koi.", "https://example.com/image5.jpg", false, null, null, "Fungal Treatment for Koi", 60.00m, new Guid("11111111-1111-1111-1111-111111111111"), 120 },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8546), "Replacement filter for Koi ponds.", "https://example.com/image6.jpg", false, null, null, "Koi Pond Filter", 75.00m, new Guid("22222222-2222-2222-2222-222222222222"), 60 },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8548), "Antibiotic for treating bacterial infections in Koi.", "https://example.com/image7.jpg", false, null, null, "Koi Antibiotic", 45.00m, new Guid("11111111-1111-1111-1111-111111111111"), 90 },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8551), "Prevents algae buildup in Koi ponds.", "https://example.com/image8.jpg", false, null, null, "Algae Control Solution", 30.00m, new Guid("22222222-2222-2222-2222-222222222222"), 170 },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8553), "Controls parasite infections in Koi.", "https://example.com/image9.jpg", false, null, null, "Parasite Control Solution", 55.00m, new Guid("11111111-1111-1111-1111-111111111111"), 100 },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8556), "Increases oxygen levels in Koi ponds.", "https://example.com/image10.jpg", false, null, null, "Oxygen Booster for Ponds", 65.00m, new Guid("22222222-2222-2222-2222-222222222222"), 130 }
                });

            migrationBuilder.InsertData(
                table: "Veterinarian",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "LicenseNumber", "ModifiedBy", "ModifiedDate", "Qualifications", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7697), false, "VN789012", null, null, "PhD in Veterinary Science", "Fish Surgery", new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a") },
                    { new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7690), false, "VN123456", null, null, "Doctor of Veterinary Medicine (DVM)", "Aquatic Veterinary Medicine", new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea") }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AcceptedDate", "AppointmentDate", "ComboServiceId", "CompletedDate", "CreatedBy", "CreatedDate", "CustomerId", "IsDeleted", "ModifiedBy", "ModifiedDate", "PetId", "PetServiceId", "Status" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 11, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7974), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Pending" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 11, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7979), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Waiting" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 11, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7983), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), false, null, null, null, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Pending" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 11, 3, 13, 30, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7987), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "Waiting" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 11, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7993), new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Waiting" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 11, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7997), new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "InProgress" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8002), new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), false, null, null, null, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "InProgress" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 11, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8011), new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), false, null, null, null, new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"), "Reported" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 11, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8015), new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Reported" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 11, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8019), new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), false, null, null, null, new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), "Completed" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), null, new DateTime(2024, 11, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 11, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8023), new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), false, null, null, null, new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"), "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "Id", "Age", "Color", "CreatedBy", "CreatedDate", "Gender", "HealthStatus", "ImageUrl", "IsDeleted", "LastHealthCheck", "Length", "ModifiedBy", "ModifiedDate", "Name", "Note", "OwnerId", "PetTypeId", "Quantity", "Weight" },
                values: new object[,]
                {
                    { new Guid("f1111111-1111-1111-1111-111111111111"), 3, "Orange and White", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8214), "Male", 1, "https://example.com/koi1.jpg", false, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, null, null, "Koi Fish 1", "Healthy with vibrant colors.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("e1111111-1111-1111-1111-111111111111"), 5, 2.5 },
                    { new Guid("f2222222-2222-2222-2222-222222222222"), 4, "Red and White", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8225), "Female", 2, "https://example.com/koi2.jpg", false, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, null, null, "Koi Fish 2", "Slight issue with fins, under observation.", new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), new Guid("e1111111-1111-1111-1111-111111111111"), 3, 3.0 },
                    { new Guid("f3333333-3333-3333-3333-333333333333"), 2, "Yellow and White", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8291), "Male", 1, "https://example.com/koi3.jpg", false, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, null, null, "Koi Fish 3", "In great condition, regular feeding.", new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), new Guid("e1111111-1111-1111-1111-111111111111"), 10, 2.2000000000000002 },
                    { new Guid("f4444444-4444-4444-4444-444444444444"), 1, "Black and White", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8296), "Female", 1, "https://example.com/koi4.jpg", false, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, null, null, "Koi Fish 4", "Newly purchased, adjusting to pond.", new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), new Guid("e1111111-1111-1111-1111-111111111111"), 7, 1.8 },
                    { new Guid("f5555555-5555-5555-5555-555555555555"), 5, "Blue and White", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8301), "Male", 1, "https://example.com/koi5.jpg", false, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, null, null, "Koi Fish 5", "Strong swimmer, excellent condition.", new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), new Guid("e1111111-1111-1111-1111-111111111111"), 2, 3.5 },
                    { new Guid("f6666666-6666-6666-6666-666666666666"), 2, "White", null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8305), "Female", 1, "https://example.com/koi6.jpg", false, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28.0, null, null, "Koi Fish 6", "Excellent appetite, feeding well.", new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), new Guid("e1111111-1111-1111-1111-111111111111"), 4, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "VeterinarianSchedule",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Date", "EndTime", "IsAvailable", "IsDeleted", "ModifiedBy", "ModifiedDate", "StartTime", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7821), new DateTime(2024, 10, 22, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798), new TimeSpan(0, 18, 0, 0, 0), true, false, null, null, new TimeSpan(0, 10, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 10, 20, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798), new TimeSpan(0, 20, 0, 0, 0), true, false, null, null, new TimeSpan(0, 12, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 10, 19, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798), new TimeSpan(0, 15, 0, 0, 0), true, false, null, null, new TimeSpan(0, 9, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7816), new DateTime(2024, 10, 21, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798), new TimeSpan(0, 16, 0, 0, 0), true, false, null, null, new TimeSpan(0, 8, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 10, 24, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798), new TimeSpan(0, 19, 0, 0, 0), true, false, null, null, new TimeSpan(0, 11, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7824), new DateTime(2024, 10, 23, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798), new TimeSpan(0, 17, 0, 0, 0), true, false, null, null, new TimeSpan(0, 9, 0, 0, 0), new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(7833), new DateTime(2024, 10, 18, 8, 43, 36, 804, DateTimeKind.Local).AddTicks(7798), new TimeSpan(0, 18, 0, 0, 0), true, false, null, null, new TimeSpan(0, 10, 0, 0, 0), new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "AppointmentVeterinarian",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "VeterinarianId" },
                values: new object[,]
                {
                    { new Guid("11111111-aaaa-1111-aaaa-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8104), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("22222222-aaaa-2222-aaaa-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8108), false, null, null, new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("33333333-aaaa-3333-aaaa-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8111), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("44444444-aaaa-4444-aaaa-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8113), false, null, null, new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") },
                    { new Guid("55555555-aaaa-5555-aaaa-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8116), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-bbbb-5555-bbbb-555555555555"), new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8118), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") },
                    { new Guid("55555555-cccc-5555-cccc-555555555555"), new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(8120), false, null, null, new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") }
                });

            migrationBuilder.InsertData(
                table: "ServiceReport",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "CreatedDate", "HasPrescription", "IsCompleted", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionId", "Recommendations", "ReportContent", "ReportDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9132), false, true, false, null, null, null, "Regular water testing recommended.", "Report for Koi health check, everything looks fine.", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9135), true, true, false, null, null, new Guid("11111111-1111-1111-1111-111111111111"), "Follow the prescribed medicine.", "Parasite treatment required for Koi.", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9138), false, true, false, null, null, null, "Adjust pH levels in the water.", "Water quality test completed, minor adjustments needed.", new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9126), true, true, false, null, null, new Guid("22222222-2222-2222-2222-222222222222"), "Apply antifungal medication.", "Fungal infection treatment recommended.", new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9141), false, true, false, null, null, null, "Monitor fish for 48 hours.", "Emergency care completed, fish stable.", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666666"), new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9143), false, true, false, null, null, null, "Maintain current diet, no changes needed.", "Feeding routine assessment, nutrition levels adequate.", new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new Guid("77777777-7777-7777-7777-777777777777"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9148), false, true, false, null, null, null, "Fish arrived safely. No action needed.", "Transportation completed successfully.", new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88888888-8888-8888-8888-888888888888"), new Guid("88888888-8888-8888-8888-888888888888"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9151), false, true, false, null, null, null, "Monitor breeding progress over the next 10 days.", "Koi breeding assistance provided. Successful pairing observed.", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99999999-9999-9999-9999-999999999999"), new Guid("99999999-9999-9999-9999-999999999999"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9153), false, true, false, null, null, null, "Replace filter immediately to prevent water contamination.", "Water quality testing performed. Filter replacement needed.", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9156), true, true, false, null, null, new Guid("33333333-3333-3333-3333-333333333333"), "Apply antiseptic and monitor healing progress.", "Health check performed. Minor injuries found.", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PrescriptionDate", "ServiceReportId" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9245), false, null, null, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9249), false, null, null, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2024, 10, 18, 1, 43, 36, 804, DateTimeKind.Utc).AddTicks(9251), false, null, null, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionDetail",
                columns: new[] { "PrescriptionDetailId", "MedicineId", "PrescriptionId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), new Guid("11111111-1111-1111-1111-111111111111"), 100.00m, 2 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), new Guid("22222222-2222-2222-2222-222222222222"), 150.00m, 3 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), new Guid("33333333-3333-3333-3333-333333333333"), 50.00m, 1 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("44444444-4444-4444-4444-444444444444"), new Guid("22222222-2222-2222-2222-222222222222"), 200.00m, 4 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new Guid("55555555-5555-5555-5555-555555555555"), new Guid("33333333-3333-3333-3333-333333333333"), 250.00m, 5 }
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
                name: "IX_ServiceReport_AppointmentId",
                table: "ServiceReport",
                column: "AppointmentId");

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
                name: "Role");

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
