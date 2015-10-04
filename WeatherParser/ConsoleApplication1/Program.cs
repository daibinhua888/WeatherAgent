using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherParser;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = WeatherQuestionParser.Parse("上海今天天气怎么样？");

            result = WeatherQuestionParser.Parse("上海十月1号天气怎么样");

            Console.ReadKey();
        }
    }
}
