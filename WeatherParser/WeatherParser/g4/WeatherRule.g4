grammar WeatherRule;

compileUnit
	:	parse
	;




parse
	:city_nday weather how? questionSymbol?
	;

city_nday
	:city nday
	|nday city
	;

city
	:'上海'
	|'成都'
	|'运城'
	;


nday
	:relativeExpression
	|positiveExpression
	|fixDayExpression
	;


relativeExpression
	:TODAY
	|TOMORROW
	|DAYAFTERTOMORROW
	|DAYBEFORETODAY
	;

positiveExpression
	:'这' number? '天'
	;

fixDayExpression
	: monthly date
	;

monthly
	: number MONTH
	;

date
	: number DAY
	;


number
	:DIGITAL
	|CHINESEDIGITAL
	;

DIGITAL
	:'1'
	|'2'
	|'3'
	|'4'
	|'5'
	|'6'
	|'7'
	|'8'
	|'9'
	|'10'
	|'11'
	|'12'
	|'13'
	|'14'
	|'15'
	|'16'
	|'17'
	|'18'
	|'19'
	|'20'
	|'21'
	|'22'
	|'23'
	|'24'
	|'25'
	|'26'
	|'27'
	|'28'
	|'29'
	|'30'
	|'31'
	;

CHINESEDIGITAL
	:'一'
	|'二'
	|'三'
	|'四'
	|'五'
	|'六'
	|'七'
	|'八'
	|'九'
	|'十'
	|'十一'
	|'十二'
	|'十三'
	|'十四'
	|'十五'
	|'十六'
	|'十七'
	|'十八'
	|'十九'
	|'二十'
	|'二十一'
	|'二十二'
	|'二十三'
	|'二十四'
	|'二十五'
	|'二十六'
	|'二十七'
	|'二十八'
	|'二十九'
	|'三十'
	|'三十一'
	;
	
weather
	:'天气'
	;

how
	: ZENMEYANG
	;

questionSymbol
	: QUESTION
	;


ZENMEYANG:'怎么样'|'哪能'|'怎样';

QUESTION:'?'|'？';


DAYBEFORETODAY:'昨天';
TODAY:'今天';
TOMORROW:'明天';
DAYAFTERTOMORROW:'后天';


MONTH:'月';
DAY:'号'|'日';

