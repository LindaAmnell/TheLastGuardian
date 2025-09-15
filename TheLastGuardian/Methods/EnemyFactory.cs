namespace TheLastGuardian.Methods
{
    public static class EnemyFactory
    {

        private static int count = 0;
        private static int fightCount = 0;

        private static Random randomEnemy = new Random();


        private static Enemy[] enemy =
        {
            new Enemy("Fallen Dreg", 50, 10, 20),
            new Enemy("Hive Thrall", 55, 15, 25),
            new Enemy("Vex Goblin", 55, 12, 20),
            new Enemy("Cabal Legionary", 40, 15, 20),
            new Enemy("Taken Knight", 70, 12, 20),
        };

        private static Enemy[] boss =
         {
            new Enemy("Sepiks Prime", 200, 18, 60),
            new Enemy("Crota, Son of Oryx", 250, 20, 80),
            new Enemy("Atheon, Time’s Conflux", 300, 21, 90),
            new Enemy("Valus Ta'aurc", 300, 18, 75),
            new Enemy("Oryx, the Taken King", 350, 20, 95)
        };

        public static Enemy RandomEnemy()
        {
            fightCount++;
            count++;

            if (fightCount == 3)
            {
                foreach (Enemy e in enemy)
                {
                    e.Hp += 5;
                    e.Damage += 2;
                    e.GlimmerReward += 2;
                }
                fightCount = 0;
            }

            if (count == 5)
            {
                Enemy randomBoss = boss[randomEnemy.Next(boss.Length)];
                Console.WriteLine("Be ready for Boss fight!");

                foreach (Enemy e in boss)
                {
                    e.Hp += 10;
                    e.Damage += 5;
                    e.GlimmerReward += 2;
                }

                count = 0;

                return new Enemy(randomBoss.Name, randomBoss.Hp, randomBoss.Damage, randomBoss.GlimmerReward);
            }

            Console.WriteLine("count is:" + count);
            Enemy protoEnemy = enemy[randomEnemy.Next(enemy.Length)];
            return new Enemy(protoEnemy.Name, protoEnemy.Hp, protoEnemy.Damage, protoEnemy.GlimmerReward);

        }
    }
}
