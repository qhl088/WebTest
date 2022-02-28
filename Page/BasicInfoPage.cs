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
    public class BasicInfoPage
    {
        [FindsBy(How = How.Id, Using = "profile_truename")]
        private IWebElement _truename;//真实姓名

        [FindsBy(How = How.Id, Using = "profile_idcard")]
        private IWebElement _idcard;//身份证

        [FindsBy(How = How.Id, Using = "profile_mobile")]
        private IWebElement _mobile;//手机号

        [FindsBy(How = How.Id, Using = "profile_title")]
        private IWebElement _title;//头衔

        [FindsBy(How = How.Id, Using = "profile_site")]
        private IWebElement _site;//个人空间

        [FindsBy(How = How.Id, Using = "weibo")]
        private IWebElement _weibo;//微博

        [FindsBy(How = How.Id, Using = "profile_qq")]
        private IWebElement _qq;//QQ号

        [FindsBy(How = How.Id, Using = "profile_truename-error")]
        private IWebElement _truenameError;//最多只能输入 18 个字符

        [FindsBy(How = How.CssSelector, Using = ".col-md-2.control-label")]
        private IWebElement _tagName;//真实姓名

        bool b = true; //模拟全局变量
        Actions actions = new Actions(Browser.Driver2);//鼠标点击行为

        /// <summary>
        /// 测试列表
        /// </summary>
        /// <param name="n">测试条件编号</param>
        /// <param name="info">测试内容</param>
        public void updateProfile(int n,string info)
        {
            switch (n)
            {
                case 1:
                    _truename.Click();
                    _truename.SendKeys(info);
                    _idcard.Click();
                    break;
                case 2:
                    _idcard.Click();
                    _idcard.SendKeys(info);
                    _mobile.Click();
                    break;
                case 3:
                    _mobile.Click();
                    _mobile.SendKeys(info);
                    _title.Click();
                    break;
                case 4:
                    _title.Click();
                    _title.SendKeys(info);
                    _site.Click();
                    break;
                case 5:
                    _site.Click();
                    _site.SendKeys(info);
                    _weibo.Click();
                    break;
                case 6:
                    _weibo.Click();
                    _weibo.SendKeys(info);
                    _qq.Click();
                    break;
                case 7:
                    _qq.Click();
                    _qq.SendKeys(info);
                    _weibo.Click();
                    break;
            }
        }

        /// <summary>
        /// 更新姓名
        /// </summary>
        /// <param name="name">测试名字</param>
        public void updateName(string name)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_truename")));
            _truename.Click();
            _truename.SendKeys(name);
            _tagName.Click();
            actions.MoveByOffset(0, 0).Click();//鼠标动作点击空白处
        }

        public bool IsNameErrorExist
        { 
            get
            {
                //if(_truename.Displayed==true)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
                
                try
                {
                    WebDriverWait wait = new WebDriverWait(Browser.Driver2, TimeSpan.FromSeconds(5));
                    b = wait.Until(ExpectedConditions.TitleContains("最多只能输入 18 个字符"));
                    return b = true;
                }
                catch
                {
                    return b = false;
                }
            }
        }
        
    }

}
