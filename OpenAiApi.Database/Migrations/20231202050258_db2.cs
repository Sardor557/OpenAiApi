using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenAiApi.Database.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "assistant_message",
                table: "tb_telegram_user_messages",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 12, 2, 10, 2, 58, 386, DateTimeKind.Local).AddTicks(5318));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "assistant_message",
                table: "tb_telegram_user_messages");

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 11, 11, 20, 38, 34, 499, DateTimeKind.Local).AddTicks(4214));
        }
    }
}
