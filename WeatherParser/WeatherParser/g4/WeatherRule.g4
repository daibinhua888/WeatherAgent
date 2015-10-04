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
	:'�Ϻ�'
	|'�ɶ�'
	|'�˳�'
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
	:'��' number? '��'
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
	:'һ'
	|'��'
	|'��'
	|'��'
	|'��'
	|'��'
	|'��'
	|'��'
	|'��'
	|'ʮ'
	|'ʮһ'
	|'ʮ��'
	|'ʮ��'
	|'ʮ��'
	|'ʮ��'
	|'ʮ��'
	|'ʮ��'
	|'ʮ��'
	|'ʮ��'
	|'��ʮ'
	|'��ʮһ'
	|'��ʮ��'
	|'��ʮ��'
	|'��ʮ��'
	|'��ʮ��'
	|'��ʮ��'
	|'��ʮ��'
	|'��ʮ��'
	|'��ʮ��'
	|'��ʮ'
	|'��ʮһ'
	;
	
weather
	:'����'
	;

how
	: ZENMEYANG
	;

questionSymbol
	: QUESTION
	;


ZENMEYANG:'��ô��'|'����'|'����';

QUESTION:'?'|'��';


DAYBEFORETODAY:'����';
TODAY:'����';
TOMORROW:'����';
DAYAFTERTOMORROW:'����';


MONTH:'��';
DAY:'��'|'��';

