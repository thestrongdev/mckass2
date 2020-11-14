using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace mckass2
{
    class Challenge
    {
        
        public static double AverageDroids(List<int> droids)
        {
            List<int> evenDroids = new List<int>();

            foreach (int droid in droids)
            {
                if (droid%2 == 0)
                {
                    evenDroids.Add(droid);
                }
            }

            double averageEvenDroids = evenDroids.Average();

            return averageEvenDroids;
        }
        
        public static List<string> ConvertPlanets(string[] planets)
        {
            List<string> newPlanets = new List<string>();

            for (int i = planets.Length - 1; i >= 0; i--)
            {
                newPlanets.Add(planets[i]);

            }
            return newPlanets;
        }
        
        public static int AddStarWarsCharacters(string[] characters)
        {
            int yoda = 0;

            for(int i=0; i<characters.Length; i++)
            {
                if(characters[i].Equals("Yoda", StringComparison.OrdinalIgnoreCase))
                {
                    yoda = i;
                }
            }

            return yoda;
        }

        public static string DeathStarCombat(Dictionary<string, int> charAttack) //don't feel I've really grasped how to most efficiently handle dictionaries
        {
            var values = charAttack.Values;
            List<int> onlyAttack = new List<int>();
            string bestAttack;
            int bestAttackNum;

            foreach (var value in values) //find max value
            {
                onlyAttack.Add(value);
            }

            bestAttackNum = onlyAttack.Max();

            foreach(KeyValuePair<string, int> pair in charAttack)
            {
                if(EqualityComparer<int>.Default.Equals(pair.Value, bestAttackNum))
                {
                    bestAttack = pair.Key;
                    return bestAttack;
                }
            }

            return "error or nothing in list";

        }
    }
}
