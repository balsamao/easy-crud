using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCrud.Infra.Migrations
{
    public partial class Version0100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Portfolio = table.Column<string>(maxLength: 50, nullable: true),
                    HourlySalary = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevelopersPreferences",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeveloperId = table.Column<long>(nullable: false),
                    UpToFourHoursPerDay = table.Column<bool>(nullable: true),
                    FourToSixHoursPerDay = table.Column<bool>(nullable: true),
                    sixtoEightHoursPerDay = table.Column<bool>(nullable: true),
                    UpToEightHoursADay = table.Column<bool>(nullable: true),
                    OnlyWeekends = table.Column<bool>(nullable: true),
                    Morning = table.Column<bool>(nullable: true),
                    Afternoon = table.Column<bool>(nullable: true),
                    Night = table.Column<bool>(nullable: true),
                    Dawn = table.Column<bool>(nullable: true),
                    Business = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopersPreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevelopersPreferences_Developers_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DevelopersSkills",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeveloperId = table.Column<long>(nullable: false),
                    AditionalInformation = table.Column<string>(nullable: true),
                    LinkCrud = table.Column<string>(nullable: true),
                    Ionic = table.Column<int>(nullable: true),
                    ReactJS = table.Column<int>(nullable: true),
                    ReactNative = table.Column<int>(nullable: true),
                    Android = table.Column<int>(nullable: true),
                    Flutter = table.Column<int>(nullable: true),
                    SWIFT = table.Column<int>(nullable: true),
                    IOS = table.Column<int>(nullable: true),
                    HTML = table.Column<int>(nullable: true),
                    CSS = table.Column<int>(nullable: true),
                    Bootstrap = table.Column<int>(nullable: true),
                    Jquery = table.Column<int>(nullable: true),
                    AngularJs = table.Column<int>(nullable: true),
                    Angular = table.Column<int>(nullable: true),
                    Java = table.Column<int>(nullable: true),
                    Python = table.Column<int>(nullable: true),
                    Flask = table.Column<int>(nullable: true),
                    AspNetMVC = table.Column<int>(nullable: true),
                    AspNetWebForm = table.Column<int>(nullable: true),
                    C = table.Column<int>(nullable: true),
                    Csharp = table.Column<int>(nullable: true),
                    NodeJS = table.Column<int>(nullable: true),
                    ExpressNodeJs = table.Column<int>(nullable: true),
                    Cake = table.Column<int>(nullable: true),
                    Django = table.Column<int>(nullable: true),
                    Majento = table.Column<int>(nullable: true),
                    PHP = table.Column<int>(nullable: true),
                    Vue = table.Column<int>(nullable: true),
                    Wordpress = table.Column<int>(nullable: true),
                    Ruby = table.Column<int>(nullable: true),
                    MySQLServer = table.Column<int>(nullable: true),
                    MySQL = table.Column<int>(nullable: true),
                    Salesforce = table.Column<int>(nullable: true),
                    Photoshop = table.Column<int>(nullable: true),
                    Illustrator = table.Column<int>(nullable: true),
                    SEO = table.Column<int>(nullable: true),
                    Laravel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopersSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevelopersSkills_Developers_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DevelopersPreferences_DeveloperId",
                table: "DevelopersPreferences",
                column: "DeveloperId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DevelopersSkills_DeveloperId",
                table: "DevelopersSkills",
                column: "DeveloperId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevelopersPreferences");

            migrationBuilder.DropTable(
                name: "DevelopersSkills");

            migrationBuilder.DropTable(
                name: "Developers");
        }
    }
}
