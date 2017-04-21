using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld_Day2
{

    enum StatName
    {
        strength,
        perception,
        endurance,
        charisma,
        intelligence,
        agility,
        luck

    };




    class Stat
    {

        //public enum StatName
        //{
        //    strength,
        //    perception,
        //    endurance,
        //    charisma,
        //    intelligence,
        //    agility,
        //    luck

        //};

        //public StatName SName;
        public int points;
        private Stat pstat;
        private Stat stats;
        public int playerTotalStats;
        private int minimumStats = 35;

        public Stat(string name)
        {


        }




        public Stat()
        {

        }

       



        public void RollStat()
        {
            Random roll = new Random();





            List<StatName> Statistic = new List<StatName>();

            while (playerTotalStats <= minimumStats)
            {
                foreach (StatName element in Statistic)
                {
                    points = roll.Next(1, 11);
                    playerTotalStats += points;
                    Console.WriteLine($"for your {element} you rolled a {points}");
                }

            }
            Console.WriteLine(playerTotalStats);
                 
            
            //new Stat() { SName = StatName.strength, points = roll.Next(1, 11) },
            //new Stat() { SName = StatName.perception, points = roll.Next(1, 11) },
            //new Stat() { SName = StatName.endurance, points = roll.Next(1, 11) },
            //new Stat() { SName = StatName.charisma, points = roll.Next(1, 11) },
            //new Stat() { SName = StatName.intelligence, points = roll.Next(1, 11) },
            //new Stat() { SName = StatName.agility, points = roll.Next(1, 11) },
            //new Stat() { SName = StatName.luck, points = roll.Next(1, 11) },

        }





        public void StatList()
        {

        }

        StatName[] statistic = new StatName[Enum.GetNames(typeof(StatName)).Length];


        public IEnumerable<Stat>

        private List<StatName> Statistic(StatName[] statistic)
        {
            List<StatName> plist = new List<StatName>(this.statistic);
            foreach (StatName element in plist)
            {
                Console.WriteLine(element);
            }
            return plist;
        }


        public void ConvertArray(StatName[] statistic)
        {
            List<StatName> plist = new List<StatName>(statistic);
            foreach (StatName element in plist)
            {
                Console.WriteLine(element);
            }
            
        }

        //public void DisplayStats()
        //{
        //    Console.WriteLine("Your Amazing Base Stats");
        //    Console.WriteLine("________________________");
        //    Console.WriteLine($"Strength: {Statistic}");
        //    Console.WriteLine($"Perception: {perception}");
        //    Console.WriteLine($"Endurance: {endurance}");
        //    Console.WriteLine($"Charisma: {charisma}");
        //    Console.WriteLine($"Intelligence: {intelligence}");
        //    Console.WriteLine($"Agility: {agility}");
        //    Console.WriteLine($"Luck: {luck}");
        //    Console.WriteLine("________________________");
        //    Console.WriteLine("Your Amazing Derived Stats");
        //    Console.WriteLine("________________________");
        //    Console.WriteLine($"Hit Points: {hitpoints}");
        //}

    }




}
  







