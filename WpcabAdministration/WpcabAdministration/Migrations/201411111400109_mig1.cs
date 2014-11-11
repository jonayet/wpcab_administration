namespace WpcabAdministration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "DataFromKhedmatStarts", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "DateOfLastMonthlyKhedmat", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "DateOfLastUpdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "LastUpdateBy", c => c.String());
            AddColumn("dbo.Members", "LastUpdateById", c => c.Int(nullable: false));
            DropColumn("dbo.Members", "StartDateOfAccount");
            DropColumn("dbo.Members", "LastDateOfMonthlyKhedmat");
            DropColumn("dbo.Members", "LastDateOfUpdate");
            DropColumn("dbo.Members", "UpdatedBy");
            DropColumn("dbo.Members", "UpdateById");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "UpdateById", c => c.Int(nullable: false));
            AddColumn("dbo.Members", "UpdatedBy", c => c.String());
            AddColumn("dbo.Members", "LastDateOfUpdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "LastDateOfMonthlyKhedmat", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "StartDateOfAccount", c => c.DateTime(nullable: false));
            DropColumn("dbo.Members", "LastUpdateById");
            DropColumn("dbo.Members", "LastUpdateBy");
            DropColumn("dbo.Members", "DateOfLastUpdate");
            DropColumn("dbo.Members", "DateOfLastMonthlyKhedmat");
            DropColumn("dbo.Members", "DataFromKhedmatStarts");
        }
    }
}
