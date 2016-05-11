using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using chat_exjobb_v3.Models;

namespace chat_exjobb_v3.Repositories
{
    public class ChatContext : DbContext 
    {
        public DbSet<ChatMessage> ChatMessage { get; set; }
        public DbSet<ChatRoom> ChatRoom { get; set; }

        public ChatContext() : base("Chatv3Context")
        {

        }
    }
}