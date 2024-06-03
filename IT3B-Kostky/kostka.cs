using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3B_Kostky

{
    public class Dice
    {
        private Random _random;

        public Dice()
        {
            _random = new Random();
        }

        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}

