namespace ApiPublicacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segundopaso : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Publicacions", "User", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Publicacions", "User", c => c.String());
        }
    }
}
