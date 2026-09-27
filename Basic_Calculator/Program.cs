int firstNumber, secondNumber;
Console.WriteLine("Type first number:");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Type second number:");
secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"Sum is {firstNumber + secondNumber}");
Console.WriteLine($"Difference is {firstNumber - secondNumber}");
Console.WriteLine($"Product is {firstNumber * secondNumber}");
Console.WriteLine($"Quotient is {firstNumber / secondNumber}");