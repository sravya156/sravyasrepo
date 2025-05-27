using NatureHub2.Models;
using System;

namespace NatureHub2.Repos
{
    public class OrderRepo : Repository<Order>, IOrderRepo
    {
        public OrderRepo(HubDb2Context context) : base(context) { }
    }
}
