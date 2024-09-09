using System;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();

        Console.WriteLine("Insert player health points");
        int playerHp = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert plater defense");
        int playerDef = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert player attack");
        int playerATK = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert monster health points");
        int monsterHp = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert monster defense");
        int monsterDef = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert monster attack");
        int monsterAtk = Convert.ToInt32(Console.ReadLine());

        int moneta = rnd.Next(1, 3);

        if ((playerATK - monsterDef) > 0 || (monsterAtk - playerDef) > 0)
        {
            Console.WriteLine(moneta);
            if (moneta == 1)
            {
                Console.WriteLine("Player starts");
                while (monsterHp > 0 && playerHp > 0)
                {
                    if (monsterHp > 0 && playerHp > 0)
                    {
                        Console.WriteLine("Player attack");
                        if ((playerATK - monsterDef) > 0)
                        {
                            if ((playerATK - monsterDef) > 0)
                            {
                                monsterHp = calculateDamage(monsterHp, playerATK, monsterDef, "Player");
                                //monsterHp = monsterHp - (playerATK - monsterDef);
                                //Console.WriteLine("Player dealt" + (playerATK - monsterDef));
                            }
                            else
                            {
                                Console.WriteLine("No damage dealt");
                            }
                            Console.WriteLine("Monster health " + monsterHp);
                            if (monsterHp <= 0)
                            {
                                Console.WriteLine("Player won");
                            }
                        }
                    }
                    if (monsterHp > 0 && playerHp > 0)
                    {
                        Console.WriteLine("Monster attack");
                        if ((monsterAtk - playerDef) > 0)
                        {
                            playerHp = calculateDamage(monsterAtk, monsterAtk, playerDef, "Monster");
                            // playerHp = playerHp - (monsterAtk - playerDef);
                            // Console.WriteLine("Monster dealt" + (monsterAtk - playerDef));
                        }
                        else
                        {
                            Console.WriteLine("No damage dealt");
                        }
                        Console.WriteLine("Player health " + playerHp);
                        if (playerHp <= 0)
                        {
                            Console.WriteLine("Monster won");
                        }
                    }


                }

            }
            else
            {
                Console.WriteLine("Monster starts");
                while (monsterHp > 0 && playerHp > 0)
                {
                    if (monsterHp > 0 && playerHp > 0)
                    {
                        Console.WriteLine("Monster attack");
                        if ((monsterAtk - playerDef) > 0)
                        {
                            playerHp = calculateDamage(monsterAtk, monsterAtk, playerDef, "Monster");
                            // playerHp = playerHp - (monsterAtk - playerDef);
                            // Console.WriteLine("Monster dealt" + (monsterAtk - playerDef));
                        }
                        else
                        {
                            Console.WriteLine("No damage dealt");
                        }
                        Console.WriteLine("Player health " + playerHp);
                        if (playerHp <= 0)
                        {
                            Console.WriteLine("Monster won");
                        }
                    }
                    if (monsterHp > 0 && playerHp > 0)
                    {
                        Console.WriteLine("Player attack");
                        if ((playerATK - monsterDef) > 0)
                        {
                            monsterHp = calculateDamage(monsterHp, playerATK, monsterDef, "Player");
                            // monsterHp = monsterHp - (playerATK - monsterDef);
                            // Console.WriteLine("Player dealt" + (playerATK - monsterDef));
                        }
                        else
                        {
                            Console.WriteLine("No damage dealt");
                        }
                        Console.WriteLine("Monster HP " + monsterHp);
                        if (monsterHp <= 0)
                        {
                            Console.WriteLine("Player won");
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No damage will be dealt, the fight will not end");

        }

        Console.ReadLine();
    }

    public static int calculateDamage(int health, int dmg, int defense, string name)
    {
        health = health - (dmg - defense);
        Console.WriteLine(name + " dealt" + (dmg - defense));

        return health;
    }
}
