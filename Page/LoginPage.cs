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
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "login_username")]
        private IWebElement _userName;

        [FindsBy(How = How.Id, Using = "login_password")]
        private IWebElement _password;

        [FindsBy(How = How.ClassName, Using = "js-btn-login")]
        private IWebElement _loginBtn;

        [FindsBy(How = How.LinkText, Using = "找回密码")]
        private IWebElement _restPwd;

        [FindsBy(How = How.Name, Using = "_remember_me")]
        private IWebElement _rembPwd;

        /// <summary>
        /// 登录测试账户
        /// </summary>
        /// <param name="name">测试用户名</param>
        /// <param name="password">测试密码</param>
        public void Login(string name, string password)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("js-btn-login")));

            _userName.Click();
            _userName.SendKeys(name);
            _password.Click();
            _password.SendKeys(password);
            //_loginBtn.Click();
            //_rembPwd.Click();
        }

        /// <summary>
        /// 找回密码
        /// </summary>
        public void FrogotPwd()
        {
            _restPwd.Click();
        }

        /// <summary>
        /// 不勾选记住密码
        /// </summary>
        public void RembPwdClear()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("_remember_me")));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("js-btn-login")));
            _rembPwd.Click();//取消勾选记住密码
            _loginBtn.Click();
        }

        /// <summary>
        /// 勾选记住密码
        /// </summary>
        public void RembPwdSelect()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 15));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("_remember_me")));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("js-btn-login")));
            var value = _rembPwd.Enabled;//记住密码是否开启
            if (value = false)
            {
                _rembPwd.Click();
            }
            _loginBtn.Click();
        }

        public IWebElement avtarDetail//定位头像出现
        {
            get
            {
                return Browser.Driver2.FindElement(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img"));
            }
        }

        public bool IsAvtarDetailExist//判断头像是否出现
        {
            get
            {
                return avtarDetail.Displayed;
            }
        }

        public IWebElement errorDetail//错误信息出现
        {
            get { return Browser.Driver2.FindElement(By.CssSelector(".alert.alert-danger")); }
            //css定位 前面加. 空格的地方用.来代替
        }

        public bool IsErrorDetailExist//判断错误信息是否出现
        {
            get { return errorDetail.Displayed; }
        }

        public bool IsLoginBtnExist//判断登录按钮是否出现
        {
            get { return _loginBtn.Displayed; }
        }
    }
}
