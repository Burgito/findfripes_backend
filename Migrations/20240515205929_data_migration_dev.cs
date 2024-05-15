using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace findfripes_dotnet.Migrations
{
    /// <inheritdoc />
    public partial class data_migration_dev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "id", "city", "country", "created_at", "line_1", "line_2", "line_3", "post_code", "updated_at" },
                values: new object[,]
                {
                    { 1, "Johannaside", "Mozambique", null, "75171 Wuckert Village", null, null, "10145", null },
                    { 2, "Dylanport", "Singapore", null, "8304 Nicklaus Crossroad", null, null, "32488-5789", null },
                    { 3, "East Electa", "Papua New Guinea", null, "380 Garland Forge", null, null, "84674", null },
                    { 4, "West Keira", "Australia", null, "80845 Mitchell Plain", null, null, "77992-5304", null },
                    { 5, "Estebanstad", "Virgin Islands, U.S.", null, "91711 Greenfelder Manor", null, null, "20236-9004", null },
                    { 6, "Hellerview", "Libyan Arab Jamahiriya", null, "10736 Frami Bridge", null, null, "96066", null },
                    { 7, "Dianahaven", "Costa Rica", null, "0710 Littel Harbor", null, null, "70114-2036", null },
                    { 8, "Gusikowskiport", "Lebanon", null, "51138 Gertrude Locks", null, null, "32869-5234", null },
                    { 9, "Lake Kiley", "Israel", null, "23931 Durgan Street", null, null, "55858", null },
                    { 10, "Rempelfurt", "Saudi Arabia", null, "3104 Cassin Junctions", null, null, "12050", null },
                    { 11, "New Shawna", "Democratic People's Republic of Korea", null, "260 McCullough Station", null, null, "56729-1169", null },
                    { 12, "Edwardmouth", "Trinidad and Tobago", null, "6256 Ford Fields", null, null, "17165-4920", null },
                    { 13, "Bernhardstad", "Peru", null, "92799 Phyllis Mountain", null, null, "22197-9706", null },
                    { 14, "West Keanu", "Croatia", null, "308 Damaris Extension", null, null, "98287", null },
                    { 15, "West Newellland", "Italy", null, "730 Wiley Manor", null, null, "64649", null },
                    { 16, "Rowestad", "Mauritania", null, "584 Hudson Islands", null, null, "69478-7205", null },
                    { 17, "Jadeberg", "Virgin Islands, U.S.", null, "990 Hintz Divide", null, null, "54772", null },
                    { 18, "Edenbury", "Finland", null, "45060 Skye Stream", null, null, "57968", null },
                    { 19, "Howemouth", "Colombia", null, "4877 Jakubowski Hills", null, null, "31358", null },
                    { 20, "Noeliastad", "Chad", null, "862 Kaela Squares", null, null, "93505-9905", null },
                    { 21, "South Dixieton", "France", null, "122 Kautzer Crossroad", null, null, "78180", null },
                    { 22, "North Sistertown", "Algeria", null, "93185 Kutch Mount", null, null, "27166", null },
                    { 23, "Deckowfort", "Slovenia", null, "8806 Elinor Corners", null, null, "40914-4237", null },
                    { 24, "East Melynaport", "Austria", null, "43485 Dee Village", null, null, "34063", null },
                    { 25, "Jacobsontown", "Samoa", null, "2771 Elise Via", null, null, "45714", null },
                    { 26, "South Cayla", "New Caledonia", null, "78936 Rosalinda Streets", null, null, "37763-1953", null },
                    { 27, "South Ernestina", "Belgium", null, "527 Brittany Islands", null, null, "08219", null },
                    { 28, "New Gina", "Iraq", null, "30373 Russel Forge", null, null, "03998-9026", null },
                    { 29, "Terranceton", "Spain", null, "737 Oswaldo Skyway", null, null, "19077-5114", null },
                    { 30, "Jonathanstad", "Cape Verde", null, "69898 Savion Mission", null, null, "34099", null },
                    { 31, "East Jerrod", "Madagascar", null, "70251 Josue Ferry", null, null, "38529-0059", null },
                    { 32, "Orlandberg", "Lithuania", null, "643 Dewayne Points", null, null, "31765", null },
                    { 33, "South Vedachester", "Bahamas", null, "7690 Jefferey Hills", null, null, "24117-2674", null },
                    { 34, "Volkmanburgh", "Guernsey", null, "61853 Kerluke Isle", null, null, "44744", null },
                    { 35, "South Jerrold", "Haiti", null, "903 Shayne Park", null, null, "05885-4857", null },
                    { 36, "North Bert", "Ethiopia", null, "175 Kaitlyn Walk", null, null, "76477", null },
                    { 37, "East Lilianeview", "Macedonia", null, "5663 Magdalena Meadows", null, null, "11585", null },
                    { 38, "West Jamesonbury", "Venezuela", null, "1548 Bradtke Burg", null, null, "35807", null },
                    { 39, "Drakeborough", "Egypt", null, "025 Baumbach Stream", null, null, "23920-9280", null },
                    { 40, "South Aubree", "Virgin Islands, British", null, "6327 Drake Parks", null, null, "16283", null },
                    { 41, "Port Curtland", "Central African Republic", null, "06864 Mitchell Prairie", null, null, "37125", null },
                    { 42, "Leuschkemouth", "Czech Republic", null, "054 Buckridge Curve", null, null, "13525", null },
                    { 43, "South Jarredfort", "Mexico", null, "3840 Greenholt Locks", null, null, "21387", null },
                    { 44, "Carolanneshire", "Greece", null, "21952 Kraig Island", null, null, "62119-6056", null },
                    { 45, "Harveychester", "China", null, "1916 Powlowski Street", null, null, "58787", null },
                    { 46, "Lake Turner", "Lesotho", null, "889 Sporer Course", null, null, "29653", null },
                    { 47, "Ryanbury", "Western Sahara", null, "791 Raymond Radial", null, null, "56648-3079", null },
                    { 48, "New Emmet", "Western Sahara", null, "20129 Prince Tunnel", null, null, "37235-4621", null },
                    { 49, "New Donnyshire", "French Guiana", null, "3414 Rodriguez Village", null, null, "10564-0533", null },
                    { 50, "Friesenburgh", "Myanmar", null, "251 Herta Haven", null, null, "76469", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "id",
                keyValue: 50);
        }
    }
}
