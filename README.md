# FestiveTechCalendar2025

A Blazor Server app that uses Microsoft Semantic Kernel to decide if a name is on Santa’s Naughty or Nice list. Includes a simple UI and example SK function calls.

## Features
- Blazor Server with interactive components
- Semantic Kernel prompt invocation
- Example function `RandomNaughtyOrNice`
- .NET 10 target

## Prerequisites
- .NET SDK 10 (latest preview)
- An LLM provider configured for Semantic Kernel (e.g., Azure OpenAI or OpenAI)

## Configuration
- Update `appsettings.json` or `appsettings.local.json` with your model/provider settings and keys.
- Typical settings include model name, endpoint, and API key.
- Do not commit secrets; add local files to `.gitignore`.

## Getting Started
1. Clone the repository.
2. Restore dependencies: `dotnet restore`.
3. Configure SK provider in `appsettings.local.json`.
4. Run the app: `dotnet run` (from the project directory).
5. Open the app in a browser and enter a name to get a Naughty/Nice result.

## Project Structure
- `FestiveTechCalendar2025/Components/Pages/Home.razor` – UI and SK calls
- `FestiveTechCalendar2025/Program.cs` – app setup and services
- `FestiveTechCalendar2025/RandomNumberPlugin.cs` – sample plugin/functions

## Development
- Update or add Semantic Kernel functions for custom behaviors.
- Use dependency injection to provide `Kernel` to components.

## Build and Test
- Build: `dotnet build`
- Run: `dotnet run`
- Add unit tests as needed under a test project.

## CI/CD
- See `azure-pipelines.yml` for pipeline configuration.

## Contributing
- Fork the repo and create feature branches.
- Submit PRs with concise descriptions.
- Follow existing code style and keep changes minimal.

## License
- See repository license file if present.