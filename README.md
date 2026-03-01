# CatWorx Badge Maker

A .NET 8 console application that collects employee information and exports it
to a CSV file, forming the data layer for an employee security-badge generation
pipeline.

---

## Why This Project Matters

This assignment was a hands-on introduction to the core pillars of the C# / .NET
ecosystem that professional developers rely on every day:

| Concept | Where it appears |
|---|---|
| **Object-oriented design** | `Employee` class — encapsulation of related data with a clean public API |
| **Static utility classes** | `Util` — stateless service methods that operate on external data |
| **File I/O** | `StreamWriter` writing structured CSV output to disk |
| **Console I/O** | Interactive prompts with validated user input |
| **Collections** | `List<Employee>` — typed generic collection |
| **Input validation** | `int.TryParse` guarding against malformed employee IDs |

Understanding these fundamentals is the prerequisite for every serious .NET
topic that follows: dependency injection, async/await, Entity Framework, ASP.NET
Core, and beyond. Getting them right at the foundational level is what separates
code that works once from code that is maintainable for years.

---

## Project Structure

```
CatWorx.BadgeMaker/
├── Employee.cs        # Domain model — stores per-employee badge data
├── Program.cs         # Entry point — drives the interactive data-collection loop
├── Util.cs            # Services — console printing and CSV export
├── data/
│   └── employees.csv  # Generated output (created on first run)
└── CatWorx.BadgeMaker.csproj
```

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Run

```bash
dotnet run
```

Follow the prompts to enter one or more employees. Leave the first-name field
empty and press **Enter** to finish. The application will:

1. Print a formatted summary table to the console.
2. Write `data/employees.csv` (created automatically if the folder is absent).

### CSV output format

```
ID,Name,PhotoUrl
1001,Jane Smith,https://example.com/photos/jane.jpg
```

---

## Key Design Decisions

- **`Employee` uses read-only auto-properties** instead of private backing fields
  with manual getters. This is idiomatic modern C# and eliminates boilerplate
  while preserving encapsulation.
- **`int.TryParse` for ID input** prevents the application from crashing on
  non-numeric input, giving the user a second chance rather than throwing an
  unhandled exception.
- **File-scoped namespaces** (`namespace CatWorx.BadgeMaker;`) reduce indentation
  across every file — the standard style since C# 10.
- **`using StreamWriter file = new(...)`** uses the modern declaration-style
  `using` statement (no extra braces required), keeping the scope tight and the
  nesting shallow.
