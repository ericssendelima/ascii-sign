using System.Text;
using AsciiSign;

Console.OutputEncoding = Encoding.UTF8;

static void Section(string title, FontType font, params string[] lines)
{
  Console.WriteLine();
  Sign.DrawOnConsole(title, font);

  foreach (var line in lines)
    Sign.DrawOnConsole(line, font);

  Console.WriteLine();
  Console.WriteLine(new string('=', 52));
}

Section(
    "turing", FontType.TURING,
    "abcdefghijklmnopqrs",
    "tuvwxy z"
);

Section(
    "true type", FontType.TRUE_TYPE,
    "abcdefghi",
    "jklmnopqr",
    "stuvwxyz-"
);

Section(
    "shaded", FontType.SHADED,
    "abcdefghijkl",
    "mnopqrstuvwx",
    "yz .!#+-/*",
    "0123456789"
);

Section(
    "basic", FontType.BASIC,
    "abcdefghijkl",
    "mnopqrstuvwx",
    "yz .!#+-/*",
    "0123456789"
);

Section(
    "inverted", FontType.INVERTED_BASIC,
    "abcdefghijkl",
    "mnopqrstuvwx",
    "yz .!#+-/*",
    "0123456789"
);