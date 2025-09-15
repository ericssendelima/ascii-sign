namespace AsciiSign
{
  public static class CharacterMap
  {
    /// <summary>
    /// Dictionary mapping characters to their 5-line binary signatures.
    /// Each integer in the array represents a line in the 5x5 grid, where
    /// the bits represent the pixel states (1 for filled, 0 for empty).
    /// The grid is 5 pixels wide and 5 pixels tall.
    /// </summary>
    public static readonly IReadOnlyDictionary<char, int[]> LetterSignatures = new Dictionary<char, int[]>
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
  }
}