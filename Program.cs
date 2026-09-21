Console.WriteLine("Student Grade Calculator");

Console.Write("Enter student name: ");
string studentName = Console.ReadLine();

List<double> grades = new List<double>();

Console.Write("How many grades do you want to enter? ");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.Write("Enter grade: ");
    double grade = Convert.ToDouble(Console.ReadLine());

    grades.Add(grade);
}

double total = 0;

foreach (double grade in grades)
{
    total += grade;
}

// Intentional mistake: divides by count + 1
double average = total / (count + 1);

string result;

if (average >= 60)
{
    result = "Passed";
}
else
{
    result = "Failed";
}

Console.WriteLine();
Console.WriteLine("Student: " + studentName);
Console.WriteLine("Average: " + average);
Console.WriteLine("Result: " + result);
