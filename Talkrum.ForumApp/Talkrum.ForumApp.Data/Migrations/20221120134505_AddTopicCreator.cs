using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Talkrum.ForumApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTopicCreator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_AspNetUsers_ApplicationUserId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_ApplicationUserId",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Interactions");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Topics",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Interactions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_AuthorId",
                table: "Interactions",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_AspNetUsers_AuthorId",
                table: "Interactions",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_AspNetUsers_AuthorId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_AuthorId",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Interactions");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Topics",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Interactions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_ApplicationUserId",
                table: "Interactions",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_AspNetUsers_ApplicationUserId",
                table: "Interactions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
