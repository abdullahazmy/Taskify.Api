using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taskify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModifyDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_TaskItem_TaskItemId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItem_AspNetUsers_AssignedToUserId",
                table: "TaskItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItem_Project_ProjectId",
                table: "TaskItem");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProject_AspNetUsers_UserId",
                table: "UserProject");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProject_Project_ProjectId",
                table: "UserProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProject",
                table: "UserProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskItem",
                table: "TaskItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21d95f32-4d0c-4584-92e3-ff3adfeee763");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a0488cc-5ca7-4913-9278-2a26a1b16c60");

            migrationBuilder.RenameTable(
                name: "UserProject",
                newName: "UserProjects");

            migrationBuilder.RenameTable(
                name: "TaskItem",
                newName: "TaskItems");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_UserProject_ProjectId",
                table: "UserProjects",
                newName: "IX_UserProjects_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskItem_ProjectId",
                table: "TaskItems",
                newName: "IX_TaskItems_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskItem_AssignedToUserId",
                table: "TaskItems",
                newName: "IX_TaskItems_AssignedToUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_TaskItemId",
                table: "Comments",
                newName: "IX_Comments_TaskItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProjects",
                table: "UserProjects",
                columns: new[] { "UserId", "ProjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskItems",
                table: "TaskItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b9da746d-30ba-491b-9ef0-ed6ed0598b6e", "2", "User", "User" },
                    { "e9dfb94e-326c-4d90-be37-137ff911203d", "1", "Admin", "Admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_TaskItems_TaskItemId",
                table: "Comments",
                column: "TaskItemId",
                principalTable: "TaskItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_AspNetUsers_AssignedToUserId",
                table: "TaskItems",
                column: "AssignedToUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Projects_ProjectId",
                table: "TaskItems",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjects_AspNetUsers_UserId",
                table: "UserProjects",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjects_Projects_ProjectId",
                table: "UserProjects",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_TaskItems_TaskItemId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_AspNetUsers_AssignedToUserId",
                table: "TaskItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Projects_ProjectId",
                table: "TaskItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjects_AspNetUsers_UserId",
                table: "UserProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjects_Projects_ProjectId",
                table: "UserProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProjects",
                table: "UserProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskItems",
                table: "TaskItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9da746d-30ba-491b-9ef0-ed6ed0598b6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9dfb94e-326c-4d90-be37-137ff911203d");

            migrationBuilder.RenameTable(
                name: "UserProjects",
                newName: "UserProject");

            migrationBuilder.RenameTable(
                name: "TaskItems",
                newName: "TaskItem");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_UserProjects_ProjectId",
                table: "UserProject",
                newName: "IX_UserProject_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskItems_ProjectId",
                table: "TaskItem",
                newName: "IX_TaskItem_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskItems_AssignedToUserId",
                table: "TaskItem",
                newName: "IX_TaskItem_AssignedToUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comment",
                newName: "IX_Comment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_TaskItemId",
                table: "Comment",
                newName: "IX_Comment_TaskItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProject",
                table: "UserProject",
                columns: new[] { "UserId", "ProjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskItem",
                table: "TaskItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21d95f32-4d0c-4584-92e3-ff3adfeee763", "2", "User", "User" },
                    { "5a0488cc-5ca7-4913-9278-2a26a1b16c60", "1", "Admin", "Admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_TaskItem_TaskItemId",
                table: "Comment",
                column: "TaskItemId",
                principalTable: "TaskItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItem_AspNetUsers_AssignedToUserId",
                table: "TaskItem",
                column: "AssignedToUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItem_Project_ProjectId",
                table: "TaskItem",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_AspNetUsers_UserId",
                table: "UserProject",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_Project_ProjectId",
                table: "UserProject",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
