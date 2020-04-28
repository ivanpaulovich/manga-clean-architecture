﻿// <copyright file="20191124223925_Users.cs" company="Ivan Paulovich">
// Copyright © Ivan Paulovich. All rights reserved.
// </copyright>

namespace Infrastructure.DataAccess.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ExternalUserId",
                "Customer");

            migrationBuilder.CreateTable(
                "User",
                table => new {ExternalUserId = table.Column<string>(), CustomerId = table.Column<Guid>()},
                constraints: table => { table.PrimaryKey("PK_User", x => new {x.ExternalUserId, x.CustomerId}); });

            migrationBuilder.UpdateData(
                "Credit",
                "Id",
                new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                "TransactionDate",
                new DateTime(2019, 11, 24, 22, 39, 24, 636, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                "Debit",
                "Id",
                new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                "TransactionDate",
                new DateTime(2019, 11, 24, 22, 39, 24, 636, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.InsertData(
                "User",
                new[] {"ExternalUserId", "CustomerId"},
                new object[] {"github/ivanpaulovich", new Guid("197d0438-e04b-453d-b5de-eca05960c6ae")});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "User");

            migrationBuilder.AddColumn<string>(
                "ExternalUserId",
                "Customer",
                "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                "Credit",
                "Id",
                new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                "TransactionDate",
                new DateTime(2019, 11, 16, 22, 15, 10, 176, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                "Customer",
                "Id",
                new Guid("197d0438-e04b-453d-b5de-eca05960c6ae"),
                "ExternalUserId",
                "42");

            migrationBuilder.UpdateData(
                "Debit",
                "Id",
                new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                "TransactionDate",
                new DateTime(2019, 11, 16, 22, 15, 10, 176, DateTimeKind.Utc).AddTicks(5200));
        }
    }
}
