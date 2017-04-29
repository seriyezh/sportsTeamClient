using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UnitTestApp1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var reader = new RSSReader.RSSReader();

            var result = reader.GetNews();

            Assert.IsNotNull(result);
        }
    }
}
