using System;

namespace Plotter
{
    partial class WindowController
    {
        private double Fn1(double x) => Math.Sin(x);

        private double Fn2(double x) => 4 * Math.Pow(x, 2) - 2 * x - 22;

        private double Fn3(double x) => Math.Log10(Math.Pow(x, 2)) / Math.Pow(x, 3);
    }
}
