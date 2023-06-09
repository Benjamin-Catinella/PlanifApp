
namespace TestPlanifApp
{
    [TestClass]
    public class UnitTest
    {
        // generate a call of object from ModelViewWeather.cs
        ModelViewWeather modelWeather = new ModelViewWeather();

        [TestMethod]
        public void TestVille()
        {
            // Arrange
            
            string CityReceived = modelWeather.City;
            string CityExpected = "Grenoble";
            // Act

            // Assert
            Assert.AreEqual(CityExpected, CityReceived);
        }
    }
}