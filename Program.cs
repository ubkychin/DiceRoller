using System;
using System.Collections.Generic;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Die d1 = new Die();
            Die d2 = new Die(12);
            Die d3 = new Die(20);

            List<Die> diceList1 = new List<Die>();
            diceList1.Add(d1);
            diceList1.Add(d2);
            diceList1.Add(d3);

            List<Die> diceList2 = new List<Die>();
            diceList2.Add(d2);
            
            Person p1 = new Person("William Wallace", diceList1);
            Person p2 = new Person("Joan of Arc", diceList2);

            System.Console.WriteLine(p1.Name);
            System.Console.WriteLine(p1.Dice.Count);

            System.Console.WriteLine(p2.Name);
            System.Console.WriteLine(p2.Dice.Count);
            p2.AddNewDie(18);
            System.Console.WriteLine(p2.Dice.Count);

            for(int i = 0; i < 20; i++) {
                // roll William Wallace's second die
                System.Console.WriteLine(p1.RollDie(4));
            }
        }
    }

    public class Die {
        public int NumOfSides;

        public Die(int numofsides) {
            this.NumOfSides = numofsides;
        }

        public Die() {
            this.NumOfSides = 6;
        }

        public int Roll() {
            Random rand = new Random();
            int roll = rand.Next(1, this.NumOfSides+1);

            return roll;
        }
    }

    public class Person {
        public string Name;
        public List<Die> Dice;

        public Person(string name, List<Die> dice) {
            this.Name = name;
            this.Dice = dice;
        }

        public Person() {
            this.Name = "John Doe";
            this.Dice = new List<Die>();
        }

        /// <summary>
        /// Rolls a specified die from the Dice List.  If die is out of range will return -1
        /// </summary>
        /// <param name="die">indexing starts at 0</param>
        /// <returns></returns>
        public int RollDie(int die) {
            int roll = -1;
            if(die > 0 && die < Dice.Count) {
                roll = Dice[die].Roll();
            }
            return roll;
        }

        /// <summary>
        /// Roll all of the player's dice once and return the total.
        /// </summary>
        /// <returns></returns>
        public int RollAllDice() {
            return 0; // placeholder
        }

        public void AddNewDie(int sides) {
            Die d = new Die(sides);
            this.Dice.Add(d);
        }

    }
}
