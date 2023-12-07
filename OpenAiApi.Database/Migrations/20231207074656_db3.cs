using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenAiApi.Database.Migrations
{
    /// <inheritdoc />
    public partial class db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "assistant_message",
                table: "tb_telegram_user_messages",
                type: "character varying(4096)",
                maxLength: 4096,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 12, 7, 12, 46, 55, 984, DateTimeKind.Local).AddTicks(9140));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "assistant_message",
                table: "tb_telegram_user_messages",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(4096)",
                oldMaxLength: 4096,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 12, 1, 14, 30, 44, 481, DateTimeKind.Local).AddTicks(3088));
        }
    }
}
