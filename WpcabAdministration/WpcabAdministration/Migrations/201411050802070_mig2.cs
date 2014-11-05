namespace WpcabAdministration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "DateFromInactive", c => c.DateTime(nullable: false));
            DropColumn("dbo.Members", "DateOfInactive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "DateOfInactive", c => c.DateTime(nullable: false));
            DropColumn("dbo.Members", "DateFromInactive");
        }
    }
}
