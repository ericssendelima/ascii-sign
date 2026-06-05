using SkiaSharp;

namespace AsciiSign.Converter;

public static class AsciiSignExporter
{
  public static void SavePng(string[,] matrix, string path, int pixelWidth = 12, int pixelHeight = 12)
  {
    const int Padding = 32;

    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    int contentWidth = cols * pixelWidth;
    int contentHeight = rows * pixelHeight;

    int width = contentWidth + (Padding * 2);
    int height = contentHeight + (Padding * 2);

    int offsetX = (width - contentWidth) / 2;
    int offsetY = (height - contentHeight) / 2;

    var info = new SKImageInfo(width, height, SKColorType.Rgba8888, SKAlphaType.Premul);

    using var surface = SKSurface.Create(info);
    var canvas = surface.Canvas;

    var bg = new SKColor(17, 17, 17);
    var on = new SKColor(0, 255, 102);

    canvas.Clear(bg);

    using var paint = new SKPaint
    {
      Color = on,
      IsAntialias = false, 
      Style = SKPaintStyle.Fill
    };

    for (int r = 0; r < rows; r++)
    {
      int y0 = offsetY + r * pixelHeight;

      for (int c = 0; c < cols; c++)
      {
        var cell = matrix[r, c] ?? string.Empty;
        if (!cell.Contains('█')) 
          continue;

        int x0 = offsetX + c * pixelWidth;
        canvas.DrawRect(x0, y0, pixelWidth, pixelHeight, paint);
      }
    }

    using var image = surface.Snapshot();
    using var data = image.Encode(SKEncodedImageFormat.Png, 100);

    using var stream = File.OpenWrite(path);
    data.SaveTo(stream);
  }
}