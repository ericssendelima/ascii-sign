namespace AsciiSign.utils.extensions
{
  /// <summary>
  /// Provides extension methods for manipulating and processing matrices.
  /// </summary>
  internal static class MatrixExtensions
  {
    /// <summary>
    /// Downscales the given matrix by combining pairs of rows into single rows, effectively reducing the height of the matrix by half.
    /// </summary>
    /// <param name="matrix">The matrix to downscale.</param>
    /// <returns>The downscaled matrix.</returns>
    internal static string[,] Downscale(this string[,] matrix)
    {
      string cellControl;
      string downscaledElement;

      int matrixLines = matrix.GetLength(0);
      int matrixRows = matrix.GetLength(1);

      bool isEvenMatrixLines = matrixLines % 2 == 0;

      // Calculate the number of matrixLines in the downscaled matrix
      int downscaledLines = isEvenMatrixLines ? (matrixLines / 2) : (matrixLines + 1) / 2; 


      string[,] downscaled = new string[downscaledLines, matrixRows];

      for (int currentLine = 0; currentLine < matrixLines; currentLine += 2)
      {
        for (int currentRow = 0; currentRow < matrixRows; currentRow++)
        {
          string element1 = matrix[currentLine, currentRow];
          string element2;

          if (!isEvenMatrixLines && currentLine == matrixLines - 1)
          {
            element2 = "  "; // Assuming the last row should be empty
          }
          else
          {
            element2 = matrix[currentLine + 1, currentRow];
          }

          cellControl = $"{MapToDownscaledCharacter(element1)}{MapToDownscaledCharacter(element2)}";
          downscaledElement = DownscaledCharacter(cellControl);

          if (matrixLines != 0)
          {
            downscaled[currentLine / 2, currentRow] = downscaledElement;
          }
          else
          {
            downscaled[currentLine, currentRow] = downscaledElement;
          }
        }
      }

      return downscaled;
    }

    /// <summary>
    /// Maps the given element to a character representation for downscaling purposes.
    /// </summary>
    /// <param name="element">The element to map.</param>
    /// <returns>The mapped character.</returns>
    private static string MapToDownscaledCharacter(string element)
    {
      return element switch
      {
        "██" => "1",
        "  " => "0",
        _ => "0"
      };
    }

    /// <summary>
    /// Determines the downscaled character based on the provided cell control string, 
    /// which represents the combination of two elements in the original matrix.
    /// </summary>
    /// <param name="cellControl">The cell control string.</param>
    /// <returns>The downscaled character.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the cell control value is invalid.</exception>
    private static string DownscaledCharacter(string cellControl)
    {
      return cellControl switch
      {
        "11" => "█",
        "10" => "▀",
        "01" => "▄",
        "00" => " ",
        _ => throw new InvalidOperationException($"Invalid cell control value: {cellControl}")
      };
    }
  }
}
