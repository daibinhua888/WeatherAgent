using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherParser.g4;

namespace WeatherParser
{
    internal class WeatherListener : WeatherRuleBaseListener
    {
        private ParseResult result = new ParseResult();

        public ParseResult Result
        {
            get
            {
                return this.result;
            }
        }

        public override void ExitCity(WeatherRuleParser.CityContext context)
        {
            //在哪里
            result.Where = context.GetText();
        }

        public override void ExitRelativeExpression(WeatherRuleParser.RelativeExpressionContext context)
        {
            /*
            DAYBEFORETODAY:'昨天';
            TODAY:'今天';
            TOMORROW:'明天';
            DAYAFTERTOMORROW:'后天';
            */
            DateTime whichDay = DateTime.Now;

            var tokenString = context.GetText();
            if (tokenString == "昨天")
                whichDay = whichDay.AddDays(-1);
            else if (tokenString == "今天")
                ;
            else if (tokenString == "明天")
                whichDay = whichDay.AddDays(1);
            else if (tokenString == "后天")
                whichDay = whichDay.AddDays(1);
            else
                throw new NotSupportedException();

            this.result.FromDate = whichDay;
            this.result.ToDate = whichDay;
        }

        public override void ExitPositiveExpression(WeatherRuleParser.PositiveExpressionContext context)
        {
            //      '这' number? '天'

            this.result.FromDate = DateTime.Now;

            var numToken = context.number();
            if (numToken == null)
            {
                this.result.ToDate = DateTime.Now;
                return;
            }

            var numberString = numToken.GetText();

            int day = Utils.Parse2Int(numberString);

            this.result.ToDate = DateTime.Now.AddDays(day);
        }

        public override void ExitFixDayExpression(WeatherRuleParser.FixDayExpressionContext context)
        {
            var monthString=context.monthly().number().GetText();
            var dayString = context.date().number().GetText();

            int month = Utils.Parse2Int(monthString);
            int day = Utils.Parse2Int(dayString);

            DateTime date = new DateTime(DateTime.Now.Year, month, day);

            this.result.FromDate = date;
            this.result.ToDate = date;
        }
    }
}
