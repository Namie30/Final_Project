namespace Final.Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is a Calculator Application PLease input 2 numbers");
                Console.Write("First Number: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Second Number: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Now Choose Operation (+ - * /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"{x} + {y} = {x + y}");
                        break;
                    case '-':
                        Console.WriteLine($"{x} - {y} = {x - y}");
                        break;
                    case '*':
                        Console.WriteLine($"{x} * {y} = {x * y}");
                        break;
                    case '/':
                        if (y == 0)
                        {
                            throw new DivideByZeroException("Cannot divide by zero");
                        }
                        else
                        {
                            Console.WriteLine($"{x} / {y} = {x / y}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.Beep();
            Console.ReadKey();
        }
    }
}