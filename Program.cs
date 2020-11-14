using System;
using System.Collections.Generic;
using System.Linq;

namespace mckass2
{
    class Program
    {
        static void Main(string[] args)
        {

            //TEST AVERAGEDROIDS
            Console.WriteLine("AVERAGEDROID TEST");
            List<int> droids = new List<int> { 1, 1, 3, 5, 6, 7, 8, 10, 12, 13, 2, 4}; //evens: 6, 8, 10, 12, 2, 4
            Console.WriteLine(Challenge.AverageDroids(droids)); //SHOULD OUTPUT 7
            Console.WriteLine();

            //TEST CONVERTPLANETS
            Console.WriteLine("CONVERTPLANETS TEST");
            string[] planets = { "Uranus", "Jupiter", "Saturn", "Pluto?", "Venus", "Earth", "Mars", "Mercury", "Neputune" };
            List<string> testPlanets = Challenge.ConvertPlanets(planets); //SHOULD REVERSE ^^ ORDER

            foreach (string planet in testPlanets)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine();

            //TEST DEATHSTARCOMBAT
            Console.WriteLine("DEATHSTARCOMBAT TEST");
            Dictionary<string, int> deathStarStats = new Dictionary<string, int>
            {
                {"Obi", 3 },
                {"Luke", 5},
                {"Darth", 11},
                {"Leia", 7},
                {"Chewbacca", 8},
                {"C3PO", 45},
                {"R2D2", 14},
                {"Han", 10}
            };

            string theBest = Challenge.DeathStarCombat(deathStarStats);
            Console.WriteLine(theBest); //SHOULD BE C3PO
            Console.WriteLine();

            //TEST ADDSTARWARSCHAR
            Console.WriteLine("ADDSTARWARSCHAR TEST");
            string [] starChars = {"Obi", "Luke", "Chewbacca", "Yoda", "Han", "Leia", "R2D2", "C3PO", "Darth"};
            //YODA AT INDEX 3
            Console.WriteLine(Challenge.AddStarWarsCharacters(starChars));
            Console.WriteLine();

            //TEST TRYTOCATCHDARTHVADER
            Console.WriteLine("TRYTOCATCHDARTHVADER TEST");
            Console.WriteLine("Enter number to test: ");
            string testValue = Console.ReadLine();

            try
            {
                Challenge.TryToCatchDarthVader(testValue);
                Console.WriteLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
