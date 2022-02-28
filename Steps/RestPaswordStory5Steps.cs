using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace WebAuto1.Features
{
    [Binding]
    public class RestPaswordStory5Steps
    {
        [Given(@"I can open login page")]
        public void GivenICanOpenLoginPage()
        {
            Browser.HomePage.SelectLogin();
        }
        
        [Given(@"I select reset password")]
        public void GivenISelectResetPassword()
        {
            Browser.LoginPage.FrogotPwd();
        }

        [When(@"I input valid email")]
        public void WhenIInputValidEmail(Table table)
        {
            var rest = table.CreateInstance<AccountForm>();
            Browser.RestPage.TypeEmail(rest.email);
        }

        [When(@"I select reset button")]
        public void WhenISelectResetButton()
        {
            Browser.RestPage.RestPwd();
        }

        [Then(@"the email error is displayed")]
        public void ThenTheEmailErrorIsDisplayed()
        {
            Assert.That(Browser.RestPage.IsUnregisterEmailErorExist, Is.True);
        }

        [Then(@"the invalid email error is displayed")]
        public void ThenTheInvalidEmailErrorIsDisplayed()
        {
            Assert.That(Browser.RestPage.IsInvalidEmailErrorExist, Is.True);
        }

        [AfterScenario]
        public void Close()
        {
            Browser.Driver2.Quit();
        }
    }
}
