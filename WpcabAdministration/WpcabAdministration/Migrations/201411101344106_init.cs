namespace WpcabAdministration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "SignatureFileName", c => c.String());
            DropColumn("dbo.Members", "SignatureFilePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "SignatureFilePath", c => c.String());
            DropColumn("dbo.Members", "SignatureFileName");
        }
    }
}
