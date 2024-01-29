List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<int> evenNumbers = numbers.FindAll(num => num % 2 == 0);
Console.WriteLine("The filtered numbers are:");
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}