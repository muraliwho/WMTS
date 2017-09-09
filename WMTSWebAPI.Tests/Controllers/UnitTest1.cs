using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WMTSWebAPI.Controllers;
using System.Web.Mvc;

namespace WMTSWebAPI.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            WMTSController controller = new WMTSController();

            // Act
            string  result = controller.Get() as string;

            // Assert
            Assert.IsNotNull(result);
            //Assert.AreEqual("value", result);
            
            
        }
    }
}
