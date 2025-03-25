using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Day10
{
    public class Player
    {
        public int ap = 10;

        public void Attack(Monster monster)
        {
            monster.takeAttack(ap);
        }
    }
}
