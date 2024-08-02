ForegroundColor = ConsoleColor.DarkCyan;

WriteLine("Uncomment the lines to See \n\tA. Compiler Version. \n\tB. Auto Generate <Main>$() method.");
WriteLine("\n1. //  #error version");
WriteLine("2. //  throw new Exception();");

// Compiler version: '4.11.0-3.24321.9 (847d5884)'. Language version: 12.0.
// #error version

ResetColor();

// Uncomment this line to throw an exception and show Auto Generate Method name """Program.<Main>$(String[] args)"""
// throw new Exception();

