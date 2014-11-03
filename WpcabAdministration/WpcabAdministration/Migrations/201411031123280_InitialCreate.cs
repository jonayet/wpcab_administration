namespace WpcabAdministration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictId = c.Int(nullable: false, identity: true),
                        NameEn = c.String(),
                        NameBn = c.String(),
                    })
                .PrimaryKey(t => t.DistrictId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        FormId = c.String(),
                        NameEn = c.String(nullable: false),
                        NameBn = c.String(),
                        FatherNameEn = c.String(),
                        FatherNameBn = c.String(),
                        MotherNameEn = c.String(),
                        MotherNameBn = c.String(),
                        Gender = c.String(),
                        MaritalStatus = c.String(),
                        BloodGroup = c.String(),
                        Photo = c.String(),
                        SignatureImage = c.String(),
                        PhoneNumber = c.String(),
                        MobileNumber = c.String(),
                        Email = c.String(),
                        NationalId = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateOfMembership = c.DateTime(nullable: false),
                        StartDateOfAccount = c.DateTime(nullable: false),
                        EducationalQualification = c.String(),
                        Profession = c.String(),
                        Experience = c.String(),
                        MonthlyIncome = c.Int(nullable: false),
                        MonthlyExpense = c.Int(nullable: false),
                        NoOfFamilyMember = c.Int(nullable: false),
                        FinancialStatus = c.Int(nullable: false),
                        Relegion = c.String(),
                        IsPassed = c.Boolean(nullable: false),
                        DateOfPassing = c.DateTime(nullable: false),
                        IsInactive = c.Boolean(nullable: false),
                        DateOfInactive = c.DateTime(nullable: false),
                        ReferralId = c.String(),
                        VillageId = c.Int(nullable: false),
                        PostOfficeId = c.Int(nullable: false),
                        PoliceStationId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        ZoneId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        Nationality = c.String(),
                        UserName = c.String(nullable: false, maxLength: 8),
                        Password = c.String(nullable: false, maxLength: 8),
                        Referral_MemberId = c.Int(),
                    })
                .PrimaryKey(t => t.MemberId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Districts", t => t.DistrictId, cascadeDelete: true)
                .ForeignKey("dbo.PoliceStations", t => t.PoliceStationId, cascadeDelete: true)
                .ForeignKey("dbo.PostOffices", t => t.PostOfficeId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.Referral_MemberId)
                .ForeignKey("dbo.Villages", t => t.VillageId, cascadeDelete: true)
                .ForeignKey("dbo.Zones", t => t.ZoneId, cascadeDelete: true)
                .Index(t => t.VillageId)
                .Index(t => t.PostOfficeId)
                .Index(t => t.PoliceStationId)
                .Index(t => t.DistrictId)
                .Index(t => t.ZoneId)
                .Index(t => t.CountryId)
                .Index(t => t.Referral_MemberId);
            
            CreateTable(
                "dbo.PoliceStations",
                c => new
                    {
                        PoliceStationId = c.Int(nullable: false, identity: true),
                        NameEn = c.String(),
                        NameBn = c.String(),
                    })
                .PrimaryKey(t => t.PoliceStationId);
            
            CreateTable(
                "dbo.PostOffices",
                c => new
                    {
                        PostOfficeId = c.Int(nullable: false, identity: true),
                        NameEn = c.String(),
                        NameBn = c.String(),
                    })
                .PrimaryKey(t => t.PostOfficeId);
            
            CreateTable(
                "dbo.Villages",
                c => new
                    {
                        VillageId = c.Int(nullable: false, identity: true),
                        NameEn = c.String(),
                        NameBn = c.String(),
                    })
                .PrimaryKey(t => t.VillageId);
            
            CreateTable(
                "dbo.Zones",
                c => new
                    {
                        ZoneId = c.Int(nullable: false, identity: true),
                        NameEn = c.String(),
                        NameBn = c.String(),
                    })
                .PrimaryKey(t => t.ZoneId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "ZoneId", "dbo.Zones");
            DropForeignKey("dbo.Members", "VillageId", "dbo.Villages");
            DropForeignKey("dbo.Members", "Referral_MemberId", "dbo.Members");
            DropForeignKey("dbo.Members", "PostOfficeId", "dbo.PostOffices");
            DropForeignKey("dbo.Members", "PoliceStationId", "dbo.PoliceStations");
            DropForeignKey("dbo.Members", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Members", "CountryId", "dbo.Countries");
            DropIndex("dbo.Members", new[] { "Referral_MemberId" });
            DropIndex("dbo.Members", new[] { "CountryId" });
            DropIndex("dbo.Members", new[] { "ZoneId" });
            DropIndex("dbo.Members", new[] { "DistrictId" });
            DropIndex("dbo.Members", new[] { "PoliceStationId" });
            DropIndex("dbo.Members", new[] { "PostOfficeId" });
            DropIndex("dbo.Members", new[] { "VillageId" });
            DropTable("dbo.Zones");
            DropTable("dbo.Villages");
            DropTable("dbo.PostOffices");
            DropTable("dbo.PoliceStations");
            DropTable("dbo.Members");
            DropTable("dbo.Districts");
            DropTable("dbo.Countries");
        }
    }
}
