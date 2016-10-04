using System;
using Xamarin.UITest.Queries;

namespace TechDays2016_Demo
{
    public interface ISessionsScreen
    {
        Func<AppQuery, AppQuery> SearchEntry { get; }
        Func<AppQuery, AppQuery> OurSession { get; }
    }
}
