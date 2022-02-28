using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class RegisterPage
    {
        #region 对话框元素
        [FindsBy(How = How.ClassName, Using = "input-lg")]
        private IWebElement _regEmail;

        [FindsBy(How = How.Id, Using = "register_nickname")]
        private IWebElement _regName;

        [FindsBy(How = How.Id, Using = "register_password")]
        private IWebElement _regPwd;

        [FindsBy(How = How.Id, Using = "captcha_code")]
        private IWebElement _randCode;

        [FindsBy(How = How.Id, Using = "register-btn")]
        private IWebElement _registerBtn;
        #endregion
        #region 错误信息
        [FindsBy(How = How.Id, Using = "register_email-error")]
        private IWebElement _emailError;//请输入有效的电子邮件地址||请输入邮箱

        [FindsBy(How = How.Id, Using = "register_nickname-error")]
        private IWebElement _nameError;//字符长度必须小于等于18，一个中文字算2个字符||请输入用户名

        [FindsBy(How = How.Id, Using = "register_password-error")]
        private IWebElement _pwdError;//最少需要输入 5 个字符||请输入密码

        [FindsBy(How = How.Id, Using = "captcha_code-error")]
        private IWebElement _codeError;//验证码错误||请输入验证码
        #endregion
        /// <summary>
        /// 清空输入框
        /// </summary>
        public void ClearInput()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_email")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("captcha_code")));
            _regEmail.Click();
            _regEmail.Clear();
            _regName.Click();
            _regName.Clear();
            _regPwd.Click();
            _regPwd.Clear();
            _randCode.Click();
            _randCode.Clear();
        }
        /// <summary>
        /// 输入注册信息
        /// </summary>
        /// <param name="email">测试用邮箱</param>
        /// <param name="regname">测试用用户名</param>
        /// <param name="regpassword">测试用密码</param>
        /// <param name="code">测试用随机码</param>
        public void RegisterInfo(string regemail, string regname, string regpassword)
        {
            _regEmail.Click();
            _regEmail.SendKeys(regemail);
            _regName.Click();
            _regName.SendKeys(regname);
            _regPwd.Click();
            _regPwd.SendKeys(regpassword);
            //_randCode.Click();
            //_randCode.SendKeys(code);

        }

        /// <summary>
        /// 点击注册
        /// </summary>
        public void Registed()
        {
            _registerBtn.Click();
        }
        #region 判断错误是否出现
        public bool IsEmailErrorExist
        {
            get { return _emailError.Displayed; }
        }
        public bool IsNameErrorExist
        {
            get { return _nameError.Displayed; }
        }
        public bool IsPwdErrorExist
        {
            get { return _pwdError.Displayed; }
        }
        public bool IsCodeErrorExist
        {
            get { return _codeError.Displayed; }
        }
        #endregion
    }
}
