﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using moment4musicAPI.Data;

#nullable disable

namespace moment4musicAPI.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20230217124626_Modelchange")]
    partial class Modelchange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("moment4musicAPI.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("moment4musicAPI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("moment4musicAPI.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrackId"));

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrackLength")
                        .HasColumnType("int");

                    b.HasKey("TrackId");

                    b.HasIndex("AlbumId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("moment4musicAPI.Models.Track", b =>
                {
                    b.HasOne("moment4musicAPI.Models.Album", "Album")
                        .WithMany("Track")
                        .HasForeignKey("AlbumId");

                    b.HasOne("moment4musicAPI.Models.Category", "Category")
                        .WithMany("Track")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Album");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("moment4musicAPI.Models.Album", b =>
                {
                    b.Navigation("Track");
                });

            modelBuilder.Entity("moment4musicAPI.Models.Category", b =>
                {
                    b.Navigation("Track");
                });
#pragma warning restore 612, 618
        }
    }
}
