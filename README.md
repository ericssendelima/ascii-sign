<div align="center">
<h1 style="font-weight: bold; font-size: 2.5em;">✨ Ascii Sign ✨</h1>

[![Static Badge](https://img.shields.io/static/v1?label=AsciiSign&message=NuGet&color=blue&logo=nuget)](https://www.nuget.org/packages/AsciiSign/) ![Downloads](https://img.shields.io/nuget/dt/AsciiSign.svg?logo=nuget) [![NuGet Version](https://img.shields.io/nuget/v/AsciiSign.svg?logo=nuget)](https://www.nuget.org/packages/AsciiSign/) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=flat&logo=.net&logoColor=white) ![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=flat&logo=csharp&logoColor=white)
[![License: LGPLv3](https://img.shields.io/badge/License-LGPLv3-red.svg?style=flat)](https://opensource.org/licenses/LGPL-3.0)

</div>

**Transform plain text into console art with this lightweight and powerful .NET library.**
---

`AsciiSign` lets you render magnificent text directly in your terminal, using carefully designed pixel-matrix fonts. It's perfect for adding a special touch to welcome screens, banners, logs, or any console application that deserves a bit more style.


### 🌟 NEW in v2.0: The `TuringFont` and the `ShadedFont` 🌟

Inspired by the aesthetics of old-school computers and the work of the genius Alan Turing, the `TuringFont` offers a unique, filled, and bold look for your creations.

And don't worry, the classic `ShadedFont` (hollow) is still here for those who love the traditional style!

## 📸 Examples

<p align="center" style="display: flex; flex-wrap: wrap; justify-content: center; gap: 10px;">
  <img src="https://raw.githubusercontent.com/ericssendelima/ascii-sign/main/assets/turing-font-complete.png" width="24%" alt="Turing Font Example"/>
  <img src="https://raw.githubusercontent.com/ericssendelima/ascii-sign/main/assets/shaded-font-complete.png" width="24%" alt="Shaded Font Example"/>
  <img src="https://raw.githubusercontent.com/ericssendelima/ascii-sign/main/assets/basic-font-complete.png" width="24%" alt="Basic Font Example"/>
  <img src="https://raw.githubusercontent.com/ericssendelima/ascii-sign/main/assets/inverted-basic-font-complete.png" width="24%" alt="Inverted Basic Font Example"/>
</p>

### ❤️ Like this Project?

If `AsciiSign` added a little sparkle to your console and you felt happy using it, how about sharing that happiness with a coffee? Your contribution helps keep the flame of creativity burning for new features and projects!

**Friendly note:** The platform suggests some values, but you have complete freedom to enter any amount you wish in the field next to it, starting from $1. Any coffee, is a huge gesture and makes me incredibly grateful!

<a href="https://www.buymeacoffee.com/ericssendelima" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;" ></a>

## ✨ Features

*   **Four Awesome Fonts:** Choose between the classic `ShadedFont` (hollow), the new and robust `TuringFont` (filled), `BasicFont` (simple), and `InvertedBasicFont` (inverted).
*   **Zero Dependencies:** Lightweight and simple, built with pure .NET for maximum compatibility.
*   **Fluent and Simple API:** Create your art with a single, intuitive method call.
*   **Open Source, Protected:** Licensed under LGPLv3, ensuring the project remains free while protecting the author's work.


## 🎨 How to Use

Using `AsciiSign` is incredibly simple and fun.

1. **Install the package from NuGet.**

Run the following command in your terminal:

  ```shell
    dotnet add package AsciiSign
  ```

2.  **Call the drawing methods:**
    
Use the following code snippets in your C# project to see the magic happen:

  ```csharp

    using AsciiSign;

    // Using the Basic Font
    Sign.DrawBasicFont("Hello World!", isInvertedSign: false); // Basic Font

    Console.WriteLine("\n\n"); // Just to add some space

    // Using the Inverted Basic Font
    Sign.DrawBasicFont("Hello World!", isInvertedSign: true); // Inverted Basic Font

    // Using the new and awesome Turing Font!
    Sign.DrawTuringFont("Hello Turing");

    Console.WriteLine("\n\n"); // Just to add some space

    // Using the classic Shaded Font
    Sign.DrawShadedFont("Shaded Style");

  ```

3.  **Admire the result:**
    Your console will never be the same!

    <p align="left">
      <img src="https://raw.githubusercontent.com/ericssendelima/ascii-sign/refs/heads/main/assets/result-example.png"    width="24%" alt="Font Examples"/>
    </p>

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

 <a href="https://www.buymeacoffee.com/ericssendelima" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;" ></a>
