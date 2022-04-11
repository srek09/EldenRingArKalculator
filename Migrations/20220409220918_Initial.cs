using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldenRingArKalculator.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scalings",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Str0 = table.Column<float>(type: "real", nullable: false),
                    Dex0 = table.Column<float>(type: "real", nullable: false),
                    Int0 = table.Column<float>(type: "real", nullable: false),
                    Fai0 = table.Column<float>(type: "real", nullable: false),
                    Arc0 = table.Column<float>(type: "real", nullable: false),
                    Str1 = table.Column<float>(type: "real", nullable: false),
                    Dex1 = table.Column<float>(type: "real", nullable: false),
                    Int1 = table.Column<float>(type: "real", nullable: false),
                    Fai1 = table.Column<float>(type: "real", nullable: false),
                    Arc1 = table.Column<float>(type: "real", nullable: false),
                    Str2 = table.Column<float>(type: "real", nullable: false),
                    Dex2 = table.Column<float>(type: "real", nullable: false),
                    Int2 = table.Column<float>(type: "real", nullable: false),
                    Fai2 = table.Column<float>(type: "real", nullable: false),
                    Arc2 = table.Column<float>(type: "real", nullable: false),
                    Str3 = table.Column<float>(type: "real", nullable: false),
                    Dex3 = table.Column<float>(type: "real", nullable: false),
                    Int3 = table.Column<float>(type: "real", nullable: false),
                    Fai3 = table.Column<float>(type: "real", nullable: false),
                    Arc3 = table.Column<float>(type: "real", nullable: false),
                    Str4 = table.Column<float>(type: "real", nullable: false),
                    Dex4 = table.Column<float>(type: "real", nullable: false),
                    Int4 = table.Column<float>(type: "real", nullable: false),
                    Fai4 = table.Column<float>(type: "real", nullable: false),
                    Arc4 = table.Column<float>(type: "real", nullable: false),
                    Str5 = table.Column<float>(type: "real", nullable: false),
                    Dex5 = table.Column<float>(type: "real", nullable: false),
                    Int5 = table.Column<float>(type: "real", nullable: false),
                    Fai5 = table.Column<float>(type: "real", nullable: false),
                    Arc5 = table.Column<float>(type: "real", nullable: false),
                    Str6 = table.Column<float>(type: "real", nullable: false),
                    Dex6 = table.Column<float>(type: "real", nullable: false),
                    Int6 = table.Column<float>(type: "real", nullable: false),
                    Fai6 = table.Column<float>(type: "real", nullable: false),
                    Arc6 = table.Column<float>(type: "real", nullable: false),
                    Str7 = table.Column<float>(type: "real", nullable: false),
                    Dex7 = table.Column<float>(type: "real", nullable: false),
                    Int7 = table.Column<float>(type: "real", nullable: false),
                    Fai7 = table.Column<float>(type: "real", nullable: false),
                    Arc7 = table.Column<float>(type: "real", nullable: false),
                    Str8 = table.Column<float>(type: "real", nullable: false),
                    Dex8 = table.Column<float>(type: "real", nullable: false),
                    Int8 = table.Column<float>(type: "real", nullable: false),
                    Fai8 = table.Column<float>(type: "real", nullable: false),
                    Arc8 = table.Column<float>(type: "real", nullable: false),
                    Str9 = table.Column<float>(type: "real", nullable: false),
                    Dex9 = table.Column<float>(type: "real", nullable: false),
                    Int9 = table.Column<float>(type: "real", nullable: false),
                    Fai9 = table.Column<float>(type: "real", nullable: false),
                    Arc9 = table.Column<float>(type: "real", nullable: false),
                    Str10 = table.Column<float>(type: "real", nullable: false),
                    Dex10 = table.Column<float>(type: "real", nullable: false),
                    Int10 = table.Column<float>(type: "real", nullable: false),
                    Fai10 = table.Column<float>(type: "real", nullable: false),
                    Arc10 = table.Column<float>(type: "real", nullable: false),
                    Str11 = table.Column<float>(type: "real", nullable: false),
                    Dex11 = table.Column<float>(type: "real", nullable: false),
                    Int11 = table.Column<float>(type: "real", nullable: false),
                    Fai11 = table.Column<float>(type: "real", nullable: false),
                    Arc11 = table.Column<float>(type: "real", nullable: false),
                    Str12 = table.Column<float>(type: "real", nullable: false),
                    Dex12 = table.Column<float>(type: "real", nullable: false),
                    Int12 = table.Column<float>(type: "real", nullable: false),
                    Fai12 = table.Column<float>(type: "real", nullable: false),
                    Arc12 = table.Column<float>(type: "real", nullable: false),
                    Str13 = table.Column<float>(type: "real", nullable: false),
                    Dex13 = table.Column<float>(type: "real", nullable: false),
                    Int13 = table.Column<float>(type: "real", nullable: false),
                    Fai13 = table.Column<float>(type: "real", nullable: false),
                    Arc13 = table.Column<float>(type: "real", nullable: false),
                    Str14 = table.Column<float>(type: "real", nullable: false),
                    Dex14 = table.Column<float>(type: "real", nullable: false),
                    Int14 = table.Column<float>(type: "real", nullable: false),
                    Fai14 = table.Column<float>(type: "real", nullable: false),
                    Arc14 = table.Column<float>(type: "real", nullable: false),
                    Str15 = table.Column<float>(type: "real", nullable: false),
                    Dex15 = table.Column<float>(type: "real", nullable: false),
                    Int15 = table.Column<float>(type: "real", nullable: false),
                    Fai15 = table.Column<float>(type: "real", nullable: false),
                    Arc15 = table.Column<float>(type: "real", nullable: false),
                    Str16 = table.Column<float>(type: "real", nullable: false),
                    Dex16 = table.Column<float>(type: "real", nullable: false),
                    Int16 = table.Column<float>(type: "real", nullable: false),
                    Fai16 = table.Column<float>(type: "real", nullable: false),
                    Arc16 = table.Column<float>(type: "real", nullable: false),
                    Str17 = table.Column<float>(type: "real", nullable: false),
                    Dex17 = table.Column<float>(type: "real", nullable: false),
                    Int17 = table.Column<float>(type: "real", nullable: false),
                    Fai17 = table.Column<float>(type: "real", nullable: false),
                    Arc17 = table.Column<float>(type: "real", nullable: false),
                    Str18 = table.Column<float>(type: "real", nullable: false),
                    Dex18 = table.Column<float>(type: "real", nullable: false),
                    Int18 = table.Column<float>(type: "real", nullable: false),
                    Fai18 = table.Column<float>(type: "real", nullable: false),
                    Arc18 = table.Column<float>(type: "real", nullable: false),
                    Str19 = table.Column<float>(type: "real", nullable: false),
                    Dex19 = table.Column<float>(type: "real", nullable: false),
                    Int19 = table.Column<float>(type: "real", nullable: false),
                    Fai19 = table.Column<float>(type: "real", nullable: false),
                    Arc19 = table.Column<float>(type: "real", nullable: false),
                    Str20 = table.Column<float>(type: "real", nullable: false),
                    Dex20 = table.Column<float>(type: "real", nullable: false),
                    Int20 = table.Column<float>(type: "real", nullable: false),
                    Fai20 = table.Column<float>(type: "real", nullable: false),
                    Arc20 = table.Column<float>(type: "real", nullable: false),
                    Str21 = table.Column<float>(type: "real", nullable: false),
                    Dex21 = table.Column<float>(type: "real", nullable: false),
                    Int21 = table.Column<float>(type: "real", nullable: false),
                    Fai21 = table.Column<float>(type: "real", nullable: false),
                    Arc21 = table.Column<float>(type: "real", nullable: false),
                    Str22 = table.Column<float>(type: "real", nullable: false),
                    Dex22 = table.Column<float>(type: "real", nullable: false),
                    Int22 = table.Column<float>(type: "real", nullable: false),
                    Fai22 = table.Column<float>(type: "real", nullable: false),
                    Arc22 = table.Column<float>(type: "real", nullable: false),
                    Str23 = table.Column<float>(type: "real", nullable: false),
                    Dex23 = table.Column<float>(type: "real", nullable: false),
                    Int23 = table.Column<float>(type: "real", nullable: false),
                    Fai23 = table.Column<float>(type: "real", nullable: false),
                    Arc23 = table.Column<float>(type: "real", nullable: false),
                    Str24 = table.Column<float>(type: "real", nullable: false),
                    Dex24 = table.Column<float>(type: "real", nullable: false),
                    Int24 = table.Column<float>(type: "real", nullable: false),
                    Fai24 = table.Column<float>(type: "real", nullable: false),
                    Arc24 = table.Column<float>(type: "real", nullable: false),
                    Str25 = table.Column<float>(type: "real", nullable: false),
                    Dex25 = table.Column<float>(type: "real", nullable: false),
                    Int25 = table.Column<float>(type: "real", nullable: false),
                    Fai25 = table.Column<float>(type: "real", nullable: false),
                    Arc25 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scalings", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    StrScaling = table.Column<int>(type: "int", nullable: false),
                    DexScaling = table.Column<int>(type: "int", nullable: false),
                    IntScaling = table.Column<int>(type: "int", nullable: false),
                    FaiScaling = table.Column<int>(type: "int", nullable: false),
                    ArcScaling = table.Column<int>(type: "int", nullable: false),
                    Phys = table.Column<float>(type: "real", nullable: false),
                    Mag = table.Column<float>(type: "real", nullable: false),
                    Fire = table.Column<float>(type: "real", nullable: false),
                    Light = table.Column<float>(type: "real", nullable: false),
                    Holy = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scalings");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
