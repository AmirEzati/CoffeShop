using RailWayCoffee.Services.Messaging.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayCoffee.Services.Interfaces
{
    public interface IOrderService
    {
        GetAllRes GetAll(GetAllReq request);
        CreateReq Create(CreateReq request);
    }
}
