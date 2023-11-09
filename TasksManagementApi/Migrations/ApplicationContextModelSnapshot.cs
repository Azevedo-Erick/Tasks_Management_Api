﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TasksManagementApi.Data;

#nullable disable

namespace TasksManagementApi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TasksManagementApi.Models.SubTask", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20) unsigned")
                        .HasColumnName("id");

                    b.Property<DateTime>("DeadLine")
                        .HasMaxLength(255)
                        .HasColumnType("datetime(6)")
                        .HasColumnName("dead_line");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasMaxLength(255)
                        .HasColumnType("int")
                        .HasColumnName("priority");

                    b.Property<DateTime>("StartDate")
                        .HasMaxLength(255)
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_date");

                    b.Property<int>("Status")
                        .HasMaxLength(255)
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<ulong>("TaskId")
                        .HasColumnType("bigint(20) unsigned");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("sub_tasks", (string)null);
                });

            modelBuilder.Entity("TasksManagementApi.Models.Task", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20) unsigned")
                        .HasColumnName("id");

                    b.Property<DateTime>("DeadLine")
                        .HasMaxLength(255)
                        .HasColumnType("datetime(6)")
                        .HasColumnName("dead_line");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasMaxLength(255)
                        .HasColumnType("int")
                        .HasColumnName("priority");

                    b.Property<DateTime>("StartDate")
                        .HasMaxLength(255)
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_date");

                    b.Property<int>("Status")
                        .HasMaxLength(255)
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("tasks", (string)null);
                });

            modelBuilder.Entity("TasksManagementApi.Models.User", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20) unsigned")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password_hash");

                    b.Property<string>("ProfilePictureFileName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("profile_picture_file_name");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("TasksManagementApi.Models.SubTask", b =>
                {
                    b.HasOne("TasksManagementApi.Models.Task", "Task")
                        .WithMany("SubTasks")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TasksManagementApi.Models.Task", b =>
                {
                    b.Navigation("SubTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
