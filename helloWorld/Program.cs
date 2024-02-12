Console.WriteLine("Hello, who are you?");
string? name = Console.ReadLine();

Console.WriteLine($"Hello {name}! How are you?");
string? response = Console.ReadLine();

if (response?.ToLower() == "good")
{
    Console.WriteLine($"I feel Good as well, {name} :)");
}
else
{
    Console.WriteLine($"I hope your day gets better, {name}.");
}