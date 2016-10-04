using System;
using Xamarin.UITest.Queries;

namespace TechDays2016_Demo
{
	public interface IHomeScreen
	{
		Func<AppQuery, AppQuery> MenuBtn { get; }
        Func<AppQuery, AppQuery> SessionsBtn { get; }
        Func<AppQuery, AppQuery> SpeakersBtn { get; }
	}
}