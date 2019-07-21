using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XERP.DataModel.Migrations
{
    public partial class UpdatedtheCustomfieldsforIdentityFramework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActivationCode",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedById",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordDate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PasswordNeverExpires",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityHash",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UserCantChangePassword",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UserChangePasswordNextLogon",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VersionNo",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BirthPlace = table.Column<string>(nullable: true),
                    CivilStatus = table.Column<string>(nullable: false),
                    NationalityId = table.Column<int>(nullable: false),
                    CreatedById = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    VersionNo = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Industries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: false),
                    CompanyId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreatedById = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: false),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    VersionNo = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(100)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "varchar(500)", nullable: false),
                    ContactPerson = table.Column<string>(type: "varchar(200)", nullable: false),
                    Designation = table.Column<string>(type: "varchar(100)", nullable: false),
                    IndustryType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedById = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    VersionNo = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    IndustriesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Industries_IndustriesId",
                        column: x => x.IndustriesId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", nullable: false),
                    ClientId = table.Column<string>(type: "varchar(50)", nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(100)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "varchar(500)", nullable: false),
                    ContactPerson = table.Column<string>(type: "varchar(200)", nullable: false),
                    Designation = table.Column<string>(type: "varchar(100)", nullable: false),
                    IndustryType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedById = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    VersionNo = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientCompanies_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClientId",
                table: "AspNetUsers",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeeId",
                table: "AspNetUsers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanies_ClientId",
                table: "ClientCompanies",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_IndustriesId",
                table: "Clients",
                column: "IndustriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Clients_ClientId",
                table: "AspNetUsers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ClientCompanies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "ClientCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Employees_EmployeeId",
                table: "AspNetUsers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Clients_ClientId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ClientCompanies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employees_EmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ClientCompanies");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Industries");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClientId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ActivationCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordNeverExpires",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecurityHash",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCantChangePassword",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserChangePasswordNextLogon",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VersionNo",
                table: "AspNetUsers");
        }
    }
}
