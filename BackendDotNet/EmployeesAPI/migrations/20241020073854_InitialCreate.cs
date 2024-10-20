using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BUSINESS_USER",
                columns: table => new
                {
                    username = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    passwrd = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BUSINESS__F3DBC573583A5718", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "DEPARTMENT",
                columns: table => new
                {
                    dName = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DEPARTME__112B23CEBEC94EE3", x => x.dName);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dName = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    nationalNumber = table.Column<long>(type: "bigint", nullable: false),
                    fname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    mname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    lname = table.Column<string>(type: "varchar(97)", unicode: false, maxLength: 97, nullable: false),
                    adress = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    salary = table.Column<double>(type: "float", nullable: false),
                    sex = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    bDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE", x => x.id);
                    table.ForeignKey(
                        name: "FK__EMPLOYEE__dName__286302EC",
                        column: x => x.dName,
                        principalTable: "DEPARTMENT",
                        principalColumn: "dName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_dName",
                table: "EMPLOYEE",
                column: "dName");

            migrationBuilder.CreateIndex(
                name: "UQ__EMPLOYEE__C9C4D897E532BEDB",
                table: "EMPLOYEE",
                column: "nationalNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BUSINESS_USER");

            migrationBuilder.DropTable(
                name: "EMPLOYEE");

            migrationBuilder.DropTable(
                name: "DEPARTMENT");
        }
    }
}
