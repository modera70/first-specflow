using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Logger.Logger.Log($"Given {number}");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Logger.Logger.Log($"Given {number}");

        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Logger.Logger.Log($"When");

        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Logger.Logger.Log($"Then {result}");

        }
    }
}
