ForegroundColor = ConsoleColor.DarkCyan;

WriteLine("Uncomment the lines to See A. Compiler Version, and B. Auto Generate <Main>$().");
WriteLine("//  #error version");
WriteLine("//  throw new Exception();");

// Compiler version: '4.9.0-1.23560.3 (78d23490)'.Language version: 12.0.Vocabulary  
//  #error version

ResetColor();

// Uncomment this line to throw an exception and show Auto Generate Method name
// Program.<Main>$(String[] args)
//  throw new Exception();

