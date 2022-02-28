using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace WebAuto1.Features
{
    [Binding]
    public class UnpdatePorfileStory6Steps
    {
        Actions actions = new Actions(Browser.Driver2);////鼠标点击行为

        [When(@"I select basic infor")]
        public void WhenISelectBasicInfor()
        {
            Browser.PersonalOptionPage.SelectProfileSetting();
        }
        
        [When(@"I enter valid name")]
        public void WhenIEnterValidName(Table table)
        {
            var user = table.CreateInstance<AccountForm>();
            Browser.BasicInfoPag.updateName(user.name);
        }

        [When(@"I enter invalid infor (.*) and (.*)")]
        public void WhenIEnterInvalidInforAnd(string numb, string info)
        {
            int n = Convert.ToInt32(numb);
            var test = new AccountForm();
            test.number = n;
            test.info = info;
            Browser.BasicInfoPag.updateProfile(test.number, test.info);
            actions.MoveByOffset(0, 0).Click();//鼠标动作点击空白处
        }


        [Then(@"the result is error not display")]
        public void ThenTheResultIsErrorNotDisplay()
        {
            //Assert.That(Browser.BasicInfoPag.IsNameErrorExist,Is.False);
            Assert.IsFalse(Browser.BasicInfoPag.IsNameErrorExist);
        }
        
        [Then(@"the result (.*) is dispalyed")]
        public void ThenTheResultIsDispalyed(string error)
        {
            var listError = new ErrorList();
            bool b = listError.IsProfileErrorExist(error);
            //bool b = listError.IsErrorListExisit(error);
            Assert.IsTrue(b);
        }
    }
}
