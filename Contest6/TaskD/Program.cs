using System;

class Program
{
    static void Main(string[] args)
    {
        string[] info = Console.ReadLine().Split();
        switch (info[0])
        {
            case "Soldier":
                Soldier s = null;
                switch(info[1])
                {
                    case "Soldier":
                        s = new Soldier();
                        break;
                    case "CoolerSoldier":
                        s = new CoolerSoldier();
                        break;
                    case "ManInBlack":
                        s = new ManInBlack();
                        break;
                    case "ManInBlackBoss":
                        s = new ManInBlackBoss();
                        break;
                    default:
                        throw new ArgumentException();
                }
                Console.WriteLine(s.Attack());
                break;
            case "ManInBlack":
                ManInBlack mib = null;
                switch(info[1])
                {
                    case "ManInBlack":
                        mib = new ManInBlack();
                        break;
                    case "ManInBlackBoss":
                        mib = new ManInBlackBoss();
                        break;
                    default:
                        throw new ArgumentException();
                }
                Console.WriteLine(mib.Attack());
                break;
            default:
                throw new ArgumentException();
        }
    }
}
