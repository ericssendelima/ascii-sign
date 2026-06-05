# Supported Characters by Font

This page documents which characters are currently supported by each `AsciiSign` font.

> Quick preview (recommended): clone the repo and run the Console example to see all supported characters rendered in the terminal:
>
> ```bash
> git clone https://github.com/ericssendelima/ascii-sign.git
> cd ascii-sign/examples/AsciiSignConsoleApp
> dotnet run
> ```

## Notes & behavior

- Character support **varies by font**.
- If your input text is **too long** for a given font, `AsciiSign` may throw an exception (intentional, to prevent malformed output).
- For full control over layout (console width, browser viewport, PDF page size, WPF window, etc.), generate a raw matrix and render it yourself:
  ```csharp
  string[,] matrix = Sign.GetAsciiArtMatrix("your text", FontType.TRUE_TYPE);
  ```

---

## FontType.TURING

**Supported (as showcased in the Console example):**
- Letters: `a-z`
- Space: ` `


---

## FontType.TRUE_TYPE

**Supported (as showcased in the Console example):**
- Letters: `a-z`
- Space: ` `
- Symbols: `-`


---

## FontType.SHADED

**Supported (as showcased in the Console example):**
- Letters: `a-z`
- Numbers: `0-9`
- Space: ` `
- Symbols: `. ! # + - / *`


---

## FontType.BASIC

**Supported (as showcased in the Console example):**
- Letters: `a-z`
- Numbers: `0-9`
- Space: ` `
- Symbols: `. ! # + - / *`


---

## FontType.INVERTED_BASIC

**Supported (as showcased in the Console example):**
- Letters: `a-z`
- Numbers: `0-9`
- Space: ` `
- Symbols: `. ! # + - / *`
