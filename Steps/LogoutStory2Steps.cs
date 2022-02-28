using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace WebAuto1.Features
{
    [Binding]
    public class LogoutStory2Steps
    {
        [When(@"I move to personal list")]
        public void WhenIMoveToPersonalList()
        {
            Browser.PersonalList.Persoanl();
        }
        
        [When(@"I select logout option")]
        public void WhenISelectLogoutOption()
        {
            Browser.PersonalList.SelectLogout();
        }
        
        [Then(@"the logout should be successful")]
        public void ThenTheLogoutShouldBeSuccessful()
        {
            Assert.That(Browser.LoginPage.IsLoginBtnExist, Is.True);
        }
    }
}
