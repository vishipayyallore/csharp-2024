// File: Point2D.cs

namespace PointLib;

public struct Point
{
    public int X;
    public int Y;

    public override readonly string ToString() => $"Point 2D: ({X}, {Y})";
}
