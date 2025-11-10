using AsciiSign.utils.characterDictionaries;

namespace AsciiSign.utils.services
{
  /// <summary>
  /// Provides methods for processing text related to ASCII art rendering.
  /// </summary>
  /// <typeparam name="T">The type of the signatures (string, int).</typeparam>
  public static class Text<T>
  {
    /// <summary>
    /// Retrieves the signatures for each character in the given array from the character map.
    /// </summary>
    /// <param name="letters">
    /// An array of characters for which signatures are to be retrieved.
    /// </param>
    /// <param name="characterMap">
    /// The character dictionary mapping characters to their signatures.
    /// </param>
    /// <returns>
    /// A dictionary mapping each character to its corresponding array of signatures.
    /// </returns>
    public static Dictionary<char, T[]> GetSignatures(char[] letters, CharacterDictionary<T> characterMap)
    {
      var textSignatures = new Dictionary<char, T[]>();

      // Populate the dictionary with signatures for each unique character
      for (int i = 0; i < letters.Length; i++)
      {
        if (!textSignatures.ContainsKey(letters[i]))
        {
          textSignatures.Add(letters[i], Signature(letters[i], characterMap));
        }
      }
      return textSignatures;
    }


    /// <summary>
    /// Retrieves the signature array for a single character from the character map.
    /// </summary>
    /// <param name="letter">
    /// The character for which the signature array is to be retrieved.
    /// </param>
    /// <param name="characterMap">
    /// The character dictionary mapping characters to their signatures.
    /// </param>
    /// <returns>
    /// An array of signatures corresponding to the given character.
    /// </returns>
    private static T[] Signature(char letter, CharacterDictionary<T> characterMap)
    {
      // Find and return the signature array for the given character
      var charSignature = characterMap.SignaturesMap.FirstOrDefault(kv => kv.Key == letter);

      return charSignature.Value;
    }
  }
}