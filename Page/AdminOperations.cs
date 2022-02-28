using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class AdminOperations
    {
        [FindsBy(How = How.LinkText, Using = "资讯管理")]
        private IWebElement _newsManageF;//资讯管理

        [FindsBy(How = How.LinkText, Using = "小组管理")]
        private IWebElement _goupeManage;//小组管理

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/ul/li[1]/a")]
        private IWebElement _newsManageS;//二级标签-资讯管理

        [FindsBy(How = How.LinkText, Using = "栏目管理")]
        private IWebElement _tagManage;//二级标签-栏目管理

        /// <summary>
        /// 点击资讯管理
        /// </summary>
        public void SelectNewsMangeF()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("添加资讯")));
            _newsManageF.Click();
        }
        
        /// <summary>
        /// 点击二级资讯管理
        /// </summary>
        public void SelectNewsMangeS()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/ul/li[1]/a")));
            _newsManageS.Click();
        }

        /// <summary>
        /// 点击二级栏目管理
        /// </summary>
        public void SelectTagMange()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("栏目管理")));
            _tagManage.Click();
        }

    }
}
