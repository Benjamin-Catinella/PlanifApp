
namespace TestPlanifApp
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestVille()
        {
            // Arrange
            WeatherObject modelWeather = ModelViewWeather.ModelWeather();
            // Act

            // Assert
            Assert.AreEqual("Grenoble", modelWeather.City);
        }
    }
}