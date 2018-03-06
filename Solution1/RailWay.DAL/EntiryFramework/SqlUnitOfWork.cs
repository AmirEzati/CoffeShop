using System;
using RailWayCoffee.DAL.Repositories;

namespace RailWayCoffee.DAL.EntiryFramework
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private  Models.DatabaseContext _databaseContext { get; set; }
        public SqlUnitOfWork(Models.DatabaseContext databaseContext)
        {
            if (databaseContext == null)
            {
                throw (new System.ArgumentNullException("databaseContext"));
            }
            _databaseContext = databaseContext;
           
        }

        private IOrderRepository _orderRepository { get; set; }
        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_databaseContext);
                }

                return _orderRepository;
            }

        }


        public void Commit()
        {
            _databaseContext.SaveChanges();
        }
    }
}
