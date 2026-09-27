float celsius;
double fahrenheit;

Console.WriteLine("Type your celsius temperature:");
float.TryParse(Console.ReadLine(), out celsius);

fahrenheit = Math.Round((celsius * 9 / 5) + 32, 2);
Console.WriteLine($"{celsius}°C = {fahrenheit}°F");