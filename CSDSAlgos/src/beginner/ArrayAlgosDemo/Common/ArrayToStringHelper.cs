namespace ArrayAlgosDemo.Common;

public static class ArrayToStringHelper
{
    public static string[] ConvertIntArrayToStringArray(int[]? inputArray)
    {
        // If the inputArray is null, return an empty string array.
        if (inputArray is null)
        {
            return [];
        }

        return Array.ConvertAll(inputArray, ele => ele.ToString());
    }

    public static string ConvertIntArrayToString(int[]? inputArray)
    {
        return string.Join(", ", ConvertIntArrayToStringArray(inputArray));
    }
}