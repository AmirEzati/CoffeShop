using RailWayCoffee.Infrastructure.Logging;
using RailWayCoffee.Services.Interfaces;
using System.Net.Http;
using System.Web.Http;
using RailWayCoffee.Services.Messaging.DTOs;
using System;
using System.Collections.Generic;

namespace RailWayCoffee.UI.MVC.Controllers.Api
{
    [Authorize]
    public class OrderController : BaseController
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService, ILogger logger)
            : base(logger)
        {
            _orderService = orderService;
        }

        public HttpResponseMessage PostOrder(OrderDto order)
        {
            //Create new order 

            /*
            var response _orderService.Create(new CreateReq() { Order=order, });
            ...
            ...
            string uri = Url.Link("DefaultApi",new { id=orderId});
            var httpResponse = Request.CreateResponse(System.Net.HttpStatusCode.Created);
            httpResponse.Headers.Location = new System.Uri(uri);
            */
            return Request.CreateResponse(System.Net.HttpStatusCode.Created);//code 201
        }
       
        /// <summary>
        /// api/order/id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderDto GetOrder(Guid orderId)
        {
            OrderDto item = new OrderDto();//From repository

            if (item == null)
            {
                throw new HttpResponseException
                    (new HttpResponseMessage(System.Net.HttpStatusCode.NotFound));//code 404
            }
            return item;
        }

        public IEnumerable<OrderDto> GetAllNewOrders()
        {
            return null;
        }

        /// <summary>
        /// in routing we should add routeTemplate: "api/{controller}/{action}/{id}",
        /// </summary>
        /// <returns></returns>
        /// 
        [ActionName("getAllOrders")]
        public IEnumerable<OrderDto> GetAllOrders()
        {
            return null;
        }

        public void PutOrder(Guid orderId, OrderDto order)
        {
            //_orderService.Update(...);
        }

        [HttpPut]
        [Route("api/Order/Commit")]
        public void PutCommitOrder(Guid orderId, OrderDto order)
        {
            //_orderService.Update(...);
        }

        public HttpResponseMessage DeleteOrder(Guid orderId)
        {
            //_orderService.Remove(new deleteReq() { Id=orderId});
            return new HttpResponseMessage(System.Net.HttpStatusCode.NoContent);//code 204
        }
    }
}