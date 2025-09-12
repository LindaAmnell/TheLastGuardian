namespace TheLastGuardian.Methods
{
    public static class EnemyFactory
    {

        public static Enemy RandomEnemy()
        {
            Enemy[] enemies =
        {
             new Enemy("Fallen Dreg", 50, 10, 20),
             new Enemy("Hive Thrall", 55, 20, 25),
             new Enemy("Vex Goblin", 55, 15, 20),
             new Enemy("Cabal Legionary", 40, 20, 20),
             new Enemy("Taken Knight", 70, 10, 20),
        };

            Random randomEnemy = new Random();
            Enemy random = enemies[randomEnemy.Next(enemies.Length)];

            return random;
        }
    }
}
