using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace TechDays2016_Demo
{
    [Binding]
    public class ViewSessionsFromSpeakerSteps : StepsBase
    {
        private string _currentSpeaker;

        [Given (@"I am on the Speakers page")]
        public void GivenIAmOnTheSpeakersPage ()
        {
            // Navigate to Speakers
            app.Tap (homeScreen.MenuBtn);
            app.WaitForElement (homeScreen.SpeakersBtn);
            app.Tap (homeScreen.SpeakersBtn);

            app.WaitForNoElement (speakersScreen.LoadingIndicator);
        }

        [When (@"I view the sessions from ""(.*)""")]
        public void WhenIViewTheSessionsFrom (string name)
        {
            app.ScrollDownTo (name, timeout: TimeSpan.FromSeconds (30));
            app.Tap (c => c.Marked (name));

            _currentSpeaker = name;
        }

        [Then (@"I should see these ""(.*)""")]
        public void ThenIShouldSeeThese (string sessions)
        {
            app.ScrollDownTo ("Sessions", timeout: TimeSpan.FromSeconds (30));

            var sessionsArray = sessions.Split (';');
            foreach (var session in sessionsArray)
            {
                var result = app.Query (c => c.Marked (session)).Length;
                Assert.AreEqual (1, result, string.Format("Session '{0}' not found for speaker '{1}'.", session, _currentSpeaker));
            }
        }
    }
}
