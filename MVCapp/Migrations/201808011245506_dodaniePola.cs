namespace MVCapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniePola : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CodeFirsts", "NowePole", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CodeFirsts", "NowePole");
        }
    }
}
