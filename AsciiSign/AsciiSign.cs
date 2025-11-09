/*
 * AsciiSign
 * Copyright (C) 2025 Yalê Ericssen de Lima
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using AsciiSign.utils.characterDictionaries;
using AsciiSign.utils.enums;
using AsciiSign.utils.services;

namespace AsciiSign;

/// <summary>
/// Static class to render text in ASCII art style in the console.
/// </summary>
/// <remarks>
/// Each character is represented in a 5x5 grid using binary signatures.
/// Supported characters include uppercase letters A-Z, digits 0-9, and some special characters.
/// </remarks>
public static class Sign
{
  public static void DrawTuringFont(string text)
  {
    DrawString<string>(text, FontType.TURING, Turing.Instance, MatrixHeight.SIX);
  }

  public static void DrawShadedFont(string text)
  {
    DrawString<string>(text, FontType.SHADED, Shaded.Instance, MatrixHeight.SIX);
  }

  public static void DrawBasicFont(string text, bool isInvertedSign)
  {
    DrawString<int>(text, FontType.BASIC, Basic.Instance, MatrixHeight.FIVE, isInvertedSign);
  }
  private static void DrawString<T>(string text, FontType fontType, CharacterDictionary<T> characterMap, MatrixHeight matrixHeight, bool? isInvertedSign = false)
  {
    // Get the array of characters from the input text
    char[] letters = DataProcessing<T>.GetCharactersArray(text, fontType);

    T[,] textMatrixSignatures = DataProcessing<T>.GetTextMatrixSignatures(text, fontType, characterMap, matrixHeight);

    characterMap.Draw(textMatrixSignatures, letters, isInvertedSign);
  }
}
