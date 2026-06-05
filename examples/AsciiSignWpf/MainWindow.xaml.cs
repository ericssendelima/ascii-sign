using System.Text;
using System.Windows;
using AsciiSign;

namespace AsciiArtWpf
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      var textToDraw = Sign.GetAsciiArtMatrix("wpf - ascii", FontType.TRUE_TYPE);

      var sb = new StringBuilder();

      for (int i = 0; i < textToDraw.GetLength(0); i++)
      {
        for (int decimalElement = 0; decimalElement < textToDraw.GetLength(1); decimalElement++)
        {
          sb.Append(textToDraw[i, decimalElement]);
        }
        sb.AppendLine();
      }

      AsciiArtText.Text = sb.ToString();
    }
  }
}