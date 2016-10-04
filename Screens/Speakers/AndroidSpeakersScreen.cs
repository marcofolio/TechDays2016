using System;
using Xamarin.UITest.Queries;

namespace TechDays2016_Demo
{
    public class AndroidSpeakersScreen : ISpeakersScreen
    {
        public Func<AppQuery, AppQuery> LoadingIndicator { get; } =
            new Func<AppQuery, AppQuery> (c => c.Marked ("Loading Speakers..."));
    }
}
