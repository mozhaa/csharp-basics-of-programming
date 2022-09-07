using System;

namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for(int i = 0; i < height; i++){
                for(int j = 0; j < width; j++){
                    if(i == 0 || i == height - 1 || j == 0 || j == width - 1){
                        Console.Write(frameChar);
                    }
                    else{
                        Console.Write(' ');
                    }
                }
                Console.Write('\n');
            }
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int i = 0;
            while(i < height){
                int j = 0;
                while(j < width){
                    if(i == 0 || i == height - 1 || j == 0 || j == width - 1){
                        Console.Write(frameChar);
                    }
                    else{
                        Console.Write(' ');
                    }
                    j++;
                }
                Console.Write('\n');
                i++;
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            if(a == 0 || b == 0){
                return Math.Max(a, b);
            }
            long _max = Math.Max(a, b), _min = Math.Min(a, b);
            return Gcd(_min, _max % _min);
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double result = 0;
            for(int i = 0; i <= n; i++){
                double add_value = 1.0D;
                for(int k = 1; k <= i; k++){
                    add_value *= x;
                    add_value /= Convert.ToDouble(k);
                }
                result += add_value;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            // PrintFrame(5, 3, '+');
            // PrintFrame2(6, 3, '#');
            // Console.WriteLine(Gcd(36, 24));
            // Console.WriteLine(ExpTaylor(Math.E, 10));
            
            var tests = new Tests();
            tests.Setup();
            tests.TestPrintFrame1();
            tests.TearDown();
            
            tests.Setup();
            tests.TestPrintFrame2();
            tests.TearDown();

            tests.Setup();
            tests.TestGcd();
            tests.TearDown();

            tests.Setup();
            tests.TestExpTaylor();
            tests.TearDown();

            Console.WriteLine("All tests were passed");
        }
    }
}