using TechTalk.SpecFlow;
using Xamarin.UITest;
using Should;
using System.Linq;

namespace TechDays2016_Demo
{
	[Binding]
	public class CommonSteps
	{
        readonly IApp app;

		readonly IHomeScreen homeScreen;

        readonly ISessionsScreen sessionsScreen;
        readonly ISessionDetailsScreen sessionDetailsScreen;

		readonly ISpeakersScreen speakersScreen;
        readonly ISpeakerDetailsScreen speakerDetailsScreen;

		public CommonSteps ()
		{
			app = FeatureContext.Current.Get<IApp>("App");

			homeScreen = FeatureContext.Current.Get<IHomeScreen> (ScreenNames.Home);

            sessionsScreen = FeatureContext.Current.Get<ISessionsScreen> (ScreenNames.Sessions);
            sessionDetailsScreen = FeatureContext.Current.Get<ISessionDetailsScreen> (ScreenNames.SessionDetails);

            speakersScreen = FeatureContext.Current.Get<ISpeakersScreen> (ScreenNames.Speakers);
            speakerDetailsScreen = FeatureContext.Current.Get<ISpeakerDetailsScreen> (ScreenNames.SpeakerDetails);
		}
 
	}
	
}