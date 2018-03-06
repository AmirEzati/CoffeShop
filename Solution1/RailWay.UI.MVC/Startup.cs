using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RailWay.UI.MVC.Startup))]
namespace RailWay.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
