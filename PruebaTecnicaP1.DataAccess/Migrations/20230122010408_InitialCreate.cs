using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaTecnicaP1.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Covids",
                columns: table => new
                {
                    CovidId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegionId = table.Column<long>(type: "INTEGER", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    TotalCases = table.Column<long>(type: "INTEGER", nullable: true),
                    TotalTests = table.Column<long>(type: "INTEGER", nullable: true),
                    ActiveCases = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Covids", x => x.CovidId);
                    table.ForeignKey(
                        name: "FK_Covids_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Covids_RegionId",
                table: "Covids",
                column: "RegionId");

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Descripcion" },
                values: new object[] {  1, "Europe"  });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Descripcion" },
                values: new object[] { 2, "North America" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Descripcion" },
                values: new object[] { 3, "Asia" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Descripcion" },
                values: new object[] { 4, "South America" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Descripcion" },
                values: new object[] { 5, "Africa" });

            migrationBuilder.InsertData(
               table: "Regions",
               columns: new[] { "RegionId", "Descripcion" },
               values: new object[] { 6, "Oceania" });

            #region Europe
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 1, 1, "France", 39472273, 178092, 271490188 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 2, 1, "Germany", 37659518, 299633, 122332384 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 3, 1, "Italy", 25363742, 353643, 264182282 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 4, 1, "UK", 24243393, 85592, 522526476 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 5, 1, "Russia", 21882414, 189885, 273400000 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 6, 1, "Spain", 13711251, 70642, 471036328 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 7, 1, "Netherlands", 8578818, 19702, 25984435 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 8, 1, "Poland", 6374976, 920358, 38074695 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 9, 1, "Austria", 5751836, 23805, 205307182 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 10, 1, "Portugal", 5557941, 2676, 45879317 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 11, 1, "Greece", 5548487, 0, 102228365 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 12, 1, "Ukraine", 5364322, 5406, 32603805 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 13, 1, "Belgium", 4688927, 23144, 36517298 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 14, 1, "Czechia", 4586356, 6483, 56856706 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 15, 1, "Switzerland", 4384899, 16113, 23318743 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 16, 1, "Romania", 3319680, 7595, 26244526 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 17, 1, "Denmark", 3172335, 2458, 129117516 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 18, 1, "Sweden", 2690473, 27886, 19393009 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 19, 1, "Serbia", 2463173, 16553, 12050560 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 20, 1, "Hungary", 2191200, 8597, 11394556 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 21, 1, "Slovakia", 1860366, 731, 7385197 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 22, 1, "Ireland", 1699347, 1096, 12968708 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 23, 1, "Norway", 1477276, 1688, 11002430 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 24, 1, "Finland", 1449824, 7885, 12007701 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 25, 1, "Slovenia", 1319207, 6063, 2818894 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 26, 1, "Bulgaria", 1294697, 3341, 10956400 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 27, 1, "Lithuania", 1293928, 5507, 10338969 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 28, 1, "Croatia", 1266949, 923, 5460461 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 29, 1, "Belarus", 994037, 1327, 13646641 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 30, 1, "Latvia", 97508, 477, 7855522 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 31, 1, "Estonia", 613206, 8532, 3648199 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 32, 1, "Moldova", 597598, 81509, 3216305 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 33, 1, "Bosnia and Herzegovina", 401263, 601, 1883798 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 34, 1, "North Macedonia", 346297, 204, 2213883 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 35, 1, "Albania", 334084, 1687, 1941032 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 36, 1, "Luxembourg", 297757, 7633, 4412567 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 37, 1, "Montenegro", 285836, 516, 2691378 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 38, 1, "Iceland", 208539, null, 1996384 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 39, 1, "Malta", 116894, 713, 2106222 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 40, 1, "Channel Islands", 100931, 191, 1252808 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 41, 1, "Andorra", 4782, 92, 249838 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 42, 1, "Isle of Man", 38008, null, 150753 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 43, 1, "Faeroe Islands", 34658, null, 778 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 44, 1, "San Marino", 2329, 135, 157634 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 45, 1, "Liechtenstein", 21325, 20, 112457 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 46, 1, "Gibraltar", 20379, 3689, 534283 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 47, 1, "Monaco", 16041, 21, 78646 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 48, 1, "Vatican City", 29, 0, 0 });
            #endregion

            #region North America
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 49, 2, "USA", 103829943, 1927708, 1157889067 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 50, 2, "Mexico", 7341480, 438007, 19289408 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 51, 2, "Canada", 4524782, 54629, 66343123 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 52, 2, "Guatemala", 1222699, 6712, 6688885 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 53, 2, "Costa Rica", 1177514, 30768, 4659757 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 54, 2, "Cuba", 1112350, 109, 14276770 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 55, 2, "Panama", 1028272, 1538, 7441420 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 56, 2, "Dominican Republic", 659761, 10592, 3740928 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 57, 2, "Honduras", 470144, null, 1614662 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 58, 2, "Martinique", 229348, null, 828928 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 59, 2, "El Salvador", 201785, 18145, 2610114 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 60, 2, "Guadeloupe", 200965, null, 938039 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 61, 2, "Trinidad and Tobago", 187204, 172, 885178 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 62, 2, "Jamaica", 153143, 47551, 1183986 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 63, 2, "Barbados", 105905, 22, 788414 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 64, 2, "Belize", 70555, 82, 576016 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 65, 2, "Curaçao", 45986, 971, 496693 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 66, 2, "Aruba", 43965, 1291, 177885 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 67, 2, "Bahamas", 37491, 292, 257839 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 68, 2, "Haiti", 34008, 162, 132422 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 69, 2, "Cayman Islands", 31472, 22882, 222773 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 70, 2, "Saint Lucia", 29761, 257, 210983 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 71, 2, "Grenada", 1968, 84, 182981 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 72, 2, "Bermuda", 18751, 38, 1024316 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 73, 2, "Nicaragua", 18491, 14041, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 74, 2, "Dominica", 1576, 13, 229344 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 75, 2, "Saint Martin", 12222, 1076, 112382 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 76, 2, "Greenland", 11971, 9189, 164926 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 77, 2, "Caribbean Netherlands", 11648, 1134, 30126 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 78, 2, "Sint Maarten", 1101, 16, 62056 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 79, 2, "St. Vincent Grenadines", 9572, 8, 113366 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 80, 2, "Antigua and Barbuda", 9106, 6, 18901 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 81, 2, "British Virgin Islands", 7305, null, 107339 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 82, 2, "Saint Kitts and Nevis", 6585, 11, 12688 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 83, 2, "Turks and Caicos", 6522, 33, 611527 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 84, 2, "St. Barth", 5418, null, 78646 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 85, 2, "Anguilla", 3904, 13, 51382 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 86, 2, "Saint Pierre Miquelon", 3411, 960, 254 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 87, 2, "Montserrat", 1403, 19, 17762 });
            #endregion

            #region Asia
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 88, 3, "India", 44681921, 196, 914020290 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 89, 3, "Japan", 32045328, 10510382, 90589390 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 90, 3, "S. Korea", 29999529, 700339, 15804065 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 91, 3, "Turkey", 17042722, null, 162743369 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 92, 3, "Vietnam", 11526329, 870734, 85826548 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 93, 3, "Taiwan", 9342958, 453589, 29898634 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 94, 3, "Iran", 7563385, 81586, 54420785 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 95, 3, "Indonesia", 6728065, 5461, 114158919 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 96, 3, "Malaysia", 5034521, 1032, 67531230 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 97, 3, "Israel", 4780420, 6911, 41373364 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 98, 3, "DPRK", 4772813, 0, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 99, 3, "Thailand", 4725885, 19, 17270775 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 100, 3, "Philippines", 4071963, 10587, 34238444 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 101, 3, "Hong Kong", 2858054, 51912, 75375235 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 102, 3, "Iraq", 2465545, 673, 19544451 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 103, 3, "Singapore", 2214064, 70726, 24756374 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 104, 3, "Bangladesh", 2037408, 17571, 15175874 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 105, 3, "Georgia", 1811015, 17558, 16920079 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 106, 3, "Jordan", 1746997, 1868, 17201885 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 107, 3, "Pakistan", 1576176, 6847, 30570862 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 108, 3, "Kazakhstan", 1405417, 8702, 11575012 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 109, 3, "Lebanon", 1226529, 128171, 4795578 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 110, 3, "UAE", 1048623, 1437, 198398727 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 111, 3, "Mongolia", 1007855, 90, 4030048 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 112, 3, "Nepal", 1001076, 22, 6000597 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 113, 3, "Azerbaijan", 827638, 333, 7469502 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 114, 3, "Saudi Arabia", 827608, 2817, 45015781 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 115, 3, "Bahrain", 699893, 413, 10669416 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 116, 3, "Sri Lanka", 671976, 3, 6486117 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 117, 3, "Kuwait", 662858, 51, 8455743 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 118, 3, "Cyprus", 640729, 9618, 9640118 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 119, 3, "Myanmar", 633799, 68, 9905287 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 120, 3, "Palestine", 621008, 159, 3078533 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 121, 3, "China", 503302, 118977, 160000000 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 122, 3, "Qatar", 491967, 281, 4065369 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 123, 3, "Armenia", 446008, 2129, 3242901 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 124, 3, "Oman", 399154, 10225, 25000000 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 125, 3, "Brunei", 274217, 30391, 717784 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 126, 3, "Uzbekistan", 25036, 7237, 1377915 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 127, 3, "Laos", 217944, null, 1233207 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 128, 3, "Afghanistan", 208084, 14316, 1184310 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 129, 3, "Kyrgyzstan", 206588, 7191, 1907195 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 130, 3, "Maldives", 185708, 2171, 2213831 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 131, 3, "Cambodia", 138676, 9, 3091420 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 132, 3, "Bhutan", 62577, 992, 2303734 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 133, 3, "Syria", 5745, 3, 146269 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 134, 3, "Timor-Leste", 23409, 169, 278529 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 135, 3, "Tajikistan", 17786, 397, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 136, 3, "Yemen", 11945, 662, 329592 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 137, 3, "Macao", 3468, 28, 785 });
            #endregion

            #region South America
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 138, 4, "Brazil", 36733016, 361672, 63776166 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 139, 4, "Argentina", 10024095, 81129, 35716069 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 140, 4, "Colombia", 6354791, 37163, 36951507 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 141, 4, "Chile", 5103912, 628, 48027445 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 142, 4, "Peru", 4478692, 8481, 37651001 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 143, 4, "Bolivia", 1183705, 24718, 2705422 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 144, 4, "Ecuador", 1047624, 7161, 3082403 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 145, 4, "Uruguay", 1029564, 3288, 6114822 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 146, 4, "Paraguay", 805486, null, 2657506 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 147, 4, "Venezuela", 551283, 877, 3359014 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 148, 4, "French Guiana", 98012, 86342, 651257 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 149, 4, "Suriname", 8202, null, 239603 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 150, 4, "Guyana", 72815, 356, 715603 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests"  }, values: new object[] { 151, 4, "Falkland Islands", 193, 0, 8632 });
            #endregion

            #region Africa
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 152, 5, "South Africa", 4053796, 38702, 26473049 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 153, 5, "Morocco", 1272164, 133, 12913354 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 154, 5, "Tunisia", 1150217, null, 4995308 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 155, 5, "Egypt", 515645, 4885, 3693367 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 156, 5, "Libya", 507158, 4, 2483446 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 157, 5, "Ethiopia", 499295, 5786, 5448371 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 158, 5, "Réunion", 484813, 65323, 1603660 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 159, 5, "Kenya", 342782, 120, 39669068 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 160, 5, "Zambia", 338986, 2292, 3840304 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 161, 5, "Botswana", 328581, 2039, 2026898 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 162, 5, "Algeria", 271328, 81735, 230861 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 163, 5, "Nigeria", 266463, 3458, 5708974 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 164, 5, "Zimbabwe", 259981, 667, 2525756 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 165, 5, "Mozambique", 231404, 371, 1371127 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 166, 5, "Ghana", 171102, 13, 2526985 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 167, 5, "Namibia", 170496, 89, 1062663 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 168, 5, "Uganda", 170279, 66218, 3012408 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 169, 5, "Rwanda", 133078, 73, 5959042 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 170, 5, "Cameroon", 123993, 3412, 1751774 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 171, 5, "Angola", 105095, 115, 1499795 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 172, 5, "DRC", 95346, 966, 846704 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 173, 5, "Senegal", 889, 17, 1146543 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 174, 5, "Malawi", 88446, 469, 624784 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 175, 5, "Ivory Coast", 87966, 6, 1669594 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 176, 5, "Eswatini", 74086, 41, 1048081 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 177, 5, "Madagascar", 67788, 39, 523557 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 178, 5, "Sudan", 63725, 450, 562941 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 179, 5, "Mauritania", 63664, 234, 1009957 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 180, 5, "Cabo Verde", 63224, 60, 401622 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 181, 5, "Burundi", 52162, 731, 345742 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 182, 5, "Seychelles", 50355, 157, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 183, 5, "Gabon", 4898, 6, 1621909 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 184, 5, "Tanzania", 4253, null, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 185, 5, "Mayotte", 42002, null, 176919 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 186, 5, "Mauritius", 41627, 684, 358675 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 187, 5, "Togo", 39353, 6, 806058 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 188, 5, "Guinea", 38224, 0, 660107 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 189, 5, "Lesotho", 3479, 8087, 431221 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 190, 5, "Mali", 32775, 79, 787143 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 191, 5, "Benin", 27989, 3, 60431 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 192, 5, "Somalia", 2731, 12767, 400466 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 193, 5, "Congo", 25375, 983, 347815 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 194, 5, "Burkina Faso", 22025, 33, 248995 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 195, 5, "South Sudan", 18368, 115, 41028 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 196, 5, "Equatorial Guinea", 17186, 123, 365697 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 197, 5, "Djibouti", 1569, 74, 305941 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 198, 5, "CAR", 15361, 471, 81294 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 199, 5, "Gambia", 12586, 25, 155686 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 200, 5, "Eritrea", 10189, 0, 23693 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 201, 5, "Niger", 9931, 729, 254538 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 202, 5, "Comoros", 8992, 4, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 203, 5, "Guinea-Bissau", 8947, 115, 145231 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 204, 5, "Liberia", 8043, 8, 139824 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 205, 5, "Sierra Leone", 776, null, 259958 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 206, 5, "Chad", 7651, 2583, 191341 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 207, 5, "Sao Tome and Principe", 6279, 0, 29036 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 208, 5, "Saint Helena", 1806, 1804, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 209, 5, "Western Sahara", 10, 0, 0 });
            #endregion

            #region Oceania
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 210, 6, "Australia", 11274262, 57946, 78835048 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 211, 6, "New Zealand", 2157933, 17924, 7710637 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 212, 6, "New Caledonia", 79785, 71, 98964 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 213, 6, "French Polynesia", 77957, null, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 214, 6, "Fiji", 68808, 1155, 667444 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 215, 6, "Papua New Guinea", 46663, 2012, 249149 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 216, 6, "Solomon Islands", 24575, null, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 217, 6, "Micronesia", 22676, null, 54967 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 218, 6, "Tonga", 1659, 939, 535009 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 219, 6, "Samoa", 16022, 14388, 187397 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 220, 6, "Marshall Islands", 15554, 9, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 221, 6, "Vanuatu", 12014, 24, 24976 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 222, 6, "Cook Islands", 6988, 33, 1969 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 223, 6, "Palau", 5986, 7, 68724 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 224, 6, "Kiribati", 4991, 227, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 225, 6, "Nauru", 4621, 11, 20509 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 226, 6, "Wallis and Futuna", 3427, 2982, 20508 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 227, 6, "Tuvalu", 2805, 2805, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 228, 6, "Niue", 730, 19, 0 });
            migrationBuilder.InsertData(table: "Covids", columns: new[] { "CovidId", "RegionId", "Country", "TotalCases", "ActiveCases", "TotalTests" }, values: new object[] { 229, 6, "Tokelau", 5, 5, 0 });
            #endregion
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Covids");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
