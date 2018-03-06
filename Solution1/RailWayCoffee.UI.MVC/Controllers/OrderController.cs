using RailWayCoffee.Models;
using RailWayCoffee.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailWayCoffee.UI.MVC.Controllers
{
    public class OrderController : BaseController
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: Order
        public ActionResult Index()
        {
            var n = new  DatabaseContext();
           
            var model=_orderService.GetAll(new Services.Messaging.OrderService.GetAllReq() {
            });
            return View();
        }
    }
}