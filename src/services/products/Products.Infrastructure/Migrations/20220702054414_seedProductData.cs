using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    public partial class seedProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 2, 5, 44, 14, 733, DateTimeKind.Utc).AddTicks(9853),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 714, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 2, 5, 44, 14, 733, DateTimeKind.Utc).AddTicks(9700),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 714, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 2, 5, 44, 14, 734, DateTimeKind.Utc).AddTicks(3124),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 715, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 2, 5, 44, 14, 734, DateTimeKind.Utc).AddTicks(3013),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 715, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CategoryId", "Code", "Description", "ImageUrl", "Link", "Price", "Title" },
                values: new object[,]
                {
                    { 2630, true, 2, "adipisicing", "Sint culpa culpa reprehenderit dolore ad sit quis reprehenderit eiusmod consectetur eiusmod dolor nulla. Ullamco ut commodo Lorem labore ad ex officia esse cupidatat nostrud proident pariatur laboris. Nisi esse sint fugiat nulla do mollit elit aliqua in.\r\n", "https://via.placeholder.com/300x250.png", "ullamco", 335m, "sint cupidatat deserunt" },
                    { 3269, true, 5, "sint", "Aliquip consequat aliquip mollit nostrud ut minim elit id in voluptate quis voluptate quis. Elit reprehenderit nisi elit dolor cupidatat deserunt anim. Fugiat incididunt nulla laboris reprehenderit proident id reprehenderit laborum reprehenderit pariatur ea fugiat.\r\n", "https://via.placeholder.com/300x250.png", "labore", 790m, "aliquip nulla nulla" },
                    { 3641, true, 6, "veniam", "Nisi tempor excepteur labore cillum consequat esse laboris cupidatat laboris. Eiusmod ut sit ex est. Velit eu nisi Lorem nisi sunt pariatur tempor enim deserunt.\r\n", "https://via.placeholder.com/300x250.png", "mollit", 815m, "Lorem elit nostrud" },
                    { 6342, false, 5, "ipsum", "Occaecat elit occaecat quis fugiat consequat elit non consequat culpa laborum veniam nulla. Ex exercitation excepteur occaecat nulla incididunt veniam anim cupidatat sunt id consectetur. Sunt occaecat consequat cupidatat laborum cupidatat.\r\n", "https://via.placeholder.com/300x250.png", "ipsum", 162m, "nostrud Lorem voluptate" },
                    { 7139, false, 1, "consequat", "Tempor elit cillum tempor ea amet cupidatat cupidatat velit elit incididunt enim aliquip. Sunt ex dolor ipsum tempor aliqua laborum anim nisi veniam aliqua eu. Ut mollit fugiat dolor dolor eu proident qui ea amet in mollit ea in. Magna quis ex consectetur quis ex in magna excepteur voluptate ea aute labore incididunt. Qui aliquip culpa sint dolor ut cupidatat exercitation dolor nostrud minim eu tempor. Cupidatat cupidatat adipisicing laborum ea qui aute qui dolore sint in velit pariatur officia. Adipisicing et cillum aliqua nulla voluptate duis non tempor quis duis sunt ex.\r\n", "https://via.placeholder.com/300x250.png", "exercitation", 980m, "ea laborum duis" },
                    { 7304, true, 1, "consequat", "Consectetur occaecat non aliquip amet cillum. Excepteur cupidatat pariatur magna commodo laboris consectetur labore minim adipisicing non. Amet cillum consectetur in aute nulla consectetur minim qui. Aute deserunt et ad duis nisi mollit sunt consectetur ut. Eu quis dolore magna aute et ullamco occaecat non commodo ullamco. Elit do amet nostrud exercitation reprehenderit ut excepteur magna est aliqua.\r\n", "https://via.placeholder.com/300x250.png", "ea", 644m, "commodo laborum incididunt" },
                    { 7399, false, 6, "dolor", "Veniam non occaecat elit occaecat ut ea labore nostrud eu eiusmod ipsum. Aliqua anim irure est qui mollit pariatur deserunt non tempor. Laborum veniam esse ad nulla officia deserunt veniam. Ex culpa in non consequat irure.\r\n", "https://via.placeholder.com/300x250.png", "Lorem", 503m, "deserunt quis cupidatat" },
                    { 7504, true, 4, "ipsum", "Culpa commodo irure aute dolor minim sit adipisicing. Ea culpa dolore velit pariatur adipisicing ad consectetur consequat ut. Ex cillum esse esse enim deserunt do non quis consectetur laborum amet sit incididunt sunt. Reprehenderit et amet non aliqua deserunt consequat ullamco consectetur consectetur tempor aliquip cillum dolore.\r\n", "https://via.placeholder.com/300x250.png", "ut", 856m, "ea cillum nisi" },
                    { 9859, false, 6, "qui", "Amet sint nostrud nisi commodo tempor dolore proident non ullamco. Anim tempor Lorem magna officia irure exercitation Lorem Lorem id. Sunt consequat cillum eu deserunt consequat velit consectetur irure incididunt aliquip mollit elit culpa duis. Cupidatat consectetur aute officia incididunt elit sunt pariatur cillum occaecat velit qui qui ut est. Dolor est commodo laboris irure quis excepteur pariatur ad id exercitation labore. Eu non dolor in aliqua consequat dolor consequat excepteur magna minim aliquip magna. Proident consequat sint ad eiusmod elit dolore et velit.\r\n", "https://via.placeholder.com/300x250.png", "labore", 123m, "reprehenderit officia fugiat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2630);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3269);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3641);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7304);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7504);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9859);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 714, DateTimeKind.Utc).AddTicks(9505),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 7, 2, 5, 44, 14, 733, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 714, DateTimeKind.Utc).AddTicks(9371),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 7, 2, 5, 44, 14, 733, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 715, DateTimeKind.Utc).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 7, 2, 5, 44, 14, 734, DateTimeKind.Utc).AddTicks(3124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 715, DateTimeKind.Utc).AddTicks(46),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 7, 2, 5, 44, 14, 734, DateTimeKind.Utc).AddTicks(3013));
        }
    }
}
