using System.Diagnostics.Metrics;
using System.Globalization;

namespace Final.HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] WordsToGuess = {
                   "apple", "banana", "tiger", "elephant", "pizza", "guitar", "rabbit", "lemon", "robot", "river",
                   "puppy", "candle", "ocean", "turtle", "garden", "cloud", "feather", "butterfly", "rainbow", "moon",
                   "castle", "penguin", "spider", "bicycle", "piano", "cake", "fish", "volcano", "guitar", "dolphin",
                   "flower", "sun", "jellyfish", "house", "ship", "elephant", "bird", "book", "car", "tree"
};
            string randomString = WordsToGuess[random.Next(WordsToGuess.Length)]; // Randomod amorcheva sityvis Masividan
            string guessedWord = new string('_', randomString.Length);
            int attempts = 0;
            int maxAttempts = 8;

            Console.WriteLine("You are Playing HangMan Game");
            Console.WriteLine("This is a Word that You will be Guessing by letters");

            switch (randomString.Length)
            {
                case 3:
                    Console.WriteLine("_ _ _\n");
                    break;
                case 4:
                    Console.WriteLine("_ _ _ _\n");
                    break;
                case 5:
                    Console.WriteLine("_ _ _ _ _\n");
                    break;
                case 6:
                    Console.WriteLine("_ _ _ _ _ _\n");
                    break;
                case 7:
                    Console.WriteLine("_ _ _ _ _ _ _\n");
                    break;
                case 8:
                    Console.WriteLine("_ _ _ _ _ _ _ _\n");
                    break;
                case 9:
                    Console.WriteLine("_ _ _ _ _ _ _ _ _\n");
                    break;
            }
            Console.Write("What will Your First letter be: ");
            char letter = Convert.ToChar(Console.ReadLine()); //aq gasasworebelia ragac

            while (attempts < maxAttempts && !guessedWord.Equals(randomString))
            {
             Console.Write("Try again: ");
             letter = Convert.ToChar(Console.ReadLine());
             bool found = false;
             for(int i = 0; i < randomString.Length; i++)
                {
                    if (randomString[i] == letter)
                    {
                        guessedWord = guessedWord.Substring(0, i) + letter + guessedWord.Substring(i + 1); //vitvlit meramdene adgilas unda chavsvat aso
                        found = true;
                    }
                }
                if (!found)
                {
                    attempts++;
                    switch (attempts)
                    {
                        case 1:
                            Console.WriteLine("  ____");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |    ");
                            Console.WriteLine(" |    ");
                            Console.WriteLine(" |    ");
                            Console.WriteLine("_|__");
                            break;
                        case 2:
                            Console.WriteLine("  ____");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |    O");
                            Console.WriteLine(" |    ");
                            Console.WriteLine(" |    ");
                            Console.WriteLine("_|__");
                            break;
                        case 3:
                            Console.WriteLine("  ____");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |    O");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |    ");
                            Console.WriteLine("_|__");
                            break;
                        case 4:
                            Console.WriteLine("  ____");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |    O");
                            Console.WriteLine(" |   /|");
                            Console.WriteLine(" |    ");
                            Console.WriteLine("_|__");
                            break;
                        case 5:
                            Console.WriteLine("  ____");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |    O");
                            Console.WriteLine(" |   /|\\");
                            Console.WriteLine(" |    ");
                            Console.WriteLine("_|__");
                            break;
                        case 6:
                            Console.WriteLine("  ____");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |    O");
                            Console.WriteLine(" |   /|\\");
                            Console.WriteLine(" |   / ");
                            Console.WriteLine("_|__");
                            break;
                        case 7:
                            Console.WriteLine("  ____");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |    O");
                            Console.WriteLine(" |   /|\\");
                            Console.WriteLine(" |   / \\");
                            Console.WriteLine("_|__");
                            break;
                        case 8:
                            Console.WriteLine("  ____");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |   \\O/");
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |   / \\");
                            Console.WriteLine("_|__");
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    Console.WriteLine($"Correct! The word so far: {guessedWord}");
                }

                if (guessedWord == randomString)
                {
                    Console.WriteLine("Congratulations! You've guessed the word! You are Saved!");
                    break;
                }
            }
            if (attempts == maxAttempts)
            {
                Console.WriteLine("You've run out of attempts! The word was: " + randomString);
            }

            Console.Beep();
            Console.ReadKey();
        }
    }
}