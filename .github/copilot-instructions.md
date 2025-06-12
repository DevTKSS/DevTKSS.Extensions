# Copilot Instructions

## General Guidelines
- Documentation:
  - Use English for all XML documentation and comments
  - Keep documentation concise and to the point
  - Apply these rules whenever documentation is requested or appropriate
- Use German for chat responses unless specified otherwise

## Framework and Language Features
- For multi-targeted projects:
  - Use latest C#/.NET features where available
  - Implement framework-specific code using conditional compilation:

  ```csharp
  #if NET9_0_OR_GREATER
  // .NET 9 code
  #else
  // .NET 8 compatible code
  #endif
  ```

- When `/optimize` flag is present or if asked for optimization:
  - Implement optimizations for highest target framework
  - Maintain compatibility with lower frameworks using conditionals
  - Consider performance trade-offs and test thoroughly
  - Optimize code paths based on usage patterns
  - prefer expressions over statements where appropriate

## Platform-Specific Guidelines
- Uno Platform Projects:
  - Identified by `Sdk="Uno.Sdk"` in project file (.csproj)
  - Do not treat as MAUI projects
  - Reference official Uno Platform repositories
  - Use APIs from `uno`, `uno.extensions`, and official Uno sources
- Regular .NET Projects:
  - Identified by `Sdk="Microsoft.NET.Sdk"` in project file

**Note**: These above described guidelines apply workspace-wide unless explicitly overridden, regardless of whether specific flags like `/doc` or `/optimize` are used.

## Markdown Guidelines

- Use proper markdown syntax and formatting:

  ```md
  # H1 Header

  ## H2 Header
  ```

- List item
  - Nested item
      - Further nested- Code blocks must:
  - Include language identifier
  - Use correct indentation
  - Example:

  ```csharp
  public class Example
  {
      public void Method()
      {
          // Code here
          }
      }
  ```

- Tables should be properly aligned:

  | Header 1 | Header 2 |
  |----------|----------|
  | Cell 1   | Cell 2   |
