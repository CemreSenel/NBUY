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
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Age = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Age = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Experience = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    PricePerHour = table.Column<decimal>(type: "TEXT", nullable: true),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false),
                    UniversityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentTeachers",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTeachers", x => new { x.StudentId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "Age", "FirstName", "Gender", "ImageUrl", "LastName", "Url" },
                values: new object[,]
                {
                    { 1, "15", "Ali", "Erkek", "1.png", "Kazancı", "ali-kazanci" },
                    { 2, "17", "Kübra", "Kadın", "2.png", "Doğan", "kübra-dogan" },
                    { 3, "16", "İsmet", "Erkek", "3.png", "Demirci", "ismet-demirci" },
                    { 4, "18", "Melike", "Kadın", "4.png", "Kızar", "melike-demirci" },
                    { 5, "19", "Osman", "Erkek", "5.png", "Kurtar", "osman-kurtar" }
                });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Boğaziçi Üniversitesi" },
                    { 2, "İstanbul Teknik Üniversitesi" },
                    { 3, "Yıldız Teknik Üniversitesi" },
                    { 4, "Anadolu Üniversitesi" },
                    { 5, "Marmara Üniversitesi" },
                    { 6, "İstanbul Üniversitesi" },
                    { 7, "Kocaeli Üniversitesi" },
                    { 8, "Sakarya Üniversitesi" },
                    { 9, "Bahçeşehir Üniversitesi" },
                    { 10, "Bilkent Üniversitesi" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Age", "BranchId", "Experience", "FirstName", "Gender", "ImageUrl", "LastName", "Location", "PricePerHour", "UniversityId", "Url" },
                values: new object[,]
                {
                    { 1, "Matematik Öğretmeni", "24", 1, "5", "Mert", "Erkek", "1.png", "Muslu", "Yalova", 400m, 1, "mert-muslu" },
                    { 2, "Fizik Öğretmeni", "25", 3, "4", "Harun", "Erkek", "2.png", "Öztürk", "İstabul", 200m, 2, "harun-ozturk" },
                    { 3, "Kimya Öğretmeni", "26", 2, "4", "Selin", "Kadın", "3.png", "Biçici", "İstanbul", 200m, 3, "selin-bicici" },
                    { 4, "Biyoloji Öğretmeni", "27", 4, "3", "Gizem", "Kadın", "4.png", "Deniz", "Ankara", 250m, 4, "gizem-deniz" },
                    { 5, "Matematik Öğretmeni", "28", 1, "2", "Deniz", "Erkek", "5.png", "Demir", "İstanbul", 175m, 5, "deniz-demir" },
                    { 6, "Tarih Öğretmeni", "29", 5, "7", "Yusuf", "Erkek", "6.png", "Demirci", "İstanbul", 300m, 6, "yusuf-demirci" },
                    { 7, "Almanca Öğretmeni", "28", 7, "3", "Ahmet", "Erkek", "7.png", "Çetin", "İstanbul", 300m, 7, "ahmet-cetin" },
                    { 8, "Almanca Öğretmeni", "27", 7, "2", "Okan", "Erkek", "8.png", "Alan", "Kocaeli", 200m, 8, "okan-alan" },
                    { 9, "Coğrafya Öğretmeni", "26", 9, "5", "Hakan", "Erkek", "9.png", "Kara", "Kocaeli", 250m, 9, "hakan-kara" },
                    { 10, "Edebiyat Öğretmeni", "25", 6, "4", "Hande", "Kadın", "10.png", "Karakaya", "Kocaeli", 350m, 10, "hande-karakaya" }
                });

            migrationBuilder.InsertData(
                table: "StudentTeachers",
                columns: new[] { "StudentId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 4 },
                    { 2, 6 },
                    { 3, 5 },
                    { 3, 7 },
                    { 3, 8 },
                    { 4, 5 },
                    { 4, 9 },
                    { 4, 10 },
                    { 5, 4 },
                    { 5, 7 },
                    { 5, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeachers_TeacherId",
                table: "StudentTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_BranchId",
                table: "Teachers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UniversityId",
                table: "Teachers",
                column: "UniversityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentTeachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Universities");
        }
    }
}
