
using TheLastGuardian.Methods;
namespace TheLastGuardian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ReusableMethods.HeadLineText();

            Console.WriteLine("The darkness spreads across the battlefield...");
            Console.WriteLine("Rise, Guardian! Only you can stop it.");
            Console.WriteLine("Prepare your light and choose your hero:\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("⚔️ Your enemies approach. Let the battle begin!");
            Console.ResetColor();

            Player startPlayer = Methods.Methods.CreatePlayer();

            Enemy enemy = null;
            bool isGameOver = false;

            while (!isGameOver)
            {

                isGameOver = AdventureChoice.Choice(enemy, startPlayer, isGameOver);

                if (startPlayer.CurrentHp <= 0)
                {
                    Console.WriteLine("You have died. Game over!");
                    isGameOver = true;
                    return;
                }

            }
        }
    }
}
