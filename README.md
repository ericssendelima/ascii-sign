# ✨ Ascii Sign ✨

[![Static Badge](https://img.shields.io/static/v1?label=AsciiSign&message=NuGet&color=blue&logo=nuget)](https://www.nuget.org/packages/AsciiSign/) 
![Downloads](https://img.shields.io/nuget/dt/AsciiSign.svg?logo=nuget) 
[![NuGet Version](https://img.shields.io/nuget/v/AsciiSign.svg?logo=nuget)](https://www.nuget.org/packages/AsciiSign/) 
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=flat&logo=.net&logoColor=white) 
![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=flat&logo=csharp&logoColor=white)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg?style=flat)](https://opensource.org/licenses/MIT)

**Transform plain text into magnificent ASCII art anywhere—Console, Desktop, Web, or Documents—with this lightweight and powerful .NET engine.**

---

`AsciiSign` is a zero-dependency .NET library designed to generate pixel-matrix ASCII art from plain text. While it shines in the terminal for banners and welcome screens, its newly decoupled architecture allows you to extract raw matrices and render them seamlessly in UI frameworks like **Blazor**, **WPF**, or even export them to **PDFs**.

### 🌟 NEW in v2.1.0: The `TrueType` Font & UI-Agnostic Engine! 🌟
* **Beyond the Console:** We entirely refactored the rendering engine! `AsciiSign` is no longer limited to the console. You can now generate the raw ASCII matrix (`string[,]`) using `Sign.GetAsciiArtMatrix("some text", FontType.TRUE_TYPE)` and bind it to any modern interface.
* **Streamlined API:** The old specific drawing methods are now `[Obsolete]`. Everything is now unified under a single, clean `Sign.DrawOnConsole("some text", FontType.TRUE_TYPE)` method.
* **New Font:** Introducing `TrueType`, a beautiful new style inspired by the classic [*Yie Ar Redux* font by mazeon](https://mazeon.tumblr.com/post/113879887445/yie-ar-redux-truetype-font-the-original-c64).

## 📸 See it in Action

Here is how `AsciiSign` looks across different platforms:

![AsciiSign V2.1.0 Examples](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/examples/screenshots/ascii-sign-v2-1-0.png)

*Check out the [`/examples`](./examples) folder in this repository for full implementation details on each platform!*

## ✨ Features

* **UI-Agnostic Engine:** Output directly to the Console, or get the raw Matrix data to use in Blazor, WPF, WinForms, or PDF generators.
* **Five Awesome Fonts:** Choose between `TrueType` (new retro style), `TuringFont` (filled), `ShadedFont` (hollow), `BasicFont` (simple), and `InvertedBasicFont` (inverted).
* **Zero Dependencies:** Extremely lightweight, built with pure .NET for maximum compatibility and performance.
* **Fluent and Simple API:** Generate complex matrices with a single, intuitive method call.
* **Highly Permissive License:** Now completely open-source under the MIT license, giving you total freedom for both personal and commercial use.

## 🎨 Quick Start


### 1) Install the package via NuGet:

   ```shell
   dotnet add package AsciiSign
   ```

### 2) Console Usage (The Streamlined Way):

```csharp
using AsciiSign;

// The new, unified way to draw directly to the terminal
Sign.DrawOnConsole("Hello World", FontType.BASIC);
Sign.DrawOnConsole("Welcome", FontType.TURING);

// ⚠️ NOTE: Older methods like DrawBasicFont() or DrawTuringFont() are marked as [Obsolete] 
// and will point you toward using DrawOnConsole() instead. They will be completely removed in v3.0!
```


### 3) Advanced Usage (Blazor, WPF, PDF - Matrix Generation):

If you want to render the art outside the console, extract the matrix directly!


```csharp
using AsciiSign;

// Generate the raw 2D array matrix for custom UI rendering
string[,] myAsciiArt = Sign.GetAsciiArtMatrix("Hello UI", FontType.SHADED); 

// Now you can bind 'myAsciiArt' to a Blazor Grid, a WPF Canvas, or a PDF Document!
```

---

## 🔤 Supported Characters (per font)

Character support varies by font.

- To **preview all supported characters rendered in the terminal**, clone this repo and run the Console example:
  ```bash
  git clone https://github.com/ericssendelima/ascii-sign.git
  cd ascii-sign/examples/AsciiSignConsoleApp
  dotnet run
  ```

- For the full reference list, see: **[`AsciiSign/docs/characters.md`](./AsciiSign/docs/characters.md)**.


## 🖥️ Console Notes (Window Size & Text Length)

When using `AsciiSign` in the terminal, the output is affected by **your console window dimensions** and by **the maximum supported text length for each font**.

### Console window size matters
ASCII art is “drawn” using characters that occupy space on the screen.  
If your console window is **too narrow or too short**, the terminal may wrap lines or clip the output, which can visually “break” the art.

**Fix:** simply resize/maximize your console window and run again.

### Each font has a maximum text length
Some fonts have internal size constraints. If the input text is **too long** for a given font, `AsciiSign` may throw an exception (this is intentional, to prevent malformed output).

**Fix:** reduce the number of characters in the input text, or switch to a different font.

### Want full freedom? Use the matrix API
For a more flexible and UI-independent experience, prefer:

```csharp
string[,] matrix = Sign.GetAsciiArtMatrix("your text", FontType.TRUE_TYPE);
```

With the raw `string[,]` matrix in hand, you can render the art however you want—and control its final size and layout according to your platform limits:

- Console window width/height
- Browser viewport (Blazor)
- PDF page size / margins
- WPF window size
- Any other UI surface or document format

This approach is recommended for custom layouts, responsive designs, and export scenarios.

## 📸 Examples

### Console
![Console Example](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/examples/screenshots/console.png)

### WPF
![WPF Example](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/examples/screenshots/wpf.png)

### Blazor
![Blazor Example](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/examples/screenshots/blazor.png)

### Export to PNG
![PNG Example](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/examples/screenshots/png.png)

### Export to PDF
![PDF Example](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/examples/screenshots/pdf.png)

## 🤝 How to Contribute

This is a project born from curiosity and a love for creative programming. If you have ideas for optimizations or features, your contribution is more than welcome!

1.  **Fork** this [repository](https://github.com/ericssendelima/ascii-sign).
2.  Create a new **Branch** (`git checkout -b feature/your-amazing-feature`).
3.  **Commit** your changes (`git commit -m 'Add new feature...'`).
4.  **Push** to the Branch (`git push origin feature/your-amazing-feature`).
5.  Open a **Pull Request**.

### ❤️ Like this Project?

If `AsciiSign` added a little sparkle to your application and you felt happy using it, how about sharing that happiness with a coffee? Your contribution helps keep the flame of creativity burning for new features and projects!

**Friendly note:** The platform suggests some values, but you have complete freedom to enter any amount you wish in the field next to it, starting from $1. Any coffee, is a huge gesture and makes me incredibly grateful!

[![Buy Me A Coffee](https://raw.githubusercontent.com/ericssendelima/ascii-sign/main/examples/screenshots/bmac-button.webp)](https://www.buymeacoffee.com/ericssendelima)


## 📜 Credits & License

- TrueType Font Inspiration: The TrueType font implementation was heavily inspired by the amazing  [*Yie Ar Redux* font by mazeon](https://mazeon.tumblr.com/post/113879887445/yie-ar-redux-truetype-font-the-original-c64)

This project is licensed under the **MIT License** — see the [LICENSE](./LICENSE) file for details.

---

Created with ☕ and a whole lot of code by **Yalê Ericssen** ([@ericssendelima](https://github.com/ericssendelima)).
