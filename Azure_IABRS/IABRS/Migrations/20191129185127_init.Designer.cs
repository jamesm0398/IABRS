﻿// <auto-generated />
using System;
using IABRS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IABRS.Migrations
{
    [DbContext(typeof(testsForNADContext))]
    [Migration("20191129185127_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IABRS.Models.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("IABRS.Models.AspNetRoles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("IABRS.Models.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("IABRS.Models.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("IABRS.Models.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("IABRS.Models.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IABRS.Models.AspNetUsers", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AspNetUsers");
                });

            modelBuilder.Entity("IABRS.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("BookId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("IABRS.Models.BookCourse", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("CourseId");

                    b.HasKey("BookId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("BookCourse");
                });

            modelBuilder.Entity("IABRS.Models.BookUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<bool?>("BookInCart")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<bool?>("UserOwnsBook")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("bookUsers");
                });

            modelBuilder.Entity("IABRS.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("InstitutionId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("IABRS.Models.CourseUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseUser");
                });

            modelBuilder.Entity("IABRS.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("IABRS.Models.GroupPermission", b =>
                {
                    b.Property<int>("GroupId");

                    b.Property<int>("PermissionId");

                    b.HasKey("GroupId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("GroupPermission");
                });

            modelBuilder.Entity("IABRS.Models.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Institution");
                });

            modelBuilder.Entity("IABRS.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("IABRS.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(50);

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnName("FName")
                        .HasMaxLength(20);

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnName("LName")
                        .HasMaxLength(20);

                    b.Property<string>("Mname")
                        .HasColumnName("MName")
                        .HasMaxLength(10);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("IABRS.Models.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroup");
                });

            modelBuilder.Entity("IABRS.Models.Identity", b =>
                {
                    b.HasBaseType("IABRS.Models.AspNetUsers");

                    b.HasDiscriminator().HasValue("Identity");
                });

            modelBuilder.Entity("IABRS.Models.AspNetRoleClaims", b =>
                {
                    b.HasOne("IABRS.Models.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IABRS.Models.AspNetUserClaims", b =>
                {
                    b.HasOne("IABRS.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IABRS.Models.AspNetUserLogins", b =>
                {
                    b.HasOne("IABRS.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IABRS.Models.AspNetUserRoles", b =>
                {
                    b.HasOne("IABRS.Models.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IABRS.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IABRS.Models.AspNetUserTokens", b =>
                {
                    b.HasOne("IABRS.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IABRS.Models.BookCourse", b =>
                {
                    b.HasOne("IABRS.Models.Book", "Book")
                        .WithMany("BookCourse")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_BookCourse_Book");

                    b.HasOne("IABRS.Models.Course", "Course")
                        .WithMany("BookCourse")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_BookCourse_Course");
                });

            modelBuilder.Entity("IABRS.Models.BookUsers", b =>
                {
                    b.HasOne("IABRS.Models.Book", "Book")
                        .WithMany("BookUsers")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_bookUsers_books_BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IABRS.Models.Identity", "User")
                        .WithMany("BookUsers")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_bookUsers_AspNetUsers");
                });

            modelBuilder.Entity("IABRS.Models.Course", b =>
                {
                    b.HasOne("IABRS.Models.Institution", "Institution")
                        .WithMany("Course")
                        .HasForeignKey("InstitutionId")
                        .HasConstraintName("FK_Course_Institution");
                });

            modelBuilder.Entity("IABRS.Models.CourseUser", b =>
                {
                    b.HasOne("IABRS.Models.Course", "Course")
                        .WithMany("CourseUser")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_CourseUser_Course");

                    b.HasOne("IABRS.Models.Identity", "User")
                        .WithMany("CourseUser")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_CourseUser_AspNetUsers");
                });

            modelBuilder.Entity("IABRS.Models.GroupPermission", b =>
                {
                    b.HasOne("IABRS.Models.Group", "Group")
                        .WithMany("GroupPermission")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_GroupPermission_Group");

                    b.HasOne("IABRS.Models.Permission", "Permission")
                        .WithMany("GroupPermission")
                        .HasForeignKey("PermissionId")
                        .HasConstraintName("FK_GroupPermission_Permission");
                });

            modelBuilder.Entity("IABRS.Models.UserGroup", b =>
                {
                    b.HasOne("IABRS.Models.Group", "Group")
                        .WithMany("UserGroup")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_UserGroup_Group");

                    b.HasOne("IABRS.Models.Identity", "User")
                        .WithMany("UserGroup")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UserGroup_AspNetUsers");
                });
#pragma warning restore 612, 618
        }
    }
}