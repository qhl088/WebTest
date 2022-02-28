using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAuto1
{
    public class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver();

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver Driver2
        {
            get
            {
                return webDriver;
            }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }

        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }

        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                PageFactory.InitElements(Browser.Driver, loginPage);
                return loginPage;
            }
        }

        public static PersonalList PersonalList
        {
            get
            {
                var personalList = new PersonalList();
                PageFactory.InitElements(Browser.Driver, personalList);
                return personalList;
            }
        }

        public static PersonalOptionPage PersonalOptionPage
        {
            get
            {
                var personalOptPage = new PersonalOptionPage();
                PageFactory.InitElements(Browser.Driver, personalOptPage);
                return personalOptPage;
            }
        }

        public static AvatarSetPage AvatarSetPage
        {
            get
            {
                var avatarSetPage = new AvatarSetPage();
                PageFactory.InitElements(Browser.Driver, avatarSetPage);
                return avatarSetPage;
            }
        }

        public static RegisterPage RegisterPage
        {
            get
            {
                var registerPage = new RegisterPage();
                PageFactory.InitElements(Browser.Driver,registerPage);
                return registerPage;
            } 
        }

        public static RestPage RestPage
        {
            get
            {
                var restPage = new RestPage();
                PageFactory.InitElements(Browser.Driver,restPage);
                return restPage;
            }
        }

        public static BasicInfoPage BasicInfoPag
        {
            get
            {
                var basicInfoPage = new BasicInfoPage();
                PageFactory.InitElements(Browser.Driver, basicInfoPage);
                return basicInfoPage;
            }
        }

        public static AdminList AdminList
        {
            get
            {
                var adminList = new AdminList();
                PageFactory.InitElements(Browser.Driver, adminList);
                return adminList;
            }
        }

        public static AdminOptPage AdminOptPage
        {
            get
            {
                var adminOptPage = new AdminOptPage();
                PageFactory.InitElements(Browser.Driver, adminOptPage);
                return adminOptPage;
            }
        }

        public static AdminOderDetail AdminOderDetail
        {
            get
            {
                var adminOderDetail = new AdminOderDetail();
                PageFactory.InitElements(Browser.Driver, adminOderDetail);
                return adminOderDetail;
            }
        }

        public static AdminOperations AdminOperations
        {
            get
            {
                var adminOperations = new AdminOperations();
                PageFactory.InitElements(Browser.Driver, adminOperations);
                return adminOperations;
            }
        }

        public static AdminOpeNewsMange AdminOpeNewsMange
        {
            get
            {
                var adminOpeNewsMange = new AdminOpeNewsMange();
                PageFactory.InitElements(Browser.Driver, adminOpeNewsMange);
                return adminOpeNewsMange;
            }
        }

        public static OpeAddNews OpeAddNews //添加栏目
        {
            get
            {
                var opeAddNews = new OpeAddNews();
                PageFactory.InitElements(Browser.Driver, opeAddNews);
                return opeAddNews;
            }
        }



    }
}
