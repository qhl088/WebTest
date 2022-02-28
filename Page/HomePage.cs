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
    public class HomePage
    {
        static string Url = "http://lyratesting2.co.nz/";

        [FindsBy(How = How.LinkText, Using = "登录")]
        private IWebElement _login;

        [FindsBy(How = How.LinkText, Using = "注册")]
        private IWebElement _register;

        //选择登录功能
        public void SelectLogin()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("登录")));
            _login.Click();
        }

        public void SelectRegister()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("注册")));
            _register.Click();
        }
        public void Goto()
        {
            Browser.Goto(Url);
        }
    }
}
