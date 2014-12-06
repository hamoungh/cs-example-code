using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            PickUp weapon = new PickUp("weapon");
            PickUp health = new PickUp("health");
            PickUp bomb = new PickUp("bomb");
            PickUp[] pp = {weapon,health,bomb };
            List<Player> players = new List<Player>();
            Random r = new Random();            
            for (int i = 0; i < 16; i++) //players
            {
                Player p = new Player();
                for (int j = 0; j < 2; j++) // items 
                    if (r.Next(0, 2) == 0) 
                        p.pickups.Add(pp[j]);
                players.Add(p); 
            }
            // print the number of players
            // who have picked up a bomb 
            int count=0;
            foreach (Player p in players){
                Console.WriteLine(p.pickups[0].name);
                if (p.pickups[0] == bomb)
                    count++;
             }
            Console.WriteLine(count);
        }
    }
