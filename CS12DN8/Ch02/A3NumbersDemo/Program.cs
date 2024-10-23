
ForegroundColor = ConsoleColor.DarkBlue;

ShowNumberVariables();

ForegroundColor = ConsoleColor.DarkGreen;

ExploringWholeNumbers();

ForegroundColor = ConsoleColor.DarkRed;

ShowSizeOfTypes();

ForegroundColor = ConsoleColor.DarkYellow;

ComparingDoubleAndDecimalTypes();

ForegroundColor = ConsoleColor.DarkMagenta;

NewNumberTypesAndUnsafeCode();

ForegroundColor = ConsoleColor.DarkCyan;

SpecialFloatAndDoubleValues();

ResetColor();

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

    WriteLine($"byte uses {sizeof(byte)} bytes and can store numbers in the range {byte.MinValue:N0} to {byte.MaxValue:N0}.");
    WriteLine($"short uses {sizeof(short)} bytes and can store numbers in the range {short.MinValue:N0} to {short.MaxValue:N0}.");
    WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
    WriteLine($"long uses {sizeof(long)} bytes and can store numbers in the range {long.MinValue:N0} to {long.MaxValue:N0}.");
    WriteLine($"float uses {sizeof(float)} bytes and can store numbers in the range {float.MinValue:N0} to {float.MaxValue:N0}.");
    WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
    WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
    WriteLine($"char is {sizeof(char)} bytes.");
    WriteLine($"bool is {sizeof(bool)} bytes.");
}

static void ComparingDoubleAndDecimalTypes()
{
    WriteLine("\nComparing double and decimal types:");

    WriteLine("Using doubles:");
    double a = 0.1;
    double b = 0.2;

    if (a + b == 0.3)
    {
        WriteLine($"{a} + {b} equals 0.3");
    }
    else
    {
        WriteLine($"{a} + {b} does NOT equal 0.3");
    }

    WriteLine("Using decimals:");
    decimal c = 0.1M;
    decimal d = 0.2M;
    if (c + d == 0.3M)
    {
        WriteLine($"{c} + {d} equals 0.3");
    }
    else
    {
        WriteLine($"{c} + {d} does NOT equal 0.3");
    }
}

static void NewNumberTypesAndUnsafeCode()
{
    WriteLine("\nNew number types and unsafe code:");
    unsafe
    {
        WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}.");
        WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
    }
}

static void SpecialFloatAndDoubleValues()
{
    WriteLine("\nSpecial float and double values:");

    WriteLine($"double.Epsilon: {double.Epsilon}");
    WriteLine($"double.Epsilon to 324 decimal places: {double.Epsilon:N324}");
    WriteLine($"double.Epsilon to 330 decimal places: {double.Epsilon:N330}");

    const int col1 = 37;
    const int col2 = 6;
    string line = new('-', col1 + col2 + 3);

    WriteLine(line);
    WriteLine($"{"Expression",-col1} | {"Value",col2}");
    WriteLine(line);
    WriteLine($"{"double.NaN",-col1} | {double.NaN,col2}");
    WriteLine($"{"double.PositiveInfinity",-col1} | {double.PositiveInfinity,col2}");
    WriteLine($"{"double.NegativeInfinity",-col1} | {double.NegativeInfinity,col2}");
    WriteLine(line);
    WriteLine($"{"0.0 / 0.0",-col1} | {0.0 / 0.0,col2}");
    WriteLine($"{"3.0 / 0.0",-col1} | {3.0 / 0.0,col2}");
    WriteLine($"{"-3.0 / 0.0",-col1} | {-3.0 / 0.0,col2}");
    WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity",-col1} | {3.0 / 0.0 == double.PositiveInfinity,col2}");
    WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity",-col1} | {-3.0 / 0.0 == double.NegativeInfinity,col2}");
    WriteLine($"{"0.0 / 3.0",-col1} | {0.0 / 3.0,col2}");
    WriteLine($"{"0.0 / -3.0",-col1} | {0.0 / -3.0,col2}");
    WriteLine(line);
}