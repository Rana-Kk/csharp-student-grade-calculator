using System.Globalization;

Console.WriteLine("==========================================");
Console.WriteLine("       C# Student Grade Calculator");
Console.WriteLine("==========================================");
Console.WriteLine();

Console.Write("Enter student name (or type 'exit' to quit): ");
string? studentName = Console.ReadLine();

if (IsExitCommand(studentName))
{
    Console.WriteLine("Program exited. Goodbye!");
    return;
}

while (string.IsNullOrWhiteSpace(studentName))
{
    Console.Write("Student name cannot be empty. Enter a name: ");
    studentName = Console.ReadLine();

    if (IsExitCommand(studentName))
    {
        Console.WriteLine("Program exited. Goodbye!");
        return;
    }
}

var grades = new List<double>();

Console.WriteLine();
Console.WriteLine("Enter course grades from 0 to 100.");
Console.WriteLine("Type 'exit' at any time to finish the program.");
Console.WriteLine();

while (true)
{
    Console.Write($"Enter grade {grades.Count + 1}: ");
    string? input = Console.ReadLine();

    if (IsExitCommand(input))
    {
        Console.WriteLine("Program exited. Goodbye!");
        return;
    }

    if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double grade) &&
        grade >= 0 && grade <= 100)
    {
        grades.Add(grade);
        Console.WriteLine($"Grade {grade:0.##} added successfully.");

        Console.Write("Add another grade? (yes/no): ");
        string? answer = Console.ReadLine();

        if (IsExitCommand(answer))
        {
            Console.WriteLine("Program exited. Goodbye!");
            return;
        }

        if (!string.Equals(answer?.Trim(), "yes", StringComparison.OrdinalIgnoreCase))
            break;
    }
    else
    {
        Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
    }
}

if (grades.Count == 0)
{
    Console.WriteLine("No grades were entered. Nothing to calculate.");
    return;
}

double average = grades.Average();
string letterGrade = GetLetterGrade(average);

Console.WriteLine();
Console.WriteLine("==========================================");
Console.WriteLine("              GRADE RESULT");
Console.WriteLine("==========================================");
Console.WriteLine($"Student : {studentName!.Trim()}");
Console.WriteLine($"Grades  : {string.Join(", ", grades.Select(g => g.ToString("0.##", CultureInfo.InvariantCulture)))}");
Console.WriteLine($"Average : {average:0.00}");
Console.WriteLine($"Grade   : {letterGrade}");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine("Thank you for using Student Grade Calculator!");

static bool IsExitCommand(string? input) =>
    string.Equals(input?.Trim(), "exit", StringComparison.OrdinalIgnoreCase);

static string GetLetterGrade(double average) =>
    average switch
    {
        >= 90 => "A",
        >= 80 => "B",
        >= 70 => "C",
        >= 60 => "D",
        _ => "F"
    };
