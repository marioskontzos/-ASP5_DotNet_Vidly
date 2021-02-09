namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1e0b1ae9-0021-45cd-9668-ce853d8dc9de', N'admin@vidly.com', 0, N'AMFT/l+BLbakXYy8U72hGv14bDt7IVrehwU2uwvLKslKFtfpOPGqowmJjgQ6jbvxdQ==', N'f2e8da67-f6b4-410a-b0a1-ad7da21f794a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'40df5b50-827e-4ed3-b3e3-7b9506c57c80', N'guest@vidly.com', 0, N'AFGQZhVPJu1p25IoPy5yJnkaDVkoKtdiQAgd+mXtiyAbmzcgCEjjSauyExPhN/FV6g==', N'00f376a0-edf0-4f1c-94a3-6abd36a7649c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5efd7d74-cf6f-4644-a3ae-ba617090de4e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1e0b1ae9-0021-45cd-9668-ce853d8dc9de', N'5efd7d74-cf6f-4644-a3ae-ba617090de4e')
");
        }
        
        public override void Down()
        {
        }
    }
}
