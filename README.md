# ✨ Ascii Sign ✨

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=flat-square)](https://opensource.org/licenses/MIT)

A simple, lightweight, and powerful .NET library for rendering magnificent ASCII art text directly in your console. Turn ordinary words into pixel matrix masterpieces!

![Rendering Example](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/assets/exemplo001.webp)

## ✨ Features

*   **Zero Dependencies:** Lightweight and simple, built with pure .NET.
*   **Easy to Use:** A single static method call (`Sign.DrawString("...")`) to create the magic.
*   **Unique Style:** Uses a custom 5x5 matrix font, carefully designed for readability and style.

## 🎨 How to Use

Using `AsciiSign` is incredibly simple and fun.

1.  Install the package from NuGet.

  ```shell
  dotnet add package AsciiSign
  ```

2.  Call the `DrawString()` method with the string you want to render.

```csharp
// Import the namespace
using AsciiSign;

Console.Write("Digite o nome: ");
string text = Console.ReadLine();

// Call the magic!
Sign.DrawString(text);
```

**The result will be something spectacular like this:**

![Rendering Example](https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/assets/exemplo002.webp)

## 📖 The `AsciiSign` Alphabet

Each character has a unique "signature," represented by an array of 5 integers. Each integer encodes a row of 5 pixels.

<details>
<summary>Click to see the full character map!</summary>

```csharp
// Letters
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
  { 'P', new[] { 30, 17, 30, 16, 16 } },
  { 'Q', new[] { 14, 17, 17, 18, 15 } },
  { 'R', new[] { 30, 17, 30, 20, 18 } },
  { 'S', new[] { 15, 16, 14, 1, 30 } },
  { 'T', new[] { 31, 4, 4, 4, 4 } },
  { 'U', new[] { 17, 17, 17, 17, 14 } },
  { 'V', new[] { 17, 17, 17, 10, 4 } },
  { 'W', new[] { 17, 21, 21, 21, 10 } },
  { 'X', new[] { 17, 10, 4, 10, 17 } },
  { 'Y', new[] { 17, 10, 4, 4, 4 } },
  { 'Z', new[] { 31, 2, 4, 8, 31 } }

// Numbers
  { '0', new[] { 14, 17, 17, 17, 14 } },
  { '1', new[] { 4, 12, 4, 4, 14 } },
  { '2', new[] { 30, 1, 30, 16, 31 } },
  { '3', new[] { 31, 1, 14, 1, 31 } },
  { '4', new[] { 17, 17, 31, 1, 1 } },
  { '5', new[] { 31, 16, 31, 1, 31 } },
  { '6', new[] { 31, 16, 31, 17, 31 } },
  { '7', new[] { 31, 1, 2, 4, 8 } },
  { '8', new[] { 31, 17, 31, 17, 31 } },
  { '9', new[] { 31, 17, 31, 1, 31 } }

// Symbols
  { ' ', new[] { 0, 0, 0, 0, 0 } },
  { '.', new[] { 0, 0, 0, 0, 4 } },
  { '!', new[] { 4, 4, 4, 0, 4 } },
  { '#', new[] { 10, 31, 10, 31, 10 } },
  { '+', new[] { 4, 4, 31, 4, 4 } },
  { '-', new[] { 0, 0, 31, 0, 0 } },
  { '*', new[] { 21, 14, 31, 14, 21 } },
  { '/', new[] { 1, 2, 4, 8, 16 } },
```
</details>

## 🤝 How to Contribute

This is a project born from curiosity and a love for creative programming. If you have ideas for optimizations or features, your contribution is more than welcome!

1.  **Fork** this [repository](https://github.com/ericssendelima/ascii-sign).
2.  Create a new **Branch** (`git checkout -b feature/your-amazing-feature`).
3.  **Commit** your changes (`git commit -m 'Add new feature...'`).
4.  **Push** to the Branch (`git push origin feature/your-amazing-feature`).
5.  Open a **Pull Request**.

## 📜 License

This project is distributed under the MIT license. See the [LICENSE](./LICENSE) file for more details.

---

Created by **Yalê Ericssen** ([@ericssendelima](https://github.com/ericssendelima)).