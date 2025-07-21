# Copilot Instructions for RimWorld Modding Project

## Mod Overview and Purpose
This project is a RimWorld mod aimed at enhancing the default mechanics of pawn generation during quests. Specifically, it introduces new logic and features to diversify the pawns generated for quest-related activities, adding depth and variety to the storytelling aspect of RimWorld.

## Key Features and Systems

1. **Enhanced Pawn Generation for Quests**: 
   - The mod modifies the existing pawn generation system used during quests to create more diverse and interesting characters.
   
2. **Core Utility Functions**:
   - The `Core` class provides a set of static methods that are used across the mod for various utility and helper functions.

3. **Modular Design**:
   - The mod uses a class-based structure to separate different functionalities and features, making it easier to maintain and expand.

## Coding Patterns and Conventions

- **Naming Conventions**:
  - Classes use PascalCase. For example, `PawnGenerator_GeneratePawn`.
  - Methods also use PascalCase without any leading underscore.
  - Variables are typically named using camelCase.

- **Access Modifiers**:
  - Use `public` for methods that need to be accessed across different classes and potentially by other mods.
  - Use `private` or `internal` for methods that are only meant to be used within their declaring class.

- **Commenting and Documentation**:
  - Use XML documentation comments (`///`) for classes and methods that describe their functionality and parameters.

## XML Integration

- Although XML is not directly mentioned in the provided summary, XML is commonly used in RimWorld mods for defining game data such as Defs.
- Ensure XML mod data files are validated and properly formatted.
- Adhere to RimWorld's XML schema for defining new custom Defs or overriding existing ones.

## Harmony Patching

- **Usage of Harmony**:
  - Harmony is used to patch methods in RimWorld’s core code. This allows the mod to modify behavior without changing the original game files.
  
- **Patch Types**:
  - **Prefix Patch**: Execute logic before the original method.
  - **Postfix Patch**: Execute logic after the original method.

- **Safety and Compatibility**:
  - Harmonize only when necessary, ensuring patches are as non-intrusive as possible for compatibility with other mods.
  - Always check for mod compatibility by safely handling potential exceptions and removal of patches if the target structure has changed.

## Suggestions for Copilot

- **Helper Methods**: 
  - Suggest both small utility methods to handle repetitive tasks and more complex logic patterns specific to pawn generation.

- **Comments and Summaries**:
  - Encourage the use of inline comments to explain complex logic and XML comments for public methods, keeping help and documentation readily available within the codebase.

- **Pattern Recognition**:
  - Suggest patterns in game logic that enhance readability and maintainability, such as switch cases, loops, or LINQ for handling lists.

- **Harmony Integration**:
  - Suggest best practices for setting up Harmony patches, including managing Harmony instances and targeting specific methods non-destructively.

This guide provides a comprehensive overview of the project architecture and coding guidelines to aid developers in utilizing GitHub Copilot effectively for expanding and maintaining this RimWorld mod.
