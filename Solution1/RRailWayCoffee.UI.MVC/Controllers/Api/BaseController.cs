using RailWayCoffee.Infrastructure.Logging;
using System;
using System.Web.Http;

namespace RailWayCoffee.UI.MVC.Controllers.Api
{
    public class BaseController : ApiController
    {
        protected ILogger Logger { get; private set; }
        public BaseController(ILogger logger)
        {
            Logger = logger;
        }
    }
}
