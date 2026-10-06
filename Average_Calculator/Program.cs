using System.Globalization;

double firstNumber, secondNumber, thirdNumber;

Console.WriteLine("Input first number:");
firstNumber = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Input second number:");
secondNumber = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Input third number:");
thirdNumber = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

double average = Math.Round((firstNumber + secondNumber + thirdNumber) / 3, 2);

Console.WriteLine($"Average = {average.ToString(CultureInfo.InvariantCulture)}");