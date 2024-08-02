using System.Reflection;

ForegroundColor = ConsoleColor.DarkCyan;

WriteLine("Hello, C# 12, and DotNet 8 !");

string name = typeof(Program).Namespace ?? "None!";
WriteLine($"Namespace: {name}");

WriteLine($"Computer Name: {Env.MachineName}");

System.Data.DataSet ds = new();
HttpClient client = new();

WriteLine($"Data Set: {ds.DataSetName}. Http Client: {client.BaseAddress}");

OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
WriteLine(grinningEmoji);

ShowTypesAndMethod();

ResetColor();

/*
 * System.Runtime assembly contain zero types? This assembly is special because it contains only 
 * type-forwarders rather than actual types. A type-forwarder represents a type that has been 
 * implemented outside of .NET or for some other advanced reason.
 */
static void ShowTypesAndMethod()
{
    Assembly? currentAssembly = Assembly.GetEntryAssembly();

    if (currentAssembly is null)
    {
        WriteLine("Assembly is null!");

        return;
    }

    // Loop through the assemblies that my app references.
    foreach (AssemblyName name in currentAssembly.GetReferencedAssemblies())
    {
        Assembly a = Assembly.Load(name);

        int methodCount = 0;

        // Loop through all the types in the assembly.
        foreach (TypeInfo t in a.DefinedTypes)
        {
            methodCount += t.GetMethods().Length;
        }

        // Output the count of types and their methods.
        WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: name.Name);
    }
}

//void ShowVocabulary()
//{
//    WriteLine("Vocabulary:");
//    WriteLine("1. Compiler Version");
//    WriteLine("2. Auto Generate <Main>$()");
//    WriteLine("3. Nullable Reference Types");
//    WriteLine("4. Record Types");
//    WriteLine("5. Lambda Improvements");
//    WriteLine("6. Target Typed New Expressions");
//    WriteLine("7. Global Using");
//    WriteLine("8. File Scoped Namespaces");
//    WriteLine("9. Implicit Usings");
//    WriteLine("10. Interpolated String Improvements");
//    WriteLine("11. Constant Interpolated Strings");
//    WriteLine("12. Static Anonymous Functions");
//    WriteLine("13. Extended Property Patterns");
//    WriteLine("14. Extended Switch Expressions");
//    WriteLine("15. Extended Pattern Matching");
//    WriteLine("16. Extended Indexing");
//    WriteLine("17. Extended Target Typing");
//    WriteLine("18. Extended Attributes");
//    WriteLine("19. Extended Partial Methods");
//    WriteLine("20. Extended Partial Classes");
//    WriteLine("21. Extended Partial Structs");
//    WriteLine("22. Extended Partial Interfaces");
//    WriteLine("23. Extended Partial Records");
//    WriteLine("24. Extended Partial Delegates");
//    WriteLine("25. Extended Partial Enums");
//    WriteLine("26. Extended Partial Modules");
//    WriteLine("27. Extended Partial Namespaces");
//    WriteLine("28. Extended Partial Operators");
//    WriteLine("29. Extended Partial Indexers");
//    WriteLine("30. Extended Partial Properties");
//    WriteLine("31. Extended Partial Events");
//    WriteLine("32. Extended Partial Constructors");
//    WriteLine("33. Extended Partial Destructors");
//    WriteLine("34. Extended Partial Fields");
//    WriteLine("35. Extended Partial Methods");
//    WriteLine("36. Extended Partial Statements");
//    WriteLine("37. Extended Partial Local Functions");
//    WriteLine("38. Extended Partial Type Parameters");
//    WriteLine("39. Extended Partial Type Arguments");
//    WriteLine("40. Extended Partial Attributes");
//    WriteLine("41. Extended Partial Parameters");
//    WriteLine("42. Extended Partial Type Constraints");
//    WriteLine("43. Extended Partial Namespace Declarations");
//    WriteLine("44. Extended Partial Using Directives");
//    WriteLine("45. Extended Partial Global Statements");
//    WriteLine("46. Extended Partial Compilation Units");
//    WriteLine("47. Extended Partial Type Declarations");
//    WriteLine("48. Extended Partial Base Types");
//    WriteLine("49. Extended Partial Interfaces");
//    WriteLine("50. Extended Partial Enums");
//    WriteLine("51. Extended Partial Structs");
//    WriteLine("52. Extended");
//}
