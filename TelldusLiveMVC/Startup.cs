using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TelldusLiveMVC.Startup))]
namespace TelldusLiveMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
