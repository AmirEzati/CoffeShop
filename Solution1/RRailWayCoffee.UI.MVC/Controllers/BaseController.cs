using RailWayCoffee.Infrastructure.Logging;
using System.Web.Mvc;

namespace RRailWayCoffee.UI.MVC.Controllers
{
    public class BaseController : Controller
    {
        protected ILogger Logger { get; private set; }
        public BaseController(ILogger logger)
        {
            Logger = logger;
        }
    }
}