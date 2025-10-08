## ~~ Step One ~~

- Install the .NET SDK
https://dotnet.microsoft.com/en-us/download

- Verify install
Terminal: dotnet --version

## ~~ Step Two ~~

- Install vs code && C# Dev Kit Extension

## ~~ Step Three ~~

- Create your first project
Terminal: mkdir MyFirstApp
Terminal: cd MyFirstApp
Terminal: dotnet new console

## ~~ File structure ~~

The dotnet command will generate a few files/folders
- obj 
- MyFirstApp.csproj // The C# Project file
- Program.cs // Main C# code file

# ~~ Running your project ~~

- In the correct folder
Terminal: dotnet run

## ~~ Key differences from Python and JavaScript ~~

- Project based: C# development is project-based, using a .csproj file to manager settings and dependencies, unlike the more standalone 
nature of individual Python and JavaScript files.

- Compilation: C# is a compiled language. The dotnet run command or building in visual studio compiles your C# code into an intermediate language (IL) before it is executed. This is different from the interpreted nature of Python and JavaScript.

- Structured Environment: The tooling for C# (Both vs code and the .NET SDK) is designed to create a well-defined folder structure for your projects.

For a beginner, starting with a console application s highly recommended as it lets you focus on learnign the C# language without the complexity of a user interface.