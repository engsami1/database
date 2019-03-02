namespace AddEmployes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employes", "GenderEmp", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employes", "GenderEmp", c => c.Boolean(nullable: false));
        }
    }
}
