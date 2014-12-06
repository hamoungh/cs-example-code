using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectArrays
{
    class Game
    {
        public static void Main()
        {
            Player a = new Player();
            Weapon shutgun=new Weapon();
            Weapon knife=new Weapon();
            a.weapons[0]=shutgun;
            a.weapons[1]=knife;
            Player b = new Player();
            b.weapons[0]=shutgun;
        }
            
    }
}
