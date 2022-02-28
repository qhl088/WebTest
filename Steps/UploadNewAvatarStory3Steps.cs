using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace WebAuto1.Features
{
    [Binding]
    public class UploadNewAvatarStory3Steps
    {
        [When(@"I select persaonl option")]
        public void WhenISelectPersaonlOption()
        {
            Browser.PersonalList.SelectPersonalOption();
        }
        
        [When(@"I select avatar setting")]
        public void WhenISelectAvatarSetting()
        {
            Browser.PersonalOptionPage.SelectAvatarSetting();
        }
        
        [When(@"I upload Specified image")]
        public void WhenIUploadSpecifiedImage()
        {
            //Browser.AvatarSetPage.ChooseNewAvatar();
            Browser.AvatarSetPage.UploadAvatar();
            Browser.AvatarSetPage.SaveAvaBtn();
        }
        
        [Then(@"the avatar upload should be successful")]
        public void ThenTheAvatarUploadShouldBeSuccessful()
        {
            Assert.That(Browser.AvatarSetPage.IsUploadAvaExist,Is.True);
        }
    }
}
