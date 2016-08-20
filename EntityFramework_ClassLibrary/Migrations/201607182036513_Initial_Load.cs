namespace EntityFramework_ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Load : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PersonEntities");
        }
    }
}
