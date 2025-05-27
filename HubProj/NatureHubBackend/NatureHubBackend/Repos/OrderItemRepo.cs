using NatureHub2.Models;
using System;

namespace NatureHub2.Repos
{
    public class OrderItemRepo : Repository<OrderItem>, IOrderItemRepo
    {
        public OrderItemRepo(HubDb2Context context) : base(context) { }
    }
}
