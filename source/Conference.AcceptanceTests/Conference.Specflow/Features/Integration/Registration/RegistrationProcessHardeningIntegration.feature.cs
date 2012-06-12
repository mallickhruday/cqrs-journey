﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Integration.Registration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class HardeningTheRegistrationProcessSoItBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature : Xunit.IUseFixture<HardeningTheRegistrationProcessSoItBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RegistrationProcessHardeningIntegration.feature"
#line hidden
        
        public HardeningTheRegistrationProcessSoItBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Hardening the RegistrationProcess so it be able to recover from unexpected condit" +
                    "ions and failures", "There are two general issues to consider\r\nMessages are handled successfully but t" +
                    "hey cannot be completed so they are handled again and\r\nthe process state is stor" +
                    "ed but the commands it generates fail to be published", ProgrammingLanguage.CSharp, new string[] {
                        "RegistrationProcessHardeningIntegration",
                        "NoWatiN"});
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
        
        public virtual void FeatureBackground()
        {
#line 28
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "100"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "100"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "100"});
#line 29
testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 34
testRunner.And("the selected Order Items", ((string)(null)), table2);
#line hidden
        }
        
        public virtual void SetFixture(HardeningTheRegistrationProcessSoItBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Hardening the RegistrationProcess so it be able to recover from unexpected condit" +
            "ions and failures")]
        [Xunit.TraitAttribute("Description", "The Command to Register the order is lost after a crash")]
        public virtual void TheCommandToRegisterTheOrderIsLostAfterACrash()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Command to Register the order is lost after a crash", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 28
this.FeatureBackground();
#line 42
testRunner.When("the command to register the selected Order Items is lost");
#line 43
testRunner.And("the event for Order placed is emitted");
#line 45
testRunner.Then("the command for reserving the selected Seats is received");
#line 47
testRunner.And("the event for reserving the selected Seats is emitted");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Hardening the RegistrationProcess so it be able to recover from unexpected condit" +
            "ions and failures")]
        [Xunit.TraitAttribute("Description", "Times-out afther the reservation is completed")]
        public virtual void Times_OutAftherTheReservationIsCompleted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Times-out afther the reservation is completed", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line 28
this.FeatureBackground();
#line 54
testRunner.When("the event for Order placed get expired");
#line 56
testRunner.Then("the command for cancelling the reservation is received");
#line 58
testRunner.And("the command for rejecting the order is received");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Hardening the RegistrationProcess so it be able to recover from unexpected condit" +
            "ions and failures")]
        [Xunit.TraitAttribute("Description", "Execute the Payment process after the order has expired")]
        public virtual void ExecuteThePaymentProcessAfterTheOrderHasExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute the Payment process after the order has expired", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 28
this.FeatureBackground();
#line 63
testRunner.Given("the event for Order placed get expired");
#line 65
testRunner.When("the command for initiate the payment is sent");
#line 67
testRunner.And("the command for completing the payment process is sent");
#line 69
testRunner.Then("the event for confirming the payment is emitted");
#line 71
testRunner.And("the event for confirming the Order is not emitted");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Hardening the RegistrationProcess so it be able to recover from unexpected condit" +
            "ions and failures")]
        [Xunit.TraitAttribute("Description", "Execute the Payment process after all seats are reserved")]
        public virtual void ExecuteThePaymentProcessAfterAllSeatsAreReserved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute the Payment process after all seats are reserved", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line 28
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table3.AddRow(new string[] {
                        "General admission"});
            table3.AddRow(new string[] {
                        "Additional cocktail party"});
#line 75
testRunner.Given("these Seat Types becomes unavailable before the Registrant make the reservation", ((string)(null)), table3);
#line 79
testRunner.And("the command to register the selected Order Items is sent");
#line 81
testRunner.When("the command for initiate the payment is sent");
#line 83
testRunner.And("the command for completing the payment process is sent");
#line 85
testRunner.Then("the event for partially confirming the order with no available seats is emitted");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                HardeningTheRegistrationProcessSoItBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                HardeningTheRegistrationProcessSoItBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
