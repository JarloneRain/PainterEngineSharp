using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Utils;

[StructLayout(LayoutKind.Explicit)]
internal struct Union<T1, T2>
    where T1 : struct
    where T2 : struct
{
    [FieldOffset(0)] public T1 Field1;
    [FieldOffset(0)] public T2 Field2;
}

[StructLayout(LayoutKind.Explicit)]
internal struct Union<T1, T2,T3>
    where T1 : struct
    where T2 : struct
    where T3 : struct
{
    [FieldOffset(0)] public T1 Field1;
    [FieldOffset(0)] public T2 Field2;
    [FieldOffset(0)] public T3 Field3;
}

