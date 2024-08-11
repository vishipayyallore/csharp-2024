// File: Program.cs

using ch03;

PointV1 ptV1 = new() { Y = 12 };
PointV2 ptV2 = new() { X = 30, Y = 12 }; // What happens if X (or X & Y) are omitted?

WriteLine($"Point V1: {ptV1} \nPoint V2: {ptV2}");
