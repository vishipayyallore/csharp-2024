using HeaderFooter;
using HeaderFooter.Interfaces;
using NamesArrayLib;
using NamesArrayLib.Interfaces;
using NamesGenerator;
using PrintHelperLib;
using PrintHelperLib.Interfaces;

Run();

static void Run()
{
    INamesArray _namesArray = new NamesArray(new GenerateNames());
    IPrintHelper _printHelper = new PrintHelper();
    IHeader _header = new Header();
    IFooter _footer = new Footer();

    Random _random = new();

    _header.DisplayHeader('=', "Names Array Demo");

    ForegroundColor = ConsoleColor.Cyan;
    _printHelper.Print(_namesArray.GenerateNames(nameLength: _random.Next(5, 10), numberOfNames: 10));
    ResetColor();

    _footer.DisplayFooter('-');
}

