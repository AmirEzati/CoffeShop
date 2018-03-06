using RailWayCoffee.Infrastructure.Logging;
using RailWayCoffee.Models;
using RailWayCoffee.Services.Interfaces;
using RailWayCoffee.Services.Messaging.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RRailWayCoffee.UI.MVC.Controllers
{
    public class OrderController : BaseController
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService, ILogger logger)
            :base(logger)
        {
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            _orderService.Create(new CreateReq()
            {
            });

            var response =
                _orderService.GetAll(new GetAllReq()
                {
                });

            Logger.Info("test nlog INFO amir");
            Logger.Error(new DivideByZeroException(), "test nlog ERROR amir");

            return View(model: response.Orders);
        }
    }
}