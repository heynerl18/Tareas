using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMCV.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF NOT EXISTS (Select Id from AspNetRoles Where Id = '5cd41f78-f5b7-42d7-a9c8-7f09c44b6aca')
                BEGIN
	                INSERT AspNetRoles (Id, [Name], [NormalizedName])
	                VALUES ('5cd41f78-f5b7-42d7-a9c8-7f09c44b6aca', 'admin', 'ADMIN')
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles Where Id = '5cd41f78-f5b7-42d7-a9c8-7f09c44b6aca'");
        }
    }
}
