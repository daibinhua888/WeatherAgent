//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Administrator\Documents\GitHub\SplitTableEngine\Code\WeatherParser\WeatherParser\g4\WeatherRule.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace WeatherParser.g4 {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="WeatherRuleParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IWeatherRuleListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] WeatherRuleParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] WeatherRuleParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] WeatherRuleParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] WeatherRuleParser.ParseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.city_nday"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCity_nday([NotNull] WeatherRuleParser.City_ndayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.city_nday"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCity_nday([NotNull] WeatherRuleParser.City_ndayContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.city"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCity([NotNull] WeatherRuleParser.CityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.city"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCity([NotNull] WeatherRuleParser.CityContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.nday"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNday([NotNull] WeatherRuleParser.NdayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.nday"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNday([NotNull] WeatherRuleParser.NdayContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.relativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelativeExpression([NotNull] WeatherRuleParser.RelativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.relativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelativeExpression([NotNull] WeatherRuleParser.RelativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.positiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPositiveExpression([NotNull] WeatherRuleParser.PositiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.positiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPositiveExpression([NotNull] WeatherRuleParser.PositiveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.fixDayExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixDayExpression([NotNull] WeatherRuleParser.FixDayExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.fixDayExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixDayExpression([NotNull] WeatherRuleParser.FixDayExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.monthly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMonthly([NotNull] WeatherRuleParser.MonthlyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.monthly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMonthly([NotNull] WeatherRuleParser.MonthlyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.date"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDate([NotNull] WeatherRuleParser.DateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.date"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDate([NotNull] WeatherRuleParser.DateContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] WeatherRuleParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] WeatherRuleParser.NumberContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.weather"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWeather([NotNull] WeatherRuleParser.WeatherContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.weather"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWeather([NotNull] WeatherRuleParser.WeatherContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.how"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHow([NotNull] WeatherRuleParser.HowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.how"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHow([NotNull] WeatherRuleParser.HowContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="WeatherRuleParser.questionSymbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuestionSymbol([NotNull] WeatherRuleParser.QuestionSymbolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="WeatherRuleParser.questionSymbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuestionSymbol([NotNull] WeatherRuleParser.QuestionSymbolContext context);
}
} // namespace WeatherParser.g4