using System.Text;

namespace Task2
{
    public class Task2
    {

/*
 * В этих заданиях * рекомендуется всюду использовать класс StringBuilder.
 * Документация: https://docs.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-6.0
 */

/*
 * Задание 2.1. Дана непустая строка S и целое число N (> 0). Вернуть строку, содержащую символы
 * строки S, между которыми вставлено по N символов «*» (звездочка).
 */
        internal static string FillWithAsterisks(string s, int n)
        {
            var str = new StringBuilder(Convert.ToString(s[0]), s.Length * (n + 1));
            for(int i = 1; i < s.Length; i++){
                str.AppendFormat("{0}{1}", String.Concat(Enumerable.Repeat("*", n)), s[i]);
            }
            return str.ToString();
        }

/*
 * Задание 2.2. Сформировать таблицу квадратов чисел от 1 до заданного числа N.
 * Например, для N=4 должна получиться следующая строка:

1  1
2  4
3  9
4 16

 * Обратите внимание на выравнивание: числа в первом столбце выравниваются по левому краю,
 * а числа во втором -- по правому, причём между числами должен оставаться как минимум один
 * пробел. В решении можно использовать функции Pad*.
 */
        internal static string TabulateSquares(int n)
        {
            var maxLength = Convert.ToString(n).Length + Convert.ToString(Math.Pow(n, 2)).Length;    
            var result = new StringBuilder("", maxLength * (n + 1));
            for(int i = 1; i <= n; i++){
                result.Append($"{i} {Convert.ToString(Math.Pow(i, 2)).PadLeft(maxLength - Convert.ToString(i).Length)}");
                if(i != n){
                    result.Append("\n");
                }
            }
            return result.ToString();
        }

        public static void Main(string[] args)
        {
            // Console.WriteLine(FillWithAsterisks("abc", 2));
            // Console.WriteLine(TabulateSquares(20));

            var tests = new Tests();
            tests.TabulateSquaresTest();
            tests.FillWithAsterisksTest();
            Console.WriteLine("Tests passed");
        }
    }
}