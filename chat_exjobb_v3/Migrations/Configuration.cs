namespace chat_exjobb_v3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using chat_exjobb_v3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<chat_exjobb_v3.Repositories.ChatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(chat_exjobb_v3.Repositories.ChatContext context)
        {           
            context.ChatMessage.AddOrUpdate(
                message => message.chat_text, new ChatMessage { chat_text = "Hej världen", chat_date = DateTime.Now, chat_author = "isak"}
                );            
        }
    }
}
