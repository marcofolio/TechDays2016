using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TechDays2016_Demo
{
	[Binding]
	public class FavoritingASessionSteps : StepsBase
	{
        [Given (@"I am on a Session Details page")]
        public void GivenIAmOnASessionDetailsPage ()
        {
            // Navigate to Sessions
            app.Tap (homeScreen.MenuBtn);
            app.WaitForElement (homeScreen.SessionsBtn);
            app.Tap (homeScreen.SessionsBtn);

            // Search for our Session
            app.WaitForElement (sessionsScreen.SearchEntry);
            app.ClearText (sessionsScreen.SearchEntry);
            app.EnterText (sessionsScreen.SearchEntry, "turn specs");

            // Open our Session
            app.WaitForElement (sessionsScreen.OurSession);
            app.Tap (sessionsScreen.OurSession);
        }

        [When (@"I press Favorite")]
        public void WhenIPressFavorite ()
        {
            app.Tap (sessionDetailsScreen.FavoriteBtn);
        }

        [Then (@"The session will be marked as Favorite")]
        public void ThenTheSessionWillBeMarkedAsFavorite ()
        {
            // Implicit
        }

        [Then (@"I should see ""(.*)""")]
        public void ThenIShouldSee (string text)
        {
            var result = app.Query (c => c.Marked (text)).Length;
            Assert.AreEqual (1, result);
        }
	}
}