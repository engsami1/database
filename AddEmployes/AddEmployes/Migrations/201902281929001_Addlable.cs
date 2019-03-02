namespace AddEmployes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addlable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employes", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employes", "City");
        }
    }
}
