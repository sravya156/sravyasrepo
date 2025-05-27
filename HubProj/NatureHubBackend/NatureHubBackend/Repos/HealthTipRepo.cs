using NatureHub2.Models;
using System;

namespace NatureHub2.Repos
{
    public class HealthTipRepo : Repository<HealthTip>, IHealthTipRepo
    {
        public HealthTipRepo(HubDb2Context context) : base(context) { }
    }
}
