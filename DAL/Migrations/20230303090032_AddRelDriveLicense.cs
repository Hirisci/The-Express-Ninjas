﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddRelDriveLicense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "DriverLicenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicenses_DriverId",
                table: "DriverLicenses",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLicenses_Drivers_DriverId",
                table: "DriverLicenses",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverLicenses_Drivers_DriverId",
                table: "DriverLicenses");

            migrationBuilder.DropIndex(
                name: "IX_DriverLicenses_DriverId",
                table: "DriverLicenses");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "DriverLicenses");
        }
    }
}
