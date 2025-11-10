namespace AsciiSign.utils.characterDictionaries
{
  /// <summary>
  /// A basic character dictionary mapping characters to their ASCII art signatures using 5x5 pixel representation.
  /// </summary>
  /// <remarks>
  /// This class provides a mapping of characters to their 5x5 pixel ASCII art signatures.
  /// It inherits from CharacterDictionary with int as the type for matrix signatures.
  /// </remarks>
  public class Basic : CharacterDictionary<int>
  {
    // Mapping of characters to their 5x5 pixel signatures represented as arrays of integers.
    private readonly Dictionary<char, int[]> _signaturesMap = new()
    {
      { 'A', new[] { 14, 17, 31, 17, 17 } },
      { 'B', new[] { 30, 17, 30, 17, 30 } },
      { 'C', new[] { 14, 17, 16, 17, 14 } },
      { 'D', new[] { 30, 17, 17, 17, 30 } },
      { 'E', new[] { 31, 16, 30, 16, 31 } },
      { 'F', new[] { 31, 16, 30, 16, 16 } },
      { 'G', new[] { 14, 16, 23, 17, 14 } },
      { 'H', new[] { 17, 17, 31, 17, 17 } },
      { 'I', new[] { 14, 4, 4, 4, 14 } },
      { 'J', new[] { 7, 2, 2, 18, 12 } },
      { 'K', new[] { 18, 20, 24, 20, 18 } },
      { 'L', new[] { 16, 16, 16, 16, 31 } },
      { 'M', new[] { 17, 27, 21, 17, 17 } },
      { 'N', new[] { 25, 25, 21, 19, 19 } },
      { 'O', new[] { 14, 17, 17, 17, 14 } },
      { 'P', new[] { 30, 17, 30, 16, 16 } },
      { 'Q', new[] { 14, 17, 17, 18, 15 } },
      { 'R', new[] { 30, 17, 30, 20, 18 } },
      { 'S', new[] { 15, 16, 14, 1, 30 } },
      { 'T', new[] { 31, 4, 4, 4, 4 } },
      { 'U', new[] { 17, 17, 17, 17, 14 } },
      { 'V', new[] { 17, 17, 17, 10, 4 } },
      { 'W', new[] { 17, 21, 21, 21, 10 } },
      { 'X', new[] { 17, 10, 4, 10, 17 } },
      { 'Y', new[] { 17, 10, 4, 4, 4 } },
      { 'Z', new[] { 31, 2, 4, 8, 31 } },
      { ' ', new[] { 0, 0, 0, 0, 0 } },
      { '.', new[] { 0, 0, 0, 0, 4 } },
      { '!', new[] { 4, 4, 4, 0, 4 } },
      { '#', new[] { 10, 31, 10, 31, 10 } },
      { '+', new[] { 4, 4, 31, 4, 4 } },
      { '-', new[] { 0, 0, 31, 0, 0 } },
      { '*', new[] { 21, 14, 31, 14, 21 } },
      { '/', new[] { 1, 2, 4, 8, 16 } },
      { '0', new[] { 14, 17, 17, 17, 14 } },
      { '1', new[] { 4, 12, 4, 4, 14 } },
      { '2', new[] { 30, 1, 30, 16, 31 } },
      { '3', new[] { 31, 1, 14, 1, 31 } },
      { '4', new[] { 17, 17, 31, 1, 1 } },
      { '5', new[] { 31, 16, 31, 1, 31 } },
      { '6', new[] { 31, 16, 31, 17, 31 } },
      { '7', new[] { 31, 1, 2, 4, 8 } },
      { '8', new[] { 31, 17, 31, 17, 31 } },
      { '9', new[] { 31, 17, 31, 1, 31 } }
    };

    // Read-only access to the signatures map
    public override IReadOnlyDictionary<char, int[]> SignaturesMap => _signaturesMap;

    // Singleton instance of the Basic character dictionary
    public static readonly Basic Instance = new();

    // Private constructor to enforce singleton pattern
    private Basic() { }

    // Render the text matrix signatures to the console
    public override void Draw(int[,] textMatrixSignatures, char[] letters, bool? isInvertedSign = false)
    {
      bool inverted = isInvertedSign ?? false;
      // Render the text in the console
      Console.WriteLine();
      Console.Write("██");
      Console.WriteLine(new string('█', letters.Length * 10 + (letters.Length - 1) * 2 + 6));
      Console.WriteLine("██" + new string(inverted ? '█' : ' ', letters.Length * 10 + (letters.Length - 1) * 2 + 4) + "██");
      // Render each of the 5 lines
      for (int line = 0; line < 5; line++)
      {
        Console.Write(inverted ? "████" : "██  ");
        // Render each character in the line
        for (int decimalElement = 0; decimalElement < letters.Length; decimalElement++)
        {
          // Get the decimal value for the current character line and convert it to binary string (padded to 5 bits) 
          int dec = textMatrixSignatures[line, decimalElement];
          string binary = Convert.ToString(dec, 2).PadLeft(5, '0');

          // Render each bit in the binary string
          foreach (char bit in binary)
          {
            // Render a filled pixel for '1' and an empty pixel for '0'
            if (bit == '1')
            {
              Console.Write(inverted ? "  " : "██");
            }
            else
            {
              Console.Write(inverted ? "██" : "  ");
            }
          }
          Console.Write(inverted ? "██" : "  ");
        }
        Console.Write("██");
        Console.WriteLine();
      }
      Console.WriteLine("██" + new string(inverted ? '█' : ' ', letters.Length * 10 + (letters.Length - 1) * 2 + 4) + "██");
      Console.Write("██");
      Console.WriteLine(new string('█', letters.Length * 10 + (letters.Length - 1) * 2 + 6));
    }
  }
}