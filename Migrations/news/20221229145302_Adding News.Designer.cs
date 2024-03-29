﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAssignment.Context;

#nullable disable

namespace WebAssignment.Migrations.news
{
    [DbContext(typeof(newsContext))]
    [Migration("20221229145302_Adding News")]
    partial class AddingNews
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAssignment.Models.news", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("news_category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("news_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("news_img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("news_text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("news");
                });
#pragma warning restore 612, 618
        }
    }
}
