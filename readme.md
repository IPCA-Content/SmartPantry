# SmartPantry

SmartPantry is a Windows desktop application project for managing a pantry. It is built with WPF and .NET 10. The current version provides login and registration screens; pantry-management functionality is still under development.

## Requirements

- Windows
- .NET 10 SDK

## Run the application

From the repository root, run:

```powershell
dotnet run --project SmartPantry\SmartPantry.csproj
```

Or open `SmartPantry.slnx` in Visual Studio and run the `SmartPantry` project.

## Project structure

- `SmartPantry/Views` — WPF windows, including login, registration, and the main window
- `SmartPantry/ViewModels` — view models for the application screens
- `SmartPantry/Models` — models (to be added)

The project uses the CommunityToolkit.Mvvm package for MVVM support.

## Datagrid
https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datagrid?view=windowsdesktop-11.0
