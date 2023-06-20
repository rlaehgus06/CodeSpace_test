// add a namespace for the WeatherForecastController
using WebApi.Controllers;


namespace WebApiTests;

[TestClass]
public class WeatherForecastControllerTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }
    // add a test method that tests the GetRange method of WeatherForecastContoller
    // Path: test/WebApiTests/Controller/WeatherForecastControllerTests.cs

    [TestMethod]
    public void GetRange_Returns_WeatherForecast()
    {
        // Arrange
        var controller = new WeatherForecastController(null);
        var range = new DateRange { Length = 5 };

        // Act
        var result = controller.GetRange(range);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(5, result.Count());
    }

}