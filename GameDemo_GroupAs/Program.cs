namespace RockPaperScissors
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Rock - Paper - Scissors Game");
            Console.WriteLine("1. Rock\n2. Paper\n 3.Scissors");

            Console.WriteLine("Select your option");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;

            }
        Console.WriteLine("Game Over");
        }
    }
}