namespace chat_exjobb_v3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class slug : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatRooms", "room_slug", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChatRooms", "room_slug");
        }
    }
}
