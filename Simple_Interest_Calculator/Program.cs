int principal, rate, time;

Console.Write("principal = ");
principal = Convert.ToInt32(Console.ReadLine());

Console.Write("rate = ");
rate = Convert.ToInt32(Console.ReadLine());

Console.Write("time = ");
time = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Simple Interest = {(principal * rate * time) / 100}");