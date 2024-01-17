﻿// <auto-generated />
using System;
using BookServiceAPICodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookServiceAPICodeFirst.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240117071925_Mig1")]
    partial class Mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookServiceAPICodeFirst.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("Lang")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("date");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
