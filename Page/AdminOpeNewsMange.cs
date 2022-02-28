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
    public class AdminOpeNewsMange
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/ul/li[1]/a")]
        private IWebElement _newsManageS;//二级标签-资讯管理

        [FindsBy(How = How.LinkText, Using = "栏目管理")]
        private IWebElement _tagManage;//二级标签-栏目管理

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-primary")]
        private IWebElement _newSearch;//搜索

        #region 添加按钮可优化
        [FindsBy(How = How.LinkText, Using = "添加资讯")]
        private IWebElement _addNews;//添加资讯-btn btn-success btn-sm

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-success.btn-sm")]
        private IWebElement _addTag;//添加栏目-btn btn-success btn-sm
        #endregion
        
        [FindsBy(How = How.XPath, Using = "//*[@id='s2id_autogen1']")]
        private IWebElement _newsCategory;//所属栏目
        //*[@id="select2-drop"]/div/input
        [FindsBy(How = How.CssSelector, Using = ".select2-input")]
        private IWebElement _newsCategoryInput;//栏目输入

        [FindsBy(How = How.Name, Using = "keywords")]
        private IWebElement _newsKeywords;//标题关键字

        [FindsBy(How = How.Name, Using = "property")]
        private IWebElement _newsProperty;//属性

        [FindsBy(How = How.Name, Using = "status")]
        private IWebElement _newsStatus;//发布状态
        
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/a[2]")]
        private IWebElement _newsEditDrop;//资讯管理-编辑下拉菜单

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/ul[2]/li[2]/ul/li[1]/div/div[4]/a[1]")]
        private IWebElement _tagEdit;//栏目管理-编辑

        /// <summary>
        /// 执行搜索
        /// </summary>
        public void Search()
        {
            _newSearch.Click();
        }

        /// <summary>
        /// 所属栏目选择-EduSoho
        /// </summary>
        /// <param name="category">Edusoho</param>
        public void NewsCategory(string category)
        {
            _newsCategory.Click();
            _newsCategoryInput.SendKeys(category);
            Browser.Driver2.FindElement(By.Id("select2-result-1")).Click();//搜索选择定位结果
        }

        /// <summary>
        /// 标题关键字选择-世界
        /// </summary>
        /// <param name="keywords">世界</param>
        public void NewsKeywords(string keywords)
        {
            _newsKeywords.Click();
            _newsKeywords.SendKeys(keywords);
        }

        /// <summary>
        /// 属性-头条
        /// </summary>
        /// <param name="prop">头条</param>
        public void NewsProperty(string prop)
        {
            SelectElement selectObj = new SelectElement(_newsProperty);
            selectObj.SelectByText(prop);
        }

        /// <summary>
        /// 发布状态-已发布/未发布
        /// </summary>
        /// <param name="status">已发布/未发布</param>
        public void NewsStatus(string status)
        {
            SelectElement selectObj = new SelectElement(_newsStatus);
            selectObj.SelectByText(status);
        }

        /// <summary>
        /// 操作-发布/取消发布
        /// </summary>
        /// <param name="status">发布/取消发布</param>
        public void Edition(string status)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            _newsEditDrop.Click();
            var publishStatus = Browser.Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/ul/li[1]/a"));
            publishStatus.Click();//点一次发布第二次取消发布
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".btn.btn-default.btn-sm")));
        }

        /// <summary>
        /// 添加栏目
        /// </summary>
        public void SelectAddNews()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".btn.btn-success.btn-sm")));
            _addTag.Click();
        }

        /// <summary>
        /// 测试用例列表
        /// </summary>
        /// <param name="info">用例</param>
        public void CaseFilter(string info)
        {
            switch(info)
            {
                case "世界":NewsKeywords(info);
                    break;
                case "头条":NewsStatus(info);
                    break;
                case "已发布":NewsStatus(info);
                    break;
                case "未发布":NewsStatus(info);
                    break;
            }
        }


        /// <summary>
        /// 锁定栏目地址
        /// </summary>
        /// <param name="code">编码</param>
        public void SwitchTitle(string code)
        {
            Browser.Driver2.FindElement(By.PartialLinkText(code));
            _tagEdit.Click();
        }

        public bool IsTextExist1//未发布
        {
            get
            {
                Browser.Driver2.PageSource.Contains("2015-6-11");
                return true;
            }
        }

        public bool IsTextExist2//已发布
        {
            get
            {
                Browser.Driver2.PageSource.Contains("2015-5-21");
                return true;
            }
        }
    }
}
