using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class OrderList
    {
        [FindsBy(How = How.CssSelector, Using = ".label.label-success")]
        private IWebElement _paymentTagSucc;//已付款

        ArrayList OrderLists = new ArrayList();
        //ArrayList DeflLists = new ArrayList();

        string tag = "已付款";
        public string orderList
        {
            get
            {
                OrderLists.Add("购买课程《EduSoho定制开发》- 默认教学计划");
                OrderLists.Add("购买班级《EduSoho产品介绍》");
                //OrderLists.Add("");//date 同 第一第二
                //OrderLists.Add("");//已付款 同 第一第二
                OrderLists.Add("暂无订单记录");//支付宝
                //OrderLists.Add("");//课程名称 同 第一
                //OrderLists.Add("");//班级编号 同 第二
                return orderList;
            }
        }

        public bool OrderResult
        {
            get
            {
                return _paymentTagSucc.Displayed;
            }
        }
        
        //public string sourceList
        //{
        //    get
        //    {
        //        var list = new List<string>()
        //        {
        //            "购买课程《EduSoho定制开发》- 默认教学计划",
        //            "购买班级《EduSoho产品介绍》",
        //            "暂无订单记录"
        //        };
        //        return sourceList;
        //    }
        //}

        //public string targetList
        //{
        //    get
        //    {
        //        var list = new List<string>()
        //        {
        //            "购买课程《EduSoho定制开发》- 默认教学计划",
        //            "购买班级《EduSoho产品介绍》",
        //            "暂无订单记录"
        //        };
        //        return targetList;
        //    }
        //}

    }
}
