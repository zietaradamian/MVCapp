namespace MVCapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nowatabelaPytanie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pytanies",
                c => new
                    {
                        PytanieID = c.Int(nullable: false, identity: true),
                        TrescPytania = c.String(),
                        SkroconaTresc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PytanieID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pytanies");
        }
    }
}
