using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Utils;

using SMath = System.Math;

public static class Math
{
    /// <summary>
    /// PX_sigmoid
    /// </summary>
    public static double Sigmoid(double x) => 1 / (1 + SMath.Exp(-x));

    /// <summary>
    /// PX_ReLU
    /// </summary>
    public static double ReLU(double x) => x <= 0 ? 0 : x;

    /// <summary>
    /// PX_sinc
    /// </summary>
    public static double Sinc(double i) => i == 0 ? 1 : SMath.Sin(i * SMath.PI) / i * SMath.PI;

    /// <summary>
    /// PX_sinc_interpolate
    /// </summary>
    public static double SincInterpolate (double[] x, int size, double d)
    {
        double sum = 0;
        for(int i = 0; i < size; i++)
            sum += x[i] * Sinc(d - i);
        return sum;
    }

    public static double Sin<T>(this Types.Point2D<T> p)
    {
        return p.X/SMath.Sqrt(p.X*p.X+p.Y*p.Y);
    }

}

