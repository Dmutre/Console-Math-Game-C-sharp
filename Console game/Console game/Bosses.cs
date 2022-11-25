using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_game
{
    internal class Bosses
    {
        public string name;
        public int health;
        public int damage;
        Random rnd = new Random();


        public void Constructor(int health, int damage, string name = "Boss")
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
        }

        public void Take_damage(int damage)
        {
            this.health -= damage;
            Console.WriteLine("Boos took damage: " + damage);
            Console.WriteLine("AAAAAAARRRRRRRR!!!!!!");
        }

        public int Give_damage()
        {
            int damage = this.damage + rnd.Next(-this.damage / 10, this.damage / 10);
            return damage;
        }
    }
}
