namespace WpcabAdministration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "SpouseNameEn", c => c.String());
            AddColumn("dbo.Members", "SpouseNameBn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "SpouseNameBn");
            DropColumn("dbo.Members", "SpouseNameEn");
        }
    }
}
