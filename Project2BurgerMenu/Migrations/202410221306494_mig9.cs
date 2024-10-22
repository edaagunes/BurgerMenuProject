namespace Project2BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        MessageDetail = c.String(),
                        SendDate = c.DateTime(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
