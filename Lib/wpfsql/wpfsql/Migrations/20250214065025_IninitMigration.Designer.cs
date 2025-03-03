﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wpfsql.Models;

#nullable disable

namespace wpfsql.Migrations
{
    [DbContext(typeof(hoadonContext))]
    [Migration("20250214065025_IninitMigration")]
    partial class IninitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("wpfsql.Models.Chitiethoadon", b =>
                {
                    b.Property<string>("Sohd")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("sohd");

                    b.Property<string>("Mahang")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("mahang");

                    b.Property<double?>("Dongia")
                        .HasColumnType("float")
                        .HasColumnName("dongia");

                    b.Property<int?>("Soluong")
                        .HasColumnType("int")
                        .HasColumnName("soluong");

                    b.HasKey("Sohd", "Mahang");

                    b.HasIndex("Mahang");

                    b.ToTable("chitiethoadon", (string)null);
                });

            modelBuilder.Entity("wpfsql.Models.Hanghoa", b =>
                {
                    b.Property<string>("Mahang")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("mahang");

                    b.Property<double?>("Dongia")
                        .HasColumnType("float")
                        .HasColumnName("dongia");

                    b.Property<string>("Dvt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("dvt");

                    b.Property<string>("Tenhang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenhang");

                    b.HasKey("Mahang");

                    b.ToTable("hanghoa", (string)null);
                });

            modelBuilder.Entity("wpfsql.Models.Hoadon", b =>
                {
                    b.Property<string>("Sohd")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("sohd");

                    b.Property<DateTime?>("Ngaylaphd")
                        .HasColumnType("datetime")
                        .HasColumnName("ngaylaphd");

                    b.Property<string>("Tenkh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenkh");

                    b.HasKey("Sohd");

                    b.ToTable("hoadon", (string)null);
                });

            modelBuilder.Entity("wpfsql.Models.Chitiethoadon", b =>
                {
                    b.HasOne("wpfsql.Models.Hanghoa", "MahangNavigation")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("Mahang")
                        .IsRequired()
                        .HasConstraintName("FK_chitiethoadon_hanghoa");

                    b.HasOne("wpfsql.Models.Hoadon", "SohdNavigation")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("Sohd")
                        .IsRequired()
                        .HasConstraintName("FK_chitiethoadon_hoadon");

                    b.Navigation("MahangNavigation");

                    b.Navigation("SohdNavigation");
                });

            modelBuilder.Entity("wpfsql.Models.Hanghoa", b =>
                {
                    b.Navigation("Chitiethoadons");
                });

            modelBuilder.Entity("wpfsql.Models.Hoadon", b =>
                {
                    b.Navigation("Chitiethoadons");
                });
#pragma warning restore 612, 618
        }
    }
}
