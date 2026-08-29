[![](https://img.shields.io/nuget/v/soenneker.enums.directions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.directions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.directions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.directions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.directions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.directions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.directions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.directions/actions/workflows/codeql.yml)

# Soenneker.Enums.Directions

Identifies whether a communication, event, or data flow is inbound or outbound relative to the system.

## Install

```bash
dotnet add package Soenneker.Enums.Directions
```

## What you get

- `Direction` — Identifies whether a communication, event, or data flow is inbound or outbound relative to the system.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `Direction.Incoming` | The item is received by or entering the system. | The item is received by or entering the system. |
| `Direction.Outgoing` | The item is sent by or leaving the system. | The item is sent by or leaving the system. |
