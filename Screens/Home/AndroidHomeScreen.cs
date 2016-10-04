using System;
using Xamarin.UITest.Queries;

namespace TechDays2016_Demo
{
	public class AndroidHomeScreen : IHomeScreen
	{
		public Func<AppQuery, AppQuery> MenuBtn { get; } =
            new Func<AppQuery, AppQuery> (c => c.Marked("OK"));

        public Func<AppQuery, AppQuery> SessionsBtn { get; } =
            new Func<AppQuery, AppQuery> (c => c.Marked ("Sessions"));

        public Func<AppQuery, AppQuery> SpeakersBtn { get; } =
            new Func<AppQuery, AppQuery> (c => c.Marked ("Speakers"));
	}		
}