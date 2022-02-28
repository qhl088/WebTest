using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebAuto1.Password;

namespace WebAuto1.Features
{
    [Binding]
    public class LoginStory1Steps
    {
        [Given(@"I can open homepage")]
        public void GivenICanOpenHomepage()
        {
            Browser.HomePage.Goto();
        }
        
        [Given(@"I can select login")]
        public void GivenICanSelectLogin()
        {
            Browser.HomePage.SelectLogin();
        }
        
        [When(@"I input valid username and password")]
        public void WhenIInputValidUsernameAndPassword(Table table)
        {
            var user = table.CreateInstance<password>();
            Browser.LoginPage.Login(user.Name, user.Password);
        }
        
        [When(@"I select login button")]
        public void WhenISelectLoginButton()
        {
            Browser.LoginPage.RembPwdClear();
        }
        
        [When(@"I can select remember me")]
        public void WhenICanSelectRememberMe()
        {
            Browser.LoginPage.RembPwdSelect();
        }
        
        [When(@"I input invalid username and password")]
        public void WhenIInputInvalidUsernameAndPassword(Table table)
        {
            var user = table.CreateInstance<invalidpassword>();
            Browser.LoginPage.Login(user.Name, user.Password);
            Browser.LoginPage.RembPwdClear();
        }
        
        [Then(@"the result should be successful")]
        public void ThenTheResultShouldBeSuccessful()
        {
            Assert.That(Browser.LoginPage.IsAvtarDetailExist, Is.True);
        }
        
        [Then(@"the login should not be successful")]
        public void ThenTheLoginShouldNotBeSuccessful()
        {
            Assert.That(Browser.LoginPage.IsErrorDetailExist, Is.True);
        }
    }
}
