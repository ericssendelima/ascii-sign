/*
 * AsciiSign
 * Copyright (C) 2025 Yalê Ericssen de Lima
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * See more <https://www.gnu.org/licenses/>.
 */

using AsciiSign.utils.characterDictionaries;
using AsciiSign.utils.enums;
using AsciiSign.utils.services;

namespace AsciiSign;

/// <summary>
/// Provides methods to draw ASCII art signs in different font styles.
/// </summary>
/// <remarks>
/// Available drawing methods:
/// - DrawTuringFont: Renders text using the Turing font.
/// - DrawShadedFont: Renders text using the Shaded font.
/// - DrawBasicFont: Renders text using the Basic font; accepts an 'isInvertedSign' flag.
///
/// Each method processes the input text and uses the corresponding character dictionary
/// to render the ASCII art to the console.
/// </remarks>

public static class Sign
{
  /// <summary>
  /// Draws text using the Turing font. 
  /// </summary>
  /// <param name="text">
  /// The text to be rendered using the Turing font.
  /// </param>
  /// <remarks>
  /// This method processes the input text and uses the Turing character dictionary
  /// to render the ASCII art to the console.
  /// </remarks>
  /// <example>
  /// Sign.DrawTuringFont("Hello World");
  /// </example>
  public static void DrawTuringFont(string text)
  {
    DrawString<string>(text, FontType.TURING, Turing.Instance, MatrixHeight.SIX);
  }
  /// <summary>
  /// Draws text using the Shaded font. 
  /// </summary>
  /// <param name="text">
  /// The text to be rendered using the Shaded font.
  /// </param>
  /// <remarks>
  /// This method processes the input text and uses the Shaded character dictionary
  /// to render the ASCII art to the console.
  /// </remarks>
  /// <example>
  /// Sign.DrawShadedFont("Hello World");
  /// </example>
  public static void DrawShadedFont(string text)
  {
    DrawString<string>(text, FontType.SHADED, Shaded.Instance, MatrixHeight.SIX);
  }
  /// <summary>
  /// Draws text using the Basic font.
  /// </summary>
  /// <param name="text">
  /// The text to be rendered using the Basic font.
  /// </param>
  /// <param name="isInvertedSign">
  /// A flag indicating whether the sign should be inverted.
  /// </param>
  /// <remarks>
  /// This method processes the input text and uses the Basic character dictionary
  /// to render the ASCII art to the console. The 'isInvertedSign' flag determines
  /// whether the sign is inverted.
  /// </remarks>
  /// <example>
  /// Sign.DrawBasicFont("Hello World", true);
  /// Sign.DrawBasicFont("Hello World", false);
  /// </example>
  public static void DrawBasicFont(string text, bool isInvertedSign)
  {
    DrawString<int>(text, FontType.BASIC, Basic.Instance, MatrixHeight.FIVE, isInvertedSign);
  }

  private static void DrawString<T>(string text, FontType fontType, CharacterDictionary<T> characterMap, MatrixHeight matrixHeight, bool? isInvertedSign = false)
  {
    // Get the array of characters from the input text
    char[] letters = Characters.GetArray(text, fontType);

    // Get the matrix signatures for the text
    T[,] textMatrixSignatures = DataProcessing<T>.GetTextMatrixSignatures(text, fontType, characterMap, matrixHeight, letters);

    // Draw the text using the character map
    characterMap.Draw(textMatrixSignatures, letters, isInvertedSign);
  }
}
