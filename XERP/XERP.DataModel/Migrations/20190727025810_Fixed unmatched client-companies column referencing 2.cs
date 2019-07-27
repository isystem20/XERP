using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XERP.DataModel.Migrations
{
    public partial class Fixedunmatchedclientcompaniescolumnreferencing2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Employees_TempId",
                table: "Employees");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Clients_TempId",
                table: "Clients");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ClientCompanies_TempId",
                table: "ClientCompanies");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "ClientCompanies");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "ClientCompanies",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(Guid));

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

            migrationBuilder.AddColumn<string>(
                name: "TempId",
                table: "Employees",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TempId",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "ClientCompanies",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AddColumn<string>(
                name: "TempId",
                table: "ClientCompanies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Employees_TempId",
                table: "Employees",
                column: "TempId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Clients_TempId",
                table: "Clients",
                column: "TempId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ClientCompanies_TempId",
                table: "ClientCompanies",
                column: "TempId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Clients_ClientId",
                table: "AspNetUsers",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ClientCompanies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "ClientCompanies",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Employees_EmployeeId",
                table: "AspNetUsers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
