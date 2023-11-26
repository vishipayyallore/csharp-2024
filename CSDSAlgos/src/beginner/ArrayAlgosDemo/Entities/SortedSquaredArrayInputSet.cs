namespace ArrayAlgosDemo.Entities;

internal class SortedSquaredArrayInputSet
{
    public int[]? InputArray { get; set; }

    public static List<SortedSquaredArrayInputSet> GenerateSortedSquaredArrayInputs() =>
        [
            new SortedSquaredArrayInputSet { InputArray = [-5, -3, -2, 0, 1, 4, 6] },
            new SortedSquaredArrayInputSet { InputArray = [-10, -5, 0, 5, 10] },
            new SortedSquaredArrayInputSet { InputArray = [1, 2, 3, 4, 5] },
            new SortedSquaredArrayInputSet { InputArray = [-10, -5, 0, 5, 10, 15] },
            new SortedSquaredArrayInputSet { InputArray = null }, // Test case with null InputArray
        ];
}