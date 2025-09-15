namespace TheLastGuardian.Methods
{
    public static class EnemyFactory
    {

        private static int count = 0;
        private static int fightCount = 0;

        public static Enemy RandomEnemy()
        {

            Enemy[] enemies =
             {
             new Enemy("Fallen Dreg", 50, 10, 20),
             new Enemy("Hive Thrall", 55, 15, 25),
             new Enemy("Vex Goblin", 55, 12, 20),
             new Enemy("Cabal Legionary", 40, 15, 20),
             new Enemy("Taken Knight", 70, 12, 20),
            };

            Enemy[] boss =
            {
            new Enemy("Sepiks Prime", 200, 18, 60),
            new Enemy("Crota, Son of Oryx", 250, 20, 80),
            new Enemy("Atheon, Time’s Conflux", 300, 21, 90),
            new Enemy("Valus Ta'aurc", 300, 18, 75),
            new Enemy("Oryx, the Taken King", 350, 20, 95)
            };
            Random randomEnemy = new Random();

            if (count == 5)
            {
                Enemy randomBoss = boss[randomEnemy.Next(boss.Length)];
                Console.WriteLine("Be ready for Boss fight!");
                count = 0;
                return randomBoss;
            }

            if (fightCount >= 3)
            {

                foreach (Enemy e in enemies)
                {
                    e.Hp += 5;
                    e.Damage += 2;
                }

            }

            Enemy random = enemies[randomEnemy.Next(enemies.Length)];
            count++;
            fightCount++;
            Console.WriteLine("count is:" + count);



            return random;
        }
    }
}
