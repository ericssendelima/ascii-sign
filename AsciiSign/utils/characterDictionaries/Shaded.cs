namespace AsciiSign.utils.characterDictionaries
{
  /// <summary>
  /// A shaded character dictionary mapping characters to their ASCII art signatures using shaded pixel representation.
  /// </summary>
  /// <remarks>
  /// This class provides a mapping of characters to their shaded pixel ASCII art signatures.
  /// It inherits from CharacterDictionary with string as the type for matrix signatures.
  /// </remarks>
  public class Shaded : CharacterDictionary<string>
  {
    // Mapping of characters to their shaded pixel ASCII art signatures represented as arrays of strings.
    protected readonly Dictionary<char, string[]> _signaturesMap = new()
    {
      { 'A', new[] { "0111f0", "1dee1f", "11111c", "1dee1c", "1c001c" , "ab00ab" } },
      { 'B', new[] { "1111f0", "1dee1f", "1111gb", "1dee1f", "1111gb" , "aeeeb0" } },
      { 'C', new[] { "0111f0", "1gee1f", "1c00ab", "1c001f", "a111gb" , "0aeeb0" } },
      { 'D', new[] { "1111f0", "1dee1f", "1c001c", "1c001c", "1111gb" , "aeeeb0" } },
      { 'E', new[] { "11111f", "1deeeb", "1111f0", "1deeb0", "11111f" , "aeeeeb" } },
      { 'F', new[] { "11111f", "1deeeb", "1111f0", "1deeb0", "1c0000" , "ab0000" } },
      { 'G', new[] { "0111f0", "1geeb0", "1c111f", "1cae1c", "a111gb" , "0aeeb0" } },
      { 'H', new[] { "1f001f", "1c001c", "11111c", "1dee1c", "1c001c" , "ab00ab" } },
      { 'I', new[] { "0111f0", "0a1db0", "001c00", "001c00", "0111f0", "0aeeb0" } },
      { 'J', new[] { "00111f", "00a1db", "0001c0", "1f01c0", "a111c0", "0aeeb0" } },
      { 'K', new[] { "1f01f0", "1c1gb0", "11gb00", "1d1f00", "1ca1f0" , "ab0ab0" } },
      {'L', new[] { "1f0000", "1c0000", "1c0000", "1c0000", "11111f" , "aeeeeb" } },
      {'M', new[] { "1f001f", "11f11c", "1d1g1c", "1cab1c", "1c001c", "ab00ab" } },
      {'N', new[] { "11f01f", "11c01c", "1d1f1c", "1ca11c", "1c011c", "ab0aeb" }},
      {'O', new[] { "0111f0", "1gee1f", "1c001c", "1c001c", "a111gb", "0aeeb0" }},
      {'P', new[] { "1111f0", "1dee1f", "1111gb", "1deeb0", "1c0000", "ab0000" }},
      {'Q', new[] { "0111f0", "1gee1f", "1c001c", "1c01gb", "a1111f", "0aeeeb" }},
      {'R', new[] { "1111f0", "1dee1f", "1111gb", "1d1db0", "1ca1f0", "ab0ab0" }},
      {'S', new[] { "01111f", "1geeeb", "a111f0", "0aee1f", "1111gb", "aeeeb0" }},
      {'T', new[] { "11111f", "ae1deb", "001c00", "001c00", "001c00", "00ab00" } },
      {'U', new[] { "1f001f", "1c001c", "1c001c", "1c001c", "a111gb", "0aeeb0" }},
      {'V', new[] { "1f001f", "1c001c", "1c001c", "a1f1gb", "0a1gb0", "00ab00" }},
      {'X', new[] { "1f001f", "a1f1gb", "0a1gb0", "01g1f0", "1gba1f", "ab00ab" }},
      {'W', new[] { "1f001f", "1c1f1c", "1c1c1c", "1c1c1c", "a1g1gb", "0abab0" }},
      {'Y', new[] { "1f001f", "a1f1gb", "0a1gb0", "001c00", "001c00", "00ab00" }},
      {'Z', new[] { "11111f", "aee1db", "001gb0", "01gb00", "11111f", "aeeeeb" }},
      {' ', new[] { "000", "000", "000", "000", "000", "000" , "000" }},
      {'.', new[] { "000000", "000000", "000000", "000000", "1f0000", "ab0000" }},
      {'!', new[] { "1f00", "1c00", "1c00", "ab00", "1f00", "ab00" }},
      {'#', new[] { "01f1f0", "11111f", "a1d1db", "11111f", "a1d1db", "0abab0" } },
      {'+', new[] { "001f00",  "001c00", "11111f", "ae1deb", "001c00", "00ab00" }},
      {'-', new[] { "000000", "000000", "11111f", "aeeeeb", "000000", "000000" }},
      {'*', new[] { "1f1f1f", "a111gb", "11111f", "a111db", "1g1d1f", "ababab" }},
      {'/', new[] { "00001f", "0001gb", "001gb0", "01gb00", "1gb000", "ab0000" }},
      {'0', new[] { "0111f0", "1gee1f", "1c001c", "1c001c", "a111gb", "0aeeb0" }},
      {'1', new[] { "001f00", "011c00", "0a1c00", "001c00", "0111f0" , "0aeeb0"}},
      {'2', new[] { "1111f0", "aeee1f", "1111gb", "1deeb0", "11111f", "aeeeeb" }},
      {'3', new[] { "11111f", "aeee1c", "0111gb", "0aee1f", "11111c", "aeeeeb"}},
      {'4', new[] { "1f001f", "1c001c", "11111c", "aeee1c", "00001c", "0000ab"}},
      {'5', new[] { "11111f", "1deeeb", "11111f", "aeee1c", "11111c", "aeeeeb" }},
      {'6', new[] { "11111f", "1deeeb", "11111f", "1dee1c", "11111c", "aeeeeb" }},
      {'7', new[] { "1111f0", "aeee1f", "0001gb", "001gb0", "01gb00", "0ab000" }},
      {'8', new[] { "0111f0", "1gee1f", "a111gb", "1gee1f", "a111gb", "0aeeb0" }},
      {'9', new[] { "11111f", "1dee1c", "11111c", "aeee1c", "11111c", "aeeeeb" }},
    };

    // Read-only access to the signatures map
    public override IReadOnlyDictionary<char, string[]> SignaturesMap => _signaturesMap;

    // Singleton instance of the Shaded character dictionary
    public static readonly Shaded Instance = new();

    // Private constructor to prevent external instantiation
    private Shaded() { }

    // Method to draw the ASCII art representation of the text matrix signatures
    public override void Draw(string[,] textMatrixSignatures, char[] letters, bool? isInvertedSign = false)
    {
      // Render the text in the console
      Console.WriteLine();

      // Render each of the 6 lines
      for (int line = 0; line < 6; line++)
      {
        Console.Write(" ");
        // Render each character in the line
        for (int decimalElement = 0; decimalElement < letters.Length; decimalElement++)
        {
          // Get the decimal value for the current character line
          string hex = textMatrixSignatures[line, decimalElement];

          // Render each bit in the hexadecimal string
          foreach (char bit in hex)
          {
            // Render a filled pixel for '1' and an empty pixel for '0'
            if (bit == '1')
            {
              Console.Write("██");
            }
            else if (bit == 'a')
            {
              Console.Write("└─");
            }
            else if (bit == 'b')
            {
              Console.Write("┘ ");
            }
            else if (bit == 'c')
            {
              Console.Write("│ ");
            }
            else if (bit == 'd')
            {
              Console.Write("┌─");
            }
            else if (bit == 'e')
            {
              Console.Write("──");
            }
            else if (bit == 'f')
            {
              Console.Write("┐ ");
            }
            else if (bit == 'g')
            {
              Console.Write("┼─");
            }
            else if (bit == 'h')
            {
              Console.Write("─┘");
            }
            else if (bit == 'i')
            {
              Console.Write("├─");
            }
            else
            {
              Console.Write("  ");
            }
          }
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }
}
