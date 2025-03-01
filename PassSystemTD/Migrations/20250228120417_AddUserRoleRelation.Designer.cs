﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PassSystemTD.Data;

#nullable disable

namespace PassSystemTD.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250228120417_AddUserRoleRelation")]
    partial class AddUserRoleRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PassSystemTD.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDean")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsStudent")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsTeacher")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("PassSystemTD.Entities.TokenEntity", b =>
                {
                    b.Property<string>("Token")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Token");

                    b.ToTable("BannedTokens");
                });

            modelBuilder.Entity("PassSystemTD.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PassSystemTD.Entities.Role", b =>
                {
                    b.HasOne("PassSystemTD.Entities.User", "User")
                        .WithOne("Role")
                        .HasForeignKey("PassSystemTD.Entities.Role", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PassSystemTD.Entities.User", b =>
                {
                    b.Navigation("Role")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
