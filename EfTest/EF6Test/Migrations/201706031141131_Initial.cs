namespace EF6Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Driver",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        LicenseNumber = c.String(),
                        ExperienceFrom = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        DriverId = c.Long(nullable: false),
                        State = c.Long(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Driver", t => t.DriverId)
                .Index(t => t.DriverId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        GivenNames = c.String(),
                        FamilyName = c.String(maxLength: 150),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passenger",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        BirthDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Search",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        State = c.Long(nullable: false),
                        ModifiedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suggestion",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        SearchId = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        State = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Search", t => t.SearchId)
                .Index(t => t.SearchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suggestion", "SearchId", "dbo.Search");
            DropForeignKey("dbo.Passenger", "Id", "dbo.Person");
            DropForeignKey("dbo.Driver", "Id", "dbo.Person");
            DropForeignKey("dbo.Order", "DriverId", "dbo.Driver");
            DropIndex("dbo.Suggestion", new[] { "SearchId" });
            DropIndex("dbo.Passenger", new[] { "Id" });
            DropIndex("dbo.Order", new[] { "DriverId" });
            DropIndex("dbo.Driver", new[] { "Id" });
            DropTable("dbo.Suggestion");
            DropTable("dbo.Search");
            DropTable("dbo.Passenger");
            DropTable("dbo.Person");
            DropTable("dbo.Order");
            DropTable("dbo.Driver");
        }
    }
}
