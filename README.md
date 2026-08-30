[![](https://img.shields.io/nuget/v/soenneker.quark.enums.displaytypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.displaytypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.displaytypes/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.displaytypes/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.displaytypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.displaytypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.displaytypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.displaytypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.displaytypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.displaytypes/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.DisplayTypes

Strongly named Tailwind display utility tokens for Quark components and builders.

## Installation

```bash
dotnet add package Soenneker.Quark.Enums.DisplayTypes
```

## Usage

```csharp
using Soenneker.Quark;

DisplayEnum display = DisplayEnum.InlineFlex;
string className = display.Value;
// inline-flex
```

Values are complete Tailwind class names, so they can be written directly into a class attribute. `DisplayEnum.None.Value` is `hidden`, not the CSS keyword `none`.

Available values cover:

- Visibility/layout: `None`, `Inline`, `InlineBlock`, `Block`, `FlowRoot`, `Flex`, `InlineFlex`, `Grid`, `InlineGrid`, `Contents`, and `ListItem`.
- Table layout: `Table`, `TableCaption`, `TableColumn`, `TableColumnGroup`, `TableFooterGroup`, `TableHeaderGroup`, `TableRowGroup`, `TableCell`, and `TableRow`.

Use [`Soenneker.Quark.Builders`](https://www.nuget.org/packages/Soenneker.Quark.Builders/) when responsive or state variants need to be chained around these values.
