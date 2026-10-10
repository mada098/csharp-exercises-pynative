var myList = new List<int>();
Console.WriteLine("Prepare to input your numbers!");

repeatInput:
Console.Write("How many numbers do you want to add? Input: ");
var totalNumbersInput = Console.ReadLine();

if (!int.TryParse(totalNumbersInput, out var totalNumbersInputInt))
{
    goto repeatInput;
}

repeatAddingElements:
for (int i = 1; i <= totalNumbersInputInt; i++)
{
    Console.Write("Enter an integer: ");
    var input = Console.ReadLine();
    if (!int.TryParse(input, out var inputInt))
    {
        goto repeatAddingElements;
    }
    else
    {
        myList.Add(inputInt);
    }
}

Console.WriteLine($"Total numbers added: {myList.Count}");