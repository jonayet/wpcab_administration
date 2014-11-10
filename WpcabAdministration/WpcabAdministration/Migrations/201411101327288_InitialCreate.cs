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
                        PhotoFileName = c.String(),
                        NameEn = c.String(nullable: false),
                        NameBn = c.String(),
                        FatherNameEn = c.String(),
                        FatherNameBn = c.String(),
                        MotherNameEn = c.String(),
                        MotherNameBn = c.String(),
                        Gender = c.String(),
                        MaritalStatus = c.String(),
                        SpouseNameEn = c.String(),
                        SpouseNameBn = c.String(),
                        CareOfEn = c.String(),
                        CareOfBn = c.String(),
                        BloodGroup = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        IsPassed = c.Boolean(nullable: false),
                        DateOfPassing = c.DateTime(nullable: false),
                        NationalId = c.String(),
                        PresentAddress = c.String(),
                        Phone = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        VillageEn = c.String(),
                        VillageBn = c.String(),
                        PostOfficeEn = c.String(),
                        PostOfficeBn = c.String(),
                        PoliceStationEn = c.String(),
                        PoliceStationBn = c.String(),
                        DistrictEn = c.String(),
                        DistrictBn = c.String(),
                        CountryId = c.Int(nullable: false),
                        FormId = c.String(),
                        DateOfMembership = c.DateTime(nullable: false),
                        IsInactive = c.Boolean(nullable: false),
                        DateFromInactive = c.DateTime(nullable: false),
                        StartDateOfAccount = c.DateTime(nullable: false),
                        ReferralName = c.String(),
                        ReferralId = c.String(),
                        ZoneId = c.Int(nullable: false),
                        EducationalQualification = c.String(),
                        Relegion = c.String(),
                        SubRelegion = c.String(),
                        Nationality = c.String(),
                        Profession = c.String(),
                        Experience = c.String(),
                        MonthlyIncome = c.Int(nullable: false),
                        MonthlyExpense = c.Int(nullable: false),
                        NoOfFamilyMembers = c.Int(nullable: false),
                        FinancialStatus = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 8),
                        PasswordHash = c.String(nullable: false, maxLength: 8),
                        LastDateOfTransaction = c.DateTime(nullable: false),
                        LastUpdateBy = c.String(),
                        LastUpdateById = c.Int(nullable: false),
                        SignatureFilePath = c.String(),
                    })
                .PrimaryKey(t => t.MemberId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Zones", t => t.ZoneId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.ZoneId);
            
            CreateTable(
                "dbo.Relatives",
                c => new
                    {
                        RelativeId = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        NameEn = c.String(),
                        NameBn = c.String(),
                    })
                .PrimaryKey(t => t.RelativeId)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.Zones",
                c => new
                    {
                        ZoneId = c.Int(nullable: false, identity: true),
                        NameEn = c.String(),
                        NameBn = c.String(),
                    })
                .PrimaryKey(t => t.ZoneId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "ZoneId", "dbo.Zones");
            DropForeignKey("dbo.Relatives", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Members", "CountryId", "dbo.Countries");
            DropIndex("dbo.Relatives", new[] { "MemberId" });
            DropIndex("dbo.Members", new[] { "ZoneId" });
            DropIndex("dbo.Members", new[] { "CountryId" });
            DropTable("dbo.Villages");
            DropTable("dbo.PostOffices");
            DropTable("dbo.PoliceStations");
            DropTable("dbo.Zones");
            DropTable("dbo.Relatives");
            DropTable("dbo.Members");
            DropTable("dbo.Districts");
            DropTable("dbo.Countries");
        }
    }
}
