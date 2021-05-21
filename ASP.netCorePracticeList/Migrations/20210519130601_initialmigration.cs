using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.netCorePracticeList.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientTableData",
                columns: table => new
                {
                    ClientNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Pincode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTableData", x => x.ClientNumber);
                });

            migrationBuilder.CreateTable(
                name: "ClientTaEmployeeDepartmentTableDetailsbleData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: true),
                    Salary = table.Column<long>(nullable: true),
                    Commision = table.Column<long>(nullable: true),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTaEmployeeDepartmentTableDetailsbleData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerEntryTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    Customeraddress = table.Column<string>(nullable: true),
                    CustomerContactNo = table.Column<string>(nullable: true),
                    CustomerCity = table.Column<string>(nullable: true),
                    CustomerCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEntryTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTableDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTableDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(nullable: true),
                    ModelPrice = table.Column<long>(nullable: true),
                    ModelImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTableDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<bool>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTableDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientTableData");

            migrationBuilder.DropTable(
                name: "ClientTaEmployeeDepartmentTableDetailsbleData");

            migrationBuilder.DropTable(
                name: "CustomerEntryTable");

            migrationBuilder.DropTable(
                name: "EmployeeTableDetails");

            migrationBuilder.DropTable(
                name: "MobileDetails");

            migrationBuilder.DropTable(
                name: "UserTableDetails");
        }
    }
}
