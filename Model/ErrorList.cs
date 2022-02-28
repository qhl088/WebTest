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
    public class ErrorList
    {
        //string[] error = new string[5];
        #region 注册错误
        [FindsBy(How = How.Id, Using = "register_email-error")]
        private IWebElement _emailError;//请输入有效的电子邮件地址||请输入邮箱

        [FindsBy(How = How.Id, Using = "register_nickname-error")]
        private IWebElement _nameError;//字符长度必须小于等于18，一个中文字算2个字符||请输入用户名

        [FindsBy(How = How.Id, Using = "register_password-error")]
        private IWebElement _pwdError;//最少需要输入 5 个字符||请输入密码
        #endregion

        #region 个人信息错误
        [FindsBy(How = How.Id, Using = "profile_truename-error")]
        private IWebElement _truenameError;//最多只能输入 18 个字符

        [FindsBy(How = How.Id, Using = "profile_idcard-error")]
        private IWebElement _idcardError;//请正确输入您的身份证号码

        [FindsBy(How = How.Id, Using = "profile_mobile-error")]
        private IWebElement _mobileError;//请输入正确的手机号

        [FindsBy(How = How.Id, Using = "profile_title-error")]
        private IWebElement _titleError;//最多只能输入 24 个字符

        [FindsBy(How = How.Id, Using = "profile_site-error")]
        private IWebElement _siteError;//地址不正确，须以http://或者https://开头。

        [FindsBy(How = How.Id, Using = "weibo-error")]
        private IWebElement _weiboError;//地址不正确，须以http://或者https://开头。

        [FindsBy(How = How.Id, Using = "profile_qq-error")]
        private IWebElement _qqError;//请输入正确的QQ号
        #endregion

        Hashtable regError = new Hashtable();//只能在属性内添加集合元素

        ArrayList basicInfoError = new ArrayList();

        bool b;

        public string error
        {
            get
            {
                regError.Add(1, "字符长度必须小于等于18");
                regError.Add(2, "请输入有效的电子邮件地址");
                regError.Add(3, "最少需要输入5个字符");
                regError.Add(4, "请输入邮箱");
                //list.Add("字符长度必须小于等于18");
                //list.Add("请输入有效的电子邮件地址");
                //list.Add("最少需要输入5个字符");
                //list.Add("请输入邮箱");
                return error;
            }
        }

        public string errorOfProfile
        {
            get
            {
                basicInfoError.Add("最多只能输入 18 个字符");
                basicInfoError.Add("请正确输入您的身份证号码");
                basicInfoError.Add("请输入正确的手机号");
                basicInfoError.Add("最多只能输入 24 个字符");
                basicInfoError.Add("地址不正确，须以http://或者https://开头。");
                basicInfoError.Add("请输入正确的QQ号");
                return errorOfProfile;
            }
        }

        /// <summary>
        /// 验证个人设置错误
        /// </summary>
        /// <param name="error">测试错误信息</param>
        /// <returns></returns>
        public bool IsProfileErrorExist(string error)
        {
            try
            {
                basicInfoError.Contains(error);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 验证注册错误
        /// </summary>
        /// <param name="error">错误信息</param>
        /// <returns></returns>
        public bool IsErrorExist(string error)
        {

            foreach (var item in regError.Values)
            {
                if (regError.ContainsValue(error))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;

            //foreach (var item in errorOnPage)
            //{
            //    if(errorOnPage.Contains(error))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }    
            //}
            //return true;
        }

        //public bool IsErrorListExisit(string error)
        //{
        //    try
        //    {
        //        WebDriverWait wait = new WebDriverWait(Browser.Driver2, TimeSpan.FromSeconds(5));
        //        b = wait.Until(ExpectedConditions.TitleContains(error));
        //        return b = true;
        //    }
        //    catch
        //    {
        //        return b = false;
        //    }
        //}
    }
}
