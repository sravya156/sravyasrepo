using NatureHub2.Models;
using System;

namespace NatureHub2.Repos
{
    public class RemedyRepo : Repository<Remedy>, IRemedyRepo
    {
        public RemedyRepo(HubDb2Context context) : base(context) { }
    }
}
