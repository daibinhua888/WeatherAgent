using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherParser.g4;

namespace WeatherParser
{
    public static class WeatherQuestionParser
    {
        public static ParseResult Parse(string sentence)
        {
            Antlr4.Runtime.AntlrInputStream input = new Antlr4.Runtime.AntlrInputStream(sentence);
            WeatherRuleLexer lexer = new WeatherRuleLexer(input);

            Antlr4.Runtime.UnbufferedTokenStream tokens = new Antlr4.Runtime.UnbufferedTokenStream(lexer);
            WeatherRuleParser parser = new WeatherRuleParser(tokens);
            parser.RemoveErrorListeners();

            var tree = parser.compileUnit();

            ParseTreeWalker walker = new ParseTreeWalker();

            WeatherListener lsn = new WeatherListener();

            walker.Walk(lsn, tree);

            return lsn.Result;
        }
    }
}
