﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OzelDers.Data.Concrete.EfCore.Context;

#nullable disable

namespace OzelDers.Data.Migrations
{
    [DbContext(typeof(OzelDersContext))]
    partial class OzelDersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "student",
                            RoleId = "0bb67308-1aa8-475e-9df8-21950a9313d1"
                        },
                        new
                        {
                            UserId = "teacher1",
                            RoleId = "f1e2aa5a-d987-4c2b-a43b-218897c45ed6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Branches", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Matematik",
                            Url = "matematik"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kimya",
                            Url = "kimya"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fizik",
                            Url = "fizik"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Biyoloji",
                            Url = "biyoloji"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tarih",
                            Url = "tarih"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Edebiyat",
                            Url = "edebiyat"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Almanca",
                            Url = "almanca"
                        },
                        new
                        {
                            Id = 8,
                            Name = "İngilizce",
                            Url = "ingilizce"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Coğrafya",
                            Url = "cografya"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Identity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "cf8d07b6-40ff-40c4-bd85-fe8b59860ef4",
                            Description = "Admin rolü",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "0bb67308-1aa8-475e-9df8-21950a9313d1",
                            Description = "Student rolü",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "f1e2aa5a-d987-4c2b-a43b-218897c45ed6",
                            Description = "Teacher rolü",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "student",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "527ee357-2dd4-4111-aab6-ba3af0a5bb0b",
                            Email = "student@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "66f50b2c-8395-4b55-b581-ceac7340ffa2",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "teacher1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1e0d63c9-e34c-492b-b0b8-3769c7c61450",
                            Email = "teacher@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d74862c5-ef1b-4fbf-b932-b14e25cb777f",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "teacher2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "071bb2d1-353d-44fb-b433-63829c208c20",
                            Email = "teacher1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "23808c52-9d44-4a0d-ad21-053d69ced712",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "teacher3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bd3d3dca-8696-4d2d-a4e2-a37683cf0a95",
                            Email = "teacher2@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9da910a-e7de-4f5a-ac71-d359e7b35922",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Ali",
                            Gender = "Erkek",
                            ImageUrl = "1.png",
                            LastName = "Kazancı",
                            Location = "İstanbul",
                            Url = "ali-kazanci",
                            UserId = "student"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int?>("BranchId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("PricePerHour")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Teachers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Matematik Öğretmeni",
                            FirstName = "Mert",
                            Gender = "Erkek",
                            ImageUrl = "1.png",
                            IsHome = true,
                            LastName = "Muslu",
                            Location = "İstanbul",
                            PricePerHour = 400m,
                            Url = "mert-muslu",
                            UserId = "teacher1"
                        },
                        new
                        {
                            Id = 2,
                            About = "Edebiyat Öğretmeni",
                            FirstName = "Hande",
                            Gender = "Kadın",
                            ImageUrl = "2.png",
                            IsHome = true,
                            LastName = "Karakaya",
                            Location = "İstanbul",
                            PricePerHour = 300m,
                            Url = "hande-karakaya",
                            UserId = "teacher2"
                        },
                        new
                        {
                            Id = 3,
                            About = "Almanca Öğretmeni",
                            FirstName = "Harun",
                            Gender = "Erkek",
                            ImageUrl = "3.png",
                            IsHome = true,
                            LastName = "Kara",
                            Location = "İstanbul",
                            PricePerHour = 300m,
                            Url = "harun-kara",
                            UserId = "teacher3"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.TeacherBranch", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BranchId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeacherId", "BranchId");

                    b.HasIndex("BranchId");

                    b.ToTable("TeacherBranches", (string)null);

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            BranchId = 1
                        },
                        new
                        {
                            TeacherId = 1,
                            BranchId = 2
                        },
                        new
                        {
                            TeacherId = 1,
                            BranchId = 3
                        },
                        new
                        {
                            TeacherId = 2,
                            BranchId = 4
                        },
                        new
                        {
                            TeacherId = 2,
                            BranchId = 5
                        },
                        new
                        {
                            TeacherId = 2,
                            BranchId = 6
                        },
                        new
                        {
                            TeacherId = 3,
                            BranchId = 7
                        },
                        new
                        {
                            TeacherId = 3,
                            BranchId = 8
                        },
                        new
                        {
                            TeacherId = 3,
                            BranchId = 9
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OzelDers.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Student", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Identity.User", "User")
                        .WithOne("Students")
                        .HasForeignKey("OzelDers.Entity.Concrete.Student", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Teacher", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Branch", null)
                        .WithMany("Teachers")
                        .HasForeignKey("BranchId");

                    b.HasOne("OzelDers.Entity.Concrete.Identity.User", "User")
                        .WithOne("Teachers")
                        .HasForeignKey("OzelDers.Entity.Concrete.Teacher", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.TeacherBranch", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Branch", "Branch")
                        .WithMany("TeacherBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OzelDers.Entity.Concrete.Teacher", "Teacher")
                        .WithMany("TeacherBranches")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Branch", b =>
                {
                    b.Navigation("TeacherBranches");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Identity.User", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Teacher", b =>
                {
                    b.Navigation("TeacherBranches");
                });
#pragma warning restore 612, 618
        }
    }
}
