using AsciiSign.interfaces;

namespace AsciiSign.utils.characterDictionaries
{
  /// <summary>
  /// Represents a character dictionary for the Turing font style, mapping characters to their corresponding ASCII art signatures.
  /// </summary>
  internal class Turing : ICharacterDictionary
  {
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
      { 'I', new[] { "01f0", "0ab0", "01f0", "01c0", "01c0", "0ab0" } },
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
      { ' ', new[] { "0000", "0000", "0000", "0000", "0000", "0000" } },
    };

    public IReadOnlyDictionary<char, string[]> SignaturesMap => _signaturesMap;

    // Singleton instance of the Turing character dictionary
    internal static readonly Turing Instance = new();

    private Turing() { }
  }
}
