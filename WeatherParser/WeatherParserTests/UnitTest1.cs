using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherParser;

namespace WeatherParserTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_上海今天天气怎么样()
        {
            var result = WeatherQuestionParser.Parse("上海今天天气怎么样？");

            Assert.AreEqual("上海", result.Where);
            Assert.AreEqual(DateTime.Now.Date, result.FromDate.Date);
        }

        [TestMethod]
        public void Test_上海十月1号天气怎么样()
        {
            var result = WeatherQuestionParser.Parse("上海十月1号天气怎么样");

            Assert.AreEqual("上海", result.Where);
            Assert.AreEqual(DateTime.Parse("2015-10-01"), result.FromDate.Date);
            Assert.AreEqual(DateTime.Parse("2015-10-01"), result.ToDate.Date);
        }

        [TestMethod]
        public void Test_十月1号上海天气怎么样()
        {
            var result = WeatherQuestionParser.Parse("十月1号上海天气怎么样");

            Assert.AreEqual("上海", result.Where);
            Assert.AreEqual(DateTime.Parse("2015-10-01"), result.FromDate.Date);
            Assert.AreEqual(DateTime.Parse("2015-10-01"), result.ToDate.Date);
        }
    }
}
