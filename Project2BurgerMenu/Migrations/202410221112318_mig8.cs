namespace Project2BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Title", c => c.String());
            AddColumn("dbo.Messages", "Content", c => c.String());
            AddColumn("dbo.Messages", "SenderEmail", c => c.String());
            AddColumn("dbo.Messages", "ReceiverEmail", c => c.String());
            DropColumn("dbo.Messages", "Name");
            DropColumn("dbo.Messages", "Email");
            DropColumn("dbo.Messages", "MessageDetail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "MessageDetail", c => c.String());
            AddColumn("dbo.Messages", "Email", c => c.String());
            AddColumn("dbo.Messages", "Name", c => c.String());
            DropColumn("dbo.Messages", "ReceiverEmail");
            DropColumn("dbo.Messages", "SenderEmail");
            DropColumn("dbo.Messages", "Content");
            DropColumn("dbo.Messages", "Title");
        }
    }
}
