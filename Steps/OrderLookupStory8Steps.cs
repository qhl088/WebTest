using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebAuto1.Password;

namespace WebAuto1.Features
{
    [Binding]
    public class OrderLookupStory8Steps
    {
        [Given(@"I can login admin account")]
        public void GivenICanLoginAdminAccount(Table table)
        {
            var admin = table.CreateInstance<password>();
            Browser.HomePage.SelectLogin();
            Browser.LoginPage.Login(admin.Name, admin.Password);//feature内表格要和类内的变量名一致
            Browser.LoginPage.RembPwdClear();
        }
        
        [When(@"I select course order and serach")]
        public void WhenISelectCourseOrderAndSerach()
        {
            Browser.AdminList.Admin();
            Browser.AdminList.SelectAdminBckEnd();
            Browser.AdminOptPage.SelectOderlist();
            Browser.AdminOderDetail.Courselookup();
            Browser.AdminOderDetail.SearchBtn();
        }
        
        [When(@"I select class order and serach")]
        public void WhenISelectClassOrderAndSerach()
        {
            Browser.AdminList.Admin();
            Browser.AdminList.SelectAdminBckEnd();
            Browser.AdminOptPage.SelectOderlist();
            Browser.AdminOderDetail.ClassLookup();
            Browser.AdminOderDetail.SearchBtn();
        }
        
        [When(@"I select course order and input (.*) and (.*)")]
        public void WhenISelectCourseOrderAndInputAnd(string numb, string info)
        {
            Browser.AdminList.Admin();
            Browser.AdminList.SelectAdminBckEnd();
            Browser.AdminOptPage.SelectOderlist();
            Browser.AdminOderDetail.Courselookup();
            int n = Convert.ToInt32(numb);
            var test = new OrderFrom();
            test.number = n;
            test.info = info;
            Browser.AdminOderDetail.OrderSearch(test.number, test.info);
        }
        
        [When(@"I select class order and input (.*) and (.*)")]
        public void WhenISelectClassOrderAndInputAnd(string numb, string info)
        {
            Browser.AdminList.Admin();
            Browser.AdminList.SelectAdminBckEnd();
            Browser.AdminOptPage.SelectOderlist();
            Browser.AdminOderDetail.ClassLookup();
            int n = Convert.ToInt32(numb);
            var test = new OrderFrom();
            test.number = n;
            test.info = info;
            Browser.AdminOderDetail.OrderSearch(test.number, test.info);
        }
        
        [Then(@"the result should pass")]
        public void ThenTheResultShouldPass()
        {
            //Assert.IsTrue(Browser.Driver2.PageSource.Contains(page.defList));
            Assert.IsTrue(Browser.AdminOderDetail.OrderResult);
        }
        
        [Then(@"the result shoud pass")]
        public void ThenTheResultShoudPass()
        {
            Assert.IsTrue(Browser.AdminOderDetail.OrderResult);
        }
    }
}
