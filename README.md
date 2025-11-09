# ✨ Ascii Sign ✨

[![Static Badge](https://img.shields.io/static/v1?label=AsciiSign&message=NuGet&color=blue&logo=nuget)](https://www.nuget.org/packages/AsciiSign/) ![Downloads](https://img.shields.io/nuget/dt/AsciiSign.svg?logo=nuget) [![NuGet Version](https://img.shields.io/nuget/v/AsciiSign.svg?logo=nuget)](https://www.nuget.org/packages/AsciiSign/) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=flat&logo=.net&logoColor=white) ![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=flat&logo=csharp&logoColor=white)
[![License: LGPLv3](https://img.shields.io/badge/License-LGPLv3-red.svg?style=flat)](https://opensource.org/licenses/LGPL-3.0)

**Transform plain text into console art with this lightweight and powerful .NET library.**
A simple, lightweight, and powerful .NET library for rendering magnificent ASCII art text directly in your console. Turn ordinary words into pixel matrix masterpieces!

![Rendering Example](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/assets/normal-sign.png)

![Rendering Example](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/assets/inverted-sign.png)

## ✨ Features

*   **Zero Dependencies:** Lightweight and simple, built with pure .NET.
*   **Easy to Use:** A single static method call (`Sign.DrawString("...", isInvertedSign: false)`) to create the magic.
*   **Unique Style:** Uses a custom 5x5 matrix font, carefully designed for readability and style.

## 🎨 How to Use

Using `AsciiSign` is incredibly simple and fun.

1.  Install the package from NuGet.

  ```shell
  dotnet add package AsciiSign
  ```

2.  **Call the drawing methods:**
    Use the following code snippets in your C# project to see the magic happen:
2.  Call the `DrawString(string, bool)` method with the string you want to render.

    ```csharp

    using AsciiSign;

    // Using the Basic Font
    Sign.DrawBasicFont("Hello World!", isInvertedSign: false); // Basic Font

    Console.WriteLine("\n\n"); // Just to add some space

    // Using the Inverted Basic Font
    Sign.DrawBasicFont("Hello World!", isInvertedSign: true); // Inverted Basic Font

    // Using the new and awesome Turing Font!
    Sign.DrawTuringFont("Hello Turing!");

    Console.WriteLine("\n\n"); // Just to add some space

    // Using the classic Shaded Font
    Sign.DrawShadedFont("Shaded Style");

    ```

3.  **Admire the result:**
    Your console will never be the same!

    *(This would be a great place for a GIF showing both fonts in action!)*

## 🤝 How to Contribute

This is a project born from curiosity and a love for creative programming. If you have ideas for optimizations or features, your contribution is more than welcome!

1.  **Fork** this [repository](https://github.com/ericssendelima/ascii-sign).
2.  Create a new **Branch** (`git checkout -b feature/your-amazing-feature`).
3.  **Commit** your changes (`git commit -m 'Add new feature...'`).
4.  **Push** to the Branch (`git push origin feature/your-amazing-feature`).
5.  Open a **Pull Request**.

## 📜 License

This project is distributed under the LGPLv3 license. See the [LICENSE](./LICENSE) file for more details.

---

 Created with ☕ and a whole lot of code by **Yalê Ericssen** ([@ericssendelima](https://github.com/ericssendelima)).
