﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hqh.project.EntityFrameCore.DbMigration.Migrations
{
    public partial class addUser20200422002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "t_user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "t_user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "t_user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "t_user",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "t_user",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "t_user",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "t_user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "t_user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "t_user",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "t_user",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
