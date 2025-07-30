using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Types;

public struct Color
{
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }
    public byte A { get; set; }
}

public struct ColorHSL
{
    //Alpha 0--1
    float Alpha { get; set; }
    //Hue 0-360
    float Hue { get; set; }
    //Saturation 0--1
    float Saturation { get; set; }
    //Lightness 0--1
    float Lightness { get; set; }
}


