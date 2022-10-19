﻿// <auto-generated />
using System;
using InternManager.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InternManager.WebUI.Migrations
{
    [DbContext(typeof(InternContext))]
    [Migration("20221017203616_ef Code First database re-created")]
    partial class efCodeFirstdatabaserecreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternManager.Entities.Concrate.Boss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsSuper");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Bosses");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacultyName")
                        .IsRequired();

                    b.Property<int?>("FacultyNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Intern", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RecEnd");

                    b.Property<DateTime>("RecEnd2");

                    b.Property<DateTime>("RecStart");

                    b.Property<DateTime>("RecStart2");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Interns");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Intern1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<byte[]>("DetailDocument");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Info");

                    b.Property<int>("InternId");

                    b.Property<bool>("IsOk");

                    b.Property<int>("KurumId");

                    b.Property<string>("Note");

                    b.Property<string>("OkDays");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Student_Id");

                    b.Property<int>("TotalDays");

                    b.HasKey("Id");

                    b.HasIndex("InternId");

                    b.HasIndex("KurumId");

                    b.HasIndex("Student_Id");

                    b.ToTable("Interns1");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Intern2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<byte[]>("DetailDocument");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Info");

                    b.Property<int>("InternId");

                    b.Property<bool>("IsOk");

                    b.Property<int>("KurumId");

                    b.Property<string>("Note");

                    b.Property<string>("OkDays");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Student_Id");

                    b.Property<int>("TotalDays");

                    b.HasKey("Id");

                    b.HasIndex("InternId");

                    b.HasIndex("KurumId");

                    b.HasIndex("Student_Id");

                    b.ToTable("Interns2");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.ISE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<byte[]>("DetailDocument");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Info");

                    b.Property<int>("InternId");

                    b.Property<bool>("IsOk");

                    b.Property<int>("KurumId");

                    b.Property<string>("Note");

                    b.Property<string>("OkDays");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Student_Id");

                    b.Property<int>("TotalDays");

                    b.HasKey("Id");

                    b.HasIndex("InternId");

                    b.HasIndex("KurumId");

                    b.HasIndex("Student_Id");

                    b.ToTable("Ises");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Kurum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<bool>("DevletKatkisi");

                    b.Property<string>("FaaliyetAlani")
                        .IsRequired();

                    b.Property<string>("Fax");

                    b.Property<string>("FirmaYetkiliAdSoyad")
                        .IsRequired();

                    b.Property<string>("KurumMail");

                    b.Property<string>("PostalCode")
                        .IsRequired();

                    b.Property<string>("ResmiAd")
                        .IsRequired();

                    b.Property<string>("StajSorumlusu")
                        .IsRequired();

                    b.Property<string>("TelNo");

                    b.Property<string>("TelNo2");

                    b.Property<string>("Town")
                        .IsRequired();

                    b.Property<bool>("Unvan");

                    b.HasKey("Id");

                    b.ToTable("Kurums");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Civilization");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("IdentyNumber");

                    b.Property<byte[]>("Image");

                    b.Property<string>("NameSurname");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("City");

                    b.Property<int>("FacultyId");

                    b.Property<bool>("IsFirstPassword");

                    b.Property<int>("PersonId");

                    b.Property<string>("PostalCode");

                    b.Property<string>("StudentMail");

                    b.Property<string>("StudentNumber");

                    b.Property<string>("StudentPassword");

                    b.Property<string>("Town");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("PersonId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyNumber");

                    b.Property<bool>("IsBoos");

                    b.Property<bool>("IsFirstPassword");

                    b.Property<int>("PersonId");

                    b.Property<string>("TeacherMail");

                    b.Property<string>("TeacherNumber");

                    b.Property<string>("TeacherPassword");

                    b.HasKey("Id");

                    b.HasIndex("FacultyNumber");

                    b.HasIndex("PersonId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Boss", b =>
                {
                    b.HasOne("InternManager.Entities.Concrate.Teacher", "TeacherPk")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Intern1", b =>
                {
                    b.HasOne("InternManager.Entities.Concrate.Intern", "InternPk")
                        .WithMany()
                        .HasForeignKey("InternId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternManager.Entities.Concrate.Kurum", "KurumPk")
                        .WithMany()
                        .HasForeignKey("KurumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternManager.Entities.Concrate.Student", "StudentPk")
                        .WithMany()
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Intern2", b =>
                {
                    b.HasOne("InternManager.Entities.Concrate.Intern", "InternPk")
                        .WithMany()
                        .HasForeignKey("InternId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternManager.Entities.Concrate.Kurum", "KurumPk")
                        .WithMany()
                        .HasForeignKey("KurumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternManager.Entities.Concrate.Student", "StudentPk")
                        .WithMany()
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.ISE", b =>
                {
                    b.HasOne("InternManager.Entities.Concrate.Intern", "InternPk")
                        .WithMany()
                        .HasForeignKey("InternId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternManager.Entities.Concrate.Kurum", "KurumPk")
                        .WithMany()
                        .HasForeignKey("KurumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternManager.Entities.Concrate.Student", "StudentPk")
                        .WithMany()
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Student", b =>
                {
                    b.HasOne("InternManager.Entities.Concrate.Faculty", "FacultyPk")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternManager.Entities.Concrate.Person", "PersonPk")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternManager.Entities.Concrate.Teacher", b =>
                {
                    b.HasOne("InternManager.Entities.Concrate.Faculty", "FacultyPk")
                        .WithMany()
                        .HasForeignKey("FacultyNumber")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternManager.Entities.Concrate.Person", "PersonPk")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
