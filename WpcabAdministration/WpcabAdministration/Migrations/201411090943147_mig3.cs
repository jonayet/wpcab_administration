namespace WpcabAdministration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "PresentAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "PresentAddress");
        }
    }
}
