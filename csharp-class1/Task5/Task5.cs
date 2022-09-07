using System;
using System.Numerics;

namespace Task5
{
    public class Task5
    {
/*
 * Задание 5.1. Запустите функцию `main`, нажав зелёный треугольник слева от её имени. Это действие создаст
 * конфигурацию, которую позже можно отредактировать. В этом задании для ввода данных используются
 * либо параметры командной строки, либо консольный ввод. При запуске через Rider параметры командной строки
 * задаются в окне "Run/Edit configurations..." ("Program arguments:").
 */
        public static void Main(string[] args)
        {
            // DemoInput(args);
            // ComputeFib(args);
            var tests = new Tests();
            tests.Setup();
            tests.Test1();
            tests.TearDown();

            tests.Setup();
            tests.Test2();
            tests.TearDown();

            tests.Setup();
            tests.Test3();
            tests.TearDown();

            tests.Setup();
            tests.Test4();
            tests.TearDown();
            Console.WriteLine("All tests were passed");
        }

/*
 * Задание 5.2. Разберите код функции `demoInput`.
 */
        internal static void DemoInput(string[] args)
        {
            string name;
            if (args.Length > 0)
            {
                name = string.Join(" ", args);
            }
            else
            {
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Привет, {name}");
        }

/*
 * Задание 5.3. Напишите программу, которая принимает на вход целое неотрицательное число
 * (либо параметром командной строки, либо с клавиатуры) и печатает число Фибоначчи:
 * https://ru.wikipedia.org/wiki/%D0%A7%D0%B8%D1%81%D0%BB%D0%B0_%D0%A4%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8
 * с соответствующим номером. Мы считаем, что нулевым числом Фибоначчи является число 0, а первым — число 1.
 *
 * Для представления чисел Фибоначчи следует использовать длинные целые:
 * - https://docs.microsoft.com/ru-ru/dotnet/api/system.numerics.biginteger?view=net-6.0
 */

        internal static BigInteger Fib(int n)
        {
            var fibonaccis = new BigInteger[n+1];
            fibonaccis[0] = new BigInteger(BitConverter.GetBytes(0));
            fibonaccis[1] = new BigInteger(BitConverter.GetBytes(1));
            for(int i = 2; i <= n; i++){
                fibonaccis[i] = BigInteger.Add(fibonaccis[i - 1], fibonaccis[i - 2]);
            }
            return fibonaccis[n];
        }

        internal static void ComputeFib(string[] args)
        {
            int n = 0;
            if(args.Length > 0){
                n = Convert.ToInt32(args[0]);
            }
            else{
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Fib(n).ToString());
        }
    }
}