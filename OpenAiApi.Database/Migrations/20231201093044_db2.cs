using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OpenAiApi.Database.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_assistant_messages",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    telegram_user_message = table.Column<long>(type: "bigint", nullable: false),
                    telegram_user_message_id_id = table.Column<long>(type: "bigint", nullable: true),
                    message = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<int>(type: "integer", nullable: false),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_user = table.Column<int>(type: "integer", nullable: true),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_assistant_messages", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_assistant_messages_tb_telegram_user_messages_telegram_use",
                        column: x => x.telegram_user_message_id_id,
                        principalTable: "tb_telegram_user_messages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 12, 1, 14, 30, 44, 481, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.CreateIndex(
                name: "ix_tb_assistant_messages_telegram_user_message_id_id",
                table: "tb_assistant_messages",
                column: "telegram_user_message_id_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_assistant_messages");

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 11, 11, 20, 38, 34, 499, DateTimeKind.Local).AddTicks(4214));
        }
    }
}
