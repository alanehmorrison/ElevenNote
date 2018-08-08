using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElevenNot.WebMVC.Startup))]
namespace ElevenNot.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
