using NatureHub2.Models;
using System;

namespace NatureHub2.Repos
{
    public class ReviewRepo : Repository<Review>, IReviewRepo
    {
        public ReviewRepo(HubDb2Context context) : base(context) { }
    }
}
