# TodoAppCSharp

A simple to-do list desktop application built with C# and Windows Forms.

## Features

- Add new tasks  
- Edit tasks in-place  
- Mark tasks as done/undone  
- Delete tasks  
- Import/export tasks to and from JSON  
- Persistent data saved locally (JSON-based storage)

## Requirements

- .NET 8 SDK or later  
- Windows OS  
- Visual Studio 2022+ (with .NET Desktop Development workload)

## How to Run

1. Clone the repository:
 https://github.com/HaniSafaee/TodoAppCSharp.git
2. Open the solution file `TodoAppCSharp.sln` in Visual Studio.

3. Build and run the project using the "Start" button in Visual Studio.

<pre lang="markdown"> ## Project Structure ``` TodoAppCSharp/ 
├── Form1.cs # Main UI and logic 
├── Task.cs # Task model 
├── TaskManager.cs # Handles saving/loading tasks from JSON 
├── TodoAppCSharp.sln # Visual Studio solution file 
├── Program.cs # App entry point 
├── README.md # Project instructions 
└── bin/ & obj/ # Build outputs (auto-generated) ``` </pre>

## Notes

- Tasks are saved automatically in a JSON file named `tasks.json` located in the executable directory.
- Import/export allows you to move your task list across sessions or share them with others.

## License

This project is for educational and portfolio purposes.
