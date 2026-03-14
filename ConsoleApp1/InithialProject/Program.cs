// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Statistics App");

Console.Write("Enter first number: ");
string first = Console.ReadLine();

Console.Write("Enter second number: ");
string second = Console.ReadLine();

if (int.TryParse(first, out int a) && int.TryParse(second, out int b))
{
    Console.WriteLine("Sum = " + StatisticsHelper.Sum(a, b));
}
else
{
    Console.WriteLine("Invalid input");
}
int[] values = { 2, 4, 6, 8 };
Console.WriteLine("Average = " + StatisticsHelper.CalculateAverage(values));