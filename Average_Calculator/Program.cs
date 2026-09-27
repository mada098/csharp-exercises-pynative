double firstNumber, secondNumber, thirdNumber;

Console.WriteLine("Input first number:");
firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Input second number:");
secondNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Input third number:");
thirdNumber = double.Parse(Console.ReadLine());

Console.WriteLine($"Average = {Math.Round((firstNumber + secondNumber + thirdNumber)/3,2)}");