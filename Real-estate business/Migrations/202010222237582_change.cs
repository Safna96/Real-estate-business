namespace Real_estate_business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Staff_tbl", "DOB", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Staff_tbl", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
