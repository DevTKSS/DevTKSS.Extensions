# DevTKSS.Extensions

DevTKSS.Extensions is a modular suite of .NET libraries designed to simplify and accelerate development for .NET 8 and .NET 9 projects. Each library targets a specific area, such as string manipulation, data tables, numerics, storage, or Windows interop, and provides clean, reusable extension methods and helpers.

## Solution Structure

The solution consists of the following libraries:

- **DevTKSS.Extensions.Strings**: String and file path helpers (e.g., ReplaceDecSep, RemoveFileExtension)
- **DevTKSS.Extensions.DataTables**: DataTable extensions for easier data manipulation
- **DevTKSS.Extensions.Numerics**: Numeric helpers, including trigonometry and vector operations
- **DevTKSS.Extensions.Uno.Storage**: Uno Platform storage helpers, e.g., file and line range reading
- **DevTKSS.Extensions.Enumerable.DataContracts**: Enumerable and serialization helpers
- **DevTKSS.Extensions.Marshalling**: Windows interop and marshalling helpers (e.g., COM interop)

All libraries are designed for easy integration and follow modern .NET best practices. Multi-targeting for .NET 8 and .NET 9 is supported, and Uno Platform compatibility is provided where relevant.

For a quick start, see [getting-started.md](./docs/articles/getting-started.md).

> **API documentation** will be generated with DocFX and is available separately.
