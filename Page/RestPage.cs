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
    public class RestPage
    {
        [FindsBy(How = How.Id, Using = "form_email")]
        private IWebElement _typeEmail;

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-primary")]
        private IWebElement _restBtn;

        /// <summary>
        /// 输入无效邮箱
        /// </summary>
        /// <param name="email">列表内邮箱</param>
        public void TypeEmail(string email)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("form_email")));
            _typeEmail.SendKeys(email);  
        }

        /// <summary>
        /// 重设密码
        /// </summary>
        public void RestPwd()
        {
            _restBtn.Click();
        }

        #region 该邮箱地址没有注册过帐号
        public IWebElement unregistEmailError
        {
            get { return Browser.Driver2.FindElement(By.CssSelector(".alert.alert-danger")); }
        }
        public bool IsUnregisterEmailErorExist
        {
            get { return unregistEmailError.Displayed; }
        }
        #endregion

        #region 请输入有效的电子邮件地址
        public IWebElement invalidEmailError
        {
            get { return Browser.Driver2.FindElement(By.CssSelector(".form-error-message.jq-validate-error")); }
        }
        public bool IsInvalidEmailErrorExist
        {
            get { return invalidEmailError.Displayed; }
        }
        #endregion

    }
}
