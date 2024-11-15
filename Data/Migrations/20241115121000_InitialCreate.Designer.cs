﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(RemoteDatabaseContext))]
    [Migration("20241115121000_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.DAO.Groups", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Data.DAO.GroupsSubjects", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int?>("GroupID")
                        .HasColumnType("integer");

                    b.Property<int>("Semester")
                        .HasColumnType("integer");

                    b.Property<int?>("SubjectID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.HasIndex("SubjectID");

                    b.ToTable("GroupsSubjects");
                });

            modelBuilder.Entity("Data.DAO.Presence", b =>
                {
                    b.Property<int>("LessonNumber")
                        .HasColumnType("integer");

                    b.Property<int>("GroupSubjectID")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("StatusID")
                        .HasColumnType("integer");

                    b.Property<int>("StudentID")
                        .HasColumnType("integer");

                    b.HasKey("LessonNumber", "GroupSubjectID");

                    b.HasIndex("GroupSubjectID");

                    b.HasIndex("StatusID");

                    b.HasIndex("StudentID");

                    b.ToTable("Presence");
                });

            modelBuilder.Entity("Data.DAO.Statuses", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("Data.DAO.Students", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("GroupID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Data.DAO.Subjects", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Data.DAO.GroupsSubjects", b =>
                {
                    b.HasOne("Data.DAO.Groups", "Group")
                        .WithMany()
                        .HasForeignKey("GroupID");

                    b.HasOne("Data.DAO.Subjects", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID");

                    b.Navigation("Group");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Data.DAO.Presence", b =>
                {
                    b.HasOne("Data.DAO.GroupsSubjects", "GroupSubject")
                        .WithMany()
                        .HasForeignKey("GroupSubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DAO.Statuses", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DAO.Students", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupSubject");

                    b.Navigation("Status");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data.DAO.Students", b =>
                {
                    b.HasOne("Data.DAO.Groups", "Group")
                        .WithMany()
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
