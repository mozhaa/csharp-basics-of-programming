using System;

namespace Task3
{
    public class Task3
    {
/*
 * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
 */

/*
 * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
 * 	        0,	если x < 0,
 * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
           −1,	если x принадлежит [1, 2), [3, 4), … .
 */
        internal static double F(double x) => (x < 0) ? 0 : (Math.Floor(x)%2 == 0) ? 1 : -1;

/*
 * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
 * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
 * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
 * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
 */
        internal static int NumberOfDays(int year) => (year%4 != 0 || (year%100 == 0 && year%400 != 0)) ? 365 : 366;

/*
    * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
    * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
    * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
    * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
    * Вернуть ориентацию локатора после выполнения этих команд.
    */

        internal static char Rotate1(char orientation, int cmd1, int cmd2)
        {
            int direction = orientation switch {
                'С' => 0,
                'З' => 1,
                'Ю' => 2,
                'В' => 3,
                _ => -1
            };
            // Console.WriteLine($"INPUT: {orientation}({direction})");
            direction = (direction + cmd1 + 4) % 4;
            // Console.WriteLine($"OPERATION: \"{cmd1}\" -> direction: \"{direction}\"");
            direction = (direction + cmd2 + 4) % 4;
            // Console.WriteLine($"OPERATION: \"{cmd2}\" -> direction: \"{direction}\"");
            // Console.WriteLine($"RESULT: {(new char[] {'С', 'З', 'Ю', 'В'})[direction]}");
            return (new char[] {'С', 'З', 'Ю', 'В'})[direction];
        }

        internal static char Rotate2(char orientation, int cmd1, int cmd2)
        {
            return Rotate1(orientation, cmd1, cmd2);
        }

/*
 * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
 * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
 * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
 * 41 — «сорок один год».
 *
 * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
 * переполнено некорректными с точки зрения русского языка решениями.
 */
        internal static String AgeDescription(int age)
        {
            int first_digit = (age - age%10) / 10;
            int second_digit = age%10;
            string[] first_words = new string[] {"", "", "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто "};
            string[] second_words = new string[] {"", "один ", "два ", "три ", "четыре ", "пять ", "шесть ", "семь ", "восемь ", "девять "};
            string[] third_words = new string[] {"лет", "год", "года"};
            string result = "";
            result += first_words[first_digit];
            result += second_words[second_digit];
            result += second_digit switch {
                0 or 5 or 6 or 7 or 8 or 9 => third_words[0],
                1 => third_words[1],
                2 or 3 or 4 => third_words[2],
                _ => ""
            };
            return result;
        }

        public static void Main(string[] args)
        {
            // Console.WriteLine(F(3.2D));
            // Console.WriteLine(NumberOfDays(2022));
            // Console.WriteLine(Rotate1('С', 2, -1));
            // Console.WriteLine(Rotate2('С', -1, 2));
            // Console.WriteLine(AgeDescription(26));

            var tests = new Tests();
            tests.FTest();
            tests.NumberOfDaysTest();
            tests.Rotate2Test();
            tests.AgeDescriptionTest();
            Console.WriteLine("All tests were passed");
        }
    }
}