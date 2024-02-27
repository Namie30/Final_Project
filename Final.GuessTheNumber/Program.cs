namespace Final.GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            Console.WriteLine("You are playing,'Guess the Number Game'");
            Console.WriteLine("Number that You are trying to Guess is between 1-100 (Inclusive)"); //100 included 
            Console.Write("Your guess is: ");
            int ourNumber = int.Parse(Console.ReadLine());
            int y = 0;

            while(ourNumber != randomNumber)
            {
                if(ourNumber < randomNumber)
                {
                  Console.Write("Try something higher: ");
                }
                else if(ourNumber > randomNumber)
                {
                    Console.Write("Try something lower: ");
                }
               
             ourNumber = int.Parse(Console.ReadLine());
                y++;    
            }

            Console.WriteLine($"You Win!! It took you {y} guesses to get the right Number");
           
            Console.Beep();
            Console.ReadKey();
        }
    }
}