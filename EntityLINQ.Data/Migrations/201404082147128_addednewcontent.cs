namespace EntityLINQ.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednewcontent : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Jobs", new[] { "CompanyId" });
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        OrderTotal = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            DropTable("dbo.Companies");
            DropTable("dbo.Jobs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Salary = c.Double(nullable: false),
                        Description = c.String(),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        EmployeeCount = c.Int(nullable: false),
                        WebsiteUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            CreateIndex("dbo.Jobs", "CompanyId");
            AddForeignKey("dbo.Jobs", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
    }
}
