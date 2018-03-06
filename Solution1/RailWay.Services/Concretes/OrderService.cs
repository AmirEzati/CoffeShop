using RailWayCoffee.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailWayCoffee.Services.Messaging.OrderService;
using RailWayCoffee.DAL;

namespace RailWayCoffee.Services.Concretes
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork _unitOfWork;
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public CreateReq Create(CreateReq request)
        {
            _unitOfWork.OrderRepository.Add(new Models.DomainModels.Order()
            {
            });
            _unitOfWork.Commit();
            return null;
        }

        public GetAllRes GetAll(GetAllReq request)
        {
            var model = _unitOfWork.OrderRepository.GetAll();

            var response = new GetAllRes()
            {
                Orders = model.Select(v => new ViewModels.Order.IndexViewModel()
                {
                    Id = v.Id,
                })
                .ToList(),
            };

            return response;
        }
    }
}
