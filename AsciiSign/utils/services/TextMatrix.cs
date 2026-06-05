using AsciiSign.utils.enums;

namespace AsciiSign.utils.services
{
  internal class TextMatrix(int matrixLines)
  {
    private readonly int _matrixLines = matrixLines;
    internal int MatrixLines => _matrixLines;

    /// <summary>
    /// Generates a matrix of signatures for the given array of characters based on the provided text signatures
    /// </summary>
    /// <param name="letters">
    /// An array of characters for which the matrix is to be generated.
    /// </param>
    /// <param name="textSignatures">
    /// A dictionary mapping each character to its corresponding array of signatures.
    /// </param>
    /// <returns>
    /// A matrix of signatures representing the input text.
    /// </returns>
    internal string[,] GetSignaturesMatrix(char[] letters, Dictionary<char, string[]> textSignatures)
    {
      string[,] textMatrixSignatures = new string[MatrixLines, letters.Length];

      //Fill the matrix with the signatures for each character
      for (int line = 0; line < MatrixLines; line++)
      {
        for (int decimalElement = 0; decimalElement < letters.Length; decimalElement++)
        {
          textMatrixSignatures[line, decimalElement] = textSignatures[letters[decimalElement]][line];
        }
      }
      return textMatrixSignatures;
    }

    /// <summary>
    /// Determines the height of the signature matrix based on the selected font type.
    /// </summary>
    /// <param name="fontType">The type of font for which to determine the matrix height.</param>
    /// <returns>The height of the signature matrix.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when an invalid font type is provided.</exception>
    internal static MatrixHeight GetMatrixHeight(FontType fontType)
    {
      return fontType switch
      {
        FontType.BASIC => MatrixHeight.NINE,
        FontType.INVERTED_BASIC => MatrixHeight.NINE,
        FontType.SHADED => MatrixHeight.SIX,
        FontType.TURING => MatrixHeight.SIX,
        FontType.TRUE_TYPE => MatrixHeight.SEVEN,
        _ => throw new ArgumentOutOfRangeException(nameof(fontType), fontType, "Invalid option.")
      };
    }
  }
}