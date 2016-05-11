using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using chat_exjobb_v3.Repositories;
using chat_exjobb_v3.Models;

namespace chat_exjobb_v3.Models
{
    public class Storage
    {
        private ChatContext db = new ChatContext();

        private static readonly Lazy<Storage> _instance = new Lazy<Storage>(() => new Storage());

        public void Save(string room_slug, string name, string message)
        {
            try
            {
                ChatMessage mes = new ChatMessage();
                mes.chat_text = message;
                mes.chat_author = name;
                mes.chat_date = DateTime.Now;
                mes.chat_room_slug = room_slug;

                db.ChatMessage.Add(mes);
                db.SaveChanges();

            } catch(Exception ex)
            {

            }
            
            //Clients.All.broadcastMessage(name, message);
        }

        public static Storage Instance
        {
            get
            {
                return _instance.Value;
            }

        }
    }
}