﻿// <auto-generated />
using BookServiceAPIUsingCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookServiceAPIUsingCodeFirst.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookServiceAPIUsingCodeFirst.Entities.Book", b =>
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

                    b.Property<int>("ReleaseDate")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.ToTable("Tbl_Book");
                });
#pragma warning restore 612, 618
        }
    }
}
