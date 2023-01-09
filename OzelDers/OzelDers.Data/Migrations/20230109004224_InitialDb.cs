using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OzelDers.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<string>(type: "TEXT", nullable: true),
                    About = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Experience = table.Column<string>(type: "TEXT", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    PricePerHour = table.Column<decimal>(type: "TEXT", nullable: true),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    Location = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    PricePerHour = table.Column<decimal>(type: "TEXT", nullable: true),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teachers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81c801d9-79d9-49e1-adcf-89dd9a61ed5f", null, "Admin rolü", "Admin", "ADMIN" },
                    { "8b3671a2-c360-4e7b-9a1f-bd12ba0675a8", null, "Student rolü", "Student", "STUDENT" },
                    { "df2fd075-b997-42c3-8434-9a5c8c96ebba", null, "Teacher rolü", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Matematik", "matematik" },
                    { 2, "Kimya", "kimya" },
                    { 3, "Fizik", "fizik" },
                    { 4, "Biyoloji", "biyoloji" },
                    { 5, "Tarih", "tarih" },
                    { 6, "Edebiyat", "edebiyat" },
                    { 7, "Almanca", "almanca" },
                    { 8, "İngilizce", "ingilizce" },
                    { 9, "Coğrafya", "cografya" },
                    { 10, "Bilgisayar", "bilgisayar" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "Gender", "ImageUrl", "LastName", "Location", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, "Ali", "Erkek", "1.png", "Kazancı", "İstanbul", "ali-kazanci", null },
                    { 2, "Kübra", "Kadın", "2.png", "Doğan", "İstanbul", "kübra-dogan", null },
                    { 3, "İsmet", "Erkek", "3.png", "Demirci", "İzmir", "ismet-demirci", null },
                    { 4, "Melike", "Kadın", "4.png", "Kızar", "Ankara", "melike-demirci", null },
                    { 5, "Osman", "Erkek", "5.png", "Kurtar", "Ankara", "osman-kurtar", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Age", "BranchId", "ConcurrencyStamp", "Email", "EmailConfirmed", "Experience", "FirstName", "Gender", "ImageUrl", "LastName", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "PricePerHour", "SecurityStamp", "TwoFactorEnabled", "Url", "UserName" },
                values: new object[,]
                {
                    { "10a3f450-ad89-4dd4-b0a6-a272fd3a0e30", null, 0, null, 1, "1d020701-ecf7-4422-9c1e-6850432d8c3d", "kübra@gmail.com", true, null, "Kübra", "Kadın", "7.png", "Doğan", "İstanbul", false, null, "KUBRA@GMAIL.COM", "KUBRA", "AQAAAAIAAYagAAAAELujTWhHbZ/FIuuSjE2d9Oqw59zB0kdAyNhhSiWKA/ZuuqaL0IvhI6kYOxAWjnYygw==", null, "3333333333", false, null, "98656c04-3182-4ea3-8d19-8f0c33e3d300", false, "kübra-dogan", "kübra" },
                    { "1b05e331-b168-4339-ac5e-a54d4a34d915", null, 0, null, 1, "3f3ccf95-3d2d-48de-98b2-38d3d31de66c", "melike@gmail.com", true, null, "Melike", "Kadın", "9.png", "Kızar", "Ankara", false, null, "MELIKE@GMAIL.COM", "MELIKE", "AQAAAAIAAYagAAAAEPIwyd00eeO36U9R/5FeIA+OyYZ+Q1iUAlpm64IYCrpPYqKBnaAEpW0VylR4+RJ1TQ==", null, "1111111111", false, null, "a0e1a135-7860-4f3b-be81-c6c74ca72f87", false, "melike-demirci", "melike" },
                    { "1eb3f91e-38f0-4bc2-bf73-eb5697630df5", "Matematik Öğretmeni", 0, "27", 4, "fdeb27d2-a851-4093-b39d-f002ebf089da", "deniz@gmail.com", true, "3", "Deniz", "Erkek", "5.png", "Demir", "Ankara", false, null, "DENIZ@GMAIL.COM", "DENIZ", "AQAAAAIAAYagAAAAEFG0fmaak5kXtY+5BXQg20Rgt77fldYkY8lDBCXRECr0dv/WJ3BIBe+RDKwN/SA/Yw==", null, "5555555555", false, 175m, "44eb4026-14b7-4f88-8f44-980e22e1e09a", false, "deniz-demir", "deniz" },
                    { "209eafa6-f4f2-47fe-a0ee-236f99f5991b", null, 0, null, 1, "992c8081-b37c-4b8c-9289-a199b91a8e32", "ali@gmail.com", true, null, "Ali", "Erkek", "6.png", "Kazancı", "İstanbul", false, null, "ALI@GMAIL.COM", "ALI", "AQAAAAIAAYagAAAAEIfQ81DvviyWq+wBjcUmNKwNAiYRUhrAOl9OQL1gWMoUN6bgG8m2gSSPxI0w/69XSA==", null, "4444444444", false, null, "ad92e257-df94-4c7f-b6da-4adf70a5caf1", false, "ali-kazanci", "ali" },
                    { "5a7cc18d-d8ca-4fda-8735-df944a36d812", null, 0, null, 1, "fef68802-7450-48a1-8434-d0a73db4a715", "osman@gmail.com", true, null, "Osman", "Erkek", "10.png", "Kurtar", "Ankara", false, null, "OSMAN@GMAIL.COM", "OSMAN", "AQAAAAIAAYagAAAAEMA43yunVG9+5weXU4TnGJ+b8k5erKWAK4b/F1nEXSyIN79ruLR0fVdAosms9zYvRg==", null, "9876543210", false, null, "82a0edd1-3bc6-4f2e-9233-a085be61f1af", false, "osman-kurtar", "osman" },
                    { "67414ee1-1440-4ed2-8c15-da82f0812396", "Kimya Öğretmeni", 0, "26", 2, "28792856-5850-4638-a1c4-726122389d3e", "selin@gmail.com", true, "4", "Selin", "Kadın", "3.png", "Biçici", "İstanbul", false, null, "SELIN@GMAIL.COM", "SELİN", "AQAAAAIAAYagAAAAEJ4RiBjz5K631gfmNyEhlyIlJge33p1vN83XzSg3nF5EALl2ov+JfLwv7dpbB8qEGw==", null, "7777777777", false, 200m, "7e83556b-a5df-4f2a-a08e-e758e09c0cee", false, "selin-bicici", "selin" },
                    { "79e4050c-f177-4290-84b5-2282d02fe34f", null, 0, "24", 1, "3eeb1e8f-d0f0-45d5-a9ba-42cbb76b276a", "admin@gmail.com", true, null, "Mert", "Erkek", null, "Muslu", "Yalova", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEEs8IH0jqFkZTyHjKTNldOAo8QlbbUbSTgksMFeRWyhGS0p8QGAKnEL18/gzR3+42A==", null, "9999999999", false, null, "df20acc8-47e7-437a-80fb-aa770a1ae445", false, "mert-muslu", "admin" },
                    { "7d05c2e8-331c-4015-ae13-9f7a70d1f01b", null, 0, null, 1, "6b958cf4-63f7-4ea3-a347-59d658d4146d", "ismet@gmail.com", true, null, "İsmet", "Erkek", "8.png", "Demirci", "İzmir", false, null, "ISMET@GMAIL.COM", "ISMET", "AQAAAAIAAYagAAAAEB9VZbbA70DKkD4WtvroKZTkj0vW5GSyy3Y22dMHhtQ/l3Lsr30AwVY/h4ie9YLauw==", null, "2222222222", false, null, "098961f2-caa8-4415-9969-f25b57b80228", false, "ismet-demirci", "ismet" },
                    { "8db235b9-9112-4357-8023-95ced89f4b2d", "Fizik Öğretmeni", 0, "25", 1, "2aed369d-34ae-464f-a61f-86d0d6d338e6", "harun@gmail.com", true, "4", "Harun", "Erkek", "2.png", "Öztürk", "İstabul", false, null, "HARUN@GMAIL.COM", "HARUN", "AQAAAAIAAYagAAAAECrPcMFNNvv+CbK8MKwkViSvoS2cvxLdjHZuQkIBOfJbiHRFApLMvvrVrRDiZM2aUg==", null, "8888888888", false, 200m, "34d62c5a-7e62-4254-9ac5-e0c5a29e1ab3", false, "harun-ozturk", "harun" },
                    { "a560e21f-ef22-450a-8005-80af4c388459", "Biyoloji Öğretmeni", 0, "27", 3, "d3da5a89-2383-460a-9663-753868e004ff", "gizem@gmail.com", true, "3", "Gizem", "Kadın", "4.png", "Deniz", "Ankara", false, null, "GIZEM@GMAIL.COM", "GIZEM", "AQAAAAIAAYagAAAAEDKscQdBy662lY8+VaIXV1r0U6cfuwRdnuZd6W/W8Z7QIWEVLIaqW47zbOt6vQs9ZQ==", null, "6666666666", false, 250m, "de029745-97b1-4e9f-9874-1737e587d03b", false, "gizem-deniz", "gizem" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "BranchId", "FirstName", "Gender", "ImageUrl", "LastName", "Location", "PricePerHour", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, "Matematik Öğretmeni", 1, "Mert", "Erkek", "1.png", "Muslu", "İstanbul", 400m, "mert-muslu", null },
                    { 2, "Fizik Öğretmeni", 1, "Harun", "Erkek", "2.png", "Öztürk", "İstanbul", 200m, "harun-ozturk", null },
                    { 3, "Kimya Öğretmeni", 1, "Selin", "Kadın", "3.png", "Biçici", "Ankara", 200m, "selin-bicici", null },
                    { 4, "Biyoloji Öğretmeni", 1, "Gizem", "Kadın", "4.png", "Deniz", "İzmir", 250m, "gizem-deniz", null },
                    { 5, "Matematik Öğretmeni", 1, "Deniz", "Erkek", "5.png", "Demir", "İstanbul", 175m, "deniz-demir", null },
                    { 6, "Tarih Öğretmeni", 1, "Yusuf", "Erkek", "6.png", "Demirci", "İstanbul", 300m, "yusuf-demirci", null },
                    { 7, "Almanca Öğretmeni", 1, "Ahmet", "Erkek", "7.png", "Çetin", "Ankara", 300m, "ahmet-cetin", null },
                    { 8, "Almanca Öğretmeni", 1, "Okan", "Erkek", "8.png", "Alan", "İzmir", 200m, "okan-alan", null },
                    { 9, "Coğrafya Öğretmeni", 1, "Hakan", "Erkek", "9.png", "Kara", "İzmir", 250m, "hakan-kara", null },
                    { 10, "Edebiyat Öğretmeni", 1, "Hande", "Kadın", "10.png", "Karakaya", "İstanbul", 350m, "hande-karakaya", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8b3671a2-c360-4e7b-9a1f-bd12ba0675a8", "10a3f450-ad89-4dd4-b0a6-a272fd3a0e30" },
                    { "8b3671a2-c360-4e7b-9a1f-bd12ba0675a8", "1b05e331-b168-4339-ac5e-a54d4a34d915" },
                    { "df2fd075-b997-42c3-8434-9a5c8c96ebba", "1eb3f91e-38f0-4bc2-bf73-eb5697630df5" },
                    { "8b3671a2-c360-4e7b-9a1f-bd12ba0675a8", "209eafa6-f4f2-47fe-a0ee-236f99f5991b" },
                    { "8b3671a2-c360-4e7b-9a1f-bd12ba0675a8", "5a7cc18d-d8ca-4fda-8735-df944a36d812" },
                    { "df2fd075-b997-42c3-8434-9a5c8c96ebba", "67414ee1-1440-4ed2-8c15-da82f0812396" },
                    { "81c801d9-79d9-49e1-adcf-89dd9a61ed5f", "79e4050c-f177-4290-84b5-2282d02fe34f" },
                    { "8b3671a2-c360-4e7b-9a1f-bd12ba0675a8", "7d05c2e8-331c-4015-ae13-9f7a70d1f01b" },
                    { "df2fd075-b997-42c3-8434-9a5c8c96ebba", "8db235b9-9112-4357-8023-95ced89f4b2d" },
                    { "df2fd075-b997-42c3-8434-9a5c8c96ebba", "a560e21f-ef22-450a-8005-80af4c388459" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BranchId",
                table: "AspNetUsers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_BranchId",
                table: "Teachers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
