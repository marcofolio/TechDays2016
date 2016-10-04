using NUnit.Framework;
using Xamarin.UITest;
using TechTalk.SpecFlow;

namespace TechDays2016_Demo
{
	public class FeatureBase
	{
		protected static IApp app;
		protected Platform platform;

		public FeatureBase ()
		{
			this.platform = Platform.Android;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
            FeatureContext.Current.Clear ();
			FeatureContext.Current.Add ("App", app);
			AppInitializer.InitializeScreens (platform);
		}
	}

}