// File: PointV1.cs

namespace ch03.Models;

public class PointV1
{
    public int X { get; init; }

    public int Y { get; init; }

    public override string ToString() => $"({X}, {Y})";
}
