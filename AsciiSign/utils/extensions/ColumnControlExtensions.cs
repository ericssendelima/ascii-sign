using AsciiSign.interfaces;
using AsciiSign.utils.enums;
using AsciiSign.utils.services;

namespace AsciiSign.utils.extensions
{
  /// <summary>
  /// This class provides extension methods for managing the character dictionary and converting text matrix signatures into an ASCII art matrix.
  /// It includes logic to determine the starting column for each letter based on the character length and matrix height, ensuring proper
  /// alignment of the ASCII art representation.
  /// </summary>
  internal static class ColumnControlExtensions
  {
    /// <summary>
    /// Converts the text matrix signatures into an ASCII art matrix based on the provided character dictionary, letters, and matrix height.
    /// </summary>
    /// <param name="characterDictionary">The character dictionary containing the ASCII art representations.</param>
    /// <param name="textMatrixSignatures">The text matrix signatures to convert.</param>
    /// <param name="letters">The array of letters to render.</param>
    /// <param name="matrixHeight">The height of the ASCII art matrix.</param>
    /// <returns>The resulting ASCII art matrix.</returns>
    internal static string[,] ToAsciiArtMatrix(this ICharacterDictionary characterDictionary, string[,] textMatrixSignatures, 
      char[] letters, MatrixHeight matrixHeight)
    {
      int matrixHeightInteger = (int)matrixHeight;

      var characterLength = (textMatrixSignatures[0,0].Length * letters.Length);
      var response = new string[matrixHeightInteger, characterLength];

      for (int line = 0; line < matrixHeightInteger; line++) // Number of lines in the ASCII art matrix
      {
        for (int column = 0; column < letters.Length; column++) // Number of letters to render
        {
          int currentLetterColumnPosition = GetLetterStartColumn(textMatrixSignatures, matrixHeightInteger, column);

          // Get the hexadecimal string representation for the current line and letter
          string hex = textMatrixSignatures[line, column];
          for (int hexColumn = 0; hexColumn < hex.Length; hexColumn++) 
          {
            response[line, currentLetterColumnPosition] = Characters.GetRelactiveAsciiValue(hex[hexColumn]);
            currentLetterColumnPosition++;
          }
        }
      }
      return response;
    }

    /// <summary>
    /// Determines the starting column for a letter in the ASCII art matrix based on the character length and matrix height.
    /// This relationship changes according to the character length and matrix height.
    /// </summary>
    /// <param name="textMatrixSignatures">The text matrix signatures.</param>
    /// <param name="matrixHeight">The height of the ASCII art matrix.</param>
    /// <param name="column">The column index of the letter.</param>
    /// <returns>The starting column for the letter.</returns>
    private static int GetLetterStartColumn(string[,] textMatrixSignatures, int matrixHeight, int column)
    {
      int response;
      int characterLength = textMatrixSignatures[0, 0].Length;

      if (characterLength == matrixHeight)
      {
        response = matrixHeight * column;
      }
      else if (characterLength < matrixHeight)
      {
        if (matrixHeight - characterLength > 2)
        {
          response = (matrixHeight - 3) * column;
        }
        else
        {
          response = (matrixHeight - 2) * column;
        }
      }
      else
      {
        response = (matrixHeight + 1) * column;
      }
      return response;
    }
  }
}
