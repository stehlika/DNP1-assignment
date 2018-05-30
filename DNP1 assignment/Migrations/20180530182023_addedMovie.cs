using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DNP1assignment.Migrations
{
    public partial class addedMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MinimalAge",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");

            migrationBuilder.AddColumn<bool>(
                name: "Adult",
                table: "Movies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Poster_path",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Release_date",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adult",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Poster_path",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Release_date",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinimalAge",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Movies",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
