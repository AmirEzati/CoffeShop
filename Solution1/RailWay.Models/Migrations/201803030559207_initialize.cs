namespace RailWayCoffee.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "RailWayCoffee.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        CoffeeId = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        ETA = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        IsCanceled = c.Boolean(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Coffees", t => t.CoffeeId)
                .ForeignKey("dbo.Users", t => t.CustomerId)
                .Index(t => t.CustomerId)
                .Index(t => t.CoffeeId);
            
            CreateTable(
                "dbo.Coffees",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        price = c.Double(nullable: false),
                        PreparationTime = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 150),
                        Email = c.String(nullable: false),
                        MobileNumber = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "RailWayCoffee.UserNotifications",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        NotificationId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.NotificationId })
                .ForeignKey("dbo.Notifications", t => t.NotificationId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.NotificationId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("RailWayCoffee.Orders", "CustomerId", "dbo.Users");
            DropForeignKey("RailWayCoffee.UserNotifications", "UserId", "dbo.Users");
            DropForeignKey("RailWayCoffee.UserNotifications", "NotificationId", "dbo.Notifications");
            DropForeignKey("RailWayCoffee.Orders", "CoffeeId", "dbo.Coffees");
            DropIndex("RailWayCoffee.UserNotifications", new[] { "NotificationId" });
            DropIndex("RailWayCoffee.UserNotifications", new[] { "UserId" });
            DropIndex("RailWayCoffee.Orders", new[] { "CoffeeId" });
            DropIndex("RailWayCoffee.Orders", new[] { "CustomerId" });
            DropTable("dbo.Notifications");
            DropTable("RailWayCoffee.UserNotifications");
            DropTable("dbo.Users");
            DropTable("dbo.Coffees");
            DropTable("RailWayCoffee.Orders");
        }
    }
}
