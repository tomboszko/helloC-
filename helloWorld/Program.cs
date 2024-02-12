

Console.WriteLine("Hello, who are you?");
string? name = Console.ReadLine();
if (!string.IsNullOrEmpty(name))
{
    name = char.ToUpper(name[0]) + name.Substring(1);
}

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

Console.WriteLine("What year were you born in?");
string? birthYearString;
int birthYear;
while (true)
{
    birthYearString = Console.ReadLine();
    if (int.TryParse(birthYearString, out birthYear))
    {
        break;
    }
    else
    {
        Console.WriteLine("I'm sorry, I didn't understand that.");
        Console.WriteLine("You must respond with a number. Please try again.");
    }
}

int age = DateTime.Now.Year - birthYear;
Console.WriteLine($"You are {age} years old.");

Console.WriteLine("Would you like to play a math game? (yes/no)");
string? playGame = Console.ReadLine();
if (playGame?.ToLower() == "yes")
{
    Random random = new Random();
    int num1 = random.Next(1, 10);
    int num2 = random.Next(1, 10);

    int answer;
    do
    {
        Console.WriteLine($"What is {num1} + {num2}?");
        string? answerString = Console.ReadLine();
        if (int.TryParse(answerString, out answer) && answer == num1 + num2)
        {
            Console.WriteLine("Correct! Well done.");

        }
        else
        {
            Console.WriteLine($"Sorry, that's not correct. Let's try again.");
        }
    } while (answer != num1 + num2);
}
else
{
    Console.WriteLine("Okay, maybe next time!");
}