repeat: //  label
Console.WriteLine("Input number of days: ");
var input = Console.ReadLine();
if (int.TryParse(input, out var days))
{
    int years = days / 365; //  number of years
    days = days % 365;      //  obtain remaining number of days after getting the years

    int weeks = days / 7;   //  number of weeks
    days = days % 7;        //  obtain remaining number of days after getting the weeks

    Console.WriteLine($"Years = {years}");
    Console.WriteLine($"Weeks = {weeks}");
    Console.WriteLine($"Days = {days}");  
}
else
{
    goto repeat;
}
  