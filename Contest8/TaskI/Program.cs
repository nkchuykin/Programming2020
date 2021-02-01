using System;

class Program
{
    static void Main(string[] args)
    {
        int countOfMonsters = int.Parse(Console.ReadLine());
        int castlePosition = int.Parse(Console.ReadLine());
        int MarioHP = int.Parse(Console.ReadLine());
        int MarioAttack = int.Parse(Console.ReadLine());
        int bossHP = int.Parse(Console.ReadLine());
        int bossAttack = int.Parse(Console.ReadLine());
        Game game = new Game(castlePosition, countOfMonsters,
                             new Hero(MarioHP, MarioAttack),
                             new Boss(bossHP, bossAttack));

        int monsterHP;
        int monsterAttack;
        int monsterPosition;
        
        for (int i = 0; i < countOfMonsters; i++)
        {
            monsterHP = int.Parse(Console.ReadLine());
            monsterAttack = int.Parse(Console.ReadLine());
            monsterPosition = int.Parse(Console.ReadLine());
            Monster monster = new Monster(monsterHP, monsterAttack, monsterPosition);
            game.attackHero += monster.AttackHero;
        }

        game.Play();
    }
}

