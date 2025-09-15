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
  public static void DrawString(string text, bool isInvertedSign)
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
    Console.WriteLine("██" + new string(isInvertedSign ? '█' : ' ', letters.Length * 10 + (letters.Length - 1) * 2 + 4) + "██");
    // Render each of the 5 lines
    for (int line = 0; line < 5; line++)
    {
      Console.Write(isInvertedSign ? "████" : "██  ");
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
            Console.Write(isInvertedSign ? "  " : "██");
          }
          else
          {
            Console.Write(isInvertedSign ? "██" : "  ");
          }
        }
        Console.Write(isInvertedSign ? "██" : "  ");
      }
      Console.Write("██");
      Console.WriteLine();
    }
    Console.WriteLine("██" + new string(isInvertedSign ? '█' : ' ', letters.Length * 10 + (letters.Length - 1) * 2 + 4) + "██");
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
        textSignatures.Add(letters[i], CharacterMap.LetterSignatures.First(s => s.Key == letters[i]).Value);
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
