namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StateChange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentDescription = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationID = c.Int(nullable: false, identity: true),
                        LocationDescription = c.String(),
                    })
                .PrimaryKey(t => t.LocationID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        SNumber = c.String(),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        PersonalEmail = c.String(),
                        SchoolEmail = c.String(),
                        PhoneNumber = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        StatusDescription = c.String(),
                    })
                .PrimaryKey(t => t.StatusID);
            
            AddColumn("dbo.States", "StateName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.States", "StateName");
            DropTable("dbo.Status");
            DropTable("dbo.People");
            DropTable("dbo.Locations");
            DropTable("dbo.Departments");
        }
    }
}
