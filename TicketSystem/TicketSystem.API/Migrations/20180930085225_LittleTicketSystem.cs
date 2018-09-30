using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.API.Migrations
{
    public partial class LittleTicketSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminPassword = table.Column<int>(nullable: false),
                    AdminUserName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeparmentIDID = table.Column<int>(nullable: true),
                    UserAvatar = table.Column<string>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true),
                    UserLastIP = table.Column<string>(nullable: true),
                    UserLastLogin = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    UserPhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Departments_DeparmentIDID",
                        column: x => x.DeparmentIDID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mail",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MailDescription = table.Column<int>(nullable: false),
                    MailTitle = table.Column<int>(nullable: false),
                    UserIDID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mail_Users_UserIDID",
                        column: x => x.UserIDID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NotificationDescription = table.Column<int>(nullable: false),
                    NotificationID = table.Column<int>(nullable: false),
                    NotificationTitle = table.Column<int>(nullable: false),
                    UserIDID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserIDID",
                        column: x => x.UserIDID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignDate = table.Column<string>(nullable: true),
                    AssignUser = table.Column<int>(nullable: false),
                    CreateDate = table.Column<string>(nullable: true),
                    CreateUser = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    TicketDescription = table.Column<string>(nullable: true),
                    TicketTitle = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: false),
                    UserIDID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_UserIDID",
                        column: x => x.UserIDID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mail_UserIDID",
                table: "Mail",
                column: "UserIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserIDID",
                table: "Notifications",
                column: "UserIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserIDID",
                table: "Tickets",
                column: "UserIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DeparmentIDID",
                table: "Users",
                column: "DeparmentIDID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Mail");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
