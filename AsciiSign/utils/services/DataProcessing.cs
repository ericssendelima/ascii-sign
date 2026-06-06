using AsciiSign.interfaces;
using AsciiSign.utils.enums;
using AsciiSign.utils.extensions;

namespace AsciiSign.utils.services
{
  /// <summary>
  /// Provides methods for processing data related to ASCII art rendering.
  /// </summary>
  internal static class DataProcessing
  {
    /// <summary>
    /// Processes the input text and generates a matrix of ASCII art representations based on the specified font type and character map.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <param name="fontType">The font type to use for rendering.</param>
    /// <param name="characterMap">The character dictionary containing the ASCII art representations.</param>
    /// <param name="matrixHeight">The height of the ASCII art matrix.</param>
    /// <param name="consoleDrawing">Indicates whether the ASCII art is intended for console drawing, which may affect character processing.</param>
    /// <param name="downscale">Indicates whether the ASCII art should be downscaled, which may affect character processing.</param>
    /// <returns>The generated ASCII art matrix.</returns>
    internal static string[,] FinalMatrixProcessment(string text, FontType fontType, ICharacterDictionary characterMap,
   MatrixHeight matrixHeight, bool consoleDrawing, bool downscale)
    {
      char[] letters = Characters.GetLettersOfInputText(text, fontType, consoleDrawing, downscale);

      string[,] textMatrixSignatures = GetTextMatrixSignatures(characterMap, matrixHeight, letters);

      return characterMap.ToAsciiArtMatrix(textMatrixSignatures, letters, matrixHeight);
    }

    /// <summary>
    /// Generates a matrix of signatures for the given text based on the character map and matrix height.
    /// </summary>
    /// <param name="characterMap">The character dictionary containing the ASCII art representations.</param>
    /// <param name="matrixHeight">The height of the ASCII art matrix.</param>
    /// <param name="letters">The array of letters to render.</param>
    /// <returns>The matrix of signatures for the given text.</returns>
    private static string[,] GetTextMatrixSignatures(ICharacterDictionary characterMap, MatrixHeight matrixHeight, char[] letters)
    {
      Dictionary<char, string[]> textSignatures = Text.GetSignatures(letters, characterMap);

      string[,] textMatrixSignatures = new TextMatrix((int)matrixHeight).GetSignaturesMatrix(letters, textSignatures);

      return textMatrixSignatures;
    }
  }
}