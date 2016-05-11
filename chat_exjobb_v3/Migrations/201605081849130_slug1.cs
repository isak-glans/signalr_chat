namespace chat_exjobb_v3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class slug1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatMessages", "chat_room_slug", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChatMessages", "chat_room_slug");
        }
    }
}
