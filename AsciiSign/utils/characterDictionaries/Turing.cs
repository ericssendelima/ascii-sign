namespace AsciiSign.utils.characterDictionaries
{
  /// <summary>
  /// A Turing character dictionary mapping characters to their ASCII art signatures using Turing machine tape representation.
  /// </summary>
  /// <remarks>
  /// This class provides a mapping of characters to their Turing machine tape ASCII art signatures.
  /// It inherits from CharacterDictionary with string as the type for matrix signatures.
  /// </remarks>
  public class Turing : CharacterDictionary<string>
  {
    // A dictionary mapping characters to their Turing machine tape ASCII art signatures.
    protected readonly Dictionary<char, string[]> _signaturesMap = new()
    {
      { 'A', new[] { "111f", "1d1c", "ab1c", "111c", "1d1c" , "abab" } },
      { 'B', new[] { "1f00", "1c00", "111f", "1d1c", "a11c", "0aeb" } },
      { 'C', new[] { "111f", "ae1c", "1fab", "1c1f", "111c", "aeeb" } },
      { 'D', new[] { "001f", "001c", "111c", "1d1c", "11gb", "aeb0" } },
      { 'E', new[] { "111f", "1deb", "11f0", "aeb0", "111f", "aeeb" } },
      { 'F', new[] { "111f", "aeeb", "11f0", "1db0", "1c00", "ab00" } },
      { 'G', new[] { "1f1f", "111c", "ae1c", "1f1c", "111c", "aeeb" } },
      { 'H', new[] { "1f1f", "1cab", "111f", "1d1c", "1c1c", "abab" } },
      { 'I', new[] { "1f", "ab", "1f", "1c", "1c", "ab" } },
      { 'J', new[] { "001f", "011c", "0a1c", "1f1c", "111c", "aeeb" } },
      { 'K', new[] { "001f", "1f1c", "11gb", "1d1f", "1cab", "ab00" } },
      { 'L', new[] { "1f00", "1c00", "1c00", "1c1f", "111c", "aeeb" } },
      { 'M', new[] { "1f1f", "111c", "1d1c", "1c1c", "1c1c", "abab" } },
      { 'N', new[] { "111f", "ae1c", "1f1c", "1c1c", "1c1c", "abab" } },
      { 'O', new[] { "111f", "1d1c", "1c1c", "ab1c", "111c", "aeeb" } },
      { 'P', new[] { "0000", "111f", "1d1c", "111c", "1deb", "ab00" } },
      { 'Q', new[] { "111f", "1d1c", "1c1c", "111c", "a1db", "0ab0" } },
      { 'R', new[] { "111f", "1d1c", "1cab", "1c00", "1c00", "ab00" } },
      { 'S', new[] { "11f0", "1db0", "111f", "ae1c", "011c", "0aeb" } },
      { 'T', new[] { "111f", "a1db", "0ab0", "01f0", "01c0", "0ab0" } },
      { 'U', new[] { "1f1f", "1c1c", "1c1c", "1cab", "111f", "aeeb" } },
      { 'V', new[] { "0000", "1f1f", "1c1c", "1c1c", "a1gb", "0ab0" } },
      { 'X', new[] { "001f", "1f1c", "a1gb", "1g1f", "1cab", "ab00" } },
      { 'W', new[] { "1f1f", "1c1c", "111c", "111c", "1d1c", "abab" } },
      { 'Y', new[] { "1f1f", "111c", "a1db", "01c0", "01c0", "0ab0" } },
      { 'Z', new[] { "111f", "ae1c", "01gb", "1gb0", "111f", "aeeb" } },
      { ' ', new[] { "00", "00", "00", "00", "00", "00" } },
      { '@', new[] { "" } },
    };

    // Read-only access to the signatures map
    public override IReadOnlyDictionary<char, string[]> SignaturesMap => _signaturesMap;

    // Singleton instance of the Turing character dictionary
    public static readonly Turing Instance = new();

    // Private constructor to prevent external instantiation
    private Turing() { }

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
