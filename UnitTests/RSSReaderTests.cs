using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using RSSReader;

namespace UnitTestApp1
{
    [TestClass]
    public class RSSReaderTests
    {
        [TestMethod]
        public void TestMethod1()
        {
			var mapper = new LokoNewsMapping();
			var parser = new NewsParser(mapper);

			var reader = new RSSReader.RSSReader(parser, mapper);

            var result = reader.GetNews();

            Assert.IsNotNull(result.Result);
        }
    }
}
