using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using chat_exjobb_v3.Models;

namespace chat_exjobb_v3.Hubs
{
    
    public class ChatHub : Hub     
    {        

        public void sendMessage(string roomSlug, string name, string message)
        {
            // Store in database.
            Storage.Instance.Save(roomSlug, name, message);

            Clients.Group(roomSlug).broadcastMessage(name, message);            
        }  

        public void JoinRoom(string roomSlug, string username)
        {            
            // This was once a task..

            // User joins the room.
            Task t = Task.Run( () => Groups.Add(Context.ConnectionId, roomSlug) );
            t.Wait();            

            // Tell all users that you have joined room.
            Clients.Group(roomSlug).joinRoomDone(roomSlug, username);
        }
        

        public Task LeaveRoom(string roomSlug, string username)
        {
            return Groups.Remove(Context.ConnectionId, roomSlug );
        }
        
    }
}