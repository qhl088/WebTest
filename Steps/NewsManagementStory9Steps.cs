using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace WebAuto1.Features
{
    [Binding]
    public class NewsManagementStory9Steps
    {
        [When(@"I select News Management go to news mangement page")]
        public void WhenISelectNewsManagementGoToNewsMangementPage()
        {
            Browser.AdminList.Admin();
            Browser.AdminList.SelectAdminBckEnd();
            Browser.AdminOptPage.SelectOperations();
            Browser.AdminOperations.SelectNewsMangeF();
            Browser.AdminOperations.SelectNewsMangeS();
        }

        [When(@"searching by multiple filter (.*) and (.*)")]
        public void WhenSearchingByMultipleFilterAnd(string category, string info)
        {
            Browser.AdminOpeNewsMange.NewsCategory(category);
            if(category == null)
            {
                Browser.AdminOpeNewsMange.Search();
            }
            else
            {
                Browser.AdminOpeNewsMange.CaseFilter(info);
                Browser.AdminOpeNewsMange.Search();
            }
            
        }

        [When(@"switch an article status")]
        public void WhenSwitchAnArticleStatus(Table table)
        {
            var article = table.CreateInstance<NewsMangement>();
            Browser.AdminOpeNewsMange.NewsCategory(article.category);
            Browser.AdminOpeNewsMange.Search();
            Browser.AdminOpeNewsMange.Edition(article.published);
            Browser.AdminOpeNewsMange.Edition(article.unpublished);
        }
        
        [When(@"I select News Management go to category mangement page")]
        public void WhenISelectNewsManagementGoToCategoryMangementPage()
        {
            Browser.AdminList.Admin();
            Browser.AdminList.SelectAdminBckEnd();
            Browser.AdminOptPage.SelectOperations();
            Browser.AdminOperations.SelectNewsMangeF();
            Browser.AdminOperations.SelectTagMange();
        }
        
        [When(@"open new category and title is (.*) and code (.*)")]
        public void WhenOpenNewCategoryAndTitleIsAndCode(string title, string code, Table table)
        {
            Browser.AdminOpeNewsMange.SelectAddNews();
            var article = table.CreateInstance<NewsMangement>();
            Browser.OpeAddNews.CreateCategory(article.title, article.code);
            Browser.OpeAddNews.CatSaveBtn();
        }

        [When(@"switch (.*) to (.*) status")]
        public void WhenSwitchToStatus(string code, string newtitle,Table table)
        {
            var article = table.CreateInstance<NewsMangement>();
            Browser.AdminOpeNewsMange.SwitchTitle(article.code);
            Browser.OpeAddNews.EditCategory(article.newtitle);
            Browser.OpeAddNews.CatSaveBtn();
        }

        [Then(@"the result is displayed")]
        public void ThenTheResultIsDisplayed()
        {
            try
            {
                Assert.IsTrue(Browser.AdminOpeNewsMange.IsTextExist2);
            }
            catch
            {
                Assert.IsTrue(Browser.AdminOpeNewsMange.IsTextExist1);
            }
        }
        
        [Then(@"the result title is displayed")]
        public void ThenTheResultTitleIsDisplayed()
        {
            Assert.IsTrue(Browser.AdminOpeNewsMange.IsTextExist1);
        }
        
        [Then(@"the result title status is displayed")]
        public void ThenTheResultTitleStatusIsDisplayed()
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("自动化测试"));
        }
    }
}
