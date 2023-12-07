﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OpenAiApi.Database;

#nullable disable

namespace OpenAiApi.Database.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231201093044_db2")]
    partial class db2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OpenAiApi.Database.Models.tbAssistantMessage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<string>("Message")
                        .HasMaxLength(10000)
                        .HasColumnType("character varying(10000)")
                        .HasColumnName("message");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<long>("TelegramUserMessage")
                        .HasColumnType("bigint")
                        .HasColumnName("telegram_user_message");

                    b.Property<long?>("TelegramUserMessageIdId")
                        .HasColumnType("bigint")
                        .HasColumnName("telegram_user_message_id_id");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.HasKey("Id")
                        .HasName("pk_tb_assistant_messages");

                    b.HasIndex("TelegramUserMessageIdId")
                        .HasDatabaseName("ix_tb_assistant_messages_telegram_user_message_id_id");

                    b.ToTable("tb_assistant_messages", (string)null);
                });

            modelBuilder.Entity("OpenAiApi.Database.Models.tbTelegramUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<string>("FullName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("full_name");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean")
                        .HasColumnName("is_admin");

                    b.Property<string>("Lang")
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("lang");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<long>("TelegramId")
                        .HasColumnType("bigint")
                        .HasColumnName("telegram_id");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.Property<string>("UserName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_tb_telegram_users");

                    b.HasIndex("TelegramId")
                        .IsUnique()
                        .HasDatabaseName("ix_tb_telegram_users_telegram_id");

                    b.ToTable("tb_telegram_users", (string)null);
                });

            modelBuilder.Entity("OpenAiApi.Database.Models.tbTelegramUserMessage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<string>("Message")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("message");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<int>("TelegramUserId")
                        .HasColumnType("integer")
                        .HasColumnName("telegram_user_id");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.HasKey("Id")
                        .HasName("pk_tb_telegram_user_messages");

                    b.HasIndex("TelegramUserId")
                        .HasDatabaseName("ix_tb_telegram_user_messages_telegram_user_id");

                    b.ToTable("tb_telegram_user_messages", (string)null);
                });

            modelBuilder.Entity("OpenAiApi.Database.Models.tbUser", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("password");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.HasKey("Id")
                        .HasName("pk_tb_users");

                    b.ToTable("tb_users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 12, 1, 14, 30, 44, 481, DateTimeKind.Local).AddTicks(3088),
                            CreateUser = 1,
                            Login = "Admin",
                            Password = "bf6e55cd42d6d5dedfafcdd05ba5d8b8",
                            Status = 1
                        });
                });

            modelBuilder.Entity("OpenAiApi.Database.Models.tbAssistantMessage", b =>
                {
                    b.HasOne("OpenAiApi.Database.Models.tbTelegramUserMessage", "TelegramUserMessageId")
                        .WithMany()
                        .HasForeignKey("TelegramUserMessageIdId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_tb_assistant_messages_tb_telegram_user_messages_telegram_use");

                    b.Navigation("TelegramUserMessageId");
                });

            modelBuilder.Entity("OpenAiApi.Database.Models.tbTelegramUserMessage", b =>
                {
                    b.HasOne("OpenAiApi.Database.Models.tbTelegramUser", "TelegramUser")
                        .WithMany("Messages")
                        .HasForeignKey("TelegramUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_tb_telegram_user_messages_tb_telegram_users_telegram_user_id");

                    b.Navigation("TelegramUser");
                });

            modelBuilder.Entity("OpenAiApi.Database.Models.tbTelegramUser", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
