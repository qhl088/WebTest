using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class PersonalList
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/a/img")]
        private IWebElement _personalList;

        [FindsBy(How = How.CssSelector, Using = ".es-icon.es-icon-setting")]
        private IWebElement _personalOptPage;

        [FindsBy(How = How.CssSelector, Using = ".user-nav-li-logout")]
        private IWebElement _logout;

        public void Persoanl()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".avatar-xs")));
            var actions = new Actions(Browser.Driver2);
            actions.MoveToElement(_personalList).Perform();
        }

        public void SelectLogout()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".user-nav-li-logout")));
            var actions = new Actions(Browser.Driver2);//执行鼠标事件ActionChains
            actions.MoveToElement(_logout).Click().Perform();
            //Perform执行所有 ActionChains 中存储的行为
            Thread.Sleep(5000);
        }

        public void SelectPersonalOption()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".es-icon.es-icon-setting")));
            var actions = new Actions(Browser.Driver2);
            actions.MoveToElement(_personalOptPage).Click().Perform();
        }
    }
}
