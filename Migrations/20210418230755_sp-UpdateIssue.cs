using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCRUD.Migrations
{
    public partial class spUpdateIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[UpdateIssue]
                        @Name nvarchar(50)
                        ,@Location nvarchar(50)
                        ,@SeverityId int
                        ,@Description nvarchar(512)
                        ,@Notes nvarchar(512)
                        ,@Resolution nvarchar(512)
                        ,@Resolved bit
                        ,@Id int
                    AS
                    BEGIN
                        DECLARE @ResolvedDate datetime2(7)

                        IF (@Resolved = 1) 
	                        SET @ResolvedDate = GETDATE();
                        ELSE
	                        SET @ResolvedDate = NULL;

                        UPDATE [dbo].[Issue]
                           SET [Name] = @Name
                              ,[Location] = @Location
                              ,[SeverityId] = @SeverityId
                              ,[ResolvedDate] = @ResolvedDate
                              ,[Description] = @Description
                              ,[Notes] = @Notes
                              ,[Resolution] = @Resolution
                              ,[Resolved] = @Resolved
                         WHERE [Id] = @Id
                    END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
