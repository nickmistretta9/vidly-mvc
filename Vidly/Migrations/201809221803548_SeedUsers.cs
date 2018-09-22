namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e2f4cbbd-19e2-4eac-bf13-cb84cb1463cb', N'guest@vidly.com', 0, N'AFnYZDFiqojg6c/yejGAOudfkHXMMgM5TVjhoMpQi6ojjFsEyOUgDX4kvir2ZMUeJQ==', N'0c98a3c9-9b32-43d8-9516-089a29d9cbcd', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ede9cbdf-3d33-4deb-b6e4-d374cc5edead', N'admin@vidly.com', 0, N'AJKMFC/7ZTPYjhdHq8W8icFhjkVefiQVq3q2ST/dxDoYokVbAtmMiPehDLXJAHz5tg==', N'f6b50227-ce55-4872-a3d6-d355f1ef108c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'57085068-cef1-4259-9bc1-c462b221110c', N'CanManageMovies')
                  
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ede9cbdf-3d33-4deb-b6e4-d374cc5edead', N'57085068-cef1-4259-9bc1-c462b221110c')
               ");
        }
        
        public override void Down()
        {
        }
    }
}
