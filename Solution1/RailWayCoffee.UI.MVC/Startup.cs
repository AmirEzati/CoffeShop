using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RailWayCoffee.UI.MVC.Startup))]
namespace RailWayCoffee.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
