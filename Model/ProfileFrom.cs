using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class ProfileFrom
    {
        public int number { get; set; }
        public string info { get; set; }
        public string error { get; set; }

        Hashtable profileTest = new Hashtable();

        public void profileUpdate(int number,string info)
        {
            profileTest.Add(number, info);
        }
    }
}
