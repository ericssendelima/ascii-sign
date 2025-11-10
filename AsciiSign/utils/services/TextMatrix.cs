using AsciiSign.utils.characterDictionaries;
using AsciiSign.utils.enums;

namespace AsciiSign.utils.services
{
  /// <summary>
  /// Represents a matrix of text signatures for ASCII art rendering.
  /// </summary>
  /// <typeparam name="T">The type of the signatures (string, int).</typeparam>
  public class TextMatrix<T>(int matrixHeight)
  {
    private readonly int _matrixHeight = matrixHeight;
    public int MatrixHeight => _matrixHeight;

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
    public T[,] GetSignatures(char[] letters, Dictionary<char, T[]> textSignatures)
    {
      T[,] textMatrixSignatures = new T[MatrixHeight, letters.Length];

      // Fill the matrix with the signatures for each character
      for (int line = 0; line < MatrixHeight; line++)
      {
        for (int decimalElement = 0; decimalElement < letters.Length; decimalElement++)
        {
          textMatrixSignatures[line, decimalElement] = textSignatures[letters[decimalElement]][line];
        }
      }
      return textMatrixSignatures;
    }
  }
}