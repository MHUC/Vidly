namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'75d7218d-3524-4116-a4f7-fbad5e6352e2', N'guest@vidly.com', 0, N'AOFroNqKt0Mujzqpz8+e3HZ10a1gT57nqwSBw5h1XM5N+vbRko2UeGlT4a9hdj7E8g==', N'70bde10c-78ce-4694-9b7a-d7d5a3535afa', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a19c7790-1355-4f5c-932b-4b4423f1ceb6', N'admin@vidly.com', 0, N'AJ465Mj8HQstF8xBfquBScUYAKPA/bGzEbFjJjsYB5z+6C1IGUILorMcRWT5ODZncg==', N'8e811c8f-ed7a-4842-af7f-a04c773c646b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a79657a8-f960-435d-92d7-14796fc52074', N'hammadmushk@gmail.com', 0, N'AC77j1i6FP++A8AV83/ihNatWQyTKN5zNFMjhCmMdfCxWoIEwBMIuwQYocTBChudgA==', N'4f96fa30-9b69-4326-bef9-83095c36df35', NULL, 0, 0, NULL, 1, 0, N'hammadmushk@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c802f5d0-d52f-4d30-a750-8ced26f89600', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a19c7790-1355-4f5c-932b-4b4423f1ceb6', N'c802f5d0-d52f-4d30-a750-8ced26f89600')


");
        }
        
        public override void Down()
        {
        }
    }
}
