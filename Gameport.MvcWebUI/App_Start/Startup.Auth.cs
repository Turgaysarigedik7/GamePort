using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.Google;
using Owin;

[assembly: OwinStartup(typeof(Gameport.MvcWebUI.App_Start.Startup))]

namespace Gameport.MvcWebUI.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
                 ClientId="909137579952-86f4q38c4kcksa38vsh4q2md1ogi47oo.apps.googleusercontent.com",
                 ClientSecret= "_h7OgKR5VUuars5iMxuNWyA_"
            });
        
           
        }
    }
 }

