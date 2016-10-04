using System;
using Xamarin.UITest.Queries;

namespace TechDays2016_Demo
{
    public class AndroidSessionDetailsScreen : ISessionDetailsScreen
    {
        public Func<AppQuery, AppQuery> FavoriteBtn { get; } =
            new Func<AppQuery, AppQuery> (c => c.Marked ("Follow").Parent ().Parent ().Child (3).Child (2));
    }
}
