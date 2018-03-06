using RailWayCoffee.DAL.Repositories;
using RailWayCoffee.Models;
using RailWayCoffee.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayCoffee.DAL.EntiryFramework
{
    public class OrderRepository : SqlRepository<Order>, IOrderRepository
    {
        public OrderRepository(DatabaseContext databaseContext) :
            base(databaseContext)
        {

        }
    }
}
