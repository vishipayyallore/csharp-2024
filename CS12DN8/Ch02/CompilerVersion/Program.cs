ForegroundColor = ConsoleColor.DarkCyan;

WriteLine("Uncomment the lines to See A. Compiler Version, and B. Auto Generate <Main>$().");
WriteLine("1. //  #error version");
WriteLine("2. //  throw new Exception();");

// Compiler version: '4.9.0-2.23613.5 (47b0a1e0)'.Language version: 12.0.
// #error version

ResetColor();

// Uncomment this line to throw an exception and show Auto Generate Method name """Program.<Main>$(String[] args)"""
throw new Exception();

