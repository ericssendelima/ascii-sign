namespace AsciiSign
{
  /// <summary>
  /// Defines the different font types that can be used for ASCII art generation.
  /// </summary>
  public enum FontType
  {
    /// <summary>
    /// The default font type, which is a simple and clean style suitable for most ASCII art.
    /// </summary>
    BASIC = 1,
    /// <summary>
    /// An inverted version of the basic font, which can be used to create a different visual effect by inverting the characters.
    /// </summary>
    INVERTED_BASIC = 2,
    /// <summary>
    /// A shaded font type that adds a shadow effect to the characters, giving them a more 2.5-dimensional appearance. 
    /// </summary>
    SHADED = 3,
    /// <summary>
    /// A font type inspired by the Turing machine, which can be used to create a unique and futuristic ASCII art style.
    /// </summary>
    TURING = 4,
    /// <summary>
    /// A true type font type, which can be used to create a more realistic and detailed ASCII art style.
    /// Inspired by the "Yie Ar Redux" font developed by the artist mazeon.
    /// </summary>
    TRUE_TYPE = 5
  }
}