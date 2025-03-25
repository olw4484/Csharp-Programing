using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Day10
{
    public class Monster
    {
        public int hp = 100;

        public void takeAttack(int damege)
        {
            hp -= damege;
        }
    }
}
