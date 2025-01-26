﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheClubGymproject.Model;

#nullable disable

namespace TheClubGymproject.Migrations
{
    [DbContext(typeof(TheclubGymcontext))]
    [Migration("20250120095112_sadd")]
    partial class sadd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TheClubGymproject.Model.classes", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Classname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Classtime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trainersID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("trainersID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("TheClubGymproject.Model.members", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MembershipEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MembershipStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("couch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("TheClubGymproject.Model.payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("membersID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("membersID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("TheClubGymproject.Model.trainers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialaiztion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phonenumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("trainers");
                });

            modelBuilder.Entity("classesmembers", b =>
                {
                    b.Property<string>("classesID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("membersID")
                        .HasColumnType("int");

                    b.HasKey("classesID", "membersID");

                    b.HasIndex("membersID");

                    b.ToTable("classesmembers");
                });

            modelBuilder.Entity("TheClubGymproject.Model.classes", b =>
                {
                    b.HasOne("TheClubGymproject.Model.trainers", "trainers")
                        .WithMany("classes")
                        .HasForeignKey("trainersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("trainers");
                });

            modelBuilder.Entity("TheClubGymproject.Model.payment", b =>
                {
                    b.HasOne("TheClubGymproject.Model.members", "members")
                        .WithMany("payments")
                        .HasForeignKey("membersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("members");
                });

            modelBuilder.Entity("classesmembers", b =>
                {
                    b.HasOne("TheClubGymproject.Model.classes", null)
                        .WithMany()
                        .HasForeignKey("classesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheClubGymproject.Model.members", null)
                        .WithMany()
                        .HasForeignKey("membersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TheClubGymproject.Model.members", b =>
                {
                    b.Navigation("payments");
                });

            modelBuilder.Entity("TheClubGymproject.Model.trainers", b =>
                {
                    b.Navigation("classes");
                });
#pragma warning restore 612, 618
        }
    }
}
