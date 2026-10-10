Console.Write("firstNumber = ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("secondNumber = ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("thirdNumber = ");
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine(int.Max(int.Max(firstNumber, secondNumber),thirdNumber));