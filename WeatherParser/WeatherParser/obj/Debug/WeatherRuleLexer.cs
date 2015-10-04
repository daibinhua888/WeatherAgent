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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class WeatherRuleLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, DIGITAL=7, CHINESEDIGITAL=8, 
		ZENMEYANG=9, QUESTION=10, DAYBEFORETODAY=11, TODAY=12, TOMORROW=13, DAYAFTERTOMORROW=14, 
		MONTH=15, DAY=16;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "DIGITAL", "CHINESEDIGITAL", 
		"ZENMEYANG", "QUESTION", "DAYBEFORETODAY", "TODAY", "TOMORROW", "DAYAFTERTOMORROW", 
		"MONTH", "DAY"
	};


	public WeatherRuleLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'�Ϻ�'", "'�ɶ�'", "'�˳�'", "'��'", "'��'", "'����'", null, null, null, 
		null, "'����'", "'����'", "'����'", "'����'", "'��'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "DIGITAL", "CHINESEDIGITAL", 
		"ZENMEYANG", "QUESTION", "DAYBEFORETODAY", "TODAY", "TOMORROW", "DAYAFTERTOMORROW", 
		"MONTH", "DAY"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "WeatherRule.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x12\xB4\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4"+
		"\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x5\b\x61"+
		"\n\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t"+
		"\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t"+
		"\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t"+
		"\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x5\t\x98"+
		"\n\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x5\n\xA1\n\n\x3\v\x3\v\x3\f\x3"+
		"\f\x3\f\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10"+
		"\x3\x11\x3\x11\x2\x2\x2\x12\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r"+
		"\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF"+
		"\x1D\x2\x10\x1F\x2\x11!\x2\x12\x3\x2\x5\f\x2\x4E02\x4E02\x4E05\x4E05\x4E0B"+
		"\x4E0B\x4E5F\x4E5F\x4E8E\x4E8E\x4E96\x4E96\x516D\x516D\x516F\x516F\x5343"+
		"\x5343\x56DD\x56DD\x4\x2\x41\x41\xFF21\xFF21\x4\x2\x53F9\x53F9\x65E7\x65E7"+
		"\xE0\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2"+
		"\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2"+
		"\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3"+
		"\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2"+
		"!\x3\x2\x2\x2\x3#\x3\x2\x2\x2\x5&\x3\x2\x2\x2\a)\x3\x2\x2\x2\t,\x3\x2"+
		"\x2\x2\v.\x3\x2\x2\x2\r\x30\x3\x2\x2\x2\xF`\x3\x2\x2\x2\x11\x97\x3\x2"+
		"\x2\x2\x13\xA0\x3\x2\x2\x2\x15\xA2\x3\x2\x2\x2\x17\xA4\x3\x2\x2\x2\x19"+
		"\xA7\x3\x2\x2\x2\x1B\xAA\x3\x2\x2\x2\x1D\xAD\x3\x2\x2\x2\x1F\xB0\x3\x2"+
		"\x2\x2!\xB2\x3\x2\x2\x2#$\a\x4E0C\x2\x2$%\a\x6D79\x2\x2%\x4\x3\x2\x2\x2"+
		"&\'\a\x6212\x2\x2\'(\a\x90FF\x2\x2(\x6\x3\x2\x2\x2)*\a\x8FD2\x2\x2*+\a"+
		"\x57D0\x2\x2+\b\x3\x2\x2\x2,-\a\x8FDB\x2\x2-\n\x3\x2\x2\x2./\a\x592B\x2"+
		"\x2/\f\x3\x2\x2\x2\x30\x31\a\x592B\x2\x2\x31\x32\a\x6C16\x2\x2\x32\xE"+
		"\x3\x2\x2\x2\x33\x61\x4\x33;\x2\x34\x35\a\x33\x2\x2\x35\x61\a\x32\x2\x2"+
		"\x36\x37\a\x33\x2\x2\x37\x61\a\x33\x2\x2\x38\x39\a\x33\x2\x2\x39\x61\a"+
		"\x34\x2\x2:;\a\x33\x2\x2;\x61\a\x35\x2\x2<=\a\x33\x2\x2=\x61\a\x36\x2"+
		"\x2>?\a\x33\x2\x2?\x61\a\x37\x2\x2@\x41\a\x33\x2\x2\x41\x61\a\x38\x2\x2"+
		"\x42\x43\a\x33\x2\x2\x43\x61\a\x39\x2\x2\x44\x45\a\x33\x2\x2\x45\x61\a"+
		":\x2\x2\x46G\a\x33\x2\x2G\x61\a;\x2\x2HI\a\x34\x2\x2I\x61\a\x32\x2\x2"+
		"JK\a\x34\x2\x2K\x61\a\x33\x2\x2LM\a\x34\x2\x2M\x61\a\x34\x2\x2NO\a\x34"+
		"\x2\x2O\x61\a\x35\x2\x2PQ\a\x34\x2\x2Q\x61\a\x36\x2\x2RS\a\x34\x2\x2S"+
		"\x61\a\x37\x2\x2TU\a\x34\x2\x2U\x61\a\x38\x2\x2VW\a\x34\x2\x2W\x61\a\x39"+
		"\x2\x2XY\a\x34\x2\x2Y\x61\a:\x2\x2Z[\a\x34\x2\x2[\x61\a;\x2\x2\\]\a\x35"+
		"\x2\x2]\x61\a\x32\x2\x2^_\a\x35\x2\x2_\x61\a\x33\x2\x2`\x33\x3\x2\x2\x2"+
		"`\x34\x3\x2\x2\x2`\x36\x3\x2\x2\x2`\x38\x3\x2\x2\x2`:\x3\x2\x2\x2`<\x3"+
		"\x2\x2\x2`>\x3\x2\x2\x2`@\x3\x2\x2\x2`\x42\x3\x2\x2\x2`\x44\x3\x2\x2\x2"+
		"`\x46\x3\x2\x2\x2`H\x3\x2\x2\x2`J\x3\x2\x2\x2`L\x3\x2\x2\x2`N\x3\x2\x2"+
		"\x2`P\x3\x2\x2\x2`R\x3\x2\x2\x2`T\x3\x2\x2\x2`V\x3\x2\x2\x2`X\x3\x2\x2"+
		"\x2`Z\x3\x2\x2\x2`\\\x3\x2\x2\x2`^\x3\x2\x2\x2\x61\x10\x3\x2\x2\x2\x62"+
		"\x98\t\x2\x2\x2\x63\x64\a\x5343\x2\x2\x64\x98\a\x4E02\x2\x2\x65\x66\a"+
		"\x5343\x2\x2\x66\x98\a\x4E8E\x2\x2gh\a\x5343\x2\x2h\x98\a\x4E0B\x2\x2"+
		"ij\a\x5343\x2\x2j\x98\a\x56DD\x2\x2kl\a\x5343\x2\x2l\x98\a\x4E96\x2\x2"+
		"mn\a\x5343\x2\x2n\x98\a\x516F\x2\x2op\a\x5343\x2\x2p\x98\a\x4E05\x2\x2"+
		"qr\a\x5343\x2\x2r\x98\a\x516D\x2\x2st\a\x5343\x2\x2t\x98\a\x4E5F\x2\x2"+
		"uv\a\x4E8E\x2\x2v\x98\a\x5343\x2\x2wx\a\x4E8E\x2\x2xy\a\x5343\x2\x2y\x98"+
		"\a\x4E02\x2\x2z{\a\x4E8E\x2\x2{|\a\x5343\x2\x2|\x98\a\x4E8E\x2\x2}~\a"+
		"\x4E8E\x2\x2~\x7F\a\x5343\x2\x2\x7F\x98\a\x4E0B\x2\x2\x80\x81\a\x4E8E"+
		"\x2\x2\x81\x82\a\x5343\x2\x2\x82\x98\a\x56DD\x2\x2\x83\x84\a\x4E8E\x2"+
		"\x2\x84\x85\a\x5343\x2\x2\x85\x98\a\x4E96\x2\x2\x86\x87\a\x4E8E\x2\x2"+
		"\x87\x88\a\x5343\x2\x2\x88\x98\a\x516F\x2\x2\x89\x8A\a\x4E8E\x2\x2\x8A"+
		"\x8B\a\x5343\x2\x2\x8B\x98\a\x4E05\x2\x2\x8C\x8D\a\x4E8E\x2\x2\x8D\x8E"+
		"\a\x5343\x2\x2\x8E\x98\a\x516D\x2\x2\x8F\x90\a\x4E8E\x2\x2\x90\x91\a\x5343"+
		"\x2\x2\x91\x98\a\x4E5F\x2\x2\x92\x93\a\x4E0B\x2\x2\x93\x98\a\x5343\x2"+
		"\x2\x94\x95\a\x4E0B\x2\x2\x95\x96\a\x5343\x2\x2\x96\x98\a\x4E02\x2\x2"+
		"\x97\x62\x3\x2\x2\x2\x97\x63\x3\x2\x2\x2\x97\x65\x3\x2\x2\x2\x97g\x3\x2"+
		"\x2\x2\x97i\x3\x2\x2\x2\x97k\x3\x2\x2\x2\x97m\x3\x2\x2\x2\x97o\x3\x2\x2"+
		"\x2\x97q\x3\x2\x2\x2\x97s\x3\x2\x2\x2\x97u\x3\x2\x2\x2\x97w\x3\x2\x2\x2"+
		"\x97z\x3\x2\x2\x2\x97}\x3\x2\x2\x2\x97\x80\x3\x2\x2\x2\x97\x83\x3\x2\x2"+
		"\x2\x97\x86\x3\x2\x2\x2\x97\x89\x3\x2\x2\x2\x97\x8C\x3\x2\x2\x2\x97\x8F"+
		"\x3\x2\x2\x2\x97\x92\x3\x2\x2\x2\x97\x94\x3\x2\x2\x2\x98\x12\x3\x2\x2"+
		"\x2\x99\x9A\a\x6010\x2\x2\x9A\x9B\a\x4E4A\x2\x2\x9B\xA1\a\x6839\x2\x2"+
		"\x9C\x9D\a\x54EC\x2\x2\x9D\xA1\a\x80FF\x2\x2\x9E\x9F\a\x6010\x2\x2\x9F"+
		"\xA1\a\x6839\x2\x2\xA0\x99\x3\x2\x2\x2\xA0\x9C\x3\x2\x2\x2\xA0\x9E\x3"+
		"\x2\x2\x2\xA1\x14\x3\x2\x2\x2\xA2\xA3\t\x3\x2\x2\xA3\x16\x3\x2\x2\x2\xA4"+
		"\xA5\a\x662A\x2\x2\xA5\xA6\a\x592B\x2\x2\xA6\x18\x3\x2\x2\x2\xA7\xA8\a"+
		"\x4ECC\x2\x2\xA8\xA9\a\x592B\x2\x2\xA9\x1A\x3\x2\x2\x2\xAA\xAB\a\x6610"+
		"\x2\x2\xAB\xAC\a\x592B\x2\x2\xAC\x1C\x3\x2\x2\x2\xAD\xAE\a\x5410\x2\x2"+
		"\xAE\xAF\a\x592B\x2\x2\xAF\x1E\x3\x2\x2\x2\xB0\xB1\a\x670A\x2\x2\xB1 "+
		"\x3\x2\x2\x2\xB2\xB3\t\x4\x2\x2\xB3\"\x3\x2\x2\x2\x6\x2`\x97\xA0\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace WeatherParser.g4