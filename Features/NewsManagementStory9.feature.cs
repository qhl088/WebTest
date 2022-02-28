﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WebAuto1.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NewsManagementStory9")]
    public partial class NewsManagementStory9Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NewsManagementStory9.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NewsManagementStory9", "\tNews management searching by multiple filter\r\n\tChanging the status of an article" +
                    "\r\n\tAdding a category on News Management Page\r\n\tAdding a new Category and Edit th" +
                    "e category, change the Category name.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("News management searching by multiple filter")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("Edusoho", "", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("Edusoho", "世界", "", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("Edusoho", "", "头条", "", "", null)]
        [NUnit.Framework.TestCaseAttribute("Edusoho", "", "", "已发布", "", null)]
        [NUnit.Framework.TestCaseAttribute("Edusoho", "", "", "", "未发布", null)]
        public virtual void NewsManagementSearchingByMultipleFilter(string category, string keyword, string property, string published, string unpublished, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("News management searching by multiple filter", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I can open homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "password"});
            table1.AddRow(new string[] {
                        "admin",
                        "5EstafeyEtre"});
#line 10
 testRunner.And("I can login admin account", ((string)(null)), table1, "And ");
#line 13
 testRunner.When("I select News Management go to news mangement page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.And(string.Format("searching by multiple filter {0} and <case>", category), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.Then("the result is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Changing the status of an article")]
        public virtual void ChangingTheStatusOfAnArticle()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Changing the status of an article", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("I can open homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "password"});
            table2.AddRow(new string[] {
                        "admin",
                        "5EstafeyEtre"});
#line 27
 testRunner.And("I can login admin account", ((string)(null)), table2, "And ");
#line 30
 testRunner.When("I select News Management go to news mangement page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "category",
                        "published",
                        "unpublished"});
            table3.AddRow(new string[] {
                        "Edusoho",
                        "发布",
                        "取消发布"});
#line 31
 testRunner.And("switch an article status", ((string)(null)), table3, "And ");
#line 34
 testRunner.Then("the result is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adding a category on News Management Page")]
        public virtual void AddingACategoryOnNewsManagementPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding a category on News Management Page", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
 testRunner.Given("I can open homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "password"});
            table4.AddRow(new string[] {
                        "admin",
                        "5EstafeyEtre"});
#line 38
 testRunner.And("I can login admin account", ((string)(null)), table4, "And ");
#line 41
 testRunner.When("I select News Management go to category mangement page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "title",
                        "code"});
            table5.AddRow(new string[] {
                        "自动化",
                        "314bbc"});
#line 42
 testRunner.And("open new category and title is <title> and code <code>", ((string)(null)), table5, "And ");
#line 45
 testRunner.Then("the result title is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adding a new Category and Edit the category, change the Category name.")]
        public virtual void AddingANewCategoryAndEditTheCategoryChangeTheCategoryName_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding a new Category and Edit the category, change the Category name.", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
 testRunner.Given("I can open homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "password"});
            table6.AddRow(new string[] {
                        "admin",
                        "5EstafeyEtre"});
#line 49
 testRunner.And("I can login admin account", ((string)(null)), table6, "And ");
#line 52
 testRunner.When("I select News Management go to category mangement page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "title",
                        "code",
                        "newtitle"});
            table7.AddRow(new string[] {
                        "自动化",
                        "314bbc",
                        "自动化测试"});
#line 53
 testRunner.And("switch <code> to <newtitle> status", ((string)(null)), table7, "And ");
#line 56
 testRunner.Then("the result title status is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

