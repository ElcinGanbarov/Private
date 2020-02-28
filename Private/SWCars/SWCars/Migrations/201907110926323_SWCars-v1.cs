namespace SWCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SWCarsv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Bancode = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        CarNo = c.String(maxLength: 12, unicode: false),
                        ProductionDate = c.DateTime(nullable: false),
                        CarTypeId = c.Int(nullable: false),
                        OilTypeId = c.Int(nullable: false),
                        EditedBy = c.String(nullable: false, maxLength: 30),
                        Remark = c.String(maxLength: 300),
                        EditDay = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Bancode)
                .ForeignKey("dbo.CarModels", t => t.ModelId, cascadeDelete: true)
                .ForeignKey("dbo.CarTypes", t => t.CarTypeId, cascadeDelete: true)
                .Index(t => t.ModelId)
                .Index(t => t.CarTypeId);
            
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarkaId = c.Int(nullable: false),
                        Model = c.String(nullable: false, maxLength: 20, unicode: false),
                        EditedBy = c.String(nullable: false, maxLength: 30),
                        Remark = c.String(maxLength: 300),
                        EditDay = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarMarkas", t => t.MarkaId, cascadeDelete: true)
                .Index(t => t.MarkaId);
            
            CreateTable(
                "dbo.CarMarkas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marka = c.String(nullable: false, maxLength: 20, unicode: false),
                        EditedBy = c.String(nullable: false, maxLength: 30),
                        Remark = c.String(maxLength: 300),
                        EditDay = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarsOils",
                c => new
                    {
                        Bancode = c.Int(nullable: false),
                        OilTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Bancode, t.OilTypeId })
                .ForeignKey("dbo.Cars", t => t.Bancode, cascadeDelete: true)
                .ForeignKey("dbo.OilTypes", t => t.OilTypeId, cascadeDelete: true)
                .Index(t => t.Bancode)
                .Index(t => t.OilTypeId);
            
            CreateTable(
                "dbo.OilTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OilTypeName = c.String(nullable: false, maxLength: 20, unicode: false),
                        OilTypeSpesificName = c.String(maxLength: 20, unicode: false),
                        EditedBy = c.String(nullable: false, maxLength: 30),
                        Remark = c.String(maxLength: 300),
                        EditDay = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OilFillings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Yurus = c.Int(nullable: false),
                        Litr = c.Int(nullable: false),
                        OilTypeId = c.Int(nullable: false),
                        Carid = c.Int(nullable: false),
                        EditedBy = c.String(nullable: false, maxLength: 30),
                        Remark = c.String(maxLength: 300),
                        EditDay = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Carid, cascadeDelete: true)
                .ForeignKey("dbo.OilTypes", t => t.OilTypeId, cascadeDelete: true)
                .Index(t => t.OilTypeId)
                .Index(t => t.Carid);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarTypeName = c.String(nullable: false, maxLength: 50),
                        EditedBy = c.String(nullable: false, maxLength: 30),
                        Remark = c.String(maxLength: 300),
                        EditDay = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Masters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MasterName = c.String(nullable: false, maxLength: 30),
                        EditedBy = c.String(),
                        Remark = c.String(),
                        EditDay = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        EndDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        DetalId = c.Int(nullable: false),
                        MasterId = c.Int(nullable: false),
                        EditedBy = c.String(nullable: false, maxLength: 30),
                        Remark = c.String(maxLength: 300),
                        EditDay = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Masters", t => t.MasterId, cascadeDelete: true)
                .ForeignKey("dbo.SpareParts", t => t.DetalId, cascadeDelete: true)
                .Index(t => t.DetalId)
                .Index(t => t.MasterId);
            
            CreateTable(
                "dbo.SpareParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartName = c.String(nullable: false, maxLength: 30),
                        DetailCount = c.Int(nullable: false),
                        EditedBy = c.String(),
                        Remark = c.String(),
                        EditDay = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 30),
                        Username = c.String(nullable: false, maxLength: 20, unicode: false),
                        HashPassword = c.String(nullable: false, maxLength: 20, unicode: false),
                        EmailConfirmed = c.Boolean(nullable: false),
                        UserConfirmed = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Repairs", "DetalId", "dbo.SpareParts");
            DropForeignKey("dbo.Repairs", "MasterId", "dbo.Masters");
            DropForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes");
            DropForeignKey("dbo.CarsOils", "OilTypeId", "dbo.OilTypes");
            DropForeignKey("dbo.OilFillings", "OilTypeId", "dbo.OilTypes");
            DropForeignKey("dbo.OilFillings", "Carid", "dbo.Cars");
            DropForeignKey("dbo.CarsOils", "Bancode", "dbo.Cars");
            DropForeignKey("dbo.Cars", "ModelId", "dbo.CarModels");
            DropForeignKey("dbo.CarModels", "MarkaId", "dbo.CarMarkas");
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropIndex("dbo.Repairs", new[] { "MasterId" });
            DropIndex("dbo.Repairs", new[] { "DetalId" });
            DropIndex("dbo.OilFillings", new[] { "Carid" });
            DropIndex("dbo.OilFillings", new[] { "OilTypeId" });
            DropIndex("dbo.CarsOils", new[] { "OilTypeId" });
            DropIndex("dbo.CarsOils", new[] { "Bancode" });
            DropIndex("dbo.CarModels", new[] { "MarkaId" });
            DropIndex("dbo.Cars", new[] { "CarTypeId" });
            DropIndex("dbo.Cars", new[] { "ModelId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.SpareParts");
            DropTable("dbo.Repairs");
            DropTable("dbo.Masters");
            DropTable("dbo.CarTypes");
            DropTable("dbo.OilFillings");
            DropTable("dbo.OilTypes");
            DropTable("dbo.CarsOils");
            DropTable("dbo.CarMarkas");
            DropTable("dbo.CarModels");
            DropTable("dbo.Cars");
        }
    }
}
