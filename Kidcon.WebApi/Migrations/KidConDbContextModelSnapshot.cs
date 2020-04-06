﻿// <auto-generated />
using System;
using Kidcon.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kidcon.WebApi.Migrations
{
    [DbContext(typeof(KidConDbContext))]
    partial class KidConDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Kidcon.Shared.Models.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ClassificationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IncreasingSide")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClassificationId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Kidcon.Shared.Models.Alternative", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlternativeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AlternativePhrase")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Alternatives");
                });

            modelBuilder.Entity("Kidcon.Shared.Models.Classification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Classifications");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Type = "Asset"
                        },
                        new
                        {
                            Id = 2L,
                            Type = "Expense"
                        },
                        new
                        {
                            Id = 3L,
                            Type = "Drawings"
                        },
                        new
                        {
                            Id = 4L,
                            Type = "Capital"
                        },
                        new
                        {
                            Id = 5L,
                            Type = "Income"
                        },
                        new
                        {
                            Id = 6L,
                            Type = "Liability"
                        });
                });

            modelBuilder.Entity("Kidcon.Shared.Models.Name", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Names");
                });

            modelBuilder.Entity("Kidcon.Shared.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Kidcon.Shared.Models.Account", b =>
                {
                    b.HasOne("Kidcon.Shared.Models.Classification", "Classification")
                        .WithMany("Accounts")
                        .HasForeignKey("ClassificationId");
                });

            modelBuilder.Entity("Kidcon.Shared.Models.Alternative", b =>
                {
                    b.HasOne("Kidcon.Shared.Models.Account", "Account")
                        .WithMany("Alternatives")
                        .HasForeignKey("AccountId");
                });
#pragma warning restore 612, 618
        }
    }
}
