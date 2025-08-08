using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Types;

/// <summary>
/// px_color
/// </summary>
public struct Color
{
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }
    public byte A { get; set; }
}


/// <summary>
/// px_color_hsl
/// </summary>
public struct ColorHSL
{
    /// <summary>
    /// Alpha 0--1
    /// </summary>
    float Alpha { get; set; }
    /// <summary>
    /// Hue 0-360
    /// </summary>
    float Hue { get; set; }
    /// <summary>
    /// Saturation 0--1
    /// </summary>
    float Saturation { get; set; }
    /// <summary>
    /// Lightness 0--1
    /// </summary>
    float Lightness { get; set; }
}

/// <summary>
/// px_color_hsv
/// </summary>
public struct ColorHSV
{
    /// <summary>
    /// Alpha 0--1
    /// </summary>
    public float Alpha { get; set; }
    /// <summary>
    /// Hue 0-360
    /// </summary>
    public float Hue { get; set; }
    /// <summary>
    /// Saturation 0--100
    /// </summary>
    public float Saturation { get; set; }
    /// <summary>
    /// Value 0--100
    /// </summary>
    public float Value { get; set; }
}

struct ColorYCbCr
{
    public byte Alpha { get; set; }
    public sbyte Y { get; set; }
    public sbyte Cb { get; set; }
    public sbyte Cr { get; set; }
}