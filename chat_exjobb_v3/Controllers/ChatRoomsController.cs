using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using chat_exjobb_v3.Models;
using chat_exjobb_v3.Repositories;
using System.Web.Http.Cors;

namespace chat_exjobb_v3.Controllers 
{
    /*[EnableCors(origins: "*", headers: "*", methods: "*")]*/
    public class ChatRoomsController : ApiController
    {
        private ChatContext db = new ChatContext();

        // GET: api/ChatRooms
        public IQueryable<ChatRoom> GetChatRoom()
        {
            return db.ChatRoom;
        }

        // GET: api/ChatRooms/5
        [ResponseType(typeof(ChatRoom))]
        public IHttpActionResult GetChatRoom(int id)
        {
            ChatRoom chatRoom = db.ChatRoom.Find(id);
            if (chatRoom == null)
            {
                return NotFound();
            }

            return Ok(chatRoom);
        }

        // PUT: api/ChatRooms/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChatRoom(int id, ChatRoom chatRoom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != chatRoom.room_id)
            {
                return BadRequest();
            }

            db.Entry(chatRoom).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChatRoomExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ChatRooms
        [ResponseType(typeof(ChatRoom))]
        public IHttpActionResult PostChatRoom(ChatRoom chatRoom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ChatRoom.Add(chatRoom);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = chatRoom.room_id }, chatRoom);
        }

        // DELETE: api/ChatRooms/5
        [ResponseType(typeof(ChatRoom))]
        public IHttpActionResult DeleteChatRoom(int id)
        {
            ChatRoom chatRoom = db.ChatRoom.Find(id);
            if (chatRoom == null)
            {
                return NotFound();
            }

            db.ChatRoom.Remove(chatRoom);
            db.SaveChanges();

            return Ok(chatRoom);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChatRoomExists(int id)
        {
            return db.ChatRoom.Count(e => e.room_id == id) > 0;
        }
    }
}