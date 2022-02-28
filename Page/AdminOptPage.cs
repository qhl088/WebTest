using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class AdminOptPage
    {
        [FindsBy(How = How.LinkText, Using = "订单")]
        private IWebElement _orderList;//管理后台-订单

        [FindsBy(How = How.LinkText, Using = "运营")]
        private IWebElement _operations;//管理后台-运营

        /// <summary>
        /// 点击订单
        /// </summary>
        public void SelectOderlist()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("订单")));
            _orderList.Click();
        }

        /// <summary>
        /// 点击运营
        /// </summary>
        public void SelectOperations()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("运营")));
            _operations.Click();
        }
    }
}
