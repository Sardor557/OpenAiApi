using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenAiApi.Database.Migrations
{
    /// <inheritdoc />
    public partial class db4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tb_assistant_messages_tb_telegram_user_messages_telegram_use",
                table: "tb_assistant_messages");

            migrationBuilder.DropIndex(
                name: "ix_tb_assistant_messages_telegram_user_message_id_id",
                table: "tb_assistant_messages");

            migrationBuilder.DropColumn(
                name: "telegram_user_message_id_id",
                table: "tb_assistant_messages");

            migrationBuilder.RenameColumn(
                name: "telegram_user_message",
                table: "tb_assistant_messages",
                newName: "telegram_user_message_id");

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 12, 7, 12, 51, 5, 125, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.CreateIndex(
                name: "ix_tb_assistant_messages_telegram_user_message_id",
                table: "tb_assistant_messages",
                column: "telegram_user_message_id");

            migrationBuilder.AddForeignKey(
                name: "fk_tb_assistant_messages_tb_telegram_user_messages_telegram_us",
                table: "tb_assistant_messages",
                column: "telegram_user_message_id",
                principalTable: "tb_telegram_user_messages",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tb_assistant_messages_tb_telegram_user_messages_telegram_us",
                table: "tb_assistant_messages");

            migrationBuilder.DropIndex(
                name: "ix_tb_assistant_messages_telegram_user_message_id",
                table: "tb_assistant_messages");

            migrationBuilder.RenameColumn(
                name: "telegram_user_message_id",
                table: "tb_assistant_messages",
                newName: "telegram_user_message");

            migrationBuilder.AddColumn<long>(
                name: "telegram_user_message_id_id",
                table: "tb_assistant_messages",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 12, 7, 12, 46, 55, 984, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.CreateIndex(
                name: "ix_tb_assistant_messages_telegram_user_message_id_id",
                table: "tb_assistant_messages",
                column: "telegram_user_message_id_id");

            migrationBuilder.AddForeignKey(
                name: "fk_tb_assistant_messages_tb_telegram_user_messages_telegram_use",
                table: "tb_assistant_messages",
                column: "telegram_user_message_id_id",
                principalTable: "tb_telegram_user_messages",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
