using Xamarin.UITest;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Diagnostics;
using System;

namespace TechDays2016_Demo
{
	public static class AppInitializer
	{
		public static IApp StartApp (Platform platform)
		{
			if (platform == Platform.Android)
            {

				return ConfigureApp
					.Android
					.ApkFile ("../../binaries/com.xpirit.techdays_1.0.61.apk")
					.EnableLocalScreenshots ()
					.StartApp ();
				
			}

			throw new ArgumentException ("Unsupported platform");
		}

		public static void InitializeScreens(Platform platform)
		{
            if (platform == Platform.Android)
            {
                FeatureContext.Current.Add (ScreenNames.Home, new AndroidHomeScreen ());

                FeatureContext.Current.Add (ScreenNames.Sessions, new AndroidSessionsScreen ());
                FeatureContext.Current.Add (ScreenNames.SessionDetails, new AndroidSessionDetailsScreen ());

                FeatureContext.Current.Add (ScreenNames.Speakers, new AndroidSpeakersScreen ());
                FeatureContext.Current.Add (ScreenNames.SpeakerDetails, new AndroidSpeakerDetailsScreen ());
            }
            else
            {
                throw new ArgumentException ("Unsupported platform");
            }
		}
	}
}