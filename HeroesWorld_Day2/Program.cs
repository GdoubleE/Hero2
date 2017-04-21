using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld_Day2
{
    class Program
    {
        //static private string[] invalidNames = new[] { "Legolas", "Gandalf", "Frodo", "Bilbo" };
        //enum Statistics
        //{
        //    strength = 0,
        //    perception,
        //    endurance,
        //    charisma,
        //    intelligence,
        //    agility,
        //    luck,
        //    magic
        //};

        static void Main(string[] args)
        {

            Console.WriteLine("     This is HERO'S WORLD     ");
            Console.WriteLine("------------------------------");

            Console.Write("To begin choose a name for your Hero: ");
            

           
            

            Character player1 = new Character();
            player1.Name = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine($"Welcome to HerosWorld (tm): {player1.Name}");
            Console.WriteLine("----------------------------------------------");
            Console.Write("To Generate your stats press any key");
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------");



            player1.GetPStat();

            Stat p1stat = new Stat();
            p1stat.StatList();
            Console.WriteLine(p1stat.plist);
            //player1.RollStat();

            Console.WriteLine();

           
           // player1Stat.RollStat();

            

            Console.ReadLine();




            //    Console.WriteLine("You encounter an rabid emotionally distant exploding feral deseased lonely slightly overweight kitten");

            //    int kittenHP = 10;
            //    while (hitpoints > 0 || kittenHP > 0)
            //    {
            //        Console.WriteLine($"Player HP: {hitpoints}\nKitten HP: {kittenHP}");
            //        // Roll for initiative
            //        var yourRoll = random.Next(1, 21);
            //        var kittenRoll = random.Next(1, 21);
            //        if (yourRoll > kittenRoll)
            //        {
            //            //Player attacks first
            //            var playerDamage = random.Next(0, 3);
            //            kittenHP -= playerDamage;
            //            Console.WriteLine($"You hugged the kitten for: {playerDamage}");
            //            if (kittenHP <= 0)
            //            {
            //                break;
            //            }
            //            //Kitten attacks first
            //            var kittenDamage = random.Next(0, 3);
            //            hitpoints -= kittenDamage;
            //            Console.WriteLine($"The kitten purred at you and did: {kittenDamage}");
            //            if (hitpoints <= 0)
            //            {
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            //Kitten attacks first
            //            var kittenDamage = random.Next(0, 3);
            //            hitpoints -= kittenDamage;
            //            Console.WriteLine($"The kitten purred at you and did: {kittenDamage}");
            //            if (hitpoints <= 0)
            //            {
            //                break;
            //            }
            //            var playerDamage = random.Next(0, 3);
            //            kittenHP -= playerDamage;
            //            Console.WriteLine($"You hugged the kitten for: {playerDamage}");
            //            if (kittenHP <= 0)
            //            {
            //                break;
            //            }
            //        }
            //        Console.ReadKey();

            //    }
            //    if (hitpoints < kittenHP)
            //    {
            //        Console.WriteLine("Player Lost");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{name}: Won the fight");
            //    }
            //    Console.ReadKey();
            //}

            //static string CheckForInvalidNames()
            //{
            //    Console.WriteLine("Please Enter a Character's Name");
            //    string name="";

            //    bool validName = false;
            //    while (!validName)
            //    {
            //        name = Console.ReadLine().Trim();
            //        foreach (string invalid in invalidNames)
            //        {

            //            if (name.Contains(invalid) || name.Length == 0)
            //            {
            //                validName = false;
            //                if (name.Length == 0)
            //                {
            //                    Console.WriteLine($"You have entered a blank name, please enter a valid name");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"You have entered a forbidden name: {invalid}, please enter a valid name");
            //                }
            //                break;
            //            }
            //            else
            //            {
            //                validName = true;
            //            }
            //        }
            //    }
            //    return name;
            //}

            //static int[] GenerateStats(int [] stats)
            //{

            //    return null;
            //}
        }
    }
}
