namespace PointLib;

public struct Point
{
    public int Z;
    public int X;
    public int Y;

    public override readonly string ToString() => $"Point 3D: ({X}, {Y}, {Z})";
}
