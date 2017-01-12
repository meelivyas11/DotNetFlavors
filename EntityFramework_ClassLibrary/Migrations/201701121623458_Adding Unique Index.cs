namespace EntityFramework_ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUniqueIndex : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserEntities", "UserName", c => c.String(maxLength: 20));
            CreateIndex("dbo.UserEntities", "UserName", unique: true, name: "UserNameIndex");
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserEntities", "UserNameIndex");
            AlterColumn("dbo.UserEntities", "UserName", c => c.String());
        }
    }
}
