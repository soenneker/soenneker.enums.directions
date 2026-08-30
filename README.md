[![](https://img.shields.io/nuget/v/soenneker.enums.directions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.directions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.directions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.directions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.directions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.directions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.directions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.directions/actions/workflows/codeql.yml)

# Soenneker.Enums.Directions

A string-backed enum-value type for marking a communication, event, or data flow as incoming or outgoing.

## Install

```bash
dotnet add package Soenneker.Enums.Directions
```

## Usage

```csharp
using Soenneker.Enums.Directions;

Direction direction = Direction.Incoming;
string wireValue = direction.Value; // "Incoming"

if (Direction.TryFromValue(input, out Direction? parsed))
{
    // parsed is Incoming or Outgoing
}
```

Available values:

- `Incoming` — entering or received by the system
- `Outgoing` — leaving or sent by the system

`System.Text.Json` serializes the type as its string value and restores recognized values to the shared static instances. `FromValue` throws for unknown input; use `TryFromValue` when parsing request or provider data. `FromName` and `TryFromName` are also generated.

Direction is always relative to a defined boundary. State that boundary in the surrounding contract—for example, incoming to your application or outgoing from a mailbox—especially when an event passes through multiple systems. The type does not imply delivery status, request/response role, or network traffic direction.
