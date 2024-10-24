# C# 12, and .NET 8

## Current Location

> 1. 

## To Learn

> 1. ?? is the null-coalescing operator
> 1. Implicitly and globally importing namespaces
> 1. Surrogate Pairs
> 1. Verbatim Strings | Raw Strings literals | Raw interpolated string literals

- **Literal string**: A sequence of characters enclosed in double quotes (`"`). Escape sequences like `\t` for a tab, `\n` for a newline, or `\\` for a backslash can be used. Example:

  ```csharp
  string example = "This is a tab:\tand this is a backslash:\\";
  ```

- **Raw string literal**: Characters enclosed by three or more double-quote characters (`"""`). It allows embedding any character without escape sequences and can include newlines and other special characters as is. Example:

  ```csharp
  string example = """This is a "raw" string that doesn't require escapes.""";
  ```

- **Verbatim string**: A string prefixed with `@` to disable escape characters. This means backslashes (`\`) are treated literally, and the string can span multiple lines. Example:

  ```csharp
  string example = @"C:\Program Files\MyApp\log.txt
  This is on a new line.";
  ```

- **Interpolated string**: A string prefixed with `$`, enabling the embedding of variables and expressions directly inside the string, with their values formatted. Example:
  ```csharp
  string name = "John";
  int age = 30;
  string example = $"Name: {name}, Age: {age}";
  ```

This concise explanation covers how each type of string works in C#.
