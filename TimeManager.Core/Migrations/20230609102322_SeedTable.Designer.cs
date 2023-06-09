﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeManager.Core.Context;

#nullable disable

namespace TimeManager.Core.Migrations
{
    [DbContext(typeof(TimeManagerContext))]
    [Migration("20230609102322_SeedTable")]
    partial class SeedTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TimeManager.Core.Entity.RegularTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastExecuted")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RegularTasks");
                });

            modelBuilder.Entity("TimeManager.Core.Entity.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReportDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TaskTime")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("TimeManager.Core.Entity.TaskCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskCategory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2a390f1d-bc5f-43c0-8721-128a5eb7f698"),
                            CategoryName = "Спорт"
                        },
                        new
                        {
                            Id = new Guid("bfffda6f-3c8a-42eb-b9f6-2a4a88ba270b"),
                            CategoryName = "Навчання"
                        },
                        new
                        {
                            Id = new Guid("f5cb35ee-9d54-4561-9b28-809a7622c8a1"),
                            CategoryName = "Робота"
                        },
                        new
                        {
                            Id = new Guid("34b9ed71-a155-442e-84eb-0c089833c98a"),
                            CategoryName = "Домашні обов'язки"
                        },
                        new
                        {
                            Id = new Guid("186551bf-3433-4e4e-b742-f2616c985fdd"),
                            CategoryName = "Дозвілля"
                        });
                });

            modelBuilder.Entity("TimeManager.Core.Entity.Tasks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ReportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TaskCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TaskStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReportId");

                    b.HasIndex("TaskCategoryId");

                    b.HasIndex("TaskStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TimeManager.Core.Entity.TasksStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StasusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskStatus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("794dcf3b-0cc4-4a51-96b2-01081e44530c"),
                            StasusName = "Не розпочато"
                        },
                        new
                        {
                            Id = new Guid("9862c6fc-ff7d-4430-96a3-6bb6acddb61d"),
                            StasusName = "В процесі"
                        },
                        new
                        {
                            Id = new Guid("2cb67cd6-dcf3-4735-aa91-b9a9cbaa8b00"),
                            StasusName = "Виконано"
                        });
                });

            modelBuilder.Entity("TimeManager.Core.Entity.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReportId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TimeManager.Core.Entity.RegularTask", b =>
                {
                    b.HasOne("TimeManager.Core.Entity.Users", "User")
                        .WithMany("RegularTasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TimeManager.Core.Entity.Tasks", b =>
                {
                    b.HasOne("TimeManager.Core.Entity.Report", null)
                        .WithMany("Task")
                        .HasForeignKey("ReportId");

                    b.HasOne("TimeManager.Core.Entity.TaskCategory", "TaskCategory")
                        .WithMany()
                        .HasForeignKey("TaskCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeManager.Core.Entity.TasksStatus", "TaskStatus")
                        .WithMany()
                        .HasForeignKey("TaskStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeManager.Core.Entity.Users", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaskCategory");

                    b.Navigation("TaskStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TimeManager.Core.Entity.Users", b =>
                {
                    b.HasOne("TimeManager.Core.Entity.Report", null)
                        .WithMany("User")
                        .HasForeignKey("ReportId");
                });

            modelBuilder.Entity("TimeManager.Core.Entity.Report", b =>
                {
                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TimeManager.Core.Entity.Users", b =>
                {
                    b.Navigation("RegularTasks");

                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
