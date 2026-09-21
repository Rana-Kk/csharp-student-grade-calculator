using System.Globalization;

Console.WriteLine("==========================================");
Console.WriteLine("       C# Student Grade Calculator");
Console.WriteLine("==========================================");
Console.WriteLine();

Console.Write("Enter student name: ");
string? studentName = Console.ReadLine();

while (string.IsNullOrWhiteSpace(studentName))
{
    Console.Write("Student name cannot be empty. Enter a name: ");
    studentName = Console.ReadLine();
}

var grades = new List<double>();

Console.WriteLine();
Console.WriteLine("Enter 3 course grades from 0 to 100.");

for (int i = 0; i < 3; i++)
{
    while (true)
    {
        Console.Write($"Enter grade {i + 1}: ");
        string? input = Console.ReadLine();

        if (double.TryParse(
                input,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out double grade) &&
            grade >= 0 &&
            grade <= 100)
        {
            grades.Add(grade);
            break;
        }

        Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
    }
}

// INTENTIONAL BUG: average should be total / grades.Count
double total = grades.Sum();
double average = total / (grades.Count + 1);

string result = average >= 50 ? "Passed" : "Failed";

Console.WriteLine();
Console.WriteLine("==========================================");
Console.WriteLine("              GRADE RESULT");
Console.WriteLine("==========================================");
Console.WriteLine($"Student : {studentName.Trim()}");
Console.WriteLine($"Grades  : {string.Join(", ", grades)}");
Console.WriteLine($"Average : {average:0.00}");
Console.WriteLine($"Result  : {result}");
Console.WriteLine("==========================================");
