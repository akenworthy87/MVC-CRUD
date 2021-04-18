using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCRUD.Migrations
{
    public partial class spGetIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetIssue]
                        @Id int
                    AS
                    BEGIN
                        SET NOCOUNT ON;
                        SELECT [Id]
                              ,[Name]
                              ,[Location]
                              ,[SeverityId]
                              ,[SubmittedDate]
                              ,[ResolvedDate]
                              ,[Description]
                              ,[Notes]
                              ,[Resolution]
                              ,[Resolved]
                        FROM [MVC_CRUDContext-1].[dbo].[Issue]
		                WHERE [ID] = @Id
                    END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
