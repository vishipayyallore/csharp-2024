// Assigning a string returned from the string class constructor.
string horizontalLine = new('-', count: 74); // 74 hyphens.
WriteLine(horizontalLine);

// Assigning literal strings.
string firstName = "Bob";
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";
WriteLine($"Name: {firstName} {lastName}, Phone: {phoneNumber}");

OutputEncoding = System.Text.Encoding.UTF8;
WriteLine($"\nEmoji: {char.ConvertFromUtf32(0x1F600)}");

// Assigning a string with escape sequences.
string fullNameWithTabSeparator = "Bob\tSmith";
WriteLine($"\nFull Name with Separator: {fullNameWithTabSeparator}");

//Verbatim strings
string filePath = @"C:\televisions\sony\bravia.txt";
WriteLine($"\n(Verbatim strings) File Path: {filePath}");

// Raw strings literals
string xml = """
            <person age="50">
            <first_name>Mark</first_name>
            </person>
            """;
WriteLine($"\n(Raw strings) XML: \n{xml}");

xml = """
        <person age="50">
        <first_name>Mark</first_name>
        </person>
""";
WriteLine($"\n(Raw strings) XML with Indentation: \n{xml}");

var person = new { FirstName = "Alice", Age = 56 };

// Raw interpolated string literals
string json = $$"""
                {
                "first_name": "{{person.FirstName}}",
                "age": {{person.Age}},
                "calculation": "{{{1 + 2}}}"
                }
                """;
WriteLine($"\n(Raw interpolated strings) JSON: \n{json}");