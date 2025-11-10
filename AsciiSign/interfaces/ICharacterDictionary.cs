namespace AsciiSign.interfaces
{
  /// <summary>
  /// Defines the contract for character dictionaries used to render ASCII art.
  /// </summary>
  /// <typeparam name="T">The type used for matrix signatures.</typeparam>
  /// <remarks>
  /// This interface provides a method to draw characters based on their matrix signatures.
  /// The optional parameter allows for rendering inverted signs.
  /// </remarks>
  /// <param name="textMatrixSignatures">The matrix signatures representing the text.</param>
  /// <param name="letters">The array of characters to be drawn.</param>
  /// <param name="isInvertedSign">Optional flag to indicate if the sign should be inverted.</param>
  /// <returns>Void.</returns>
  public interface ICharacterDictionary<T>
  {
    void Draw(T[,] textMatrixSignatures, char[] letters, bool? isInvertedSign = false);
  }
}