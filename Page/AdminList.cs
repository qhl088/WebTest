using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class AdminList
    {
        //es-icon es-icon-dashboard
        [FindsBy(How = How.CssSelector, Using = ".avatar-xs")]
        private IWebElement _adminList;

        [FindsBy(How = How.CssSelector, Using = ".es-icon.es-icon-dashboard")]
        private IWebElement _adminBckEnd;

        /// <summary>
        /// 鼠标移动至管理员头像
        /// </summary>
        public void Admin()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".avatar-xs")));
            var actions = new Actions(Browser.Driver2);
            actions.MoveToElement(_adminList).Perform();
        }

        /// <summary>
        /// 鼠标点击后台管理
        /// </summary>
        public void SelectAdminBckEnd()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".es-icon.es-icon-dashboard")));
            var actions = new Actions(Browser.Driver2);
            actions.MoveToElement(_adminBckEnd).Click().Perform();
        }
    }
}
