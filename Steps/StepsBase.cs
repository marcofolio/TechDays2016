using TechTalk.SpecFlow;
using Xamarin.UITest;
using Should;
using System.Linq;
using Xamarin.UITest.Queries;
using System;

namespace TechDays2016_Demo
{
	public class StepsBase
	{
        protected readonly IApp app;
		
        protected readonly IHomeScreen homeScreen;

        protected readonly ISessionsScreen sessionsScreen;
        protected readonly ISessionDetailsScreen sessionDetailsScreen;

        protected readonly ISpeakersScreen speakersScreen;
        protected readonly ISpeakerDetailsScreen speakersDetailsScreen;

		public StepsBase ()
		{
			app = FeatureContext.Current.Get<IApp>("App");
			
            homeScreen = FeatureContext.Current.Get<IHomeScreen> (ScreenNames.Home);

            sessionsScreen = FeatureContext.Current.Get<ISessionsScreen> (ScreenNames.Sessions);
            sessionDetailsScreen = FeatureContext.Current.Get<ISessionDetailsScreen> (ScreenNames.SessionDetails);	

            speakersScreen = FeatureContext.Current.Get<ISpeakersScreen> (ScreenNames.Speakers);
            speakersDetailsScreen = FeatureContext.Current.Get<ISpeakerDetailsScreen> (ScreenNames.SpeakerDetails);
        }
	}
	
}