﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAssignment.Context;

#nullable disable

namespace WebAssignment.Migrations
{
    [DbContext(typeof(moviesContext))]
    partial class moviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAssignment.Models.movies", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"));

                    b.Property<string>("actor1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor1_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor1img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor2_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor2img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor3_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor3img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor4_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor4img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor5_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actor5img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bigmovimg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("duration")
                        .HasColumnType("int");

                    b.Property<double?>("imdb")
                        .HasColumnType("float");

                    b.Property<bool?>("isOut")
                        .HasColumnType("bit");

                    b.Property<bool?>("ispopular")
                        .HasColumnType("bit");

                    b.Property<string>("lilmovimg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trailerLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("movies");
                });
#pragma warning restore 612, 618
        }
    }
}
