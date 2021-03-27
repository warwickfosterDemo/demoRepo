using demoApp;
using System.Linq;
using demoApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace demoTest
{
    [TestClass]
    public class WeatherForecastController
    {
        [TestMethod]
        public void WeatherForecastControllerTest()
        {
            //Set
            demoApp.Controllers.WeatherForecastController weatherForecastController = new demoApp.Controllers.WeatherForecastController(null);
            
            //Test
            Assert.IsNotNull(weatherForecastController);


            //Set
            IEnumerable<WeatherForecast> weatherResult = weatherForecastController.Get();
            
            //Test
            Assert.IsNotNull(weatherResult);
            Assert.AreNotEqual(0, weatherResult.ToList().Count);
        }
    }
}
