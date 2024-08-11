namespace StudyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Samples", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Samples", "State");
        }
    }
}
