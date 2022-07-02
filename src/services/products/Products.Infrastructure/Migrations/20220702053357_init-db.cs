using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    ParentCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Link = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    BannerUrl = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValue: "https://via.placeholder.com/500x100.png"),
                    IconUrl = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, defaultValue: "https://via.placeholder.com/100.png"),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 715, DateTimeKind.Utc).AddTicks(46)),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 715, DateTimeKind.Utc).AddTicks(133))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Link = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/150x150.png"),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 714, DateTimeKind.Utc).AddTicks(9371)),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2022, 7, 2, 5, 33, 57, 714, DateTimeKind.Utc).AddTicks(9505))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "BannerUrl", "Description", "Link", "ParentCategoryId", "Priority", "Title" },
                values: new object[,]
                {
                    { 1, false, "https://via.placeholder.com/500x200.png", "Aliqua consequat labore elit eiusmod nostrud laborum consequat. Consectetur laborum adipisicing duis ad nulla enim. Esse magna adipisicing fugiat aliqua ea commodo quis anim laboris aliqua fugiat ad. Dolore elit pariatur qui excepteur culpa sit aliqua ea Lorem. Sunt laborum ut sunt cillum reprehenderit do qui nisi.\r\n", "qui", null, 1, "veniam" },
                    { 2, false, "https://via.placeholder.com/500x200.png", "Ut laborum ex laboris do anim adipisicing in adipisicing ea aliquip. In incididunt occaecat do incididunt id sunt eiusmod ut ipsum veniam cupidatat ullamco. Amet non aute cupidatat duis veniam veniam proident in.\r\n", "magna", null, 5, "proident" },
                    { 3, true, "https://via.placeholder.com/500x200.png", "Fugiat dolor qui duis non enim cupidatat eu exercitation Lorem non commodo incididunt ullamco commodo. In tempor ad cillum ad. Id elit aute fugiat nulla pariatur laborum. Nisi sit eiusmod do laborum ex officia duis Lorem aliqua. Tempor magna ipsum nostrud amet labore.\r\n", "eiusmod", null, 2, "sunt" },
                    { 4, true, "https://via.placeholder.com/500x200.png", "Consectetur adipisicing ex pariatur ex aliquip eu occaecat nulla est. Nostrud voluptate mollit ad duis nulla ullamco laboris. Cillum quis qui minim veniam amet ad laboris exercitation amet. Et cillum fugiat officia in labore aliquip tempor occaecat. Anim ut fugiat nisi sit enim. Adipisicing consectetur elit non eu adipisicing.\r\n", "voluptate", null, 7, "aute" },
                    { 5, false, "https://via.placeholder.com/500x200.png", "Anim amet esse adipisicing ut nostrud Lorem exercitation anim anim. Excepteur aliqua qui eu sint cillum consequat quis irure. Dolor amet reprehenderit nulla sunt velit occaecat est. Nisi ut ipsum pariatur reprehenderit.\r\n", "qui", null, 9, "occaecat" },
                    { 6, false, "https://via.placeholder.com/500x200.png", "Aliquip quis aute occaecat proident magna et excepteur. Consectetur magna ut Lorem ut excepteur labore ipsum. Laborum veniam do sunt cupidatat anim mollit exercitation esse consequat excepteur duis excepteur.\r\n", "ipsum", null, 4, "do" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "BannerUrl", "Description", "Link", "ParentCategoryId", "Priority", "Title" },
                values: new object[,]
                {
                    { 7, true, "https://via.placeholder.com/500x200.png", "Amet tempor ex fugiat velit aliquip id commodo eiusmod ad eiusmod aute anim. Exercitation incididunt est duis esse ex Lorem ea nulla anim est labore cupidatat aute. Ea ipsum id reprehenderit esse veniam velit magna aute laboris consectetur tempor occaecat. Incididunt officia laborum incididunt laboris.\r\n", "enim", 2, 10, "laborum" },
                    { 8, false, "https://via.placeholder.com/500x200.png", "Lorem ipsum deserunt pariatur sunt incididunt reprehenderit enim et consectetur nulla sunt. Officia eiusmod culpa deserunt non aliquip laboris in laborum ullamco est dolore in esse. Aliquip qui dolor in irure excepteur et sunt ea duis proident aliqua adipisicing sint. Mollit sit et do excepteur.\r\n", "do", 2, 7, "tempor" },
                    { 9, false, "https://via.placeholder.com/500x200.png", "Lorem ipsum deserunt pariatur sunt incididunt reprehenderit enim et consectetur nulla sunt. Officia eiusmod culpa deserunt non aliquip laboris in laborum ullamco est dolore in esse. Aliquip qui dolor in irure excepteur et sunt ea duis proident aliqua adipisicing sint. Mollit sit et do excepteur.\r\n", "do", 2, 7, "consectetur" },
                    { 10, false, "https://via.placeholder.com/500x200.png", "Lorem ipsum deserunt pariatur sunt incididunt reprehenderit enim et consectetur nulla sunt. Officia eiusmod culpa deserunt non aliquip laboris in laborum ullamco est dolore in esse. Aliquip qui dolor in irure excepteur et sunt ea duis proident aliqua adipisicing sint. Mollit sit et do excepteur.\r\n", "do", 3, 7, "Non commodo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
