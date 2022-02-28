using System;
using TechTalk.SpecFlow;
using NUnit.Framework;


namespace WebAuto1.Features
{
    [Binding]
    public class RegistrationStory4_2Steps
    {
        
        [Given(@"I can select register page")]
        public void GivenICanSelectRegisterPage()
        {
            Browser.HomePage.SelectRegister();
        }
        
        [When(@"I register with (.*) and (.*) and (.*)")]
        public void WhenIRegisterWithNameAndPasswordAndEmail(string name,string password,string email)
        {
            var enroll = new AccountForm();
            enroll.email = email;
            enroll.name = name;
            enroll.password = password;
            Browser.RegisterPage.RegisterInfo(enroll.email, enroll.name, enroll.password);
            Browser.RegisterPage.Registed();

        }
        
        [Then(@"the result error (.*) is displayed")]
        public void ThenTheResultErrorErrorIsDisplayed(string error)
        {
            //var show = new AccountForm();
            //show.error = error;

            var errorlist = new ErrorList();
            bool b = errorlist.IsErrorExist(error);
            //Assert.AreEqual(error, error);
            Assert.IsTrue(b);
        }
    }
}
