﻿// <auto-generated />
using AdvanceEFandUsingRealtionship.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AdvanceEFandUsingRealtionship.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180520121808_BookIsbnIndex")]
    partial class BookIsbnIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvanceEFandUsingRealtionship.Models.Author", b =>
                {
                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("DoB");

                    b.Property<string>("Nationality");

                    b.HasKey("FirstName", "LastName");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("AdvanceEFandUsingRealtionship.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Isbn")
                        .HasMaxLength(10);

                    b.Property<string>("Title")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("Isbn")
                        .IsUnique()
                        .HasName("IsbnIndex")
                        .HasFilter("[Isbn] IS NOT NULL");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
