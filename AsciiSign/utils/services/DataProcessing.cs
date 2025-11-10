using AsciiSign.utils.characterDictionaries;
using AsciiSign.utils.enums;

namespace AsciiSign.utils.services
{
  /// <summary>
  /// Provides methods for processing data related to ASCII art rendering.
  /// </summary>
  /// <typeparam name="T">The type of the matrix elements (string, int).</typeparam>
  public static class DataProcessing<T>
  {
    /// <summary>
    /// Generates a matrix of signatures for the given text based on the specified font type and character map.
    /// </summary>
    /// <param name="text">
    /// The input text to be converted into a matrix of signatures.
    /// </param>
    /// <param name="fontType">
    /// The font type to determine length constraints for the input text.
    /// </param>
    /// <param name="characterMap">
    /// The character dictionary mapping characters to their signatures.
    /// </param>
    /// <param name="matrixHeight">
    /// The height of the matrix for rendering the ASCII art.
    /// </param>
    /// <param name="letters">
    /// The array of characters extracted from the input text.
    /// </param>
    /// <returns>
    /// A matrix of signatures representing the input text.
    /// </returns>
    public static T[,] GetTextMatrixSignatures(string text, FontType fontType, CharacterDictionary<T> characterMap, MatrixHeight matrixHeight, char[] letters)
    {
      // Get the signatures for each character in the text
      Dictionary<char, T[]> textSignatures = Text<T>.GetSignatures(letters, characterMap);

      // Create a matrix to hold the signatures for rendering
      T[,] textMatrixSignatures = new TextMatrix<T>((int)matrixHeight).GetSignatures(letters, textSignatures);

      return textMatrixSignatures;
    }
  }
}