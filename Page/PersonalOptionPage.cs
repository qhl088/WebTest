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
    public class PersonalOptionPage
    {
        [FindsBy(How = How.CssSelector, Using = ".glyphicon.glyphicon-user")]
        private IWebElement _profileSetting;//基础信息

        [FindsBy(How = How.CssSelector, Using = ".glyphicon.glyphicon-picture")]
        private IWebElement _avatarSetting;//头像设置

        public void SelectAvatarSetting()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".glyphicon.glyphicon-picture")));
            _avatarSetting.Click();
        }

        public void SelectProfileSetting()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".glyphicon.glyphicon-user")));
            _profileSetting.Click();
        }
    }
}
