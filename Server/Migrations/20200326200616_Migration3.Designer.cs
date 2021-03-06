﻿// <auto-generated />
using System;
using ClientApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClientApp.Server.Migrations
{
    [DbContext(typeof(KidConDbContext))]
    [Migration("20200326200616_Migration3")]
    partial class Migration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("ClientApp.Shared.Models.Account", b =>
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

            modelBuilder.Entity("ClientApp.Shared.Models.Alternative", b =>
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

            modelBuilder.Entity("ClientApp.Shared.Models.Classification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Classifications");
                });

            modelBuilder.Entity("ClientApp.Shared.Models.Name", b =>
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

            modelBuilder.Entity("ClientApp.Shared.Models.User", b =>
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

            modelBuilder.Entity("ClientApp.Shared.Models.Account", b =>
                {
                    b.HasOne("ClientApp.Shared.Models.Classification", "Classification")
                        .WithMany()
                        .HasForeignKey("ClassificationId");
                });

            modelBuilder.Entity("ClientApp.Shared.Models.Alternative", b =>
                {
                    b.HasOne("ClientApp.Shared.Models.Account", "Account")
                        .WithMany("Alternatives")
                        .HasForeignKey("AccountId");
                });
#pragma warning restore 612, 618
        }
    }
}
