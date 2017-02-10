namespace Meeedium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateuser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Teaser = c.String(),
                        Body = c.String(),
                        Created = c.DateTime(nullable: false),
                        Public = c.Boolean(nullable: false),
                        OwnerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.OwnerId)
                .Index(t => t.OwnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "OwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.Blogs", new[] { "OwnerId" });
            DropTable("dbo.Blogs");
        }
    }
}
