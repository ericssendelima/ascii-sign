using AsciiSign.interfaces;
using AsciiSign.utils.enums;
using AsciiSign.utils.services;

namespace AsciiSign;

/// <summary>
/// This class provides methods responsible for creating and drawing ASCII art.
/// </summary>
public static class Sign
{
  /// <summary>
  /// Draws the ASCII art on the console based on the provided text and whether to use inverted signs or not.
  /// </summary>
  /// <param name="text">The text for which to draw ASCII art.</param>
  /// <param name="isInvertedSign">A value indicating whether to use inverted signs.</param>
  [Obsolete("This method is obsolete and will be removed in the upcoming version 3.0. " +
    "Please use the new methods DrawOnConsole(\"abcd\", FontType.BASIC), DrawOnConsole(\"abcd\", FontType.INVERTED_BASIC)" +
    " or var someMatrix = GetAsciiArtMatrix(\"abcd\", FontType.BASIC), var someMatrix = GetAsciiArtMatrix(\"abcd\", FontType.INVERTED_BASIC).")]
  public static void DrawBasicFont(string text, bool isInvertedSign)
  {
    DrawOnConsole(text, isInvertedSign ? FontType.INVERTED_BASIC : FontType.BASIC);
  }

  /// <summary>
  /// Draws the ASCII art on the console based on the provided text using the Turing font.
  /// </summary>
  /// <param name="text">The text for which to draw ASCII art.</param>
  [Obsolete("This method is obsolete and will be removed in the upcoming version 3.0. " +
    "Please use the new methods DrawOnConsole(\"abcd\", FontType.TURING) " +
    "or var matrix = GetAsciiArtMatrix(\"abcd\", FontType.TURING)")]
  public static void DrawTuringFont(string text)
  {
    DrawOnConsole(text, FontType.TURING);
  }

  /// <summary>
  /// Draws the ASCII art on the console based on the provided text using the shaded font.
  /// </summary>
  /// <param name="text">The text for which to draw ASCII art.</param>
  [Obsolete("This method is obsolete and will be removed in the upcoming version 3.0. " +
    "Please use the new methods DrawOnConsole(\"abcd\", FontType.SHADED)" +
    " or var matrix = GetAsciiArtMatrix(\"abcd\", FontType.SHADED).")]
  public static void DrawShadedFont(string text)
  {
    DrawOnConsole(text, FontType.SHADED);
  }

  /// <summary>
  /// Draws the ASCII art on the console based on the provided text and font type.
  /// </summary>
  /// <param name="text">The text for which to draw ASCII art.</param>
  /// <param name="fontType">The type of font to use.</param>
  public static void DrawOnConsole(string text, FontType fontType)
  {
    MatrixHeight matrixHeight = TextMatrix.GetMatrixHeight(fontType);

    string[,] matrixTranslated = GetAsciiArtMatrix(text, fontType, consoleDrawing: true);

    DrawMatrix(matrixTranslated, (int)matrixHeight);
  }


  /// <summary>
  /// Generates a matrix of strings representing the ASCII art for the given text and font type.
  /// </summary>
  /// <param name="text">The text for which to generate ASCII art.</param>
  /// <param name="fontType">The type of font to use.</param>
  /// <returns>A matrix of strings representing the ASCII art.</returns>
  public static string[,] GetAsciiArtMatrix(string text, FontType fontType)
    => GetAsciiArtMatrix(text, fontType, consoleDrawing: false);
  private static string[,] GetAsciiArtMatrix(string text, FontType fontType, bool consoleDrawing)
  {
    ICharacterDictionary characterDictionary = Characters.GetCharacterDictionary(fontType);
    MatrixHeight matrixHeight = TextMatrix.GetMatrixHeight(fontType);

    string[,] matrixTranslated = DataProcessing.FinalMatrixProcessment(text, fontType, characterDictionary, matrixHeight, consoleDrawing);

    return matrixTranslated;
  }

  /// <summary>
  /// Draws the ASCII art represented by the provided matrix on the console.
  /// </summary>
  /// <param name="textToDraw">The matrix of strings representing the ASCII art.</param>
  /// <param name="matrixHeight">The height of the matrix.</param>
  private static void DrawMatrix(string[,] textToDraw, int matrixHeight)
  {
    for (int i = 0; i < matrixHeight; i++)
    {
      for (int decimalElement = 0; decimalElement < textToDraw.GetLength(1); decimalElement++)
      {
        Console.Write(textToDraw[i, decimalElement]);
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
