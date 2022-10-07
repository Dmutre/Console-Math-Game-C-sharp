using System;


namespace Console_game
{
    internal class player
    {
        public int health;
        public string? name;


        public void Constructor(int health, string name)
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
        }


        public void Take_damage(int damage)
        {
            Console.WriteLine("You took damage: " + damage);
            this.health -= damage;
            Console.WriteLine("Ught!!!");
        }

        public void Heal(int add)
        {
            this.health += add;
        }

    }
}
