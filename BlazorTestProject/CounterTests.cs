using Bunit;
using SoftwareTestingSite.Pages;

namespace BlazorTestProject
{
    public class CounterTests : TestContext
    {
        [Fact]
        public void CounterShouldIncrementWhenClicked()
        {
            var cut = RenderComponent<Counter>();
            cut.Find("button").Click();
            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
            
        }
    }
}