namespace AsciiSign;

/// <summary>
/// Static class to render text in ASCII art style in the console.
/// </summary>
/// <remarks>
/// Each character is represented in a 5x5 grid using binary signatures.
/// Supported characters include uppercase letters A-Z, digits 0-9, and some special characters.
/// </remarks>
public static class Sign
{
  /// <summary>
  /// Dictionary mapping characters to their 5-line binary signatures.
  /// Each integer in the array represents a line in the 5x5 grid, where
  /// the bits represent the pixel states (1 for filled, 0 for empty).
  /// The grid is 5 pixels wide and 5 pixels tall.
  /// </summary>
  private static readonly Dictionary<char, int[]> _letterSignatures = new()
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
    { '4', new[] { 17,17, 31, 1, 1 } },
    { '5', new[] { 31, 16, 31, 1, 31 } },
    { '6', new[] { 31, 16, 31, 17, 31 } },
    { '7', new[] { 31, 1, 2, 4, 8 } },
    { '8', new[] { 31, 17, 31, 17, 31 } },
    { '9', new[] { 31, 17, 31, 1, 31 } }
  };

  /// <summary>
  /// Renders the given text in ASCII art style in the console.
  /// </summary>
  /// <param name="text">The text to render.</param>
  /// <exception cref="ArgumentException">Thrown when the text is null, empty, or exceeds 12 characters.</exception>
  /// <remarks>
  /// Each character is represented in a 5x5 grid using binary signatures.
  /// The rendered text is framed with a border for better visibility.
  /// </remarks>
  /// <example>
  /// Sign.DrawString("HELLO");
  /// </example>
  public static void DrawString(string text)
  {
    // Get the array of characters from the input text
    char[] letters = GetCharactersArray(text);

    // Get the signatures for each character in the text
    Dictionary<char, int[]> textSignatures = GetTextSignatures(letters);

    // Create a matrix to hold the signatures for rendering
    int[,] textMatrixSignatures = GetTextMatrixSignatures(letters, textSignatures);

    // Render the text in the console
    Console.WriteLine();
    Console.Write("██");
    Console.WriteLine(new string('█', letters.Length * 10 + (letters.Length - 1) * 2 + 6));
    Console.WriteLine("██" + new string(' ', letters.Length * 10 + (letters.Length - 1) * 2 + 4) + "██");
    // Render each of the 5 lines
    for (int line = 0; line < 5; line++)
    {
      Console.Write("██  ");
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
            Console.Write("██"); 
          }
          else
          {
            Console.Write("  "); 
          }
        }
        Console.Write("  ");
      }
      Console.Write("██");
      Console.WriteLine();
    }
    Console.WriteLine("██" + new string(' ', letters.Length * 10 + (letters.Length - 1) * 2 + 4) + "██");
    Console.Write("██");
    Console.WriteLine(new string('█', letters.Length * 10 + (letters.Length - 1) * 2 + 6));
  }

  /// <summary>
  /// Converts the input text into an array of uppercase characters.
  /// Validates that the text is neither null nor empty and does not exceed 12 characters
  /// </summary>
  /// <param name="text">The input text to convert.</param>
  /// <returns>An array of uppercase characters.</returns>
  /// <exception cref="ArgumentException">Thrown when the text is null, empty, or exceeds 12 characters.</exception>
  private static char[] GetCharactersArray(string text)
  {
    if (string.IsNullOrEmpty(text)) throw new ArgumentException("Text cannot be null or empty.", nameof(text));
    if (text.Length > 12) throw new ArgumentException("Text length cannot be greater than 12 characters.", nameof(text));

    char[] letters = new char[text.Length];

    // Convert each character to uppercase and store in the array
    for (int i = 0; i < text.Length; i++)
    {
      letters[i] = char.ToUpper(text[i]);
    }
    return letters;
  }

  /// <summary>
  /// Retrieves the binary signatures for each unique character in the input array.
  /// </summary>
  /// <param name="letters">The array of characters to retrieve signatures for.</param>
  /// <returns>A dictionary mapping each character to its binary signature.</returns>
  private static Dictionary<char, int[]> GetTextSignatures(char[] letters)
  {
    var textSignatures = new Dictionary<char, int[]>();

    // Populate the dictionary with signatures for each unique character
    for (int i = 0; i < letters.Length; i++)
    {
      if (!textSignatures.ContainsKey(letters[i]))
      {
        textSignatures.Add(letters[i], _letterSignatures.First(s => s.Key == letters[i]).Value);
      }
    }
    return textSignatures;
  }

  /// <summary>
  /// Constructs a matrix of binary signatures for rendering the text.
  /// </summary>
  /// <param name="letters">The array of characters to construct the matrix for.</param>
  /// <param name="textSignatures">The dictionary containing the binary signatures for each character.</param>
  /// <returns>A 2D array representing the binary signatures for each character in the text.</returns>
  private static int[,] GetTextMatrixSignatures(char[] letters, Dictionary<char, int[]> textSignatures)
  {
    int[,] textMatrixSignatures = new int[5, letters.Length];

    // Fill the matrix with the signatures for each character
    for (int line = 0; line < 5; line++)
    {
      for (int decimalElement = 0; decimalElement < letters.Length; decimalElement++)
      {
        textMatrixSignatures[line, decimalElement] = textSignatures[letters[decimalElement]][line];
      }
    }
    return textMatrixSignatures;
  }

}
