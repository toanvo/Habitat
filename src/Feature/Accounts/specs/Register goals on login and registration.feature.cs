﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RegisterGoalsOnLoginAndRegistrationFeature : Xunit.IUseFixture<RegisterGoalsOnLoginAndRegistrationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Register goals on login and registration.feature"
#line hidden
        
        public RegisterGoalsOnLoginAndRegistrationFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Register goals on login and registration", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(RegisterGoalsOnLoginAndRegistrationFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Register goals on login and registration")]
        [Xunit.TraitAttribute("Description", "Account_Register goals on login and registration_UC1_Register new user")]
        public virtual void Account_RegisterGoalsOnLoginAndRegistration_UC1_RegisterNewUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Register goals on login and registration_UC1_Register new user", new string[] {
                        "NeedImplimentation"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table1.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 7
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table1, "When ");
#line 10
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("User expands Goals section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Goal name with score"});
            table2.AddRow(new string[] {
                        "Register page (0)"});
            table2.AddRow(new string[] {
                        "Login (0)"});
#line 14
 testRunner.Then("Then Following Goals section contains", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Register goals on login and registration")]
        [Xunit.TraitAttribute("Description", "Account_Register goals on login and registration_UC2_Login with new user")]
        public virtual void Account_RegisterGoalsOnLoginAndRegistration_UC2_LoginWithNewUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Register goals on login and registration_UC2_Login with new user", new string[] {
                        "NeedImplimentation"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table3.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 21
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table3, "Given ");
#line 24
 testRunner.And("User was logged out from the Habitat", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table4.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k"});
#line 27
 testRunner.When("Actor enteres following data into Login form fields", ((string)(null)), table4, "When ");
#line 30
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("User expands Goals section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Goal name with score"});
            table5.AddRow(new string[] {
                        "Register page(0)"});
            table5.AddRow(new string[] {
                        "Login(0)"});
            table5.AddRow(new string[] {
                        "Login(0)"});
#line 34
 testRunner.Then("Then Following Goals section contains", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Register goals on login and registration")]
        [Xunit.TraitAttribute("Description", "Account_Register goals on login and registration_UC3_Login twice with new user")]
        public virtual void Account_RegisterGoalsOnLoginAndRegistration_UC3_LoginTwiceWithNewUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Register goals on login and registration_UC3_Login twice with new user", new string[] {
                        "NeedImplimentation"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table6.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 43
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table6, "Given ");
#line 46
 testRunner.And("User was logged out from the Habitat", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table7.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k"});
#line 49
 testRunner.And("Actor enteres following data into Login form fields", ((string)(null)), table7, "And ");
#line 52
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("User clicks Log out on User Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table8.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k"});
#line 56
 testRunner.And("Actor enteres following data into Login form fields", ((string)(null)), table8, "And ");
#line 59
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("User clicks on <Info-sign> in the right down corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("User expands Goals section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Goal name with score"});
            table9.AddRow(new string[] {
                        "Register page(0)"});
            table9.AddRow(new string[] {
                        "Login(0)"});
            table9.AddRow(new string[] {
                        "Login(0)"});
            table9.AddRow(new string[] {
                        "Login(0)"});
#line 63
 testRunner.Then("Then Following Goals section contains", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegisterGoalsOnLoginAndRegistrationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegisterGoalsOnLoginAndRegistrationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
