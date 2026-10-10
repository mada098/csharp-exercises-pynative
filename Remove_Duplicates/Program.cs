var numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(2); 
numbers.Add(3);
numbers.Add(4);
numbers.Add(4);
numbers.Add(5);

var newList = new List<int>();

foreach (var number in numbers)
{
    if(!newList.Contains(number))
    {
        newList.Add(number);
    }
}

Console.Write("Unique Numbers: " + string.Join(", ", newList));