using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCRUD.Migrations
{
    public partial class spGetSeverity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetSeverity]
                        @Id int
                    AS
                    BEGIN
                        SET NOCOUNT ON;
                        SELECT [Id]
                              ,[SeverityName]
                        FROM [MVC_CRUDContext-1].[dbo].[Severity]
		                WHERE [ID] = @Id
                    END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
