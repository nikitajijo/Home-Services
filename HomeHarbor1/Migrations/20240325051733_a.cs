using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeHarbor1.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Reg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phn_No = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Reg_Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Service_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Service_Id);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    Slot_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.Slot_Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Feedback_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service_Id = table.Column<int>(type: "int", nullable: false),
                    Reg_Id = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commented_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Feedback_Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Registrations_Reg_Id",
                        column: x => x.Reg_Id,
                        principalTable: "Registrations",
                        principalColumn: "Reg_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Services_Service_Id",
                        column: x => x.Service_Id,
                        principalTable: "Services",
                        principalColumn: "Service_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service_Id = table.Column<int>(type: "int", nullable: false),
                    Reg_Id = table.Column<int>(type: "int", nullable: false),
                    Slot_Id = table.Column<int>(type: "int", nullable: false),
                    Booking_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Booked_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Booking_Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Registrations_Reg_Id",
                        column: x => x.Reg_Id,
                        principalTable: "Registrations",
                        principalColumn: "Reg_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Services_Service_Id",
                        column: x => x.Service_Id,
                        principalTable: "Services",
                        principalColumn: "Service_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Slots_Slot_Id",
                        column: x => x.Slot_Id,
                        principalTable: "Slots",
                        principalColumn: "Slot_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Status_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Booking_Id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Status_Id);
                    table.ForeignKey(
                        name: "FK_Statuses_Bookings_Booking_Id",
                        column: x => x.Booking_Id,
                        principalTable: "Bookings",
                        principalColumn: "Booking_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Reg_Id",
                table: "Bookings",
                column: "Reg_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Service_Id",
                table: "Bookings",
                column: "Service_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Slot_Id",
                table: "Bookings",
                column: "Slot_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Reg_Id",
                table: "Feedbacks",
                column: "Reg_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Service_Id",
                table: "Feedbacks",
                column: "Service_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_Booking_Id",
                table: "Statuses",
                column: "Booking_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Slots");
        }
    }
}
