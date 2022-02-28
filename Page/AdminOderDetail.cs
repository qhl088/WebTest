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
    public class AdminOderDetail
    {
        Actions actions = new Actions(Browser.Driver2);

        [FindsBy(How = How.CssSelector, Using = ".list-group-item")]
        private IWebElement _courseOrder;//课程订单

        [FindsBy(How = How.LinkText, Using = "班级订单")]
        private IWebElement _classOrder;//班级订单

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-primary")]
        private IWebElement _orderSearch;//订单搜索

        [FindsBy(How = How.Name, Using = "startDateTime")]
        private IWebElement _orderStartDate;//订单创建时间

        [FindsBy(How = How.Name, Using = "status")]
        private IWebElement _orderStatus;//订单状态
    
        [FindsBy(How = How.Name, Using = "payment")]
        private IWebElement _orderPayment;//订单支付方式
        
        [FindsBy(How = How.Name, Using = "keywordType")]
        private IWebElement _orderNumb;//订单号

        [FindsBy(How = How.CssSelector, Using = ".label.label-success")]
        private IWebElement _paymentTagSucc;//已付款

        [FindsBy(How = How.ClassName, Using = "empty")]
        private IWebElement _nullOrder;//暂无订单记录

        //[FindsBy(How = How.Name, Using = "keyword")]
        //private IWebElement _orderKeyword;//关键字

        /// <summary>
        /// 默认条件课程搜索
        /// </summary>
        public void Courselookup()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("课程订单")));
            _courseOrder.Click();
        }

        /// <summary>
        /// 默认条件班级搜索
        /// </summary>
        public void ClassLookup()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("班级订单")));
            _classOrder.Click();
            //actions.MoveToElement(_classOrder).Click().Perform();
        }

        /// <summary>
        /// 搜索
        /// </summary>
        public void SearchBtn()
        {
            _orderSearch.Click();
        }
        
        /// <summary>
        /// 测试列表
        /// </summary>
        /// <param name="n">测试编号</param>
        /// <param name="info">测试条件</param>
        /// 
        public void OrderSearch(int n, string info)
        {
            switch (n)
            {
                case 1:
                    _orderStartDate.Click();
                    _orderStartDate.SendKeys(info);
                    _orderSearch.Click();
                    break;
                case 2:
                    _orderStatus.Click();
                    OrderStatus(info);
                    _orderSearch.Click();
                    break;
                case 3:
                    _orderPayment.Click();
                    PaymentMethod(info);
                    _orderSearch.Click();
                    break;
                case 4:
                    _orderNumb.Click();
                    OrderNumb(info);
                    _orderSearch.Click();
                    break;
            }
        }

        /// <summary>
        /// 订单状态下拉菜单-已付款
        /// </summary>
        public void OrderStatus(string info)
        {
            SelectElement selectObj = new SelectElement(_orderStatus);
            selectObj.SelectByText(info);//paid已付款
        }

        /// <summary>
        /// 支付方式下拉菜单-支付宝
        /// </summary>
        /// <param name="info"></param>
        public void PaymentMethod(string info)
        {
            SelectElement selectObj = new SelectElement(_orderPayment);
            selectObj.SelectByText(info);//alipay支付宝
        }

        /// <summary>
        /// 订单号下拉菜单-课程名称|班级编号
        /// </summary>
        /// <param name="info"></param>
        public void OrderNumb(string info)
        {
            SelectElement selectObj = new SelectElement(_orderNumb);
            selectObj.SelectByText(info);//courseSetTitle课程名称||targetId班级编号
        }

        /// <summary>
        /// 获取查询订单结果
        /// </summary>
        public bool OrderResult
        {
            get
            {
                try
                {
                    return _paymentTagSucc.Displayed;
                }
                catch
                {
                    return _nullOrder.Displayed;
                }
            }
        }
    }
    
}
