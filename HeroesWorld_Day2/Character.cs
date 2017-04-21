using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld_Day2
{
    class Character
    {
        private List<int>  pStats;


        //public void RollStat()
        //{
        //    Random roll = new Random();

            

        //    List<Stat> stats = new List<Stat>()
        //    {
        //        new Stat() { SName = StatName.strength, points = roll.Next(1, 11) },
        //        new Stat() { SName = StatName.perception, points = roll.Next(1, 11) },
        //        new Stat() { SName = StatName.endurance, points = roll.Next(1, 11) },
        //        new Stat() { SName = StatName.charisma, points = roll.Next(1, 11) },
        //        new Stat() { SName = StatName.intelligence, points = roll.Next(1, 11) },
        //        new Stat() { SName = StatName.agility, points = roll.Next(1, 11) },
        //        new Stat() { SName = StatName.luck, points = roll.Next(1, 11) },

        //    };
        //}


            public Character(string name)
            {
                Name = name;
            
            }
        //Stat property


        private Stat pStat;
            public Stat PStat
        {
            get
            {
                return pStat;
            }
            set
            {
                value = GetPStat();
            }
        }


        private Statistics stats;
        public Statistics Stats
        {
            get
            {
                return stats;
            }
            set
            {
                value = GetPlayerStats();
                stats = value;
            }

         }

        //Name Property
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = SetName(value);
                
            }
        }

        /// <summary>
        /// This method sets the hero's name and gives the option to re enter if invalid after it validates the hero's name against the list of invalid names. 
        /// </summary>
        /// <param name="name"> Hero's Name </param>
        /// <returns>Hero's name after Validation</returns>
        public string SetName(string name)
        {
            ValidName(name);
            while(ValidName(name) != true)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.Write("that isn't a valid name,  Please Try Again: ");
                name = Console.ReadLine();
                
            }
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"Great your Hero {name} has been created");
                Console.WriteLine("-------------------------------------------------");
            return name;
        }

        /// <summary>
        /// Method call to Statistics class that creates an instance of the Generate Statistics method
        /// </summary>
        /// <returns>hero's statistics</returns>
        
        public Statistics GetPlayerStats()
        {
            Statistics stats = new Statistics();
            stats.GenerateStats();
            stats.DisplayStats();
            return stats;
        }

        public Stat GetPStat()
        {
            Stat pstats = new Stat();
            pstats.RollStat(pstats.plist);
            //pstats.DisplayStats();
            return pstats;
        }

        public Character()
        {

        }
        //Constructor
        //public Character(string name)
        //{
        //   Name = name;
        //}


        //Constructor
        public Character(string name, Stat stats)
        {
            Name = name;
            Stats = stats;
        }

        //array of invalid names
        private string[] invalidNames = new[] { "Legolas", "Gandalf", "Frodo", "Bilbo" };
        /// <summary>
        /// Method to validate name against null and invalid options
        /// </summary>
        /// <param name="name"> takes the name parameter from the SetName method</param>
        /// <returns>returns true or false based on validity</returns>
        public bool ValidName(string name)
        {
            bool valid = false;
            if (name == null)
            {
                valid = false;
                Console.WriteLine("You must enter a name");
            }

            else
            { 
                foreach (string invalid in invalidNames)
                {
                    if (name.Contains(invalid))
                    {
                        valid = false;
                        break;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }
                return valid;
            
            
        }



        //public string CheckForInvalidNames(string name)
        //{
        //    //Console.WriteLine("Please Enter a Character's Name");
        //    // string name = "";

        //    bool validName = false;
        //    name = Console.ReadLine();
        //        foreach (string invalid in invalidNames)
        //        {

        //            if (name.Contains(invalid) || name.Length == 0)
        //            {
        //                validName = false;
        //            if (name.Length == 0)
        //            {
        //                Console.WriteLine($"You have entered a blank name, please enter a valid name");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"You have entered a forbidden name: {invalid}, please enter a valid name");
        //            }


        //        } 
        //            else
        //            {
        //                validName = true;
        //            }

        //        return validName;
        //    }

        //public string CheckForInvalidNames(string name)
        //{
        //    //Console.WriteLine("Please Enter a Character's Name");
        //    // string name = "";

        //    bool validName = false;
        //    while (!validName)
        //    {
        //        name = name.Trim(); //Console.ReadLine().Trim();
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





    }
}
