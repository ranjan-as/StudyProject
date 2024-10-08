﻿namespace StudyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Samples", "Address", c => c.String());
            AddColumn("dbo.Samples", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Samples", "City");
            DropColumn("dbo.Samples", "Address");
        }
    }
}
