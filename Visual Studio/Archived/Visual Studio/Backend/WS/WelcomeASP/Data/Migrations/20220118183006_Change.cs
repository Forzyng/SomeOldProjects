using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WelcomeASP.Data.Migrations
{
    public partial class Change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "ImgUrl",
            //    table: "Boards",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.AddColumn<byte[]>(
            //    name: "Logo",
            //    table: "Boards",
            //    type: "varbinary(max)",
            //    nullable: true);
            
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardTags",
                columns: table => new
                {
                    BoardsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardTags", x => new { x.BoardsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_BoardTags_Boards_BoardsId",
                        column: x => x.BoardsId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoardTags_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardTags_TagsId",
                table: "BoardTags",
                column: "TagsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Boards");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Boards");
        }
    }
}
