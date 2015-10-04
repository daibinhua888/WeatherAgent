using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser
{
    static class Utils
    {
        private static Dictionary<string, int> intNumbers = new Dictionary<string, int>();
        private static Dictionary<string, int> chineseIntNumbers = new Dictionary<string, int>();

        static Utils()
        {
            for (int i = 1; i <= 31;i++ )
                intNumbers.Add(i.ToString(), i);

            chineseIntNumbers.Add("一", 1);
            chineseIntNumbers.Add("二", 2);
            chineseIntNumbers.Add("三", 3);
            chineseIntNumbers.Add("四", 4);
            chineseIntNumbers.Add("五", 5);
            chineseIntNumbers.Add("六", 6);
            chineseIntNumbers.Add("七", 7);
            chineseIntNumbers.Add("八", 8);
            chineseIntNumbers.Add("九", 9);
            chineseIntNumbers.Add("十", 10);
            chineseIntNumbers.Add("十一", 11);
            chineseIntNumbers.Add("十二", 12);
            chineseIntNumbers.Add("十三", 13);
            chineseIntNumbers.Add("十四", 14);
            chineseIntNumbers.Add("十五", 15);
            chineseIntNumbers.Add("十六", 16);
            chineseIntNumbers.Add("十七", 17);
            chineseIntNumbers.Add("十八", 18);
            chineseIntNumbers.Add("十九", 19);
            chineseIntNumbers.Add("二十", 20);
            chineseIntNumbers.Add("二十一", 21);
            chineseIntNumbers.Add("二十二", 22);
            chineseIntNumbers.Add("二十三", 23);
            chineseIntNumbers.Add("二十四", 24);
            chineseIntNumbers.Add("二十五", 25);
            chineseIntNumbers.Add("二十六", 26);
            chineseIntNumbers.Add("二十七", 27);
            chineseIntNumbers.Add("二十八", 28);
            chineseIntNumbers.Add("二十九", 29);
            chineseIntNumbers.Add("三十", 30);
            chineseIntNumbers.Add("三十一", 31);
        }

        internal static int Parse2Int(string numberString)
        {
            if(intNumbers.ContainsKey(numberString))
                return intNumbers[numberString];

            if (chineseIntNumbers.ContainsKey(numberString))
                return chineseIntNumbers[numberString];

            throw new NotSupportedException();
        }
    }
}
