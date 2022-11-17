using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitabeviApp.Migrations
{
    public partial class Kitap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Anasayfa",
                table: "Kitaplar",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Ozet",
                table: "Kitaplar",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Anasayfa", "Ozet" },
                values: new object[] { true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius ipsam sit officiis debitis nostrum perspiciatis sunt tempora. Ea possimus itaque fugit ipsum recusandae esse animi asperiores incidunt eos est!" });

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Anasayfa", "Ozet" },
                values: new object[] { true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius ipsam sit officiis debitis nostrum perspiciatis sunt tempora. Ea possimus itaque fugit ipsum recusandae esse animi asperiores incidunt eos est!" });

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Anasayfa", "Ozet" },
                values: new object[] { true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius ipsam sit officiis debitis nostrum perspiciatis sunt tempora. Ea possimus itaque fugit ipsum recusandae esse animi asperiores incidunt eos est!" });

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Anasayfa", "Ozet" },
                values: new object[] { true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius ipsam sit officiis debitis nostrum perspiciatis sunt tempora. Ea possimus itaque fugit ipsum recusandae esse animi asperiores incidunt eos est!" });

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 5,
                column: "Ozet",
                value: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius ipsam sit officiis debitis nostrum perspiciatis sunt tempora. Ea possimus itaque fugit ipsum recusandae esse animi asperiores incidunt eos est!");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 6,
                column: "Ozet",
                value: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius ipsam sit officiis debitis nostrum perspiciatis sunt tempora. Ea possimus itaque fugit ipsum recusandae esse animi asperiores incidunt eos est!");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 7,
                column: "Ozet",
                value: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius ipsam sit officiis debitis nostrum perspiciatis sunt tempora. Ea possimus itaque fugit ipsum recusandae esse animi asperiores incidunt eos est!");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 8,
                column: "Ozet",
                value: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius ipsam sit officiis debitis nostrum perspiciatis sunt tempora. Ea possimus itaque fugit ipsum recusandae esse animi asperiores incidunt eos est!");

            migrationBuilder.UpdateData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 9,
                column: "Ozet",
                value: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus eius ipsam sit officiis debitis nostrum perspiciatis sunt tempora. Ea possimus itaque fugit ipsum recusandae esse animi asperiores incidunt eos est!");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anasayfa",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "Ozet",
                table: "Kitaplar");
        }
    }
}
