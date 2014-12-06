using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    class tester5
    {

       static void Main(string[] args)
        {

            PickUp weapon = new PickUp("weapon");
            PickUp health = new PickUp("health");
            PickUp bomb = new PickUp("bomb");

            Player p = new Player();
            p.pickups.Add(weapon);
            p.pickups.Add(healh);


        }
    }
}
