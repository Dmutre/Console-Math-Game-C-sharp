using System;


namespace Console_game
{
    internal class player
    {
        public int health;
        public string? name;
        public int damage;
        Random rnd = new Random();

        public void Constructor(int health, string name, int damage)
        {
            this.health = health;  
            if(name.Length <= 1)
            {
                this.name = "Huyesos";
            }
            else
            {
                this.name = name;
            }
            this.damage = damage;
        }


        public void Take_damage(int damage)
        {
            Console.WriteLine("You took damage: " + damage);
            this.health -= damage;
            Console.WriteLine("Ught!!!");
        }


        public int Give_damage()
        {
            int damage = this.damage + rnd.Next(-this.damage / 10, this.damage / 10);
            return damage;
        }

        public void Heal(int add)
        {
            this.health += add;
        }

        public void Increas_damage(int add)
        {
            this.damage += add;
        }

    }
}
