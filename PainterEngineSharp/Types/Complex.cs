using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Types;

/// <summary>
/// px_complex
/// </summary>
public struct Complex<T>
    where T : INumber<T>
{
    public T Re { get; set; }
    public T Im { get; set; }
}