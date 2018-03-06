using RailWayCoffee.Models.DomainModels;
using RailWayCoffee.Services.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayCoffee.Services.Messaging.OrderService
{
   public class GetAllRes
    {
        public IEnumerable<IndexViewModel> Orders { get; set; }
    }
}
