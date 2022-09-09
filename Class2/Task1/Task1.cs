using System.Text;

namespace Task1
{
    public class Task1
    {
/*
 * Задание 1.1. Дана строка. Верните строку, содержащую текст "Длина: NN",
 * где NN — длина заданной строки. Например, если задана строка "hello",
 * то результатом должна быть строка "Длина: 5".
 */
        internal static int StringLength(string s)
        {
            // return $"Длина: {s.Length}";
            return s.Length;
        }

/*
 * Задание 1.2. Дана непустая строка. Вернуть коды ее первого и последнего символов.
 * Рекомендуется найти специальные функции для вычисления соответствующих символов и их кодов.
 */
        internal static Tuple<int?, int?> FirstLastCodes(string s)
        {
            return new Tuple<int?, int?>(Code(First(s)), Code(Last(s)));
        }
        
        private static char? First(string s) => s[0]; 
        private static char? Last(string s) => s[s.Length - 1];
        private static int? Code(char? c) => Convert.ToInt32(c);
       

/*
 * Задание 1.3. Дана строка. Подсчитать количество содержащихся в ней цифр.
 * В решении необходимо воспользоваться циклом for.
 */
        internal static int CountDigits(string s)
        {
            int cnt = 0;
            for(int i = 0; i < s.Length; i++){
                if(Code(s[i]) <= Code('9') && Code(s[i]) >= Code('0')){
                    cnt++;
                }
            }
            return cnt;
        }

/*
 * Задание 1.4. Дана строка. Подсчитать количество содержащихся в ней цифр.
 * В решении необходимо воспользоваться методом Count:
 * https://docs.microsoft.com/ru-ru/dotnet/api/system.linq.enumerable.count?view=net-6.0#system-linq-enumerable-count-1(system-collections-generic-ienumerable((-0))-system-func((-0-system-boolean)))
 * и функцией Char.IsDigit:
 * https://docs.microsoft.com/ru-ru/dotnet/api/system.char.isdigit?view=net-6.0
 */
        internal static int CountDigits2(string s)
        {
            return Enumerable.Count(s, Char.IsDigit);
        }
        
/*
 * Задание 1.5. Дана строка, изображающая арифметическое выражение вида «<цифра>±<цифра>±…±<цифра>»,
 * где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»). Вывести значение
 * данного выражения (целое число).
 */
        internal static int CalcDigits(string expr) {
            string t = "";
            int oper = 1;
            int res = 0;
            for(int i = 0; i < expr.Length; i++){
                switch(expr[i]){
                    case '+':
                        res += oper * Convert.ToInt32(t);
                        oper = 1;
                        t = "";
                        break;
                    case '-':
                        res += oper * Convert.ToInt32(t);
                        oper = -1;
                        t = "";
                        break;
                    default:
                        t += expr[i];
                        break;
                }
            }
            res += oper * Convert.ToInt32(t);
            return res;
        }

/*
 * Задание 1.6. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2.
 */
        internal static string ReplaceWithString(string s, string s1, string s2) {
            var regex = new System.Text.RegularExpressions.Regex(System.Text.RegularExpressions.Regex.Escape(s1));
            return regex.Replace(s, s2, 1);
        }
        

        public static void Main(string[] args)
        {
            // Console.WriteLine(StringLength("1234"));
            // Console.WriteLine(First("abbbbc"));
            // Console.WriteLine(Last("abbbbc"));
            // Console.WriteLine(Code('g'));
            // Console.WriteLine(FirstLastCodes("abcde"));
            // Console.WriteLine(CountDigits("abbv43bbac3234ba1"));
            // Console.WriteLine(CountDigits2("abbv43bbac3234ba1"));
            // Console.WriteLine(CalcDigits("12+34-12-34+15"));
            // Console.WriteLine(ReplaceWithString("Aaaa bbb adad bbb", "bbb", "0000"));

            var tests = new Tests();
            tests.CalcDigitsTest();
            tests.CountDigits2Test();
            tests.FirstLastCodeTest();
            tests.StringLengthTest();
            tests.TestCountDigits();
            tests.ReplaceWithStringTest();
            Console.WriteLine("Tests passed");
        }
    }
}