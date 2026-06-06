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

### 🌟 NEW in v2.2.0: Downscaling & High-Fidelity Rendering! 🌟
* **Compact Rendering:** You can now generate compact ASCII art using the new optional `downscale: true` parameter. Ideal for constrained environments or when you need a minimalist visual.
* **Stylized shadows:** The `Turing` and `Shaded` fonts have been redesigned using solid blocks to represent shadows, due to the new ability to reduce the font size by 50% in the console.
* **Bug Fixes:** Improved error handling and resolved various exceptions that occurred during matrix generation in previous versions.

### 🌟 NEW in v2.1.0: The `TrueType` Font & UI-Agnostic Engine! 🌟
* **Beyond the Console:** We entirely refactored the rendering engine! `AsciiSign` is no longer limited to the console. You can now generate the raw ASCII matrix (`string[,]`) using `Sign.GetAsciiArtMatrix("some text", FontType.TRUE_TYPE)` and bind it to any modern interface.
* **Streamlined API:** The old specific drawing methods are now `[Obsolete]`. Everything is now unified under a single, clean `Sign.DrawOnConsole("some text", FontType.TRUE_TYPE)` method.
* **New Font:** Introducing `TrueType`, a beautiful new style inspired by the classic [*Yie Ar Redux* font by mazeon](https://mazeon.tumblr.com/post/113879887445/yie-ar-redux-truetype-font-the-original-c64).

## 📸 See it in Action

Here is how `AsciiSign` looks across different platforms:

![AsciiSign V2.2.0 Examples](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/examples/screenshots/ascii-sign-v2-2-0.png)

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

// Draw in compact size (50% reduction)
Sign.DrawOnConsole("Hello world in a compact size", FontType.TURING, downscale: true);

// ⚠️ NOTE: Older methods like DrawBasicFont() or DrawTuringFont() are marked as [Obsolete] 
// and will point you toward using DrawOnConsole() instead. They will be completely removed in v3.0!
```


### 3) Advanced Usage (Blazor, WPF, PDF - Matrix Generation):

If you want to render the art outside the console, extract the matrix directly!


```csharp
using AsciiSign;

// Generate the raw 2D array matrix for custom UI rendering
string[,] myAsciiArt = Sign.GetAsciiArtMatrix("Hello UI", FontType.SHADED); 

// Now you can bind 'AsciiSign' to a Blazor Grid, a WPF Canvas, or a PDF Document!
```

---

### 🎨 Rendering Shadows Outside the Console

When using `Sign.GetAsciiArtMatrix(...)`, the library returns a raw matrix. The "Shadow Effect" in `Turing` and `Shaded` fonts depends
on identifying which characters are meant to be shadows.

**The Logic (Required):** 
To identify a shadow, simply check if the pixel is neither a solid block (██) nor whitespace (  ):

```csharp
string pixel = asciiMatrix[row, col];

if (pixel != "██" && pixel != "  ") 
{
    // This is a shadow pixel!
}
```


#### The Implementation (Suggestion):
How you render this is entirely up to you. You can apply different colors, styles, or even different characters depending on your UI framework (Blazor, WPF, PDF, etc.).

Here is an example of how you might implement this in a custom renderer:

**Pseudo-code:**
```csharp
string[,] asciiMatrix = Sign.GetAsciiArtMatrix("Shadow Text", FontType.SHADED);

for (int row = 0; row < asciiMatrix.GetLength(0); row++) 
{
    for (int col = 0; col < asciiMatrix.GetLength(1); col++) 
    {
        string pixel = asciiMatrix[row, col];
        
        if (pixel != "██" && pixel != "  ") 
        {
            // Apply the shadow color to its own rendering method (e.g., #262626)
            RenderText(pixel, color: "#262626");
        } 
        else 
        {
            // Render as a solid fill
            RenderText(pixel, color: "#FFFFFF");
        }
     }
}


```

This allows you to customize your shadow colors perfectly to match your application's theme!

## 🔤 Supported Characters (per font)

Character support varies by font.

- For the full reference list, see: **[`AsciiSign/docs/characters.md`](https://github.com/ericssendelima/ascii-sign/blob/main/AsciiSign/docs/characters.md)**.


## 🖥️ Console & Rendering Limits

- **Console Limitations:**  If your terminal is too small, the output may wrap or clip. Some fonts have character limits.
Exceeding them will throw an exception to prevent malformed output.

- **Fix:** Maximize your window, shorten the text, or enable `downscale: true` to shrink the Ascii art by 50%.

- **Pro Tip (UI Independence):** For custom layouts (Blazor, WPF, PDF, etc.), use the `GetAsciiArtMatrix` API. 
It gives you full control over rendering, bypassing all terminal-specific constraints.

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

## 📝 Changelog
* **v2.2.0**: 
    * Added `downscale` support (50% reduction) for all fonts.
    * Redesigned `Turing` and `Shaded` fonts using solid blocks for better visual consistency.
    * Resolved multiple internal exceptions and improved error handling during matrix generation.
* **v2.1.0**: 
    * UI-agnostic engine and `TrueType` font introduction.

## 📜 Credits & License

- TrueType Font Inspiration: The TrueType font implementation was heavily inspired by the amazing  [*Yie Ar Redux* font by mazeon](https://mazeon.tumblr.com/post/113879887445/yie-ar-redux-truetype-font-the-original-c64)

This project is licensed under the **MIT License** — see the [LICENSE](./LICENSE) file for details.


---

Created with ☕ and a whole lot of code by **Yalê Ericssen** ([@ericssendelima](https://github.com/ericssendelima)).
