using AsciiSign;
using AsciiSign.Converter;

var matrix = Sign.GetAsciiArtMatrix("png - AsciiSign", FontType.TRUE_TYPE);
AsciiSignExporter.SavePng(matrix, "asciisign.png", pixelWidth: 20, pixelHeight: 20);

 