using System;
using Xamarin.UITest.Queries;

namespace TechDays2016_Demo
{
    public class AndroidSessionsScreen : ISessionsScreen
    {
        public Func<AppQuery, AppQuery> SearchEntry { get; } =
            new Func<AppQuery, AppQuery> (c => c.Marked ("search_src_text"));

        public Func<AppQuery, AppQuery> OurSession { get; } =
            new Func<AppQuery, AppQuery> (c => c.Marked ("Turn specs into high quality apps"));
    }
}
