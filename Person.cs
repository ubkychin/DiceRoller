using System.Collections.Generic;

namespace DiceRoller
{
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
            if(die > 0 && die < this.Dice.Count) {
                roll = this.Dice[die].Roll();
            }
            return roll;
        }

        /// <summary>
        /// Roll all of the player's dice once and return the total.
        /// </summary>
        /// <returns></returns>
        public int RollAllDice() {
            int total = 0;

            foreach(var die in this.Dice) {
                total += die.Roll();
            }

            return total;
        }

        public void AddNewDie(int sides) {
            Die d = new Die(sides);
            this.Dice.Add(d);
        }

    }
}