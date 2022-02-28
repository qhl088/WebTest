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
    public class OpeAddNews
    {
        [FindsBy(How = How.Id, Using = "category-name-field")]
        private IWebElement _catTitle;//栏目名称

        [FindsBy(How = How.Id, Using = "category-code-field")]
        private IWebElement _catCode;//栏目编码

        [FindsBy(How = How.Id, Using = "category-save-btn")]
        private IWebElement _catAdd;//栏目添加

        //ITargetLocator locator = Browser.Driver2.SwitchTo();
        //IAlert alert = Browser.Driver2.SwitchTo().Alert();
        //*[@id="category-name-field"]
        //

        /// <summary>
        /// 创建栏目名称
        /// </summary>
        /// <param name="title">名称</param>
        /// <param name="code">编码</param>
        public void CreateCategory(string title,string code)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("category-name-field")));
            _catTitle.SendKeys(title);
            _catCode.SendKeys(code);
        }

        /// <summary>
        /// 编辑栏目
        /// </summary>
        /// <param name="title">新名称</param>
        public void EditCategory(string title)
        {
            _catTitle.Click();
            _catTitle.Clear();
            _catTitle.SendKeys(title);
        }

        /// <summary>
        /// 保存修改
        /// </summary>
        public void CatSaveBtn()
        {
            _catAdd.Click();
        }
    }
}
