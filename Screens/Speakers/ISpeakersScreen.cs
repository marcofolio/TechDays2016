using System;
using Xamarin.UITest.Queries;

namespace TechDays2016_Demo
{
    public interface ISpeakersScreen
    {
        Func<AppQuery, AppQuery> LoadingIndicator { get; }
    }
}
