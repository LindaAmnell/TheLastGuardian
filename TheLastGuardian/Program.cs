using TheLastGuardian.Methods;
namespace TheLastGuardian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var adventureChoice = new AdventureChoice();
            Player player = null;

            ReusableMethods.HeadLineText(player);

            Console.WriteLine("The darkness spreads across the battlefield...");
            Console.WriteLine("Rise, Guardian! Only you can stop it.");
            Console.WriteLine("Prepare your light and choose your hero:\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your enemies approach. Let the battle begin!");
            Console.ResetColor();

            Player startPlayer = PlayerFactory.CreatePlayer();

            Enemy enemy = null;
            bool isGameOver = false;

            while (!isGameOver)
            {

                isGameOver = adventureChoice.Choice(enemy, startPlayer, isGameOver);

                if (startPlayer.CurrentHp <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("⚔️ You fought bravely, Guardian.");
                    Console.WriteLine("But even heroes must fall...");
                    Console.ResetColor();
                    Console.WriteLine("\nPress any key to end your journey...");
                    Console.ReadKey();
                    isGameOver = true;
                    return;
                }

            }
        }
    }
}
