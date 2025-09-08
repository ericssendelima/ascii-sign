namespace ConsoleRenderer;

public static class AsciiFont
{
  private static readonly Dictionary<char, int[]> _letterSignatures = new()
  {
    { 'A', new[] { 14, 17, 31, 17, 17 } },
    { 'B', new[] { 30, 17, 30, 17, 30 } },
    { 'C', new[] { 14, 17, 16, 17, 14 } },
    { 'D', new[] { 30, 17, 17, 17, 30 } },
    { 'E', new[] { 31, 16, 30, 16, 31 } },
    { 'F', new[] { 31, 16, 30, 16, 16 } },
    { 'G', new[] { 14, 16, 23, 17, 14 } },
    { 'H', new[] { 17, 17, 31, 17, 17 } },
    { 'I', new[] { 14, 4, 4, 4, 14 } },
    { 'J', new[] { 7, 2, 2, 18, 12 } },
    { 'K', new[] { 18, 20, 24, 20, 18 } },
    { 'L', new[] { 16, 16, 16, 16, 31 } },
    { 'M', new[] { 17, 27, 21, 17, 17 } },
    { 'N', new[] { 25, 25, 21, 19, 19 } },
    { 'O', new[] { 14, 17, 17, 17, 14 } },
    { 'U', new[] { 17, 17, 17, 17, 14 } },
    { ' ', new[] { 0, 0, 0, 0, 0 } },
    { '.', new[] { 0, 0, 0, 0, 4 } },
    { '!', new[] { 4, 4, 4, 0, 4 } }
  };

  public static void DrawString(string text)
  {
    char[] letras = GetCharactersArray(text);

    Dictionary<char, int[]> textSignatures = GetTextSignatures(letras);

    int[,] textMatrixSignatures = GetTextMatrixSignatures(letras, textSignatures);

    Console.WriteLine();
    Console.Write("██");
    Console.WriteLine(new string('█', letras.Length * 10 + (letras.Length - 1) * 2 + 6));
    Console.WriteLine("██" + new string(' ', letras.Length * 10 + (letras.Length - 1) * 2 + 4) + "██");
    for (int linha = 0; linha < 5; linha++)
    {
      Console.Write("██  ");
      for (int elementoDecimal = 0; elementoDecimal < letras.Length; elementoDecimal++)
      {
        int dec = textMatrixSignatures[linha, elementoDecimal];
        string binary = Convert.ToString(dec, 2).PadLeft(5, '0');

        foreach (char bit in binary)
        {
          // Regra de visualização!
          if (bit == '1')
          {
            Console.Write("██"); // Um "pixel" preenchido
          }
          else
          {
            Console.Write("  "); // Um "pixel" vazio
          }
        }
        Console.Write("  ");
      }
      Console.Write("██");
      Console.WriteLine();
    }
    Console.WriteLine("██" + new string(' ', letras.Length * 10 + (letras.Length - 1) * 2 + 4) + "██");
    Console.Write("██");
    Console.WriteLine(new string('█', letras.Length * 10 + (letras.Length - 1) * 2 + 6));
  }

  private static char[] GetCharactersArray(string text)
  {
    if (string.IsNullOrEmpty(text)) throw new ArgumentException("Text cannot be null or empty.", nameof(text));
    if (text.Length > 12) throw new ArgumentException("Text length cannot be greater than 12 characters.", nameof(text));

    char[] letras = new char[text.Length];

    for (int i = 0; i < text.Length; i++)
    {
      string letra = text[i].ToString().ToUpper();
      letras[i] = char.Parse(letra);
    }

    return letras;
  }

  private static Dictionary<char, int[]> GetTextSignatures(char[] letras)
  {
    var textSignatures = new Dictionary<char, int[]>();

    for (int i = 0; i < letras.Length; i++)
    {
      if (!textSignatures.ContainsKey(letras[i]))
      {
        textSignatures.Add(letras[i], _letterSignatures.First(s => s.Key == letras[i]).Value);
      }
    }

    return textSignatures;
  }

  private static int[,] GetTextMatrixSignatures(char[] letras, Dictionary<char, int[]> textSignatures)
  {
    int[,] textMatrixSignatures = new int[5, letras.Length];

    for (int linha = 0; linha < 5; linha++)
    {
      for (int elementoDecimal = 0; elementoDecimal < letras.Length; elementoDecimal++)
      {
        textMatrixSignatures[linha, elementoDecimal] = textSignatures[letras[elementoDecimal]][linha];
      }
    }

    return textMatrixSignatures;
  }

}
