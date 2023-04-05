﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission14_aaronp5.Models;

#nullable disable

namespace Mission14_aaronp5.Migrations
{
    [DbContext(typeof(JoelHiltonMovieCollectionContext))]
    [Migration("20230404191147_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("Mission14_aaronp5.Models.Movie", b =>
                {
                    b.Property<byte[]>("MovieId")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Category")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Director")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Edited")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("LentTo")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Notes")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Rating")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Title")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Year")
                        .HasColumnType("BLOB");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}