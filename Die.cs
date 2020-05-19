using System;

namespace DiceRoller
{
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
}