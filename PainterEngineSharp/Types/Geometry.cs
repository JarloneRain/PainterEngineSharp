using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Types;

/// <summary>
/// px_point2D
/// </summary>
public struct Point2D<T>
        where T : INumber<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public static Point2D<T> operator +(Point2D<T> lsh, Point2D<T> rsh) => new()
    {
        X = lsh.X + rsh.X,
        Y = lsh.Y + rsh.Y
    };
    public static Point2D<T> operator -(Point2D<T> lsh, Point2D<T> rsh) => new()
    {
        X = lsh.X - rsh.X,
        Y = lsh.Y - rsh.Y
    };
}


/// <summary>
/// px_point
/// </summary>
public struct Point<T>
    where T : INumber<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Z { get; set; }
    public static Point<T> operator +(Point<T> lsh, Point<T> rsh) => new()
    {
        X = lsh.X + rsh.X,
        Y = lsh.Y + rsh.Y,
        Z = lsh.Z + rsh.Z,
    };

    public static Point<T> operator -(Point<T> lsh, Point<T> rsh) => new()
    {
        X = lsh.X - rsh.X,
        Y = lsh.Y - rsh.Y,
        Z = lsh.Z - rsh.Z
    };
}

/// <summary>
/// px_point4D
/// </summary>
/// <typeparam name="T"></typeparam>
public struct Point4D<T>
    where T : INumber<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Z { get; set; }
    public T W { get; set; }
    public static Point4D<T> operator +(Point4D<T> lsh, Point4D<T> rsh) => new()
    {
        X = lsh.X + rsh.X,
        Y = lsh.Y + rsh.Y,
        Z = lsh.Z + rsh.Z,
        W = lsh.W + rsh.W
    };

    public static Point4D<T> operator -(Point4D<T> lsh, Point4D<T> rsh) => new()
    {
        X = lsh.X - rsh.X,
        Y = lsh.Y - rsh.Y,
        Z = lsh.Z - rsh.Z,
        W = lsh.W - rsh.W
    };
}

/// <summary>
/// px_plane
/// </summary>
public struct Plane
{
    public Point3D P0 { get; set; }
    public Vector3D Vn { get; set; }
}

/// <summary>
/// px_rect
/// </summary>
public struct Rectangle<T>
    where T : INumber<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Width { get; set; }
    public T Height { get; set; }
    public Point2D<T> XY
    {
        readonly get => new() { X = X, Y = Y };
        set => (X, Y) = (value.X, value.Y);
    }
}

/// <summary>
/// px_region
/// </summary>
public struct Region<T>
    where T : INumber<T>
{
    public T Left { get; set; }
    public T Right { get; set; }
    public T Top { get; set; }
    public T Bottom { get; set; }
}
