using Microsoft.EntityFrameworkCore.Migrations;

namespace ADD_DB_My_Apteka.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "My_Apteka_DB",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    flag = table.Column<int>(nullable: false),
                    Node = table.Column<int>(nullable: false),
                    UR = table.Column<string>(nullable: true),
                    INN = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Pass_Email = table.Column<string>(nullable: true),
                    Work_time = table.Column<string>(nullable: true),
                    Kass_1 = table.Column<string>(nullable: true),
                    Kass1_RN = table.Column<string>(nullable: true),
                    Kass1_ZN = table.Column<string>(nullable: true),
                    Kass1_FN = table.Column<string>(nullable: true),
                    Kass_2 = table.Column<string>(nullable: true),
                    Kass2_RN = table.Column<string>(nullable: true),
                    Kass2_ZN = table.Column<string>(nullable: true),
                    Kass2_FN = table.Column<string>(nullable: true),
                    Kass_3 = table.Column<string>(nullable: true),
                    Kass3_RN = table.Column<string>(nullable: true),
                    Kass3_ZN = table.Column<string>(nullable: true),
                    Kass3_FN = table.Column<string>(nullable: true),
                    Kass_4 = table.Column<string>(nullable: true),
                    Kass4_RN = table.Column<string>(nullable: true),
                    Kass4_ZN = table.Column<string>(nullable: true),
                    Kass4_FN = table.Column<string>(nullable: true),
                    VPN = table.Column<string>(nullable: true),
                    VPN_CODE = table.Column<string>(nullable: true),
                    Operator = table.Column<string>(nullable: true),
                    Tel_Operator = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_My_Apteka_DB", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "My_Apteka_DB");
        }
    }
}
