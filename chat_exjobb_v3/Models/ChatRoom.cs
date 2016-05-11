using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace chat_exjobb_v3.Models
{
    public class ChatRoom
    {
        [Key] 
        public int room_id { get; set; }
        public string room_name { get; set; }
        public string room_slug { get; set; }        
    }
}