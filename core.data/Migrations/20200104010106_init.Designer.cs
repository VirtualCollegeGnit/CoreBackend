﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using core.data;

namespace core.data.Migrations
{
    [DbContext(typeof(VirtualCollegeContext))]
    [Migration("20200104010106_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("core.data.Model.Address.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("text");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("text");

                    b.Property<int?>("PinCodeID")
                        .HasColumnType("integer");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("ID");

                    b.HasIndex("PinCodeID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("core.data.Model.Address.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DistrictID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("DistrictID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("core.data.Model.Address.District", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("StateID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("StateID");

                    b.ToTable("District");
                });

            modelBuilder.Entity("core.data.Model.Address.PinCode", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CityID")
                        .HasColumnType("integer");

                    b.Property<int>("Pincode")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("PinCode");
                });

            modelBuilder.Entity("core.data.Model.Address.State", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("State");
                });

            modelBuilder.Entity("core.data.Model.Member.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("MemberID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MemberID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("core.data.Model.Member.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Semester")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("core.data.Model.Member.Document", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AcceptedById")
                        .HasColumnType("integer");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMedia")
                        .HasColumnType("boolean");

                    b.Property<int?>("MemberID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("AcceptedById");

                    b.HasIndex("MemberID");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("core.data.Model.Member.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateOfLeaving")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.HasKey("ID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("core.data.Model.Member.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Name")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Section");
                });

            modelBuilder.Entity("core.data.Model.Member.SemesterData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("StudentDataId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StudentDataId");

                    b.ToTable("SemesterData");
                });

            modelBuilder.Entity("core.data.Model.Member.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("MemberID")
                        .HasColumnType("integer");

                    b.Property<int?>("SectionId")
                        .HasColumnType("integer");

                    b.Property<int?>("StudentDataId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MemberID");

                    b.HasIndex("SectionId");

                    b.HasIndex("StudentDataId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("core.data.Model.Member.StudentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int?>("SectionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("SectionId");

                    b.ToTable("StudentData");
                });

            modelBuilder.Entity("core.data.Model.Person.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AddressID")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("core.data.Model.Person.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int?>("MemberId")
                        .HasColumnType("integer");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<int?>("PinCodeID")
                        .HasColumnType("integer");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.Property<int?>("StateID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.HasIndex("PinCodeID");

                    b.HasIndex("StateID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("core.data.Model.Person.Relative", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ContactID")
                        .HasColumnType("integer");

                    b.Property<int?>("PersonID")
                        .HasColumnType("integer");

                    b.Property<int>("Relation")
                        .HasColumnType("integer");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.HasIndex("PersonID");

                    b.ToTable("Relative");
                });

            modelBuilder.Entity("core.data.Model.Person.Remark", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("GivenByID")
                        .HasColumnType("integer");

                    b.Property<int?>("PersonID")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("ID");

                    b.HasIndex("GivenByID");

                    b.HasIndex("PersonID");

                    b.ToTable("Remark");
                });

            modelBuilder.Entity("core.data.Model.Address.Address", b =>
                {
                    b.HasOne("core.data.Model.Address.PinCode", "PinCode")
                        .WithMany()
                        .HasForeignKey("PinCodeID");
                });

            modelBuilder.Entity("core.data.Model.Address.City", b =>
                {
                    b.HasOne("core.data.Model.Address.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictID");
                });

            modelBuilder.Entity("core.data.Model.Address.District", b =>
                {
                    b.HasOne("core.data.Model.Address.State", "State")
                        .WithMany()
                        .HasForeignKey("StateID");
                });

            modelBuilder.Entity("core.data.Model.Address.PinCode", b =>
                {
                    b.HasOne("core.data.Model.Address.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");
                });

            modelBuilder.Entity("core.data.Model.Member.Admin", b =>
                {
                    b.HasOne("core.data.Model.Member.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID");
                });

            modelBuilder.Entity("core.data.Model.Member.Document", b =>
                {
                    b.HasOne("core.data.Model.Member.Admin", "AcceptedBy")
                        .WithMany()
                        .HasForeignKey("AcceptedById");

                    b.HasOne("core.data.Model.Member.Member", "Member")
                        .WithMany("Documents")
                        .HasForeignKey("MemberID");
                });

            modelBuilder.Entity("core.data.Model.Member.SemesterData", b =>
                {
                    b.HasOne("core.data.Model.Member.StudentData", null)
                        .WithMany("SemestersData")
                        .HasForeignKey("StudentDataId");
                });

            modelBuilder.Entity("core.data.Model.Member.Student", b =>
                {
                    b.HasOne("core.data.Model.Member.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID");

                    b.HasOne("core.data.Model.Member.Section", null)
                        .WithMany("Students")
                        .HasForeignKey("SectionId");

                    b.HasOne("core.data.Model.Member.StudentData", "StudentData")
                        .WithMany()
                        .HasForeignKey("StudentDataId");
                });

            modelBuilder.Entity("core.data.Model.Member.StudentData", b =>
                {
                    b.HasOne("core.data.Model.Member.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("core.data.Model.Member.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("core.data.Model.Person.Contact", b =>
                {
                    b.HasOne("core.data.Model.Address.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("core.data.Model.Person.Person", "Person")
                        .WithOne("Contact")
                        .HasForeignKey("core.data.Model.Person.Contact", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("core.data.Model.Person.Person", b =>
                {
                    b.HasOne("core.data.Model.Member.Member", "Member")
                        .WithOne("Person")
                        .HasForeignKey("core.data.Model.Person.Person", "MemberId");

                    b.HasOne("core.data.Model.Address.PinCode", null)
                        .WithMany("People")
                        .HasForeignKey("PinCodeID");

                    b.HasOne("core.data.Model.Address.State", null)
                        .WithMany("People")
                        .HasForeignKey("StateID");
                });

            modelBuilder.Entity("core.data.Model.Person.Relative", b =>
                {
                    b.HasOne("core.data.Model.Person.Contact", null)
                        .WithMany("Relatives")
                        .HasForeignKey("ContactID");

                    b.HasOne("core.data.Model.Person.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonID");
                });

            modelBuilder.Entity("core.data.Model.Person.Remark", b =>
                {
                    b.HasOne("core.data.Model.Member.Member", "GivenBy")
                        .WithMany()
                        .HasForeignKey("GivenByID");

                    b.HasOne("core.data.Model.Person.Person", "Person")
                        .WithMany("Remarks")
                        .HasForeignKey("PersonID");
                });
#pragma warning restore 612, 618
        }
    }
}