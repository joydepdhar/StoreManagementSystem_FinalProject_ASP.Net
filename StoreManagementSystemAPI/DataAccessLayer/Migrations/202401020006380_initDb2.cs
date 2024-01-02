namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TopSearchSelleingproducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TopProductName = c.String(nullable: false, maxLength: 15),
                        Count = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TopSearchSelleingproducts");
        }
    }
}
