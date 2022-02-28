using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class OrderFrom
    {
        public int number { get; set; }
        public string info { get; set; }
        public string error { get; set; }

        Hashtable orderTest = new Hashtable();

        /// <summary>
        /// 订单测试集合
        /// </summary>
        /// <param name="number">测试编号</param>
        /// <param name="info">测试条件</param>
        public void orderInput(int number, string info)
        {
            orderTest.Add(number, info);
        }
    }
}
