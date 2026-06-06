using AsciiSign.interfaces;
using AsciiSign.utils.characterDictionaries;

namespace AsciiSign.utils.services
{
  /// <summary>
  /// Provides utility methods for character processing related to ASCII art rendering.
  /// </summary>
  internal static class Characters
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
    /// <param name="consoleDrawing">
    /// Indicates whether the ASCII art is intended for console drawing, which may affect character processing.
    /// </param>
    /// <param name="downscale">
    /// Indicates whether the ASCII art is intended to be scaled down.
    /// </param>
    /// <returns>
    /// An array of uppercase characters representing the input text.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when the input text is null, empty, or exceeds the allowed length for the specified font type.
    /// </exception>
    internal static char[] GetLettersOfInputText(string text, FontType fontType, bool consoleDrawing, bool downscale)
    {
      if (string.IsNullOrEmpty(text)) throw new ArgumentException("Text cannot be null or empty.", nameof(text));

      if (!downscale && consoleDrawing)
      {
        if (fontType != FontType.TURING && text.Length > 12)
        {
          throw new ArgumentException($"Text length cannot be greater than 12 characters for {fontType} font. Actual length: {text.Length}");
        }
        else if (fontType == FontType.TRUE_TYPE && text.Length > 9)
        {
          throw new ArgumentException($"Text length cannot be greater than 9 characters for {fontType} font. Actual length: {text.Length}");
        }
        else if (fontType == FontType.TURING && text.Length > 19)
        {
          throw new ArgumentException($"Text length cannot be greater than 19 characters for {fontType} font. Actual length: {text.Length}");
        }
      }

      char[] letters = new char[text.Length];

      for (int i = 0; i < text.Length; i++)
      {
        letters[i] = char.ToUpper(text[i]);
      }
      return letters;
    }

    /// <summary>
    /// Maps specific characters to their corresponding ASCII representations for rendering purposes. 
    /// This method is used to convert certain characters into a visual format suitable for ASCII art, based on predefined mappings.
    /// </summary>
    /// <param name="character">The character to map.</param>
    /// <returns>The ASCII representation of the character.</returns>
    internal static string GetRelactiveAsciiValue(char character)
    {
      return character switch
      {
        '1' => "██",
        'a' => " ▀",
        'b' => "▀ ",
        'c' => "█ ",
        'd' => "█▀",
        'e' => "▀▀",
        'f' => "▄ ",
        'g' => "▄▀",
        _ => "  "
      };
    }

    /// <summary>
    /// Retrieves the character dictionary corresponding to the specified font type.
    /// </summary>
    /// <param name="fontType">The font type for which to retrieve the character dictionary.</param>
    /// <returns>The character dictionary for the specified font type.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the specified font type is not supported.</exception>
    internal static ICharacterDictionary GetCharacterDictionary(FontType fontType)
    {
      return fontType switch
      {
        FontType.TRUE_TYPE => TrueType.Instance,
        FontType.BASIC => Basic.Instance,
        FontType.INVERTED_BASIC => InvertedBasic.Instance,
        FontType.SHADED => Shaded.Instance,
        FontType.TURING => Turing.Instance,
        _ => throw new ArgumentOutOfRangeException(nameof(fontType), fontType, "Invalid option.")
      };
    }
  }
}