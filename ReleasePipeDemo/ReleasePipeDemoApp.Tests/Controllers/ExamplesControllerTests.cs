using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReleasePipeDemoApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleasePipeDemoApp.Controllers.Tests
{
    [TestClass()]
    public class ExamplesControllerTests
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("wrong", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }
    }
}