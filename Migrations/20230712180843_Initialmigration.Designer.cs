﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace loginapi.Migrations
{
    [DbContext(typeof(modelContext))]
    [Migration("20230712180843_Initialmigration")]
    partial class Initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id_user")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_user");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<string>("user_handle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("user_handle");

                    b.HasKey("Id_user");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("VerificationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Verified")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("id_user")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("id_user");

                    b.ToTable("VerificationUsers", (string)null);
                });

            modelBuilder.Entity("VerificationUser", b =>
                {
                    b.HasOne("User", "UserId")
                        .WithMany()
                        .HasForeignKey("id_user");

                    b.Navigation("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
