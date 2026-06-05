using AsciiSign;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Text;

QuestPDF.Settings.License = LicenseType.Community;

var textToDraw = Sign.GetAsciiArtMatrix("asciisign", FontType.TRUE_TYPE);


var sb = new StringBuilder();

for (int row = 0; row < textToDraw.GetLength(0); row++)
{
  for (int col = 0; col < textToDraw.GetLength(1); col++)
  {
    sb.Append(textToDraw[row, col]);
  }

  if (row < textToDraw.GetLength(0) - 1)
    sb.AppendLine();
}

var pdfText = sb.ToString();

Document.Create(container =>
{
  container.Page(page =>
  {
    page.Size(PageSizes.A4.Portrait());
    page.PageColor(Colors.Cyan.Lighten4);
    page.MarginTop(40);
    page.MarginHorizontal(60);

    page.Content().Text(pdfText)
        .FontFamily("Consolas")
        .FontSize(6)
        .LineHeight(1);
  });
})
.GeneratePdf("output.pdf");


