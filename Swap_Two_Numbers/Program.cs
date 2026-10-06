Console.Write("Input 1st number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Input 2nd number: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Before Swap: firstNumber = {number1}, secondNumber = {number2}");
int temp = number1;
number1 = number2;
number2 = temp;
Console.WriteLine($"After Swap: firstNumber = {number1}, secondNumber = {number2}");