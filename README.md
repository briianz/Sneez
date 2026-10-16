# Sneez Game Engine

Sneez is a lightweight, modern, open-source-style game engine.
It aims to combine the simplicity and low resource usage of Godot with the familiar C# scripting workflow and component-based architecture of Unity.

## Architectural Decisions

**Milestone 1 - Foundation**

*   **Language & Stack:** C# (.NET)
    *   *Reasoning:* The primary requirement is that game logic uses a C# scripting workflow with a Unity-like API. Implementing the core engine and runtime entirely in C# allows for seamless integration, minimal interop overhead, and simplified builds while maintaining decent performance.

*   **Rendering & Windowing Backend:** Raylib-cs
    *   *Reasoning:* Raylib is incredibly lightweight, easy to deploy, supports multiple platforms, and requires almost zero boilerplate to get a window and renderer up and running. It aligns perfectly with the "low RAM usage, CPU overhead, and fast startup" goals while offering out-of-the-box 3D rendering primitives that let us focus on architectural and API design over graphics debugging.

*   **Project Structure:**
    *   `Sneez.Core`: The engine runtime containing lifecycle, windowing, and eventually the GameObject/Component model. It serves as the main dependency for games and the editor.
    *   `Sneez.Editor`: The graphical development environment. It will reference `Sneez.Core` to preview scenes but will remain decoupled from the final shipped game binaries.

## Getting Started

1. Install the .NET SDK.
2. Build the solution using `dotnet build`.
3. Run the editor using `dotnet run --project Sneez.Editor`.
