using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleCodeFirstEF.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTasks_StatusCode_StatusCodeCode",
                table: "UserTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusCode",
                table: "StatusCode");

            migrationBuilder.RenameTable(
                name: "StatusCode",
                newName: "StatusCodes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusCodes",
                table: "StatusCodes",
                column: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTasks_StatusCodes_StatusCodeCode",
                table: "UserTasks",
                column: "StatusCodeCode",
                principalTable: "StatusCodes",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTasks_StatusCodes_StatusCodeCode",
                table: "UserTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusCodes",
                table: "StatusCodes");

            migrationBuilder.RenameTable(
                name: "StatusCodes",
                newName: "StatusCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusCode",
                table: "StatusCode",
                column: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTasks_StatusCode_StatusCodeCode",
                table: "UserTasks",
                column: "StatusCodeCode",
                principalTable: "StatusCode",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
