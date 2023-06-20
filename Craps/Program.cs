namespace RockPaperScissorsAgainBecauseCrapsIsTooHard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomValue = random.Next(1, 4);

            {
                ChooseYourFighter();
            }

        }
        static void ChooseYourFighter()
            {
            ConsoleKey input = Console.ReadKey().Key;
            if (input == ConsoleKey.R)
            {
                Console.WriteLine("rock");
            }
            else if (input == ConsoleKey.P)
            {
                Console.WriteLine("paper");
            }
            else if (input == ConsoleKey.S)
            {
                Console.WriteLine("scissors");
            }

        }
    }
}