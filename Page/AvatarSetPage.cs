using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class AvatarSetPage
    {
        [FindsBy(How = How.LinkText, Using = "上传新头像")]
        private IWebElement _uploadAvatar;//上传新头像

        [FindsBy(How = How.Name, Using = "file")]
        private IWebElement _uploadFile;//上传新头像文件

        [FindsBy(How = How.Id, Using = "upload-avatar-btn")]
        private IWebElement _saveAvaBtn;//保存新头像

        //[FindsBy(How = How.CssSelector, Using = ".notify.notify-error")]
        //private IWebElement _errorInfo;//错误信息

        public void ChooseNewAvatar()
        {
            //_uploadAvatar.Click();不需要点击，会出现文件选择框，直接SendKey
            //_uploadBtn.SendKeys(@"C:\Users\Qiao\Desktop\OIF.jpg");
        }
        public void UploadAvatar()
        {
            _uploadFile.SendKeys(@"C:\Users\Qiao\Desktop\OIF.jpg");
            Thread.Sleep(5000);
        }
        public void SaveAvaBtn()
        {
            _saveAvaBtn.Click();
            Thread.Sleep(5000);
        }
        public bool IsUploadAvaExist
        {
            get
            {
                return _uploadAvatar.Displayed;
            }
        }
    }
}
