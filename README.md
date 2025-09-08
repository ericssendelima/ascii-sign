# ✨ Console Renderer ✨

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=flat-square)](https://opensource.org/licenses/MIT)

Uma biblioteca .NET simples, leve e poderosa para renderizar textos magníficos em arte ASCII diretamente no seu console. Transforme palavras comuns em obras de arte de matriz de pixels!

![Exemplo de Renderização](./assets/exemplo001.webp)

## ✨ Recursos

*   **Zero Dependências:** Leve e simples, feito em .NET puro.
*   **Fácil de Usar:** Uma única chamada de método estático (`ConsoleRenderer.Draw("...")`) para criar a mágica.
*   **Estilo Único:** Usa uma fonte de matriz 5x5 personalizada, criada com um design cuidadoso para garantir legibilidade e estilo.

## 🎨 Como Usar

Usar o `ConsoleRenderer` é incrivelmente simples e divertido.

1.  Adicione o projeto à sua solução.
2.  Chame o método `Draw()` com a string que você deseja renderizar.

```csharp
// Chame a mágica!
ConsoleRenderer.Draw("Ola Mundo!");
```

**O resultado será algo espetacular como isto:**

![Exemplo de Renderização](./assets/exemplo002.webp)

## 📖 O Alfabeto do `ConsoleRenderer`

Cada caractere tem uma "assinatura" única, representada por um array de 5 inteiros. Cada inteiro codifica uma linha de 5 pixels.

<details>
<summary>Clique para ver o mapa de caracteres completo!</summary>

```csharp
// Letras
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

// Números
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

// Símbolos
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

## 🤝 Como Contribuir

Este é um projeto nascido da curiosidade e do amor pela programação criativa. Se você tem ideias para otimizações ou recursos, sua contribuição é mais do que bem-vinda!

1.  Faça um **Fork** deste repositório.
2.  Crie uma nova **Branch** (`git checkout -b feature/sua-feature-incrivel`).
3.  Faça o **Commit** das suas mudanças (`git commit -m 'Adiciona novo recurso...'`).
4.  Faça o **Push** para a Branch (`git push origin feature/sua-feature-incrivel`).
5.  Abra um **Pull Request**.

## 📜 Licença

Este projeto é distribuído sob a licença MIT. Veja o arquivo [LICENSE](./LICENSE) para mais detalhes.

---

Criado por **Yalê Ericssen** ([@ericssendelima](https://github.com/ericssendelima)).