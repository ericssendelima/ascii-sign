namespace AsciiSign.interfaces
{
  /// <summary>
  /// Interface for a character dictionary that maps characters to their corresponding ASCII art signatures.
  /// </summary>
  internal interface ICharacterDictionary
  {
    IReadOnlyDictionary<char, string[]> SignaturesMap { get; }
  }
}