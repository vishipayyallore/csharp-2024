// File: Point.cs

namespace ch03.Models;

public class PointV2
{
    public required int X { get; init; }

    public required int Y { get; init; }

    public override string ToString() => $"({X}, {Y})";
}
