using AsciiSign.interfaces;

namespace AsciiSign.utils.characterDictionaries
{
  /// <summary>
  /// Provides a base class for character dictionaries used to render ASCII art.
  /// </summary>
  /// <typeparam name="T">The type used for matrix signatures.</typeparam>
  /// <remarks>
  /// This abstract class implements the ICharacterDictionary interface and requires derived classes to provide
  /// a mapping of characters to their matrix signatures as well as the drawing logic.
  /// </remarks>
  public abstract class CharacterDictionary<T> : ICharacterDictionary<T>
  {
    public abstract IReadOnlyDictionary<char, T[]> SignaturesMap { get; }

    public abstract void Draw(T[,] textMatrixSignatures, char[] letters, bool? isInvertedSign = false);

  }
}