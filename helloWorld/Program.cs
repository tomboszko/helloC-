

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

// pendu
Console.WriteLine(" You're good at math, are yuou so good with word ? Would you like to play Hangman now? (yes/no)");
string? playHangman = Console.ReadLine();
if (playHangman?.ToLower() == "yes")
{
    List<string> wordList = new List<string> { "balls", "ass", "dick", "pussy", "boobs" };
    Random random = new Random();
    string wordToGuess = wordList[random.Next(wordList.Count)];
    string wordToDisplay = new string('_', wordToGuess.Length);
    int lives = 5; // nombre de vie(peut être essayer d'adapter au nombre de lettres du mot)
    List<char> guessedLetters = new List<char>();

    Console.WriteLine("Welcome to Hangman!");
    while (lives > 0 && wordToDisplay.Contains('_'))
    {
        Console.WriteLine($"Word: {wordToDisplay} Lives left: {lives}");
        Console.Write("Guess a letter: ");
        char guess = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (guessedLetters.Contains(guess))
        {
            Console.WriteLine($"You've already guessed '{guess}'. Try a different letter.");
            continue;
        }

        guessedLetters.Add(guess);

        if (wordToGuess.Contains(guess))
        {
            Console.WriteLine($"Good guess! '{guess}' is in the word.");
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == guess)
                {
                    wordToDisplay = wordToDisplay.Remove(i, 1).Insert(i, guess.ToString());
                }
            }
        }
        else
        {
            Console.WriteLine($"Sorry, '{guess}' is not in the word. Try again.");
            lives--;
        }
    }

    if (lives > 0)
    {
        Console.WriteLine($"Congratulations, {name}! You've won! The word was '{wordToGuess}'.");
    }
    else
    {
        Console.WriteLine($"Out of lives! The word was '{wordToGuess}'. Better luck next time, {name}.");
    }
}
else
{
    Console.WriteLine("Okay, maybe some other time!");
}

Console.WriteLine("Thank you for playing. Goodbye!");

