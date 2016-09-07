namespace EntityFramework_ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        PersonEntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonEntities", t => t.PersonEntityId, cascadeDelete: true)
                .Index(t => t.PersonEntityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserEntities", "PersonEntityId", "dbo.PersonEntities");
            DropIndex("dbo.UserEntities", new[] { "PersonEntityId" });
            DropTable("dbo.UserEntities");
        }
    }
}
