using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCRUD.Migrations
{
    public partial class spGetAllSeverities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetAllSeverities]
                    AS
                    BEGIN
                        SET NOCOUNT ON;
                        SELECT [Id]
                              ,[SeverityName]
                        FROM [MVC_CRUDContext-1].[dbo].[Severity]
                    END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
