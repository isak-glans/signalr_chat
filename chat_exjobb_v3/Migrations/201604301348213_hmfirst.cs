namespace chat_exjobb_v3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hmfirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChatMessages",
                c => new
                    {
                        chat_ID = c.Int(nullable: false, identity: true),
                        chat_text = c.String(),
                        chat_date = c.DateTime(nullable: false),
                        chat_author = c.String(),
                    })
                .PrimaryKey(t => t.chat_ID);
            
            CreateTable(
                "dbo.ChatRooms",
                c => new
                    {
                        room_id = c.Int(nullable: false, identity: true),
                        room_name = c.String(),
                    })
                .PrimaryKey(t => t.room_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChatRooms");
            DropTable("dbo.ChatMessages");
        }
    }
}
