namespace RockPaperScissorsAgainBecauseCrapsIsTooHard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int opponentsChoice = random.Next(1, 4);

            Console.WriteLine("---- CHOOSE ----");
            Console.WriteLine("[R]OCK");
            Console.WriteLine("[P]APER");
            Console.WriteLine("[S]CISSORS");
            int playersChoice = ChooseYourFighter();
            SettleTheScore(opponentsChoice, playersChoice);
            Console.WriteLine($"you chose {playersChoice}");

        }


        static int ChooseYourFighter()
            {
            ConsoleKey input = Console.ReadKey().Key;
            if (input == ConsoleKey.R)
            {
                return 1;
            }
            else if (input == ConsoleKey.P)
            {
                return 2;
            }
            else if (input == ConsoleKey.S)
            {
                return 3;
            }
            else return 0;

        }
        static void SettleTheScore(int fighter, int randomValue)
        {
            if fighter = 
        }
    }
}