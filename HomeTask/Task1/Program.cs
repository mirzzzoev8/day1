List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
int sum = 0;
foreach (var item in numbers)
{
    sum+=item;
}
Console.WriteLine("The sum of all the elements in the list is: " + sum);