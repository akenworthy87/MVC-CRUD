using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCRUD.Migrations
{
    public partial class spInsertIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[InsertIssue]
                        @Name nvarchar(50)
                        ,@Location nvarchar(50)
                        ,@SeverityId int
                        ,@Description nvarchar(512)
                        ,@Notes nvarchar(512)
                        ,@Resolution nvarchar(512)
                        ,@Resolved bit
                    AS
                    BEGIN
                        DECLARE @SubmittedDate datetime2(7)
								,@ResolvedDate datetime2(7)
                        SET NOCOUNT ON;
                        SET @SubmittedDate = GETDATE();
                        IF (@Resolved = 1) SET @ResolvedDate = GETDATE();
	

                        INSERT INTO [dbo].[Issue]
                                   ([Name]
                                   ,[Location]
                                   ,[SeverityId]
                                   ,[SubmittedDate]
                                   ,[ResolvedDate]
                                   ,[Description]
                                   ,[Notes]
                                   ,[Resolution]
                                   ,[Resolved])
                             VALUES
                                   (@Name
			                        ,@Location
			                        ,@SeverityId
			                        ,@SubmittedDate
			                        ,@ResolvedDate
			                        ,@Description
			                        ,@Notes
			                        ,@Resolution
			                        ,@Resolved)
                    END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
