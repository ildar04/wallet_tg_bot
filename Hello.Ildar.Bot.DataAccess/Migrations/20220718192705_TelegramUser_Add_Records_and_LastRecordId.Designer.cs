﻿// <auto-generated />
using System;
using Hello.Ildar.Bot.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hello.Ildar.Bot.DataAccess.Migrations
{
    [DbContext(typeof(BotDbContext))]
    [Migration("20220718192705_TelegramUser_Add_Records_and_LastRecordId")]
    partial class TelegramUser_Add_Records_and_LastRecordId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hello.Ildar.Bot.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Hello.Ildar.Bot.Domain.Entities.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("TelegramUserId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TelegramUserId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("Hello.Ildar.Bot.Domain.Entities.TelegramUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<int>("ChatType")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int?>("LastRecordId")
                        .HasColumnType("integer");

                    b.Property<string>("SerializedDataJson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hello.Ildar.Bot.Domain.Entities.Record", b =>
                {
                    b.HasOne("Hello.Ildar.Bot.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hello.Ildar.Bot.Domain.Entities.TelegramUser", "TelegramUser")
                        .WithMany("Records")
                        .HasForeignKey("TelegramUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("TelegramUser");
                });

            modelBuilder.Entity("Hello.Ildar.Bot.Domain.Entities.TelegramUser", b =>
                {
                    b.Navigation("Records");
                });
#pragma warning restore 612, 618
        }
    }
}
