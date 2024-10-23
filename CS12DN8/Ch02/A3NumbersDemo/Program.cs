ShowNumberVariables();

ExploringWholeNumbers();

ShowSizeOfTypes();

static void ShowNumberVariables()
{
    // An unsigned integer is a positive whole number or 0.
    uint naturalNumber = 23;
    WriteLine($"uint uses {sizeof(uint)} bytes and can store numbers in the range {uint.MinValue:N0} to {uint.MaxValue:N0}.");
    WriteLine($"Natural Number: {naturalNumber}");

    // An integer is a negative or positive whole number or 0.
    int integerNumber = -23;
    WriteLine($"\nint uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
    WriteLine($"Integer Number: {integerNumber}");

    // A float is a single-precision floating point number.
    // F or f suffix makes the value a float literal.
    float realNumber = 2.3f;
    WriteLine($"\nfloat uses {sizeof(float)} bytes and can store numbers in the range {float.MinValue:N0} to {float.MaxValue:N0}.");
    WriteLine($"Real Number: {realNumber}");

    // A double is a double-precision floating point number.
    // double is the default for a number value with a decimal point.
    double anotherRealNumber = 2.3; // A double literal value.
    WriteLine($"\ndouble uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
    WriteLine($"Another Real Number: {anotherRealNumber}");
}

static void ExploringWholeNumbers()
{
    WriteLine("\nWhole Numbers:");
    int decimalNotation = 2_000_000;
    int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
    int hexadecimalNotation = 0x_001E_8480;

    // Check the three variables have the same value.
    WriteLine($"{decimalNotation == binaryNotation}");
    WriteLine($"{decimalNotation == hexadecimalNotation}");

    // Output the variable values in decimal.
    WriteLine($"{decimalNotation:N0}");
    WriteLine($"{binaryNotation:N0}");
    WriteLine($"{hexadecimalNotation:N0}");

    // Output the variable values in hexadecimal.
    WriteLine($"{decimalNotation:X}");
    WriteLine($"{binaryNotation:X}");
    WriteLine($"{hexadecimalNotation:X}");
}

static void ShowSizeOfTypes()
{
    // .NET Core 3.1 and later:
    WriteLine("\nSizes of data types:");
    WriteLine($"byte is {sizeof(byte)} bytes.");
    WriteLine($"short is {sizeof(short)} bytes.");
    WriteLine($"int is {sizeof(int)} bytes.");
    WriteLine($"long is {sizeof(long)} bytes.");
    WriteLine($"float is {sizeof(float)} bytes.");
    WriteLine($"double is {sizeof(double)} bytes.");
    WriteLine($"decimal is {sizeof(decimal)} bytes.");
    WriteLine($"char is {sizeof(char)} bytes.");
    WriteLine($"bool is {sizeof(bool)} bytes.");
}