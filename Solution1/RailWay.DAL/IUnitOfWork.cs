using System;
namespace RailWayCoffee.DAL
{
    public interface IUnitOfWork
    {
        Repositories.IOrderRepository OrderRepository { get; }
        void  Commit();
    }
}
