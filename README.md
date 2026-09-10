# C# Student Grade Calculator

A simple C# console application that calculates a student's average grade and corresponding letter grade.

## Features

- Accepts a student's name.
- Accepts multiple course grades.
- Validates grades between 0 and 100.
- Calculates the average grade.
- Converts the average into a letter grade.
- Provides clear and user-friendly console messages.
- Supports `exit`, `Exit`, `EXIT`, etc.
- Uses C# collections, LINQ, string methods, and a switch expression.

## Grading Scale

| Average | Letter Grade |
|---:|:---:|
| 90–100 | A |
| 80–89 | B |
| 70–79 | C |
| 60–69 | D |
| 0–59 | F |

## Requirements

- .NET 8 SDK or newer

## How to Run

Open a terminal in the `StudentGradeCalculator` folder and run:

```bash
dotnet run
```

## Example

```text
Enter student name (or type 'exit' to quit): Alex
Enter grade 1: 85
Grade 85 added successfully.
Add another grade? (yes/no): yes
Enter grade 2: 92
Grade 92 added successfully.
Add another grade? (yes/no): no

Student : Alex
Grades  : 85, 92
Average : 88.50
Grade   : B
```

## Project Structure

```text
csharp-student-grade-calculator/
├── StudentGradeCalculator/
│   ├── Program.cs
│   └── StudentGradeCalculator.csproj
├── README.md
└── .gitignore
```
