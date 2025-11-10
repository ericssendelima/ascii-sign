using AsciiSign.utils.enums;

namespace AsciiSign.utils.services
{
  /// <summary>
  /// Provides utility methods for character processing related to ASCII art rendering.
  /// </summary>
  public static class Characters
  {
    /// <summary>
    /// Converts the input text to an array of uppercase characters, enforcing length constraints based on the specified font type.
    /// </summary>
    /// <param name="text">
    /// The input text to be converted into an array of uppercase characters.
    /// </param>
    /// <param name="fontType">
    /// The font type to determine length constraints for the input text.
    /// </param>
    /// <returns>
    /// An array of uppercase characters representing the input text.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when the input text is null, empty, or exceeds the allowed length for the specified font type.
    /// </exception>
    public static char[] GetArray(string text, FontType fontType)
    {
      if (string.IsNullOrEmpty(text)) throw new ArgumentException("Text cannot be null or empty.", nameof(text));
      if (fontType != FontType.TURING && text.Length > 12)
      {
        throw new ArgumentException("Text length cannot be greater than 12 characters.", nameof(text));
      }
      else if (fontType == FontType.TURING && text.Length > 19)
      {
        throw new ArgumentException("Text length cannot be greater than 19 characters for Turing font.", nameof(text));
      }
      
      char[] letters = new char[text.Length];

      // Convert each character to uppercase and store in the array
      for (int i = 0; i < text.Length; i++)
      {
        letters[i] = char.ToUpper(text[i]);
      }
      return letters;
    }
  }
}