using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Types;

public struct Matrix<T>
    where T : INumber<T>
{
    T m00, m01, m02, m03;
    T m10, m11, m12, m13;
    T m20, m21, m22, m23;
    T m30, m31, m32, m33;
    public T this[int i, int j]
    {
        readonly get => (i, j) switch
        {
            (0, 0) => m00,
            (0, 1) => m01,
            (0, 2) => m02,
            (0, 3) => m03,
            (1, 0) => m10,
            (1, 1) => m11,
            (1, 2) => m12,
            (1, 3) => m13,
            (2, 0) => m20,
            (2, 1) => m21,
            (2, 2) => m22,
            (2, 3) => m23,
            (3, 0) => m30,
            (3, 1) => m31,
            (3, 2) => m32,
            (3, 3) => m33,
            _ => throw new IndexOutOfRangeException()
        };
        set
        {
            switch((i, j))
            {
                case (0, 0): m00 = value; break;
                case (0, 1): m01 = value; break;
                case (0, 2): m02 = value; break;
                case (0, 3): m03 = value; break;
                case (1, 0): m10 = value; break;
                case (1, 1): m11 = value; break;
                case (1, 2): m12 = value; break;
                case (1, 3): m13 = value; break;
                case (2, 0): m20 = value; break;
                case (2, 1): m21 = value; break;
                case (2, 2): m22 = value; break;
                case (2, 3): m23 = value; break;
                case (3, 0): m30 = value; break;
                case (3, 1): m31 = value; break;
                case (3, 2): m32 = value; break;
                case (3, 3): m33 = value; break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
