// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GloboChallenge.Challenge.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Register")]
    [NUnit.Framework.CategoryAttribute("Chrome")]
    public partial class RegisterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Register.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Register", "Narrativa:\r\n\tEu como usuario do sistema\r\n\tQuero fazer um novo cadastro\r\n\tPara ter" +
                    " acesso a todos os recursos do sistema", ProgrammingLanguage.CSharp, new string[] {
                        "Chrome"});
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1 - Criar Novo Cadastro")]
        public virtual void _1_CriarNovoCadastro()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1 - Criar Novo Cadastro", null, ((string[])(null)));
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
 testRunner.Given("que eu navegue para a tela Home", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 14
 testRunner.When("clico em Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 15
 testRunner.And("preencho os dados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 16
 testRunner.Then("vejo a mensagem de cadastrado com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2 - Erro ao Criar Novo Cadastro")]
        public virtual void _2_ErroAoCriarNovoCadastro()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 - Erro ao Criar Novo Cadastro", null, ((string[])(null)));
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
 testRunner.Given("que eu navegue para a tela Home", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 20
 testRunner.When("clico em Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 21
 testRunner.And("preencho os dados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 22
 testRunner.Then("vejo a mensagem de que não foi possível se cadastrar com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
