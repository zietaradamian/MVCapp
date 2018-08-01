namespace MVCapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CodeFirsts",
                c => new
                    {
                        KontaktID = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false),
                        Nazwisko = c.String(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.KontaktID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CodeFirsts");
        }
    }
}
