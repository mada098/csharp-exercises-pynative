repeat: //  label
Console.Write("Given input: ");
var input = Console.ReadLine();
if (int.TryParse(input, out var number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} is Even");
    } else 
    {
        Console.WriteLine($"{number} is Odd");
    }
}
else
{
    goto repeat;
}