using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld_Day2
{
    //enum declaration for use in the class
    //enum Stats
    //{
    //    strength,
    //    perception,
    //    endurance,
    //    charisma,
    //    intelligence,
    //    agility,
    //    luck,
    //    magic
    //};
    class Statistics
    {
        //enum declaration for use in the class
        enum Stats
        {
            strength,
            perception,
            endurance,
            charisma,
            intelligence,
            agility,
            luck,
            magic
        };




        //set up variables for use in this class
        private int strength;
        private int perception;
        private int endurance;
        private int charisma;
        private int intelligence;
        private int agility;
        private int luck;
        private int totalValueMinimum = 35;
        int playerTotalStats;
        private int hitpoints;

        //default constructor takes no parameters
        public Statistics()
        {
            int[] statistics = new int[Enum.GetNames(typeof(Stats)).Length];
        }

        /// <summary>
        /// This method Generates the Statistics for a Hero
        /// </summary>
        /// <returns></returns>
        public int[] GenerateStats()
        {
            //set up Method variables
            int rollCount = 1;
            Random random = new Random();
            //int randomNumber = random.Next(0, 100); // This will return integers between 0-99;

            //Notification message to window
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Rolling your awesome stats...");
            Console.WriteLine("-----------------------------");

            // Rolls die for each statistic until the value is at least the minimum total value
            while (playerTotalStats <= totalValueMinimum)
            {
                strength = random.Next(1, 11);
                perception = random.Next(1, 11);
                endurance = random.Next(1, 11);
                charisma = random.Next(1, 11);
                intelligence = random.Next(1, 11);
                agility = random.Next(1, 11);
                luck = random.Next(1, 11);

                //calculates the players total stats
                playerTotalStats = strength + perception + endurance + charisma + intelligence + agility + luck;
                //prints out the number of times we had to re-roll and the total stats for your player
                Console.WriteLine($"Roll: {rollCount++} We Rolled a total of: {playerTotalStats}");
            }
                //derived stat
                hitpoints = 10 + endurance;

            //creates the stats array from the enumeration Stats
            int[] stats = new int[Enum.GetNames(typeof(Stats)).Length];

            return stats;
        }

        /// <summary>
        /// This is a display method to print the stats to the console window
        /// </summary>
        public void DisplayStats()
        {
            Console.WriteLine("Your Amazing Base Stats");
            Console.WriteLine("________________________");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Perception: {perception}");
            Console.WriteLine($"Endurance: {endurance}");
            Console.WriteLine($"Charisma: {charisma}");
            Console.WriteLine($"Intelligence: {intelligence}");
            Console.WriteLine($"Agility: {agility}");
            Console.WriteLine($"Luck: {luck}");
            Console.WriteLine("________________________");
            Console.WriteLine("Your Amazing Derived Stats");
            Console.WriteLine("________________________");
            Console.WriteLine($"Hit Points: {hitpoints}");
        }
    }
}
