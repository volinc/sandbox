namespace EF6Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AggregatorOrder",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CompanyId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        PassengerId = c.Long(nullable: false),
                        State = c.Long(nullable: false),
                        ModifiedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        ShiftId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Passenger", t => t.PassengerId)
                .ForeignKey("dbo.Shift", t => t.ShiftId)
                .Index(t => t.PassengerId)
                .Index(t => t.ShiftId);
            
            CreateTable(
                "dbo.Passenger",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        BirthDate = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        GivenNames = c.String(),
                        FamilyName = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shift",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        VehicleId = c.Guid(nullable: false),
                        DriverId = c.Long(nullable: false),
                        State = c.Long(nullable: false),
                        OpenedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        ClosedAt = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Driver", t => t.DriverId)
                .ForeignKey("dbo.Vehicle", t => t.VehicleId)
                .Index(t => t.VehicleId)
                .Index(t => t.DriverId);
            
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
                "dbo.DriverVehicle",
                c => new
                    {
                        DriverId = c.Long(nullable: false),
                        VehicleId = c.Guid(nullable: false),
                        DriverData_Id = c.Long(),
                        VehicleData_Id = c.Guid(),
                    })
                .PrimaryKey(t => new { t.DriverId, t.VehicleId })
                .ForeignKey("dbo.Driver", t => t.DriverData_Id)
                .ForeignKey("dbo.Vehicle", t => t.VehicleData_Id)
                .Index(t => t.DriverData_Id)
                .Index(t => t.VehicleData_Id);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        RegistrationNumber = c.String(nullable: false),
                        Vin = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suggestion",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        OrderId = c.Guid(nullable: false),
                        ShiftId = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        State = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.OrderId)
                .ForeignKey("dbo.Shift", t => t.ShiftId)
                .Index(t => t.OrderId)
                .Index(t => t.ShiftId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AggregatorOrder", "Id", "dbo.Order");
            DropForeignKey("dbo.Suggestion", "ShiftId", "dbo.Shift");
            DropForeignKey("dbo.Suggestion", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Order", "ShiftId", "dbo.Shift");
            DropForeignKey("dbo.Shift", "VehicleId", "dbo.Vehicle");
            DropForeignKey("dbo.DriverVehicle", "VehicleData_Id", "dbo.Vehicle");
            DropForeignKey("dbo.Shift", "DriverId", "dbo.Driver");
            DropForeignKey("dbo.Driver", "Id", "dbo.Person");
            DropForeignKey("dbo.DriverVehicle", "DriverData_Id", "dbo.Driver");
            DropForeignKey("dbo.Order", "PassengerId", "dbo.Passenger");
            DropForeignKey("dbo.Passenger", "Id", "dbo.Person");
            DropIndex("dbo.Suggestion", new[] { "ShiftId" });
            DropIndex("dbo.Suggestion", new[] { "OrderId" });
            DropIndex("dbo.DriverVehicle", new[] { "VehicleData_Id" });
            DropIndex("dbo.DriverVehicle", new[] { "DriverData_Id" });
            DropIndex("dbo.Driver", new[] { "Id" });
            DropIndex("dbo.Shift", new[] { "DriverId" });
            DropIndex("dbo.Shift", new[] { "VehicleId" });
            DropIndex("dbo.Passenger", new[] { "Id" });
            DropIndex("dbo.Order", new[] { "ShiftId" });
            DropIndex("dbo.Order", new[] { "PassengerId" });
            DropIndex("dbo.AggregatorOrder", new[] { "Id" });
            DropTable("dbo.Suggestion");
            DropTable("dbo.Vehicle");
            DropTable("dbo.DriverVehicle");
            DropTable("dbo.Driver");
            DropTable("dbo.Shift");
            DropTable("dbo.Person");
            DropTable("dbo.Passenger");
            DropTable("dbo.Order");
            DropTable("dbo.AggregatorOrder");
        }
    }
}
