using NUnit.Framework;
using System;
using static NUnit.Framework.Assert;
using static Task2.Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(-10, 100, -10), Is.EqualTo(-10));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(1000000000, 1000000000, 1000000000), Is.EqualTo(1000000000));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(1000000000, 1000000000, 1000000000), Is.EqualTo(1000000000));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(-10, 1000000, 10000000), Is.EqualTo(10000000));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(-100, -1000, -10000), Is.EqualTo(-100));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        // Deg2Rad Tests
        double[] deg2rad_inputs = {180.0, -60.0, 90.0, 180*10, 0.0};
        double[] deg2rad_outputs = {3.14159, -1.0472, 1.5708, 31.41593, 0.0};
        for(int i = 0; i < deg2rad_inputs.Length; i++){
            That(Deg2Rad(deg2rad_inputs[i]), Is.EqualTo(deg2rad_outputs[i]).Within(1e-5));
        }

        // Rad2Deg Tests
        double[] rad2deg_inputs = {Math.PI, -Math.PI * 0.75, Math.PI * 10, -Math.PI * 1.5, 0};
        double[] rad2deg_outputs = {180.0, -135.0, 1800.0, -270.0, 0.0};
        for(int i = 0; i < rad2deg_inputs.Length; i++){
            That(Rad2Deg(rad2deg_inputs[i]), Is.EqualTo(rad2deg_outputs[i]).Within(1e-5));
        }
    }
}