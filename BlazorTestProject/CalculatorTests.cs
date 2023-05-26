using Bunit;
using SoftwareTestingSite.Pages;

namespace BlazorTestProject
{
    public class CalculatorTests : TestContext
    {
        [Fact]
    public void NumberButtonClickShouldAppendNumberToInputString()
    {
        // Arrange
        var component = RenderComponent<Calculator>();
        var numberButton = component.Find(".btn-primary[value='1']");

        // Act
        numberButton.Click();

        // Assert
        Assert.Equal("1", component.Instance.inputString);
    }


    [Fact]
    public void EqualsButtonClickShouldPerformAddCalculation()
    {
        // Arrange
        var component = RenderComponent<Calculator>();
        component.Instance.inputString = "5";
        component.Instance.operatorSymbol = "+";
        component.Instance.inputValue = 10.0;
        var equalsButton = component.Find(".btn-primary[value='=']");

        // Act
        equalsButton.Click();

        // Assert
        Assert.Equal("15", component.Instance.inputString);
    }
    }
}
