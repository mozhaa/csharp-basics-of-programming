using NUnit.Framework;
using System;
using static NUnit.Framework.Assert;
using static Task3.Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        var tests = new List<Tuple<double, int>> {
            new Tuple<double, int>(0.1D, 1),
            new Tuple<double, int>(4.0D, 1),
            new Tuple<double, int>(5.1D, -1),
            new Tuple<double, int>(4.99999D, 1),
            new Tuple<double, int>(1.2D, -1),
            new Tuple<double, int>(5.5D, -1),
            new Tuple<double, int>(10000.0D, 1)
        };
        foreach(var test in tests){
            That(F(test.Item1), Is.EqualTo(test.Item2).Within(1e-5));
        }
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        var tests = new List<Tuple<int, int>> {
            new Tuple<int, int>(1984, 366),
            new Tuple<int, int>(1000, 365),
            new Tuple<int, int>(1200, 366),
            new Tuple<int, int>(1300, 365),
            new Tuple<int, int>(0, 366),
            new Tuple<int, int>(10000, 366),
            new Tuple<int, int>(10004, 366)
        };
        foreach(var test in tests){
            That(NumberOfDays(test.Item1), Is.EqualTo(test.Item2));
        }
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        var tests = new List<Tuple<char, int, int, char>> {
            new Tuple<char, int, int, char>('С', 1, -1, 'С'),
            new Tuple<char, int, int, char>('З', 1, -1, 'З'),
            new Tuple<char, int, int, char>('С', 1, 1, 'Ю'),
            new Tuple<char, int, int, char>('С', -1, 2, 'З'),
            new Tuple<char, int, int, char>('Ю', 2, 2, 'Ю')
        };
        foreach(var test in tests){
            That(Rotate2(test.Item1, test.Item2, test.Item3), Is.EqualTo(test.Item4));
        }
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        var tests = new List<Tuple<int, string>> {
            new Tuple<int, string>(37, "тридцать семь лет"),
            new Tuple<int, string>(38, "тридцать восемь лет"),
            new Tuple<int, string>(30, "тридцать лет"),
            new Tuple<int, string>(69, "шестьдесят девять лет"),
            new Tuple<int, string>(61, "шестьдесят один год"),
            new Tuple<int, string>(20, "двадцать лет"),
            new Tuple<int, string>(29, "двадцать девять лет"),
            new Tuple<int, string>(50, "пятьдесят лет"),
            new Tuple<int, string>(53, "пятьдесят три года"),
            new Tuple<int, string>(54, "пятьдесят четыре года"),
            new Tuple<int, string>(51, "пятьдесят один год")
        };
        foreach(var test in tests){
            That(AgeDescription(test.Item1), Is.EqualTo(test.Item2));
        }
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}