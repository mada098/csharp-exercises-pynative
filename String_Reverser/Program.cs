string ReverseString(string s)
{
    string reversedString = "";
    for (int i = s.Length - 1; i >= 0; i--)
    {
        reversedString += s[i];
    }
    return reversedString;
}

Console.Write("text: ");
var input = Console.ReadLine();
Console.WriteLine(ReverseString(input));