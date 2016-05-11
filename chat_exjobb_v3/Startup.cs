
using Microsoft.Owin;
using Owin;
using chat_exjobb_v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Cors;


[assembly: OwinStartup(typeof(chat_exjobb_v3.Startup))]

namespace chat_exjobb_v3
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
} 