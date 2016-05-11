using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace chat_exjobb_v3.Models
{
    public class ChatMessage
    {
        [Key] 
        public int chat_ID { get; set; }
        public string chat_text { get; set; }
        public DateTime chat_date { get; set; }
        public string chat_author { get; set; }
        public string chat_room_slug { get; set; }
    }
}