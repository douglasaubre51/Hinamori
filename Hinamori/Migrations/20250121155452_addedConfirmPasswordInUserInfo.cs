using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hinamori.Migrations
{
    /// <inheritdoc />
    public partial class addedConfirmPasswordInUserInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "UserInfos");
        }
    }
}
