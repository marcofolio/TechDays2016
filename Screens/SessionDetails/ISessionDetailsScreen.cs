using System;
using Xamarin.UITest.Queries;

namespace TechDays2016_Demo
{
    public interface ISessionDetailsScreen
    {
        Func<AppQuery, AppQuery> FavoriteBtn { get; }
    }
}
