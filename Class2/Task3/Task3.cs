using System.Text.RegularExpressions;

namespace Task3
{
    public class Task3
    {
/*
 * Перед выполнением заданий рекомендуется просмотреть туториал по регулярным выражениям:
 * https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/regular-expression-language-quick-reference
 */

/*
 * Задание 3.1. Проверить, содержит ли заданная строка только цифры?
 */
        internal static bool AllDigits(string s) => new Regex("^[0-9]*$").IsMatch(s);

/*
 * Задание 3.2. Проверить, содержит ли заданная строка подстроку, состоящую
 * из букв abc в указанном порядке, но в произвольном регистре?
 */
        internal static bool ContainsABC(string s) => new Regex("abc", RegexOptions.IgnoreCase).IsMatch(s);

/*
 * Задание 3.3. Найти первое вхождение подстроки, состоящей только из цифр,
 * и вернуть её в качестве результата. Вернуть пустую строку, если вхождения нет.
 */
        internal static string FindDigitalSubstring(string s)
        {
            Match m = new Regex("[0-9]+").Match(s);
            return m.ToString();
        }

/*
 * Задание 3.4. Заменить все вхождения подстрок строки S, состоящих только из цифр,
 * на заданную строку S1.
 */
        internal static string HideDigits(string s, string s1)
        {
            string result = Regex.Replace(s, "[0-9]+", s1);
            return result;
        }

        public static void Main(string[] args)
        {
            // Console.WriteLine(AllDigits("12"));
            // Console.WriteLine(ContainsABC("iefvjaBcsfv"));
            // Console.WriteLine(ContainsABC("iefvjabcss"));
            // Console.WriteLine(ContainsABC("iefvjaBbcsfv"));
            // Console.WriteLine(FindDigitalSubstring("fgvj123dsj32"));
            // Console.WriteLine(HideDigits("___1231__34_fdvd_2298", "digits"));
            var tests = new Tests();
            tests.AllDigitsTest();
            tests.ContainsABCTest();
            tests.FindDigitalSubstringTest();
            tests.HideDigitsTest();
            Console.WriteLine("Passed");
        }
    }
}