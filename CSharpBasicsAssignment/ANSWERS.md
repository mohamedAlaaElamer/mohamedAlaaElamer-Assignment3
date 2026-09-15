# Part G: Short Answer Questions

### 1. Project Configuration Confirmation
The `.csproj` file contains all four required properties:
- `<OutputType>Exe</OutputType>`
- `<TargetFramework>net8.0</TargetFramework>` (or net9.0)
- `<ImplicitUsings>enable</ImplicitUsings>`
- `<Nullable>enable</Nullable>`

---

### 2. Do `#region` / `#endregion` change the compiled output? Why might you still use them?
- **Do they change output?** No, the compiler completely ignores them; they produce zero changes in the compiled IL code.
- **Why use them?** They are solely for code editor organization, allowing developers to collapse and expand logical sections of code to keep large files readable.

---

### 3. When would you reach for `///` XML doc comments instead of a plain `//`?
- Plain `//` comments are meant for internal notes and implementation details for anyone reading the source code directly.
- `///` XML doc comments are used on public APIs, classes, methods, and parameters. They provide IntelliSense tooltips and documentation popups for developers consuming your code, and they can be exported to generate external API documentation files.

---

### 4. Why does C# have no true global variables, and what's the closest equivalent?
- **Why no global variables?** C# is purely object-oriented, requiring all code and state to belong to a type (class, struct, or interface) to prevent unstructured side effects, maintain encapsulation, and avoid naming collisions.
- **Closest equivalent:** A `public static` field or property inside a `public static class` (e.g., `AppConfig.Setting`).